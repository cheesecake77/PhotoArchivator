using MetadataExtractor;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Globalization;

namespace PhotoArchivator
{
    public partial class MainForm : Form
    {
        private String[] PhotoFiles = { "jpeg", "jpg", "arw", "dng", "nef", "crw", "cr2", "cr3", "heic" };


        private Dictionary<StructureItem, string> _structureItems = new Dictionary<StructureItem, string>() {
            {StructureItem.None, "Не использовать"},
            {StructureItem.DateDay, "Дата: День (DD)"},
            {StructureItem.DateMonth, "Дата: Месяц (MM)"},
            {StructureItem.DateYear, "Дата: Год (YYYY)"},
            {StructureItem.DateYM, "Дата: Год-Месяц (YYYY-MM)"},
            {StructureItem.DateYMD, "Дата: Год-Месяц-День (YYYY-MM-DD)"},
            {StructureItem.PhotoType, "Тип фотографии"},
            {StructureItem.CameraCompany, "Камера: Производитель"},
            {StructureItem.CameraModel, "Камера: Модель"},
        };
        public MainForm()
        {
            InitializeComponent();
            var structureItems = Enum.GetValues(typeof(StructureItem))
                .OfType<StructureItem>()
                .Select(s => _structureItems[s])
                .ToArray();
            var dirBoxes = tableLayoutPanel1.Controls.OfType<ComboBox>().ToArray();
            foreach (var dirBox in dirBoxes) dirBox.Items.AddRange(structureItems);
            foreach (var dirBox in dirBoxes) dirBox.SelectedIndex = 0;

            CheckStart();
            CheckSctructure();

            inputDirBox.Text = Properties.Settings.Default.inputDirectory;
            outputDirBox.Text = Properties.Settings.Default.outputDirectory;

        }
        private Parameters GetParameters()
        {
            var structureItems = Enum.GetValues(typeof(StructureItem)).OfType<StructureItem>().ToArray();
            var si = tableLayoutPanel1.Controls.OfType<ComboBox>().Select(cb => cb.SelectedIndex).Where(i => i >= 1).Select(i => structureItems[i]).ToArray();
            return new Parameters { InputDir = inputDirBox.Text, OutputDir = outputDirBox.Text, StructureItems = si, Move = moveButton.Checked };
        }
        private void CheckSctructure()
        {
            SetStructure(dir1Box, dir2Box);
            SetStructure(dir2Box, dir3Box);
            SetStructure(dir3Box, dir4Box);
            SetStructure(dir4Box, dir5Box);

            void SetStructure(ComboBox c1, ComboBox c2)
            {
                if (c1.SelectedIndex == 0)
                {
                    c2.Enabled = false;
                    c2.SelectedIndex = 0;
                }
                else c2.Enabled = true;
            }
        }



        private void CheckStart()
        {
            if (startButton.Enabled =
            !string.IsNullOrEmpty(inputDirBox.Text) &&
            !string.IsNullOrEmpty(outputDirBox.Text) &&
            System.IO.Directory.Exists(inputDirBox.Text) &&
            System.IO.Directory.Exists(outputDirBox.Text) &&
            !outputDirBox.Text.TrimEnd('\\').Contains(inputDirBox.Text))
            {
                statusBar.Text = "";
            }
            else statusBar.Text = "Директории не указаны либо указаны не корректно";
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            if (backgroundWorker.IsBusy)
            {
                backgroundWorker.CancelAsync();
            }
            else
            {
                backgroundWorker.RunWorkerAsync(GetParameters());
                startButton.Text = "Стоп";
                progressBar.Value = 0;
                logBox.Items.Clear();
                outputGroupBox.Enabled = inputGroupBox.Enabled = false;
            }
        }

