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
        public MainForm()
        {
            InitializeComponent();
            dir1Box.SelectedIndex = 
                dir2Box.SelectedIndex = 
                dir3Box.SelectedIndex = 
                dir4Box.SelectedIndex = 
                dir5Box.SelectedIndex = 0;
            CheckStart();

        }

        private void CheckStart()
        {
            startButton.Enabled =
                !string.IsNullOrEmpty(inputDirBox.Text) &&
                !string.IsNullOrEmpty(outputDirBox.Text) &&
                System.IO.Directory.Exists(inputDirBox.Text) &&
                System.IO.Directory.Exists(outputDirBox.Text) &&
                !outputDirBox.Text.TrimEnd('\\').Contains(inputDirBox.Text);
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
    }
}
