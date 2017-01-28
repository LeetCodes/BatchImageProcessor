﻿namespace Batch_Image_Processor
{
    partial class FormMain
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.LabelDirIn = new System.Windows.Forms.Label();
            this.TBDirIn = new System.Windows.Forms.TextBox();
            this.TBDirOut = new System.Windows.Forms.TextBox();
            this.LabelDirOut = new System.Windows.Forms.Label();
            this.BtnDirIn = new System.Windows.Forms.Button();
            this.BtnDirOut = new System.Windows.Forms.Button();
            this.FolderBrowserDialogMain = new System.Windows.Forms.FolderBrowserDialog();
            this.GroupBoxResize = new System.Windows.Forms.GroupBox();
            this.CBLimFileSize = new System.Windows.Forms.CheckBox();
            this.TBLimFileSize = new System.Windows.Forms.TextBox();
            this.LabelLimFileSize = new System.Windows.Forms.Label();
            this.LabelLimHeight = new System.Windows.Forms.Label();
            this.LabelLimWidth = new System.Windows.Forms.Label();
            this.TBLimHeight = new System.Windows.Forms.TextBox();
            this.TBLimWidth = new System.Windows.Forms.TextBox();
            this.CBLimRes = new System.Windows.Forms.CheckBox();
            this.GroupBoxConvert = new System.Windows.Forms.GroupBox();
            this.TBRenameSuffix = new System.Windows.Forms.TextBox();
            this.TBRenamePrefix = new System.Windows.Forms.TextBox();
            this.LabelRenameSuffix = new System.Windows.Forms.Label();
            this.LabelRenamePrefix = new System.Windows.Forms.Label();
            this.CBKeepFileName = new System.Windows.Forms.CheckBox();
            this.BtnStart = new System.Windows.Forms.Button();
            this.LabelOutFormat = new System.Windows.Forms.Label();
            this.ComboBoxOutFormat = new System.Windows.Forms.ComboBox();
            this.GroupBoxCreateEmptyImg = new System.Windows.Forms.GroupBox();
            this.LabelEmptyImgFileName = new System.Windows.Forms.Label();
            this.LabelEmptyImgWidth = new System.Windows.Forms.Label();
            this.LabelEmptyImgHeight = new System.Windows.Forms.Label();
            this.TBEmptyImgFileName = new System.Windows.Forms.TextBox();
            this.TBEmptyImgWidth = new System.Windows.Forms.TextBox();
            this.TBEmptyImgHeight = new System.Windows.Forms.TextBox();
            this.BtnCreateEmptyImg = new System.Windows.Forms.Button();
            this.GroupBoxLog = new System.Windows.Forms.GroupBox();
            this.TBLog = new System.Windows.Forms.TextBox();
            this.GroupBoxResize.SuspendLayout();
            this.GroupBoxConvert.SuspendLayout();
            this.GroupBoxCreateEmptyImg.SuspendLayout();
            this.GroupBoxLog.SuspendLayout();
            this.SuspendLayout();
            // 
            // LabelDirIn
            // 
            this.LabelDirIn.AutoSize = true;
            this.LabelDirIn.Location = new System.Drawing.Point(13, 16);
            this.LabelDirIn.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabelDirIn.Name = "LabelDirIn";
            this.LabelDirIn.Size = new System.Drawing.Size(143, 15);
            this.LabelDirIn.TabIndex = 0;
            this.LabelDirIn.Text = "Input Directory: ";
            // 
            // TBDirIn
            // 
            this.TBDirIn.Location = new System.Drawing.Point(178, 13);
            this.TBDirIn.Margin = new System.Windows.Forms.Padding(4);
            this.TBDirIn.Name = "TBDirIn";
            this.TBDirIn.Size = new System.Drawing.Size(545, 25);
            this.TBDirIn.TabIndex = 1;
            this.TBDirIn.DoubleClick += new System.EventHandler(this.BtnDirIn_Click);
            // 
            // TBDirOut
            // 
            this.TBDirOut.Location = new System.Drawing.Point(178, 46);
            this.TBDirOut.Margin = new System.Windows.Forms.Padding(4);
            this.TBDirOut.Name = "TBDirOut";
            this.TBDirOut.Size = new System.Drawing.Size(545, 25);
            this.TBDirOut.TabIndex = 2;
            this.TBDirOut.DoubleClick += new System.EventHandler(this.BtnDirOut_Click);
            // 
            // LabelDirOut
            // 
            this.LabelDirOut.AutoSize = true;
            this.LabelDirOut.Location = new System.Drawing.Point(13, 51);
            this.LabelDirOut.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabelDirOut.Name = "LabelDirOut";
            this.LabelDirOut.Size = new System.Drawing.Size(151, 15);
            this.LabelDirOut.TabIndex = 3;
            this.LabelDirOut.Text = "Output Directory: ";
            // 
            // BtnDirIn
            // 
            this.BtnDirIn.Location = new System.Drawing.Point(732, 13);
            this.BtnDirIn.Margin = new System.Windows.Forms.Padding(4);
            this.BtnDirIn.Name = "BtnDirIn";
            this.BtnDirIn.Size = new System.Drawing.Size(124, 26);
            this.BtnDirIn.TabIndex = 4;
            this.BtnDirIn.Text = "Browse...";
            this.BtnDirIn.UseVisualStyleBackColor = true;
            this.BtnDirIn.Click += new System.EventHandler(this.BtnDirIn_Click);
            // 
            // BtnDirOut
            // 
            this.BtnDirOut.Location = new System.Drawing.Point(732, 45);
            this.BtnDirOut.Margin = new System.Windows.Forms.Padding(4);
            this.BtnDirOut.Name = "BtnDirOut";
            this.BtnDirOut.Size = new System.Drawing.Size(124, 26);
            this.BtnDirOut.TabIndex = 5;
            this.BtnDirOut.Text = "Browse...";
            this.BtnDirOut.UseVisualStyleBackColor = true;
            this.BtnDirOut.Click += new System.EventHandler(this.BtnDirOut_Click);
            // 
            // GroupBoxResize
            // 
            this.GroupBoxResize.Controls.Add(this.CBLimFileSize);
            this.GroupBoxResize.Controls.Add(this.TBLimFileSize);
            this.GroupBoxResize.Controls.Add(this.LabelLimFileSize);
            this.GroupBoxResize.Controls.Add(this.LabelLimHeight);
            this.GroupBoxResize.Controls.Add(this.LabelLimWidth);
            this.GroupBoxResize.Controls.Add(this.TBLimHeight);
            this.GroupBoxResize.Controls.Add(this.TBLimWidth);
            this.GroupBoxResize.Controls.Add(this.CBLimRes);
            this.GroupBoxResize.Location = new System.Drawing.Point(17, 78);
            this.GroupBoxResize.Name = "GroupBoxResize";
            this.GroupBoxResize.Size = new System.Drawing.Size(395, 176);
            this.GroupBoxResize.TabIndex = 6;
            this.GroupBoxResize.TabStop = false;
            this.GroupBoxResize.Text = "Resize";
            // 
            // CBLimFileSize
            // 
            this.CBLimFileSize.AutoSize = true;
            this.CBLimFileSize.Location = new System.Drawing.Point(6, 112);
            this.CBLimFileSize.Name = "CBLimFileSize";
            this.CBLimFileSize.Size = new System.Drawing.Size(146, 19);
            this.CBLimFileSize.TabIndex = 7;
            this.CBLimFileSize.Text = "Limit File Size";
            this.CBLimFileSize.UseVisualStyleBackColor = true;
            this.CBLimFileSize.CheckedChanged += new System.EventHandler(this.CBLimFileSize_CheckedChanged);
            // 
            // TBLimFileSize
            // 
            this.TBLimFileSize.Enabled = false;
            this.TBLimFileSize.Location = new System.Drawing.Point(211, 137);
            this.TBLimFileSize.Name = "TBLimFileSize";
            this.TBLimFileSize.Size = new System.Drawing.Size(174, 25);
            this.TBLimFileSize.TabIndex = 6;
            this.TBLimFileSize.Text = "10240";
            // 
            // LabelLimFileSize
            // 
            this.LabelLimFileSize.AutoSize = true;
            this.LabelLimFileSize.Location = new System.Drawing.Point(6, 140);
            this.LabelLimFileSize.Name = "LabelLimFileSize";
            this.LabelLimFileSize.Size = new System.Drawing.Size(199, 15);
            this.LabelLimFileSize.TabIndex = 5;
            this.LabelLimFileSize.Text = "Maximum File Size (kB): ";
            // 
            // LabelLimHeight
            // 
            this.LabelLimHeight.AutoSize = true;
            this.LabelLimHeight.Location = new System.Drawing.Point(6, 84);
            this.LabelLimHeight.Name = "LabelLimHeight";
            this.LabelLimHeight.Size = new System.Drawing.Size(199, 15);
            this.LabelLimHeight.TabIndex = 4;
            this.LabelLimHeight.Text = "Maximum Height (Pixel): ";
            // 
            // LabelLimWidth
            // 
            this.LabelLimWidth.AutoSize = true;
            this.LabelLimWidth.Location = new System.Drawing.Point(5, 53);
            this.LabelLimWidth.Name = "LabelLimWidth";
            this.LabelLimWidth.Size = new System.Drawing.Size(191, 15);
            this.LabelLimWidth.TabIndex = 3;
            this.LabelLimWidth.Text = "Maximum Width (Pixel): ";
            // 
            // TBLimHeight
            // 
            this.TBLimHeight.Location = new System.Drawing.Point(211, 81);
            this.TBLimHeight.Name = "TBLimHeight";
            this.TBLimHeight.Size = new System.Drawing.Size(174, 25);
            this.TBLimHeight.TabIndex = 2;
            this.TBLimHeight.Text = "720";
            // 
            // TBLimWidth
            // 
            this.TBLimWidth.Location = new System.Drawing.Point(211, 50);
            this.TBLimWidth.Name = "TBLimWidth";
            this.TBLimWidth.Size = new System.Drawing.Size(174, 25);
            this.TBLimWidth.TabIndex = 1;
            this.TBLimWidth.Text = "1280";
            // 
            // CBLimRes
            // 
            this.CBLimRes.AutoSize = true;
            this.CBLimRes.Checked = true;
            this.CBLimRes.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CBLimRes.Location = new System.Drawing.Point(8, 25);
            this.CBLimRes.Name = "CBLimRes";
            this.CBLimRes.Size = new System.Drawing.Size(154, 19);
            this.CBLimRes.TabIndex = 0;
            this.CBLimRes.Text = "Limit Resolution";
            this.CBLimRes.UseVisualStyleBackColor = true;
            this.CBLimRes.CheckedChanged += new System.EventHandler(this.CBLimRes_CheckedChanged);
            // 
            // GroupBoxConvert
            // 
            this.GroupBoxConvert.Controls.Add(this.GroupBoxCreateEmptyImg);
            this.GroupBoxConvert.Controls.Add(this.TBRenameSuffix);
            this.GroupBoxConvert.Controls.Add(this.TBRenamePrefix);
            this.GroupBoxConvert.Controls.Add(this.LabelRenameSuffix);
            this.GroupBoxConvert.Controls.Add(this.LabelRenamePrefix);
            this.GroupBoxConvert.Controls.Add(this.CBKeepFileName);
            this.GroupBoxConvert.Controls.Add(this.BtnStart);
            this.GroupBoxConvert.Controls.Add(this.LabelOutFormat);
            this.GroupBoxConvert.Controls.Add(this.ComboBoxOutFormat);
            this.GroupBoxConvert.Location = new System.Drawing.Point(418, 78);
            this.GroupBoxConvert.Name = "GroupBoxConvert";
            this.GroupBoxConvert.Size = new System.Drawing.Size(439, 329);
            this.GroupBoxConvert.TabIndex = 7;
            this.GroupBoxConvert.TabStop = false;
            this.GroupBoxConvert.Text = "Convert and Output";
            // 
            // TBRenameSuffix
            // 
            this.TBRenameSuffix.Enabled = false;
            this.TBRenameSuffix.Location = new System.Drawing.Point(86, 112);
            this.TBRenameSuffix.Name = "TBRenameSuffix";
            this.TBRenameSuffix.Size = new System.Drawing.Size(347, 25);
            this.TBRenameSuffix.TabIndex = 7;
            // 
            // TBRenamePrefix
            // 
            this.TBRenamePrefix.Enabled = false;
            this.TBRenamePrefix.Location = new System.Drawing.Point(86, 78);
            this.TBRenamePrefix.Name = "TBRenamePrefix";
            this.TBRenamePrefix.Size = new System.Drawing.Size(347, 25);
            this.TBRenamePrefix.TabIndex = 6;
            // 
            // LabelRenameSuffix
            // 
            this.LabelRenameSuffix.AutoSize = true;
            this.LabelRenameSuffix.Location = new System.Drawing.Point(9, 115);
            this.LabelRenameSuffix.Name = "LabelRenameSuffix";
            this.LabelRenameSuffix.Size = new System.Drawing.Size(71, 15);
            this.LabelRenameSuffix.TabIndex = 5;
            this.LabelRenameSuffix.Text = "Suffix: ";
            // 
            // LabelRenamePrefix
            // 
            this.LabelRenamePrefix.AutoSize = true;
            this.LabelRenamePrefix.Location = new System.Drawing.Point(9, 81);
            this.LabelRenamePrefix.Name = "LabelRenamePrefix";
            this.LabelRenamePrefix.Size = new System.Drawing.Size(71, 15);
            this.LabelRenamePrefix.TabIndex = 4;
            this.LabelRenamePrefix.Text = "Prefix: ";
            // 
            // CBKeepFileName
            // 
            this.CBKeepFileName.AutoSize = true;
            this.CBKeepFileName.Checked = true;
            this.CBKeepFileName.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CBKeepFileName.Location = new System.Drawing.Point(9, 53);
            this.CBKeepFileName.Name = "CBKeepFileName";
            this.CBKeepFileName.Size = new System.Drawing.Size(210, 19);
            this.CBKeepFileName.TabIndex = 3;
            this.CBKeepFileName.Text = "Keep original file name";
            this.CBKeepFileName.UseVisualStyleBackColor = true;
            // 
            // BtnStart
            // 
            this.BtnStart.Location = new System.Drawing.Point(9, 143);
            this.BtnStart.Name = "BtnStart";
            this.BtnStart.Size = new System.Drawing.Size(424, 48);
            this.BtnStart.TabIndex = 2;
            this.BtnStart.Text = "Start";
            this.BtnStart.UseVisualStyleBackColor = true;
            // 
            // LabelOutFormat
            // 
            this.LabelOutFormat.AutoSize = true;
            this.LabelOutFormat.Location = new System.Drawing.Point(6, 27);
            this.LabelOutFormat.Name = "LabelOutFormat";
            this.LabelOutFormat.Size = new System.Drawing.Size(127, 15);
            this.LabelOutFormat.TabIndex = 1;
            this.LabelOutFormat.Text = "Output Format: ";
            // 
            // ComboBoxOutFormat
            // 
            this.ComboBoxOutFormat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBoxOutFormat.FormattingEnabled = true;
            this.ComboBoxOutFormat.Location = new System.Drawing.Point(139, 24);
            this.ComboBoxOutFormat.Name = "ComboBoxOutFormat";
            this.ComboBoxOutFormat.Size = new System.Drawing.Size(294, 23);
            this.ComboBoxOutFormat.TabIndex = 0;
            // 
            // GroupBoxCreateEmptyImg
            // 
            this.GroupBoxCreateEmptyImg.Controls.Add(this.BtnCreateEmptyImg);
            this.GroupBoxCreateEmptyImg.Controls.Add(this.TBEmptyImgHeight);
            this.GroupBoxCreateEmptyImg.Controls.Add(this.TBEmptyImgWidth);
            this.GroupBoxCreateEmptyImg.Controls.Add(this.TBEmptyImgFileName);
            this.GroupBoxCreateEmptyImg.Controls.Add(this.LabelEmptyImgHeight);
            this.GroupBoxCreateEmptyImg.Controls.Add(this.LabelEmptyImgWidth);
            this.GroupBoxCreateEmptyImg.Controls.Add(this.LabelEmptyImgFileName);
            this.GroupBoxCreateEmptyImg.Location = new System.Drawing.Point(9, 197);
            this.GroupBoxCreateEmptyImg.Name = "GroupBoxCreateEmptyImg";
            this.GroupBoxCreateEmptyImg.Size = new System.Drawing.Size(424, 124);
            this.GroupBoxCreateEmptyImg.TabIndex = 8;
            this.GroupBoxCreateEmptyImg.TabStop = false;
            this.GroupBoxCreateEmptyImg.Text = "Create Empty Image (Using Format Above)";
            // 
            // LabelEmptyImgFileName
            // 
            this.LabelEmptyImgFileName.AutoSize = true;
            this.LabelEmptyImgFileName.Location = new System.Drawing.Point(6, 27);
            this.LabelEmptyImgFileName.Name = "LabelEmptyImgFileName";
            this.LabelEmptyImgFileName.Size = new System.Drawing.Size(95, 15);
            this.LabelEmptyImgFileName.TabIndex = 0;
            this.LabelEmptyImgFileName.Text = "File Name: ";
            // 
            // LabelEmptyImgWidth
            // 
            this.LabelEmptyImgWidth.AutoSize = true;
            this.LabelEmptyImgWidth.Location = new System.Drawing.Point(6, 58);
            this.LabelEmptyImgWidth.Name = "LabelEmptyImgWidth";
            this.LabelEmptyImgWidth.Size = new System.Drawing.Size(63, 15);
            this.LabelEmptyImgWidth.TabIndex = 1;
            this.LabelEmptyImgWidth.Text = "Width: ";
            // 
            // LabelEmptyImgHeight
            // 
            this.LabelEmptyImgHeight.AutoSize = true;
            this.LabelEmptyImgHeight.Location = new System.Drawing.Point(6, 89);
            this.LabelEmptyImgHeight.Name = "LabelEmptyImgHeight";
            this.LabelEmptyImgHeight.Size = new System.Drawing.Size(71, 15);
            this.LabelEmptyImgHeight.TabIndex = 2;
            this.LabelEmptyImgHeight.Text = "Height: ";
            // 
            // TBEmptyImgFileName
            // 
            this.TBEmptyImgFileName.Location = new System.Drawing.Point(107, 24);
            this.TBEmptyImgFileName.Name = "TBEmptyImgFileName";
            this.TBEmptyImgFileName.Size = new System.Drawing.Size(311, 25);
            this.TBEmptyImgFileName.TabIndex = 3;
            // 
            // TBEmptyImgWidth
            // 
            this.TBEmptyImgWidth.Location = new System.Drawing.Point(107, 55);
            this.TBEmptyImgWidth.Name = "TBEmptyImgWidth";
            this.TBEmptyImgWidth.Size = new System.Drawing.Size(169, 25);
            this.TBEmptyImgWidth.TabIndex = 4;
            // 
            // TBEmptyImgHeight
            // 
            this.TBEmptyImgHeight.Location = new System.Drawing.Point(107, 86);
            this.TBEmptyImgHeight.Name = "TBEmptyImgHeight";
            this.TBEmptyImgHeight.Size = new System.Drawing.Size(169, 25);
            this.TBEmptyImgHeight.TabIndex = 5;
            // 
            // BtnCreateEmptyImg
            // 
            this.BtnCreateEmptyImg.Location = new System.Drawing.Point(282, 55);
            this.BtnCreateEmptyImg.Name = "BtnCreateEmptyImg";
            this.BtnCreateEmptyImg.Size = new System.Drawing.Size(136, 56);
            this.BtnCreateEmptyImg.TabIndex = 6;
            this.BtnCreateEmptyImg.Text = "Create";
            this.BtnCreateEmptyImg.UseVisualStyleBackColor = true;
            // 
            // GroupBoxLog
            // 
            this.GroupBoxLog.Controls.Add(this.TBLog);
            this.GroupBoxLog.Location = new System.Drawing.Point(16, 261);
            this.GroupBoxLog.Name = "GroupBoxLog";
            this.GroupBoxLog.Size = new System.Drawing.Size(396, 146);
            this.GroupBoxLog.TabIndex = 8;
            this.GroupBoxLog.TabStop = false;
            this.GroupBoxLog.Text = "Log";
            // 
            // TBLog
            // 
            this.TBLog.Location = new System.Drawing.Point(7, 25);
            this.TBLog.Multiline = true;
            this.TBLog.Name = "TBLog";
            this.TBLog.Size = new System.Drawing.Size(379, 113);
            this.TBLog.TabIndex = 0;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(869, 415);
            this.Controls.Add(this.GroupBoxLog);
            this.Controls.Add(this.GroupBoxConvert);
            this.Controls.Add(this.GroupBoxResize);
            this.Controls.Add(this.BtnDirOut);
            this.Controls.Add(this.BtnDirIn);
            this.Controls.Add(this.LabelDirOut);
            this.Controls.Add(this.TBDirOut);
            this.Controls.Add(this.TBDirIn);
            this.Controls.Add(this.LabelDirIn);
            this.Font = new System.Drawing.Font("宋体", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Starting...";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.GroupBoxResize.ResumeLayout(false);
            this.GroupBoxResize.PerformLayout();
            this.GroupBoxConvert.ResumeLayout(false);
            this.GroupBoxConvert.PerformLayout();
            this.GroupBoxCreateEmptyImg.ResumeLayout(false);
            this.GroupBoxCreateEmptyImg.PerformLayout();
            this.GroupBoxLog.ResumeLayout(false);
            this.GroupBoxLog.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LabelDirIn;
        private System.Windows.Forms.TextBox TBDirIn;
        private System.Windows.Forms.TextBox TBDirOut;
        private System.Windows.Forms.Label LabelDirOut;
        private System.Windows.Forms.Button BtnDirIn;
        private System.Windows.Forms.Button BtnDirOut;
        private System.Windows.Forms.FolderBrowserDialog FolderBrowserDialogMain;
        private System.Windows.Forms.GroupBox GroupBoxResize;
        private System.Windows.Forms.GroupBox GroupBoxConvert;
        private System.Windows.Forms.CheckBox CBLimRes;
        private System.Windows.Forms.Label LabelLimFileSize;
        private System.Windows.Forms.Label LabelLimHeight;
        private System.Windows.Forms.Label LabelLimWidth;
        private System.Windows.Forms.CheckBox CBLimFileSize;
        private System.Windows.Forms.TextBox TBLimFileSize;
        private System.Windows.Forms.TextBox TBLimHeight;
        private System.Windows.Forms.TextBox TBLimWidth;
        private System.Windows.Forms.ComboBox ComboBoxOutFormat;
        private System.Windows.Forms.Label LabelOutFormat;
        private System.Windows.Forms.TextBox TBRenameSuffix;
        private System.Windows.Forms.TextBox TBRenamePrefix;
        private System.Windows.Forms.Label LabelRenameSuffix;
        private System.Windows.Forms.Label LabelRenamePrefix;
        private System.Windows.Forms.CheckBox CBKeepFileName;
        private System.Windows.Forms.Button BtnStart;
        private System.Windows.Forms.GroupBox GroupBoxCreateEmptyImg;
        private System.Windows.Forms.Button BtnCreateEmptyImg;
        private System.Windows.Forms.TextBox TBEmptyImgHeight;
        private System.Windows.Forms.TextBox TBEmptyImgWidth;
        private System.Windows.Forms.TextBox TBEmptyImgFileName;
        private System.Windows.Forms.Label LabelEmptyImgHeight;
        private System.Windows.Forms.Label LabelEmptyImgWidth;
        private System.Windows.Forms.Label LabelEmptyImgFileName;
        private System.Windows.Forms.GroupBox GroupBoxLog;
        private System.Windows.Forms.TextBox TBLog;
    }
}
