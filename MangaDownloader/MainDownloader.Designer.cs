namespace MangaDownloader
{
    partial class MainDownloader
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainDownloader));
            this.statusDownloader = new System.Windows.Forms.StatusStrip();
            this.lblTotalText = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblTotal = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblSeparator1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblSpaceText = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblSpace = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblSeparator2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolSave = new System.Windows.Forms.ToolStripButton();
            this.toolSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.toolCheck = new System.Windows.Forms.ToolStripButton();
            this.dialogBrowser = new System.Windows.Forms.FolderBrowserDialog();
            this.lblDirectory = new System.Windows.Forms.Label();
            this.txtPath = new System.Windows.Forms.TextBox();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.dialogImportFile = new System.Windows.Forms.OpenFileDialog();
            this.dialogExportFile = new System.Windows.Forms.SaveFileDialog();
            this.txtFolderName = new System.Windows.Forms.TextBox();
            this.lblFolderName = new System.Windows.Forms.Label();
            this.lblImageList = new System.Windows.Forms.Label();
            this.lblChapterList = new System.Windows.Forms.Label();
            this.grbDlOption = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.menuDownloader = new System.Windows.Forms.MenuStrip();
            this.itemFile = new System.Windows.Forms.ToolStripMenuItem();
            this.importToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.itemFileSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.itemExit = new System.Windows.Forms.ToolStripMenuItem();
            this.itemHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.itemHelpSupport = new System.Windows.Forms.ToolStripMenuItem();
            this.itemHelpSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.itemHelpAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.listImageChapter = new System.Windows.Forms.ListView();
            this.colList = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colStatus = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colProgress = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colSize = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colLink = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listNameChapter = new System.Windows.Forms.ListView();
            this.statusDownloader.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.grbDlOption.SuspendLayout();
            this.menuDownloader.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusDownloader
            // 
            this.statusDownloader.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.statusDownloader.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblTotalText,
            this.lblTotal,
            this.lblSeparator1,
            this.lblSpaceText,
            this.lblSpace,
            this.lblSeparator2,
            this.lblStatus});
            this.statusDownloader.Location = new System.Drawing.Point(0, 546);
            this.statusDownloader.Name = "statusDownloader";
            this.statusDownloader.Size = new System.Drawing.Size(790, 22);
            this.statusDownloader.TabIndex = 3;
            this.statusDownloader.Text = "statusStrip1";
            // 
            // lblTotalText
            // 
            this.lblTotalText.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalText.Name = "lblTotalText";
            this.lblTotalText.Size = new System.Drawing.Size(69, 17);
            this.lblTotalText.Text = "ไฟล์ทั้งหมด:";
            // 
            // lblTotal
            // 
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(36, 17);
            this.lblTotal.Text = "0 ไฟล์";
            // 
            // lblSeparator1
            // 
            this.lblSeparator1.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lblSeparator1.Margin = new System.Windows.Forms.Padding(0);
            this.lblSeparator1.Name = "lblSeparator1";
            this.lblSeparator1.Size = new System.Drawing.Size(11, 22);
            this.lblSeparator1.Text = "|";
            // 
            // lblSpaceText
            // 
            this.lblSpaceText.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSpaceText.Name = "lblSpaceText";
            this.lblSpaceText.Size = new System.Drawing.Size(129, 17);
            this.lblSpaceText.Text = "ต้องการพื้นที่ว่างทั้งหมด:";
            // 
            // lblSpace
            // 
            this.lblSpace.Name = "lblSpace";
            this.lblSpace.Size = new System.Drawing.Size(44, 17);
            this.lblSpace.Text = "0.00 KB";
            // 
            // lblSeparator2
            // 
            this.lblSeparator2.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lblSeparator2.Margin = new System.Windows.Forms.Padding(0);
            this.lblSeparator2.Name = "lblSeparator2";
            this.lblSeparator2.Size = new System.Drawing.Size(11, 22);
            this.lblSeparator2.Text = "|";
            // 
            // lblStatus
            // 
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(475, 17);
            this.lblStatus.Spring = true;
            this.lblStatus.Text = " ";
            // 
            // toolStrip1
            // 
            this.toolStrip1.AutoSize = false;
            this.toolStrip1.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolSave,
            this.toolSeparator,
            this.toolCheck});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Padding = new System.Windows.Forms.Padding(9, 3, 9, 3);
            this.toolStrip1.ShowItemToolTips = false;
            this.toolStrip1.Size = new System.Drawing.Size(790, 47);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolSave
            // 
            this.toolSave.Enabled = false;
            this.toolSave.Image = global::MangaDownloader.Properties.Resources.window_save;
            this.toolSave.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolSave.Name = "toolSave";
            this.toolSave.Padding = new System.Windows.Forms.Padding(10, 10, 0, 10);
            this.toolSave.Size = new System.Drawing.Size(119, 38);
            this.toolSave.Text = "เริ่มดาวน์โหลด";
            this.toolSave.Click += new System.EventHandler(this.toolSave_Click);
            // 
            // toolSeparator
            // 
            this.toolSeparator.Name = "toolSeparator";
            this.toolSeparator.Size = new System.Drawing.Size(6, 41);
            // 
            // toolCheck
            // 
            this.toolCheck.Image = global::MangaDownloader.Properties.Resources.window_check;
            this.toolCheck.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolCheck.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolCheck.Name = "toolCheck";
            this.toolCheck.Padding = new System.Windows.Forms.Padding(10, 10, 0, 10);
            this.toolCheck.Size = new System.Drawing.Size(119, 38);
            this.toolCheck.Text = "ตรวจสอบ URL";
            this.toolCheck.Click += new System.EventHandler(this.toolCheck_Click);
            // 
            // lblDirectory
            // 
            this.lblDirectory.AutoSize = true;
            this.lblDirectory.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblDirectory.Location = new System.Drawing.Point(10, 73);
            this.lblDirectory.Name = "lblDirectory";
            this.lblDirectory.Size = new System.Drawing.Size(107, 13);
            this.lblDirectory.TabIndex = 10;
            this.lblDirectory.Text = "Browse Directory:";
            // 
            // txtPath
            // 
            this.txtPath.Location = new System.Drawing.Point(64, 91);
            this.txtPath.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.txtPath.Name = "txtPath";
            this.txtPath.Size = new System.Drawing.Size(344, 21);
            this.txtPath.TabIndex = 11;
            this.txtPath.Text = "C:\\";
            this.txtPath.TextChanged += new System.EventHandler(this.txtPath_TextChanged);
            // 
            // btnBrowse
            // 
            this.btnBrowse.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnBrowse.Location = new System.Drawing.Point(414, 90);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(64, 21);
            this.btnBrowse.TabIndex = 12;
            this.btnBrowse.Text = "Browse";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // dialogImportFile
            // 
            this.dialogImportFile.FileName = "openFileDialog1";
            // 
            // txtFolderName
            // 
            this.txtFolderName.Location = new System.Drawing.Point(82, 20);
            this.txtFolderName.Name = "txtFolderName";
            this.txtFolderName.Size = new System.Drawing.Size(241, 21);
            this.txtFolderName.TabIndex = 14;
            // 
            // lblFolderName
            // 
            this.lblFolderName.AutoSize = true;
            this.lblFolderName.Location = new System.Drawing.Point(23, 94);
            this.lblFolderName.Margin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.lblFolderName.Name = "lblFolderName";
            this.lblFolderName.Size = new System.Drawing.Size(41, 13);
            this.lblFolderName.TabIndex = 16;
            this.lblFolderName.Text = "Folder:";
            // 
            // lblImageList
            // 
            this.lblImageList.AutoSize = true;
            this.lblImageList.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblImageList.Location = new System.Drawing.Point(307, 202);
            this.lblImageList.Name = "lblImageList";
            this.lblImageList.Size = new System.Drawing.Size(70, 13);
            this.lblImageList.TabIndex = 17;
            this.lblImageList.Text = "Image List:";
            // 
            // lblChapterList
            // 
            this.lblChapterList.AutoSize = true;
            this.lblChapterList.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblChapterList.Location = new System.Drawing.Point(10, 116);
            this.lblChapterList.Name = "lblChapterList";
            this.lblChapterList.Size = new System.Drawing.Size(78, 13);
            this.lblChapterList.TabIndex = 18;
            this.lblChapterList.Text = "Chapter List:";
            // 
            // grbDlOption
            // 
            this.grbDlOption.Controls.Add(this.label1);
            this.grbDlOption.Controls.Add(this.checkBox1);
            this.grbDlOption.Controls.Add(this.txtFolderName);
            this.grbDlOption.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbDlOption.Location = new System.Drawing.Point(307, 116);
            this.grbDlOption.Name = "grbDlOption";
            this.grbDlOption.Padding = new System.Windows.Forms.Padding(9, 3, 9, 3);
            this.grbDlOption.Size = new System.Drawing.Size(468, 73);
            this.grbDlOption.TabIndex = 9;
            this.grbDlOption.TabStop = false;
            this.grbDlOption.Text = "ตั้งค่าพื้นฐาน";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.label1.Location = new System.Drawing.Point(14, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 20;
            this.label1.Text = "ชื่อโฟลเดอร์:";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Checked = true;
            this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox1.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.checkBox1.Location = new System.Drawing.Point(17, 47);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(125, 17);
            this.checkBox1.TabIndex = 19;
            this.checkBox1.Text = "เรียงลำดับชื่อไฟล์ใหม่";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // menuDownloader
            // 
            this.menuDownloader.BackColor = System.Drawing.SystemColors.Control;
            this.menuDownloader.BackgroundImage = global::MangaDownloader.Properties.Resources.MenuBackground;
            this.menuDownloader.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.menuDownloader.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.itemFile,
            this.itemHelp});
            this.menuDownloader.Location = new System.Drawing.Point(0, 0);
            this.menuDownloader.Name = "menuDownloader";
            this.menuDownloader.Size = new System.Drawing.Size(790, 24);
            this.menuDownloader.TabIndex = 1;
            this.menuDownloader.Text = "menuStrip1";
            // 
            // itemFile
            // 
            this.itemFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.importToolStripMenuItem,
            this.exportToolStripMenuItem,
            this.itemFileSeparator,
            this.itemExit});
            this.itemFile.Name = "itemFile";
            this.itemFile.Size = new System.Drawing.Size(58, 20);
            this.itemFile.Text = "เมนูหลัก";
            // 
            // importToolStripMenuItem
            // 
            this.importToolStripMenuItem.Image = global::MangaDownloader.Properties.Resources.downloader_import;
            this.importToolStripMenuItem.Name = "importToolStripMenuItem";
            this.importToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.importToolStripMenuItem.Text = "Import";
            // 
            // exportToolStripMenuItem
            // 
            this.exportToolStripMenuItem.Image = global::MangaDownloader.Properties.Resources.downloader_export;
            this.exportToolStripMenuItem.Name = "exportToolStripMenuItem";
            this.exportToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.exportToolStripMenuItem.Text = "Export";
            // 
            // itemFileSeparator
            // 
            this.itemFileSeparator.Name = "itemFileSeparator";
            this.itemFileSeparator.Size = new System.Drawing.Size(134, 6);
            // 
            // itemExit
            // 
            this.itemExit.Name = "itemExit";
            this.itemExit.Size = new System.Drawing.Size(137, 22);
            this.itemExit.Text = "ออกจากระบบ";
            this.itemExit.Click += new System.EventHandler(this.itemExit_Click);
            // 
            // itemHelp
            // 
            this.itemHelp.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.itemHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.itemHelpSupport,
            this.itemHelpSeparator,
            this.itemHelpAbout});
            this.itemHelp.Name = "itemHelp";
            this.itemHelp.Size = new System.Drawing.Size(62, 20);
            this.itemHelp.Text = "ช่วยเหลือ";
            // 
            // itemHelpSupport
            // 
            this.itemHelpSupport.Name = "itemHelpSupport";
            this.itemHelpSupport.Size = new System.Drawing.Size(152, 22);
            this.itemHelpSupport.Text = "เว็บไซต์";
            this.itemHelpSupport.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.itemHelpSupport.Click += new System.EventHandler(this.itemHelpSupport_Click);
            // 
            // itemHelpSeparator
            // 
            this.itemHelpSeparator.Name = "itemHelpSeparator";
            this.itemHelpSeparator.Size = new System.Drawing.Size(149, 6);
            // 
            // itemHelpAbout
            // 
            this.itemHelpAbout.Name = "itemHelpAbout";
            this.itemHelpAbout.Size = new System.Drawing.Size(152, 22);
            this.itemHelpAbout.Text = "เกี่ยวกับ";
            this.itemHelpAbout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.itemHelpAbout.Click += new System.EventHandler(this.itemHelpAbout_Click);
            // 
            // listImageChapter
            // 
            this.listImageChapter.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.listImageChapter.AllowColumnReorder = true;
            this.listImageChapter.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.listImageChapter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listImageChapter.CausesValidation = false;
            this.listImageChapter.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colList,
            this.colName,
            this.colStatus,
            this.colProgress,
            this.colSize,
            this.colLink});
            this.listImageChapter.FullRowSelect = true;
            this.listImageChapter.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listImageChapter.Location = new System.Drawing.Point(307, 219);
            this.listImageChapter.Name = "listImageChapter";
            this.listImageChapter.Size = new System.Drawing.Size(468, 314);
            this.listImageChapter.TabIndex = 19;
            this.listImageChapter.UseCompatibleStateImageBehavior = false;
            this.listImageChapter.View = System.Windows.Forms.View.Details;
            this.listImageChapter.ColumnWidthChanged += new System.Windows.Forms.ColumnWidthChangedEventHandler(this.dataImageChapter_ColumnWidthChanged);
            this.listImageChapter.SelectedIndexChanged += new System.EventHandler(this.dataImageChapter_SelectedIndexChanged);
            // 
            // colList
            // 
            this.colList.Text = "List";
            // 
            // colName
            // 
            this.colName.Text = "Name";
            // 
            // colStatus
            // 
            this.colStatus.Text = "Status";
            // 
            // colProgress
            // 
            this.colProgress.Text = "Progress";
            // 
            // colSize
            // 
            this.colSize.Text = "Size";
            // 
            // colLink
            // 
            this.colLink.Text = "Link";
            // 
            // listNameChapter
            // 
            this.listNameChapter.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.listNameChapter.FullRowSelect = true;
            this.listNameChapter.GridLines = true;
            this.listNameChapter.Location = new System.Drawing.Point(12, 132);
            this.listNameChapter.Name = "listNameChapter";
            this.listNameChapter.Size = new System.Drawing.Size(289, 401);
            this.listNameChapter.TabIndex = 20;
            this.listNameChapter.UseCompatibleStateImageBehavior = false;
            // 
            // MainDownloader
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(790, 568);
            this.Controls.Add(this.listNameChapter);
            this.Controls.Add(this.listImageChapter);
            this.Controls.Add(this.grbDlOption);
            this.Controls.Add(this.lblChapterList);
            this.Controls.Add(this.lblImageList);
            this.Controls.Add(this.lblFolderName);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.txtPath);
            this.Controls.Add(this.lblDirectory);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.statusDownloader);
            this.Controls.Add(this.menuDownloader);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "MainDownloader";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Tag = "";
            this.Text = "Manga Downloader 2.0";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Main_Closing);
            this.Load += new System.EventHandler(this.Main_Load);
            this.Move += new System.EventHandler(this.Main_Move);
            this.Resize += new System.EventHandler(this.Main_Resize);
            this.statusDownloader.ResumeLayout(false);
            this.statusDownloader.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.grbDlOption.ResumeLayout(false);
            this.grbDlOption.PerformLayout();
            this.menuDownloader.ResumeLayout(false);
            this.menuDownloader.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        
        private System.Windows.Forms.StatusStrip statusDownloader;
        private System.Windows.Forms.MenuStrip menuDownloader;
        private System.Windows.Forms.ToolStripMenuItem itemFile;
        private System.Windows.Forms.ToolStripMenuItem itemHelp;
        private System.Windows.Forms.ToolStripMenuItem itemHelpSupport;
        private System.Windows.Forms.ToolStripSeparator itemHelpSeparator;
        private System.Windows.Forms.ToolStripMenuItem itemHelpAbout;
        private System.Windows.Forms.ToolStripMenuItem itemExit;
        private System.Windows.Forms.ToolStripStatusLabel lblSpaceText;
        private System.Windows.Forms.ToolStripMenuItem importToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator itemFileSeparator;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripSeparator toolSeparator;
        private System.Windows.Forms.FolderBrowserDialog dialogBrowser;
        private System.Windows.Forms.Label lblDirectory;
        private System.Windows.Forms.TextBox txtPath;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.OpenFileDialog dialogImportFile;
        private System.Windows.Forms.SaveFileDialog dialogExportFile;
        private System.Windows.Forms.ToolStripButton toolCheck;
        private System.Windows.Forms.ToolStripButton toolSave;
        private System.Windows.Forms.TextBox txtFolderName;
        private System.Windows.Forms.Label lblFolderName;
        private System.Windows.Forms.Label lblImageList;
        private System.Windows.Forms.Label lblChapterList;
        private System.Windows.Forms.GroupBox grbDlOption;
        private System.Windows.Forms.ToolStripStatusLabel lblTotalText;
        private System.Windows.Forms.ToolStripStatusLabel lblSeparator1;
        private System.Windows.Forms.ToolStripStatusLabel lblTotal;
        private System.Windows.Forms.ToolStripStatusLabel lblSpace;
        private System.Windows.Forms.ToolStripStatusLabel lblSeparator2;
        private System.Windows.Forms.ToolStripStatusLabel lblStatus;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView listImageChapter;
        private System.Windows.Forms.ColumnHeader colList;
        private System.Windows.Forms.ColumnHeader colName;
        private System.Windows.Forms.ColumnHeader colLink;
        private System.Windows.Forms.ColumnHeader colSize;
        private System.Windows.Forms.ColumnHeader colStatus;
        private System.Windows.Forms.ColumnHeader colProgress;
        private System.Windows.Forms.ListView listNameChapter;
    }
}

