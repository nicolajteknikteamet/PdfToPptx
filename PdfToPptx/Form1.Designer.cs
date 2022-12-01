namespace PdfToPptx
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.txtPdfPath = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBrowsePdfPath = new System.Windows.Forms.Button();
            this.btnTransfer = new System.Windows.Forms.Button();
            this.btnBrowseExportPath = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtExportPath = new System.Windows.Forms.TextBox();
            this.grpSingleFile = new System.Windows.Forms.GroupBox();
            this.dropPanel = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnBrowseExportWatchPath = new System.Windows.Forms.Button();
            this.txtWatchPath = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnBrowseWatchPath = new System.Windows.Forms.Button();
            this.txtExportWatchPath = new System.Windows.Forms.TextBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.txtLog = new System.Windows.Forms.TextBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusConverter = new System.Windows.Forms.ToolStripStatusLabel();
            this.grpSingleFile.SuspendLayout();
            this.dropPanel.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtPdfPath
            // 
            this.txtPdfPath.Location = new System.Drawing.Point(12, 60);
            this.txtPdfPath.Margin = new System.Windows.Forms.Padding(2);
            this.txtPdfPath.Name = "txtPdfPath";
            this.txtPdfPath.Size = new System.Drawing.Size(352, 27);
            this.txtPdfPath.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 31);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "PDF path";
            // 
            // btnBrowsePdfPath
            // 
            this.btnBrowsePdfPath.Location = new System.Drawing.Point(368, 60);
            this.btnBrowsePdfPath.Margin = new System.Windows.Forms.Padding(2);
            this.btnBrowsePdfPath.Name = "btnBrowsePdfPath";
            this.btnBrowsePdfPath.Size = new System.Drawing.Size(90, 27);
            this.btnBrowsePdfPath.TabIndex = 2;
            this.btnBrowsePdfPath.Text = "Browse";
            this.btnBrowsePdfPath.UseVisualStyleBackColor = true;
            this.btnBrowsePdfPath.Click += new System.EventHandler(this.btnBrowsePdfPath_Click);
            // 
            // btnTransfer
            // 
            this.btnTransfer.Location = new System.Drawing.Point(12, 160);
            this.btnTransfer.Margin = new System.Windows.Forms.Padding(2);
            this.btnTransfer.Name = "btnTransfer";
            this.btnTransfer.Size = new System.Drawing.Size(446, 27);
            this.btnTransfer.TabIndex = 3;
            this.btnTransfer.Text = "Transfer";
            this.btnTransfer.UseVisualStyleBackColor = true;
            this.btnTransfer.Click += new System.EventHandler(this.btnTransfer_Click);
            // 
            // btnBrowseExportPath
            // 
            this.btnBrowseExportPath.Location = new System.Drawing.Point(368, 116);
            this.btnBrowseExportPath.Margin = new System.Windows.Forms.Padding(2);
            this.btnBrowseExportPath.Name = "btnBrowseExportPath";
            this.btnBrowseExportPath.Size = new System.Drawing.Size(90, 27);
            this.btnBrowseExportPath.TabIndex = 6;
            this.btnBrowseExportPath.Text = "Browse";
            this.btnBrowseExportPath.UseVisualStyleBackColor = true;
            this.btnBrowseExportPath.Click += new System.EventHandler(this.btnBrowseExportPath_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 87);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Export directory";
            // 
            // txtExportPath
            // 
            this.txtExportPath.Location = new System.Drawing.Point(12, 116);
            this.txtExportPath.Margin = new System.Windows.Forms.Padding(2);
            this.txtExportPath.Name = "txtExportPath";
            this.txtExportPath.Size = new System.Drawing.Size(352, 27);
            this.txtExportPath.TabIndex = 4;
            // 
            // grpSingleFile
            // 
            this.grpSingleFile.Controls.Add(this.dropPanel);
            this.grpSingleFile.Controls.Add(this.label1);
            this.grpSingleFile.Controls.Add(this.btnBrowseExportPath);
            this.grpSingleFile.Controls.Add(this.txtPdfPath);
            this.grpSingleFile.Controls.Add(this.label2);
            this.grpSingleFile.Controls.Add(this.btnBrowsePdfPath);
            this.grpSingleFile.Controls.Add(this.txtExportPath);
            this.grpSingleFile.Controls.Add(this.btnTransfer);
            this.grpSingleFile.Location = new System.Drawing.Point(10, 10);
            this.grpSingleFile.Margin = new System.Windows.Forms.Padding(2);
            this.grpSingleFile.Name = "grpSingleFile";
            this.grpSingleFile.Padding = new System.Windows.Forms.Padding(2);
            this.grpSingleFile.Size = new System.Drawing.Size(471, 334);
            this.grpSingleFile.TabIndex = 7;
            this.grpSingleFile.TabStop = false;
            this.grpSingleFile.Text = "Single file";
            // 
            // dropPanel
            // 
            this.dropPanel.AllowDrop = true;
            this.dropPanel.Controls.Add(this.label5);
            this.dropPanel.Location = new System.Drawing.Point(14, 198);
            this.dropPanel.Margin = new System.Windows.Forms.Padding(2);
            this.dropPanel.Name = "dropPanel";
            this.dropPanel.Size = new System.Drawing.Size(443, 120);
            this.dropPanel.TabIndex = 7;
            this.dropPanel.DragDrop += new System.Windows.Forms.DragEventHandler(this.dropPanel_DragDrop);
            this.dropPanel.DragEnter += new System.Windows.Forms.DragEventHandler(this.dropPanel_DragEnter);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(190, 48);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 20);
            this.label5.TabIndex = 0;
            this.label5.Text = "Drop file";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.btnBrowseExportWatchPath);
            this.groupBox2.Controls.Add(this.txtWatchPath);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.btnBrowseWatchPath);
            this.groupBox2.Controls.Add(this.txtExportWatchPath);
            this.groupBox2.Controls.Add(this.btnStart);
            this.groupBox2.Location = new System.Drawing.Point(10, 348);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(471, 201);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Watch folder";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 31);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Watch path";
            // 
            // btnBrowseExportWatchPath
            // 
            this.btnBrowseExportWatchPath.Location = new System.Drawing.Point(368, 116);
            this.btnBrowseExportWatchPath.Margin = new System.Windows.Forms.Padding(2);
            this.btnBrowseExportWatchPath.Name = "btnBrowseExportWatchPath";
            this.btnBrowseExportWatchPath.Size = new System.Drawing.Size(90, 27);
            this.btnBrowseExportWatchPath.TabIndex = 6;
            this.btnBrowseExportWatchPath.Text = "Browse";
            this.btnBrowseExportWatchPath.UseVisualStyleBackColor = true;
            this.btnBrowseExportWatchPath.Click += new System.EventHandler(this.btnBrowseExportWatchPath_Click);
            // 
            // txtWatchPath
            // 
            this.txtWatchPath.Location = new System.Drawing.Point(12, 60);
            this.txtWatchPath.Margin = new System.Windows.Forms.Padding(2);
            this.txtWatchPath.Name = "txtWatchPath";
            this.txtWatchPath.Size = new System.Drawing.Size(352, 27);
            this.txtWatchPath.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 87);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Export directory";
            // 
            // btnBrowseWatchPath
            // 
            this.btnBrowseWatchPath.Location = new System.Drawing.Point(368, 60);
            this.btnBrowseWatchPath.Margin = new System.Windows.Forms.Padding(2);
            this.btnBrowseWatchPath.Name = "btnBrowseWatchPath";
            this.btnBrowseWatchPath.Size = new System.Drawing.Size(90, 27);
            this.btnBrowseWatchPath.TabIndex = 2;
            this.btnBrowseWatchPath.Text = "Browse";
            this.btnBrowseWatchPath.UseVisualStyleBackColor = true;
            this.btnBrowseWatchPath.Click += new System.EventHandler(this.btnBrowseWatchPath_Click);
            // 
            // txtExportWatchPath
            // 
            this.txtExportWatchPath.Location = new System.Drawing.Point(12, 116);
            this.txtExportWatchPath.Margin = new System.Windows.Forms.Padding(2);
            this.txtExportWatchPath.Name = "txtExportWatchPath";
            this.txtExportWatchPath.Size = new System.Drawing.Size(352, 27);
            this.txtExportWatchPath.TabIndex = 4;
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(12, 160);
            this.btnStart.Margin = new System.Windows.Forms.Padding(2);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(446, 27);
            this.btnStart.TabIndex = 3;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // txtLog
            // 
            this.txtLog.BackColor = System.Drawing.Color.White;
            this.txtLog.Location = new System.Drawing.Point(486, 20);
            this.txtLog.Margin = new System.Windows.Forms.Padding(2);
            this.txtLog.Multiline = true;
            this.txtLog.Name = "txtLog";
            this.txtLog.ReadOnly = true;
            this.txtLog.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtLog.Size = new System.Drawing.Size(556, 530);
            this.txtLog.TabIndex = 9;
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatus,
            this.toolStripStatusConverter});
            this.statusStrip1.Location = new System.Drawing.Point(0, 560);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 11, 0);
            this.statusStrip1.Size = new System.Drawing.Size(1050, 26);
            this.statusStrip1.TabIndex = 10;
            this.statusStrip1.Text = "statusStrip1";
            this.statusStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.statusStrip1_ItemClicked);
            // 
            // toolStripStatus
            // 
            this.toolStripStatus.Name = "toolStripStatus";
            this.toolStripStatus.Size = new System.Drawing.Size(131, 20);
            this.toolStripStatus.Text = "Last sync: Stopped";
            // 
            // toolStripStatusConverter
            // 
            this.toolStripStatusConverter.Name = "toolStripStatusConverter";
            this.toolStripStatusConverter.Size = new System.Drawing.Size(0, 20);
            // 
            // Form1
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1050, 586);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.txtLog);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.grpSingleFile);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "PDF to PPTX";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.Form1_DragEnter);
            this.grpSingleFile.ResumeLayout(false);
            this.grpSingleFile.PerformLayout();
            this.dropPanel.ResumeLayout(false);
            this.dropPanel.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txtPdfPath;
        private Label label1;
        private Button btnBrowsePdfPath;
        private Button btnTransfer;
        private Button btnBrowseExportPath;
        private Label label2;
        private TextBox txtExportPath;
        private GroupBox grpSingleFile;
        private GroupBox groupBox2;
        private Label label3;
        private Button btnBrowseExportWatchPath;
        private TextBox txtWatchPath;
        private Label label4;
        private Button btnBrowseWatchPath;
        private TextBox txtExportWatchPath;
        private Button btnStart;
        private TextBox txtLog;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel toolStripStatus;
        private Panel dropPanel;
        private Label label5;
        private ToolStripStatusLabel toolStripStatusConverter;
    }
}