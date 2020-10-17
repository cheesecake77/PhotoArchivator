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

namespace PhotoArchivator
{
    public partial class MainForm : Form
    {
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
                backgroundWorker.RunWorkerAsync();
                startButton.Text = "Стоп";
                progressBar.Value = 0;
                logBox.Items.Clear();
                outputGroupBox.Enabled = inputGroupBox.Enabled = false;
            }
        }

        private void backgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            
            for (int i = 0; i <= 100; i++)
            {
                if (backgroundWorker.CancellationPending) break;
                backgroundWorker.ReportProgress(i, $"Строка номер {i}");
                Thread.Sleep(200);
            }
        }

        private void backgroundWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            progressBar.Value = e.ProgressPercentage;
            if(e.UserState is string text)
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
    }

    public enum StructureItem
    {
        None, DateYear, DateMonth, DateDay, DateYM, DateYMD, PhotoType, CameraCompany, CameraModel
    }
}