        private void backgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            if (e.Argument is Parameters parameters)
            {
                backgroundWorker.ReportProgress(0, "Поиск файлов...");
                List<String> files = new List<string>();
                FindFiles(parameters.InputDir, files);
                backgroundWorker.ReportProgress(0, $" Найдено файлов: {files.Count}");
                double i = 0;
                foreach (var file in files)
                {
                    if (backgroundWorker.CancellationPending) return;
                    backgroundWorker.ReportProgress((int)(i / files.Count * 100), $"Обработка файла {file}");
                    ProcessFile(file, parameters);
                    i++;
                }
            }


        }
        private void FindFiles(string directory, List<String> files)
        {
            backgroundWorker.ReportProgress(0, $"Обрабатывется директория {directory}...");

            try
            {
                foreach (var ext in PhotoFiles)
                {
                    if (backgroundWorker.CancellationPending) return;
                    var fList = System.IO.Directory.GetFiles(directory, $"*.{ext}");
                    files.AddRange(fList);
                }
            }
            catch (Exception error)
            {
                backgroundWorker.ReportProgress(0, $"Ошибка при обработке директории {directory}: {error.Message}");
                return;
            }

            try
            {
                var dList = System.IO.Directory.GetDirectories(directory);
                foreach (var d in dList)
                {
                    if (backgroundWorker.CancellationPending) return;
                    FindFiles(d, files);
                }
            }
            catch (Exception error)
            {
                backgroundWorker.ReportProgress(0, $"Ошибка при обработке директории {directory}: {error.Message}");
            }
        }

        private void ProcessFile(string path, Parameters parameters)
        {
            try
            {
                var photo = Photo.GetPhoto(path);
                var sb = new StringBuilder(parameters.OutputDir);
                foreach (var i in parameters.StructureItems)
                {
                    switch (i)
                    {
                        case StructureItem.None:
                            break;
                        case StructureItem.DateYear:
                            sb.Append($"\\{photo.ShotTime:yyyy}");
                            break;
                        case StructureItem.DateMonth:
                            sb.Append($"\\{photo.ShotTime:MM}");
                            break;
                        case StructureItem.DateDay:
                            sb.Append($"\\{photo.ShotTime:dd}");
                            break;
                        case StructureItem.DateYM:
                            sb.Append($"\\{photo.ShotTime:yyyy-MM}");
                            break;
                        case StructureItem.DateYMD:
                            sb.Append($"\\{photo.ShotTime:yyyy-MM-dd}");
                            break;
                        case StructureItem.PhotoType:
                            sb.Append($"\\{(photo.IsRAW ? "Raw" : "NotRaw")}");
                            break;
                        case StructureItem.CameraCompany:
                            sb.Append($"\\{(string.IsNullOrEmpty(photo.Make) ? "Unknown" : photo.Make)}");
                            break;
                        case StructureItem.CameraModel:
                            sb.Append($"\\{(string.IsNullOrEmpty(photo.Model) ? "Unknown" : photo.Model)}");
                            break;
                    }
                }
                var destFile = Path.Combine(sb.ToString(), $"{photo.FileName}.{photo.Extension}");
                System.IO.Directory.CreateDirectory(sb.ToString());
                if (File.Exists(destFile))
                {
                    var destPhoto = Photo.GetPhoto(destFile);
                    if (photo.ShotTime == destPhoto.ShotTime
                        && photo.FileSize == destPhoto.FileSize
                        && photo.HasGPS == destPhoto.HasGPS
                        && photo.Make == destPhoto.Make
                        && photo.Model == destPhoto.Model) backgroundWorker.ReportProgress(-1, $"Выходная директория уже содержит файл {photo.FileName}");
                    else
                    {
                        int suf = 1;
                        while (true)
                        {
                            destFile = Path.Combine(sb.ToString(), $"{photo.FileName}-{suf++}.{photo.Extension}");
                            if (File.Exists(destFile)) continue;
                            FileCopy(path, destFile);

                        }
                    }
                }
                else FileCopy(path, destFile);
            }
            catch (Exception error)
            {
                backgroundWorker.ReportProgress(-1, $"Ощибка при обработке файла {path}: {error.Message}");
            }
            void FileCopy(string src, string dst)
            {
                if (parameters.Move) File.Move(src, dst); else File.Copy(src, dst);
                backgroundWorker.ReportProgress(-1, $"Файл {Path.GetFileName(src)} скопирован в каталог {Path.GetDirectoryName(dst)}");
            }

        }

