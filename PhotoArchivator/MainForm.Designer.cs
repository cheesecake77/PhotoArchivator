namespace PhotoArchivator
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.inputGroupBox = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.jpgRawButton = new System.Windows.Forms.RadioButton();
            this.rawButton = new System.Windows.Forms.RadioButton();
            this.jpgButton = new System.Windows.Forms.RadioButton();
            this.inputDirButton = new System.Windows.Forms.Button();
            this.inputDirBox = new System.Windows.Forms.TextBox();
            this.outputGroupBox = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.dir1Box = new System.Windows.Forms.ComboBox();
            this.dir2Box = new System.Windows.Forms.ComboBox();
            this.dir3Box = new System.Windows.Forms.ComboBox();
            this.dir4Box = new System.Windows.Forms.ComboBox();
            this.dir5Box = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.outputDirBox = new System.Windows.Forms.TextBox();
            this.outputDirButton = new System.Windows.Forms.Button();
            this.processGroupBox = new System.Windows.Forms.GroupBox();
            this.logBox = new System.Windows.Forms.ListBox();
            this.startButton = new System.Windows.Forms.Button();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.backgroundWorker = new System.ComponentModel.BackgroundWorker();
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.statusBar = new System.Windows.Forms.ToolStripStatusLabel();
            this.inputGroupBox.SuspendLayout();
            this.outputGroupBox.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.processGroupBox.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // inputGroupBox
            // 
            this.inputGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.inputGroupBox.Controls.Add(this.label2);
            this.inputGroupBox.Controls.Add(this.label1);
            this.inputGroupBox.Controls.Add(this.jpgRawButton);
            this.inputGroupBox.Controls.Add(this.rawButton);
            this.inputGroupBox.Controls.Add(this.jpgButton);
            this.inputGroupBox.Controls.Add(this.inputDirButton);
            this.inputGroupBox.Controls.Add(this.inputDirBox);
            this.inputGroupBox.Location = new System.Drawing.Point(12, 12);
            this.inputGroupBox.Name = "inputGroupBox";
            this.inputGroupBox.Size = new System.Drawing.Size(519, 76);
            this.inputGroupBox.TabIndex = 0;
            this.inputGroupBox.TabStop = false;
            this.inputGroupBox.Text = "Откуда берем";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Тип фотографии:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Исходный католог:";
            // 
            // jpgRawButton
            // 
            this.jpgRawButton.AutoSize = true;
            this.jpgRawButton.Checked = true;
            this.jpgRawButton.Location = new System.Drawing.Point(240, 45);
            this.jpgRawButton.Name = "jpgRawButton";
            this.jpgRawButton.Size = new System.Drawing.Size(90, 17);
            this.jpgRawButton.TabIndex = 4;
            this.jpgRawButton.TabStop = true;
            this.jpgRawButton.Text = "JPEG + RAW";
            this.jpgRawButton.UseVisualStyleBackColor = true;
            // 
            // rawButton
            // 
            this.rawButton.AutoSize = true;
            this.rawButton.Location = new System.Drawing.Point(183, 45);
            this.rawButton.Name = "rawButton";
            this.rawButton.Size = new System.Drawing.Size(51, 17);
            this.rawButton.TabIndex = 3;
            this.rawButton.Text = "RAW";
            this.rawButton.UseVisualStyleBackColor = true;
            // 
            // jpgButton
            // 
            this.jpgButton.AutoSize = true;
            this.jpgButton.Location = new System.Drawing.Point(125, 45);
            this.jpgButton.Name = "jpgButton";
            this.jpgButton.Size = new System.Drawing.Size(52, 17);
            this.jpgButton.TabIndex = 2;
            this.jpgButton.Text = "JPEG";
            this.jpgButton.UseVisualStyleBackColor = true;
            // 
            // inputDirButton
            // 
            this.inputDirButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.inputDirButton.Location = new System.Drawing.Point(490, 18);
            this.inputDirButton.Name = "inputDirButton";
            this.inputDirButton.Size = new System.Drawing.Size(22, 22);
            this.inputDirButton.TabIndex = 1;
            this.inputDirButton.Text = "...";
            this.inputDirButton.UseVisualStyleBackColor = true;
            this.inputDirButton.Click += new System.EventHandler(this.inputDirButton_Click);
            // 
            // inputDirBox
            // 
            this.inputDirBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.inputDirBox.Location = new System.Drawing.Point(125, 19);
            this.inputDirBox.Name = "inputDirBox";
            this.inputDirBox.Size = new System.Drawing.Size(359, 20);
            this.inputDirBox.TabIndex = 0;
            this.inputDirBox.TextChanged += new System.EventHandler(this.OnDirChanged);
            // 
            // outputGroupBox
            // 
            this.outputGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.outputGroupBox.Controls.Add(this.tableLayoutPanel1);
            this.outputGroupBox.Controls.Add(this.label4);
            this.outputGroupBox.Controls.Add(this.label3);
            this.outputGroupBox.Controls.Add(this.outputDirBox);
            this.outputGroupBox.Controls.Add(this.outputDirButton);
            this.outputGroupBox.Location = new System.Drawing.Point(12, 94);
            this.outputGroupBox.Name = "outputGroupBox";
            this.outputGroupBox.Size = new System.Drawing.Size(519, 103);
            this.outputGroupBox.TabIndex = 1;
            this.outputGroupBox.TabStop = false;
            this.outputGroupBox.Text = "Куда кладем";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Controls.Add(this.dir1Box, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.dir2Box, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.dir3Box, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.dir4Box, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.dir5Box, 4, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(9, 62);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(503, 28);
            this.tableLayoutPanel1.TabIndex = 11;
            // 
            // dir1Box
            // 
            this.dir1Box.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dir1Box.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.dir1Box.FormattingEnabled = true;
            this.dir1Box.Location = new System.Drawing.Point(3, 3);
            this.dir1Box.Name = "dir1Box";
            this.dir1Box.Size = new System.Drawing.Size(94, 21);
            this.dir1Box.TabIndex = 0;
            this.dir1Box.SelectedIndexChanged += new System.EventHandler(this.OnStructureChanged);
            // 
            // dir2Box
            // 
            this.dir2Box.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dir2Box.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.dir2Box.FormattingEnabled = true;
            this.dir2Box.Location = new System.Drawing.Point(103, 3);
            this.dir2Box.Name = "dir2Box";
            this.dir2Box.Size = new System.Drawing.Size(94, 21);
            this.dir2Box.TabIndex = 1;
            this.dir2Box.SelectedIndexChanged += new System.EventHandler(this.OnStructureChanged);
            // 
            // dir3Box
            // 
            this.dir3Box.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dir3Box.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.dir3Box.FormattingEnabled = true;
            this.dir3Box.Location = new System.Drawing.Point(203, 3);
            this.dir3Box.Name = "dir3Box";
            this.dir3Box.Size = new System.Drawing.Size(94, 21);
            this.dir3Box.TabIndex = 2;
            this.dir3Box.SelectedIndexChanged += new System.EventHandler(this.OnStructureChanged);
            // 
            // dir4Box
            // 
            this.dir4Box.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dir4Box.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.dir4Box.FormattingEnabled = true;
            this.dir4Box.Location = new System.Drawing.Point(303, 3);
            this.dir4Box.Name = "dir4Box";
            this.dir4Box.Size = new System.Drawing.Size(94, 21);
            this.dir4Box.TabIndex = 3;
            this.dir4Box.SelectedIndexChanged += new System.EventHandler(this.OnStructureChanged);
            // 
            // dir5Box
            // 
            this.dir5Box.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dir5Box.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.dir5Box.FormattingEnabled = true;
            this.dir5Box.Location = new System.Drawing.Point(403, 3);
            this.dir5Box.Name = "dir5Box";
            this.dir5Box.Size = new System.Drawing.Size(97, 21);
            this.dir5Box.TabIndex = 4;
            this.dir5Box.SelectedIndexChanged += new System.EventHandler(this.OnStructureChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 46);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Структура:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Каталог назначения:";
            // 
            // outputDirBox
            // 
            this.outputDirBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.outputDirBox.Location = new System.Drawing.Point(125, 19);
            this.outputDirBox.Name = "outputDirBox";
            this.outputDirBox.Size = new System.Drawing.Size(359, 20);
            this.outputDirBox.TabIndex = 7;
            this.outputDirBox.TextChanged += new System.EventHandler(this.OnDirChanged);
            // 
            // outputDirButton
            // 
            this.outputDirButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.outputDirButton.Location = new System.Drawing.Point(490, 18);
            this.outputDirButton.Name = "outputDirButton";
            this.outputDirButton.Size = new System.Drawing.Size(22, 22);
            this.outputDirButton.TabIndex = 8;
            this.outputDirButton.Text = "...";
            this.outputDirButton.UseVisualStyleBackColor = true;
            this.outputDirButton.Click += new System.EventHandler(this.outputDirButton_Click);
            // 
            // processGroupBox
            // 
            this.processGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.processGroupBox.Controls.Add(this.logBox);
            this.processGroupBox.Controls.Add(this.startButton);
            this.processGroupBox.Controls.Add(this.progressBar);
            this.processGroupBox.Location = new System.Drawing.Point(12, 203);
            this.processGroupBox.Name = "processGroupBox";
            this.processGroupBox.Size = new System.Drawing.Size(519, 240);
            this.processGroupBox.TabIndex = 2;
            this.processGroupBox.TabStop = false;
            this.processGroupBox.Text = "Поехали";
            // 
            // logBox
            // 
            this.logBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.logBox.FormattingEnabled = true;
            this.logBox.IntegralHeight = false;
            this.logBox.Location = new System.Drawing.Point(9, 75);
            this.logBox.Name = "logBox";
            this.logBox.Size = new System.Drawing.Size(503, 157);
            this.logBox.TabIndex = 2;
            // 
            // startButton
            // 
            this.startButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.startButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.startButton.Location = new System.Drawing.Point(9, 19);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(503, 32);
            this.startButton.TabIndex = 1;
            this.startButton.Text = "Старт";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // progressBar
            // 
            this.progressBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBar.Location = new System.Drawing.Point(9, 57);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(503, 12);
            this.progressBar.TabIndex = 0;
            // 
            // backgroundWorker
            // 
            this.backgroundWorker.WorkerReportsProgress = true;
            this.backgroundWorker.WorkerSupportsCancellation = true;
            this.backgroundWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker_DoWork);
            this.backgroundWorker.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker_ProgressChanged);
            this.backgroundWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker_RunWorkerCompleted);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusBar});
            this.statusStrip1.Location = new System.Drawing.Point(0, 433);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(543, 22);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // statusBar
            // 
            this.statusBar.LinkColor = System.Drawing.Color.Yellow;
            this.statusBar.Name = "statusBar";
            this.statusBar.Size = new System.Drawing.Size(528, 17);
            this.statusBar.Spring = true;
            this.statusBar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(543, 455);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.processGroupBox);
            this.Controls.Add(this.outputGroupBox);
            this.Controls.Add(this.inputGroupBox);
            this.MinimumSize = new System.Drawing.Size(500, 400);
            this.Name = "MainForm";
            this.Text = "Фото Архивариус";
            this.inputGroupBox.ResumeLayout(false);
            this.inputGroupBox.PerformLayout();
            this.outputGroupBox.ResumeLayout(false);
            this.outputGroupBox.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.processGroupBox.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox inputGroupBox;
        private System.Windows.Forms.Button inputDirButton;
        private System.Windows.Forms.TextBox inputDirBox;
        private System.Windows.Forms.GroupBox outputGroupBox;
        private System.Windows.Forms.GroupBox processGroupBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton jpgRawButton;
        private System.Windows.Forms.RadioButton rawButton;
        private System.Windows.Forms.RadioButton jpgButton;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ComboBox dir1Box;
        private System.Windows.Forms.ComboBox dir2Box;
        private System.Windows.Forms.ComboBox dir3Box;
        private System.Windows.Forms.ComboBox dir4Box;
        private System.Windows.Forms.ComboBox dir5Box;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox outputDirBox;
        private System.Windows.Forms.Button outputDirButton;
        private System.Windows.Forms.ListBox logBox;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.ComponentModel.BackgroundWorker backgroundWorker;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel statusBar;
    }
}

