namespace MangaDownloader
{
    partial class RequestBox
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
            this.components = new System.ComponentModel.Container();
            this.label2 = new System.Windows.Forms.Label();
            this.toolRequest = new System.Windows.Forms.ToolStrip();
            this.toolDownload = new System.Windows.Forms.ToolStripButton();
            this.toolProgressBar = new System.Windows.Forms.ToolStripProgressBar();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.ltbAddress = new System.Windows.Forms.ListView();
            this.colName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.toolProcessText = new System.Windows.Forms.ToolStripLabel();
            this.toolPaste = new System.Windows.Forms.ToolStripButton();
            this.toolRequest.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(12, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "เลือกที่ต้องการ:";
            // 
            // toolRequest
            // 
            this.toolRequest.AutoSize = false;
            this.toolRequest.BackgroundImage = global::MangaDownloader.Properties.Resources.RequestBackground;
            this.toolRequest.Dock = System.Windows.Forms.DockStyle.None;
            this.toolRequest.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.toolRequest.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolRequest.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolDownload,
            this.toolPaste,
            this.toolProgressBar,
            this.toolProcessText});
            this.toolRequest.Location = new System.Drawing.Point(-2, 361);
            this.toolRequest.Name = "toolRequest";
            this.toolRequest.Padding = new System.Windows.Forms.Padding(3);
            this.toolRequest.ShowItemToolTips = false;
            this.toolRequest.Size = new System.Drawing.Size(649, 39);
            this.toolRequest.TabIndex = 10;
            this.toolRequest.Text = "toolStrip1";
            // 
            // toolDownload
            // 
            this.toolDownload.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolDownload.Enabled = false;
            this.toolDownload.Image = global::MangaDownloader.Properties.Resources.request_download;
            this.toolDownload.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolDownload.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolDownload.Margin = new System.Windows.Forms.Padding(0, 1, 5, 1);
            this.toolDownload.Name = "toolDownload";
            this.toolDownload.Padding = new System.Windows.Forms.Padding(3);
            this.toolDownload.Size = new System.Drawing.Size(104, 31);
            this.toolDownload.Text = "เพิ่มลงรายการ";
            this.toolDownload.Click += new System.EventHandler(this.toolDownload_Click);
            // 
            // toolProgressBar
            // 
            this.toolProgressBar.AutoSize = false;
            this.toolProgressBar.Margin = new System.Windows.Forms.Padding(5, 2, 1, 1);
            this.toolProgressBar.MarqueeAnimationSpeed = 50;
            this.toolProgressBar.Name = "toolProgressBar";
            this.toolProgressBar.Size = new System.Drawing.Size(129, 12);
            this.toolProgressBar.Visible = false;
            // 
            // timer
            // 
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // ltbAddress
            // 
            this.ltbAddress.CheckBoxes = true;
            this.ltbAddress.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colName});
            this.ltbAddress.FullRowSelect = true;
            this.ltbAddress.GridLines = true;
            this.ltbAddress.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.ltbAddress.Location = new System.Drawing.Point(12, 27);
            this.ltbAddress.Name = "ltbAddress";
            this.ltbAddress.Size = new System.Drawing.Size(620, 323);
            this.ltbAddress.TabIndex = 11;
            this.ltbAddress.UseCompatibleStateImageBehavior = false;
            this.ltbAddress.View = System.Windows.Forms.View.Details;
            // 
            // colName
            // 
            this.colName.Text = "Name";
            this.colName.Width = 598;
            // 
            // toolProcessText
            // 
            this.toolProcessText.Margin = new System.Windows.Forms.Padding(3, 1, 0, 2);
            this.toolProcessText.Name = "toolProcessText";
            this.toolProcessText.Size = new System.Drawing.Size(24, 30);
            this.toolProcessText.Text = "0%";
            this.toolProcessText.Visible = false;
            // 
            // toolPaste
            // 
            this.toolPaste.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolPaste.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.toolPaste.Image = global::MangaDownloader.Properties.Resources.request_close;
            this.toolPaste.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolPaste.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolPaste.Margin = new System.Windows.Forms.Padding(5, 1, 0, 1);
            this.toolPaste.Name = "toolPaste";
            this.toolPaste.Padding = new System.Windows.Forms.Padding(3);
            this.toolPaste.Size = new System.Drawing.Size(61, 31);
            this.toolPaste.Text = "หยุด";
            this.toolPaste.Visible = false;
            this.toolPaste.Click += new System.EventHandler(this.toolPaste_Click);
            // 
            // RequestBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(644, 400);
            this.Controls.Add(this.ltbAddress);
            this.Controls.Add(this.toolRequest);
            this.Controls.Add(this.label2);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "RequestBox";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "ตรวจสอบ";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.RequestBox_Closing);
            this.Load += new System.EventHandler(this.RequestBox_Load);
            this.toolRequest.ResumeLayout(false);
            this.toolRequest.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolRequest;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolStripButton toolDownload;
        private System.Windows.Forms.ToolStripProgressBar toolProgressBar;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.ListView ltbAddress;
        private System.Windows.Forms.ColumnHeader colName;
        private System.Windows.Forms.ToolStripLabel toolProcessText;
        private System.Windows.Forms.ToolStripButton toolPaste;


    }
}