        private void backgroundWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            if (e.ProgressPercentage >= 0)
                progressBar.Value = e.ProgressPercentage;
            if (e.UserState is string text)
            {
                logBox.Items.Insert(0, text);
            }
        }

        private void backgroundWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            startButton.Text = "Старт";
            progressBar.Value = 0;
            outputGroupBox.Enabled = inputGroupBox.Enabled = true;
        }

        private void inputDirButton_Click(object sender, EventArgs e)
        {
            folderBrowserDialog.SelectedPath = inputDirBox.Text;
            folderBrowserDialog.Description = inputGroupBox.Text;
            if (folderBrowserDialog.ShowDialog(this) == DialogResult.OK)
            {
                inputDirBox.Text = folderBrowserDialog.SelectedPath;
            }
        }

        private void outputDirButton_Click(object sender, EventArgs e)
        {
            folderBrowserDialog.SelectedPath = outputDirBox.Text;
            folderBrowserDialog.Description = outputGroupBox.Text;
            if (folderBrowserDialog.ShowDialog(this) == DialogResult.OK)
            {
                outputDirBox.Text = folderBrowserDialog.SelectedPath;
            }
        }

        private void OnDirChanged(object sender, EventArgs e)
        {
            CheckStart();
        }

        private void OnStructureChanged(object sender, EventArgs e)
        {
            CheckSctructure();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Properties.Settings.Default.inputDirectory = inputDirBox.Text;
            Properties.Settings.Default.outputDirectory = outputDirBox.Text;
            Properties.Settings.Default.Save();

        }
    }

    public enum StructureItem
    {
        None, DateYear, DateMonth, DateDay, DateYM, DateYMD, PhotoType, CameraCompany, CameraModel
    }

    public class Parameters
    {
        public string InputDir { get; set; }
        public string OutputDir { get; set; }
        public IEnumerable<StructureItem> StructureItems { get; set; }
        public bool Move { get; set; }

    }

    public class Photo
    {
        private static String[] RawFiles = { ".arw", ".dng", ".nef", ".crw", ".cr2", ".cr3" };
        public DateTime ShotTime { get; private set; }
        public bool HasGPS { get; private set; }
        public string Make { get; private set; }
        public string Model { get; private set; }
        public bool IsRAW { get; private set; }
        public string Path { get; private set; }
        public string Extension => System.IO.Path.GetExtension(Path);
        public string FileName => System.IO.Path.GetFileNameWithoutExtension(Path);
        public long FileSize { get; private set; }
        public bool LoadData(string path)
        {
            Path = path;
            IEnumerable<MetadataExtractor.Directory> directories = ImageMetadataReader.ReadMetadata(path);
            var exifDirectory = directories.OfType<MetadataExtractor.Formats.Exif.ExifIfd0Directory>().FirstOrDefault();
            var gpsDirectory = directories.OfType<MetadataExtractor.Formats.Exif.GpsDirectory>().FirstOrDefault();
            var fileDirecory = directories.OfType<MetadataExtractor.Formats.FileSystem.FileMetadataDirectory>().FirstOrDefault();
            HasGPS = gpsDirectory != null;
            if (exifDirectory != null)
            {
                IsRAW = RawFiles.Contains(System.IO.Path.GetExtension(path).ToLower());

                Make = exifDirectory.GetString(271);
                ShotTime = exifDirectory.GetDateTime(306);
                Model = exifDirectory.GetString(272);
            }

            if (fileDirecory != null)
            {

                FileSize = fileDirecory.GetInt64(2);
            }

            return true;
        }

        public static Photo GetPhoto(string path)
        {
            var photo = new Photo();
            return photo.LoadData(path) ? photo : null;
        }
    }
}
