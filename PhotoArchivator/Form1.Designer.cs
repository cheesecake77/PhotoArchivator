﻿namespace PhotoArchivator
{
    partial class Form1
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
            this.outputGroupBox = new System.Windows.Forms.GroupBox();
            this.processGroupBox = new System.Windows.Forms.GroupBox();
            this.inputDirBox = new System.Windows.Forms.TextBox();
            this.inputDirButton = new System.Windows.Forms.Button();
            this.jpgButton = new System.Windows.Forms.RadioButton();
            this.rawButton = new System.Windows.Forms.RadioButton();
            this.jpgRawButton = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.outputDirButton = new System.Windows.Forms.Button();
            this.outputDirBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.dir1Box = new System.Windows.Forms.ComboBox();
            this.dir2Box = new System.Windows.Forms.ComboBox();
            this.dir3Box = new System.Windows.Forms.ComboBox();
            this.dir4Box = new System.Windows.Forms.ComboBox();
            this.dir5Box = new System.Windows.Forms.ComboBox();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.startButton = new System.Windows.Forms.Button();
            this.logBox = new System.Windows.Forms.ListBox();
            this.inputGroupBox.SuspendLayout();
            this.outputGroupBox.SuspendLayout();
            this.processGroupBox.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
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
            // inputDirBox
            // 
            this.inputDirBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.inputDirBox.Location = new System.Drawing.Point(125, 19);
            this.inputDirBox.Name = "inputDirBox";
            this.inputDirBox.Size = new System.Drawing.Size(359, 20);
            this.inputDirBox.TabIndex = 0;
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
            // jpgRawButton
            // 
            this.jpgRawButton.AutoSize = true;
            this.jpgRawButton.Checked = true;
            this.jpgRawButton.Location = new System.Drawing.Point(240, 45);
            this.jpgRawButton.Name = "jpgRawButton";
            this.jpgRawButton.Size = new System.Drawing.Size(83, 17);
            this.jpgRawButton.TabIndex = 4;
            this.jpgRawButton.TabStop = true;
            this.jpgRawButton.Text = "JPG + RAW";
            this.jpgRawButton.UseVisualStyleBackColor = true;
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Тип фотографии:";
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
            // outputDirButton
            // 
            this.outputDirButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.outputDirButton.Location = new System.Drawing.Point(490, 18);
            this.outputDirButton.Name = "outputDirButton";
            this.outputDirButton.Size = new System.Drawing.Size(22, 22);
            this.outputDirButton.TabIndex = 8;
            this.outputDirButton.Text = "...";
            this.outputDirButton.UseVisualStyleBackColor = true;
            // 
            // outputDirBox
            // 
            this.outputDirBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.outputDirBox.Location = new System.Drawing.Point(125, 19);
            this.outputDirBox.Name = "outputDirBox";
            this.outputDirBox.Size = new System.Drawing.Size(359, 20);
            this.outputDirBox.TabIndex = 7;
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
            this.dir1Box.FormattingEnabled = true;
            this.dir1Box.Location = new System.Drawing.Point(3, 3);
            this.dir1Box.Name = "dir1Box";
            this.dir1Box.Size = new System.Drawing.Size(94, 21);
            this.dir1Box.TabIndex = 0;
            // 
            // dir2Box
            // 
            this.dir2Box.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dir2Box.FormattingEnabled = true;
            this.dir2Box.Location = new System.Drawing.Point(103, 3);
            this.dir2Box.Name = "dir2Box";
            this.dir2Box.Size = new System.Drawing.Size(94, 21);
            this.dir2Box.TabIndex = 1;
            // 
            // dir3Box
            // 
            this.dir3Box.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dir3Box.FormattingEnabled = true;
            this.dir3Box.Location = new System.Drawing.Point(203, 3);
            this.dir3Box.Name = "dir3Box";
            this.dir3Box.Size = new System.Drawing.Size(94, 21);
            this.dir3Box.TabIndex = 2;
            // 
            // dir4Box
            // 
            this.dir4Box.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dir4Box.FormattingEnabled = true;
            this.dir4Box.Location = new System.Drawing.Point(303, 3);
            this.dir4Box.Name = "dir4Box";
            this.dir4Box.Size = new System.Drawing.Size(94, 21);
            this.dir4Box.TabIndex = 3;
            // 
            // dir5Box
            // 
            this.dir5Box.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dir5Box.FormattingEnabled = true;
            this.dir5Box.Location = new System.Drawing.Point(403, 3);
            this.dir5Box.Name = "dir5Box";
            this.dir5Box.Size = new System.Drawing.Size(97, 21);
            this.dir5Box.TabIndex = 4;
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(543, 455);
            this.Controls.Add(this.processGroupBox);
            this.Controls.Add(this.outputGroupBox);
            this.Controls.Add(this.inputGroupBox);
            this.MinimumSize = new System.Drawing.Size(500, 400);
            this.Name = "Form1";
            this.Text = "Фото Архивариус";
            this.inputGroupBox.ResumeLayout(false);
            this.inputGroupBox.PerformLayout();
            this.outputGroupBox.ResumeLayout(false);
            this.outputGroupBox.PerformLayout();
            this.processGroupBox.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

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
    }
}

