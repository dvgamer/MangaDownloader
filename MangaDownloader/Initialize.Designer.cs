namespace MangaDownloader
{
    partial class Initialize
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
            this.lblLoading = new System.Windows.Forms.Label();
            this.lblIntialize = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblLoading
            // 
            this.lblLoading.AutoSize = true;
            this.lblLoading.BackColor = System.Drawing.Color.Transparent;
            this.lblLoading.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoading.Location = new System.Drawing.Point(270, 169);
            this.lblLoading.Name = "lblLoading";
            this.lblLoading.Size = new System.Drawing.Size(150, 18);
            this.lblLoading.TabIndex = 1;
            this.lblLoading.Text = "Initialize Plugins...";
            // 
            // lblIntialize
            // 
            this.lblIntialize.BackColor = System.Drawing.Color.Transparent;
            this.lblIntialize.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIntialize.Location = new System.Drawing.Point(277, 188);
            this.lblIntialize.Name = "lblIntialize";
            this.lblIntialize.Size = new System.Drawing.Size(215, 62);
            this.lblIntialize.TabIndex = 2;
            this.lblIntialize.Text = "viruseddy.mdl";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(366, 250);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Developer By HaKkoMEw";
            // 
            // Initialize
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::MangaDownloader.Properties.Resources.MangaLoading;
            this.ClientSize = new System.Drawing.Size(500, 270);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblIntialize);
            this.Controls.Add(this.lblLoading);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Initialize";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Initialize";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Initialize_Load);
            this.Click += new System.EventHandler(this.Initialize_Click);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label lblLoading;
        public System.Windows.Forms.Label lblIntialize;
    }
}