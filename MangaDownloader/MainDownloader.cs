using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Net;
using System.Reflection;
using System.Text;
using System.Windows.Forms;
using Microsoft.WindowsAPICodePack.Taskbar;


namespace MangaDownloader
{
    public partial class MainDownloader : Form
    {
        // Setting and Process Viewer
        Properties.Settings config;
        RequestBox formRequest;
        Initialize formAbout;
        TaskbarManager windowsTaskbar = TaskbarManager.Instance;
        BackgroundWorker bgProcess1 = new BackgroundWorker();

        //Data
        Boolean listChanged = false;

        public MainDownloader(Initialize aboutus)
        {
            InitializeComponent();
            config = Properties.Settings.Default;

            formAbout = aboutus;
            formRequest = new RequestBox(this);
        }

        private void Main_Resize(object sender, EventArgs e)
        {
            Point posAddForm = new Point(formRequest.Size.Width / 2, formRequest.Size.Height / 2);
            Point posMainForm = new Point(config.Size.Width / 2, config.Size.Height / 2);
            formRequest.Location = new Point((config.Location.X + posMainForm.X) - posAddForm.X, (config.Location.Y + posMainForm.Y) - posAddForm.Y);

            if (this.WindowState != FormWindowState.Maximized) config.Size = this.Size;
            config.WindowState = this.WindowState;
            config.Save();
        }
        private void Main_Move(object sender, System.EventArgs e)
        {
            Point posAddForm = new Point(formRequest.Size.Width / 2, formRequest.Size.Height / 2);
            Point posMainForm = new Point(config.Size.Width / 2, config.Size.Height / 2);
            formRequest.Location = new Point((config.Location.X + posMainForm.X) - posAddForm.X, (config.Location.Y + posMainForm.Y) - posAddForm.Y);

            // Text
            //TaskbarProgressBarState state =  (TaskbarProgressBarState)(Enum.Parse(typeof(TaskbarProgressBarState), "Error"));

            windowsTaskbar.SetProgressState(TaskbarProgressBarState.Normal);
            windowsTaskbar.SetProgressValue(40, 100);

            windowsTaskbar.SetOverlayIcon(Properties.Resources.worker, "Worker");
            // TaskbarManager.Instance.SetOverlayIcon(Nothing, Nothing)

            if (this.WindowState != FormWindowState.Maximized)
            {
                config.Location = this.Location;
                config.Save();
            }
        }
        private void Main_Load(object sender, EventArgs e)
        {
            this.WindowState = config.WindowState;
            this.Size = new Size(config.Size.Width, config.Size.Height);
            this.Location = new Point(config.Location.X, config.Location.Y);
            

            txtPath.Text = config.Folder;
            dialogBrowser.Description = "Select Folder Manga";

            listImageChapter.Columns[0].Width = config.ImageListWidth;
            listImageChapter.Columns[1].Width = config.ImageNameWidth;
            listImageChapter.Columns[2].Width = config.ImageStatusWidth;
            listImageChapter.Columns[3].Width = config.ImageProgressWidth;
            listImageChapter.Columns[4].Width = config.ImageSizeWidth;
            listImageChapter.Columns[5].Width = config.ImageLinkWidth;
            listChanged = true;

            // TEST

            /*if (ShowProgressBar.IsChecked.Value)
            {
                TaskbarManager.Instance.SetProgressValue((int)progressSlider.Value, 100);
                TaskbarManager.Instance.SetProgressState((TaskbarProgressBarState)ProgressStateSelection.SelectedItem);
            }
            else
            {
                TaskbarManager.Instance.SetProgressState(TaskbarProgressBarState.NoProgress);
            }*/

            // TEST
            //Console.WriteLine(myAmount.ToString("##,#", CultureInfo.CurrentCulture.NumberFormat));
        }
        private void Main_Closing(Object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void itemExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void itemHelpSupport_Click(object sender, EventArgs e)
        {

        }

        private void itemHelpAbout_Click(object sender, EventArgs e)
        {
            this.Enabled = false;
            Point posAboutForm = new Point(formAbout.Size.Width / 2, formAbout.Size.Height / 2);
            Point posMainForm = new Point(config.Size.Width / 2, config.Size.Height / 2);
            formAbout.Location = new Point((config.Location.X + posMainForm.X) - posAboutForm.X, (config.Location.Y + posMainForm.Y) - posAboutForm.Y);
            formAbout.TopMost = false;

            formAbout.lblLoading.Text = "";
            formAbout.lblIntialize.Text = AssemblyDescription;
            formAbout.Show(this);
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {            
            DialogResult result = dialogBrowser.ShowDialog();            
            // OK button was pressed.
            if (result == DialogResult.OK)
            {
                txtPath.Text = dialogBrowser.SelectedPath;
                config.Folder = dialogBrowser.SelectedPath;
                config.Save();
            }
        }

        private void ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            lblStatus.Text = "กำลังตรวจสอบ...";
        }

        private void RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            toolCheck.Enabled = true;
            toolCheck.Visible = false;
            toolSave.Visible = true;

            if ((e.Cancelled == true))
            {
                lblStatus.Text = "Canceled!";
            }

            else if (!(e.Error == null))
            {
                lblStatus.Text = ("Error: " + e.Error.Message);
            }

            else
            {
                lblStatus.Text = "Done!";
            }
        }

        private void toolCancel_Click(object sender, EventArgs e)
        {

        }

        private void toolCheck_Click(object sender, EventArgs e)
        {
            Point posAddForm = new Point(formRequest.Size.Width / 2, formRequest.Size.Height / 2);
            Point posMainForm = new Point(config.Size.Width / 2, config.Size.Height / 2);
            formRequest = new RequestBox(this);
            formRequest.Show(this);
            formRequest.Location = new Point((config.Location.X + posMainForm.X) - posAddForm.X, (config.Location.Y + posMainForm.Y) - posAddForm.Y);
        }

        private void toolSave_Click(object sender, EventArgs e)
        {
            WebClient client = new WebClient();
            //Create a new subfolder under the current active folder
            string newPath = Path.Combine(txtPath.Text.Trim(), "");            
            // Create the subfolder            
            if (Directory.Exists(newPath))
            {
                /*
                int listImage = 0;
                foreach (String name in this.site.imageName)
                {
                    listImage++;
                    String nameImage = listImage.ToString();
                    while (nameImage.Length < 2) { nameImage = "0" + nameImage; }
                    string newFilePtah = Path.Combine(newPath, nameImage + ".jpg");
                    if (!File.Exists(newFilePtah))
                    {
                        // Download home page data.
                        Console.WriteLine("Downloading " + name);
                        // Download the Web resource and save it into a data buffer.
                        byte[] myDataBuffer = client.DownloadData(name);

                        // Display the downloaded data.
                        string download = Encoding.ASCII.GetString(myDataBuffer);
                        Console.WriteLine(download);
                    }                    
                }
                Console.WriteLine("Download successful.");
                 */
                
                // Download the Web resource and save it into a data buffer.
                byte[] myDataBuffer = client.DownloadData("http://s2.postimage.org/r6kiwjww9/image.jpg");

                using (StreamWriter file = new StreamWriter(txtPath.Text.Trim() + "/WriteLines2.jpg"))
                {
                    file.Write(Encoding.ASCII.GetString(myDataBuffer));
                }
            }
            else
            {
                Directory.CreateDirectory(newPath);
            }

        }

        private void txtPath_TextChanged(object sender, EventArgs e)
        {
            config.Folder = txtPath.Text;
            config.Save();
            DriveInfo[] drives = DriveInfo.GetDrives();
            foreach (DriveInfo drive in drives)
            {
                //Console.WriteLine(drive.Name);
                //if (drive.IsReady) Console.WriteLine(drive.TotalSize);
            }
        }

        private void dataImageChapter_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataImageChapter_ColumnWidthChanged(object sender, ColumnWidthChangedEventArgs e)
        {
            if (listChanged)
            {
                switch (e.ColumnIndex)
                {
                    case 0: config.ImageListWidth = listImageChapter.Columns[e.ColumnIndex].Width; break;
                    case 1: config.ImageNameWidth = listImageChapter.Columns[e.ColumnIndex].Width; break;
                    case 2: config.ImageStatusWidth = listImageChapter.Columns[e.ColumnIndex].Width; break;
                    case 3: config.ImageProgressWidth = listImageChapter.Columns[e.ColumnIndex].Width; break;
                    case 4: config.ImageSizeWidth = listImageChapter.Columns[e.ColumnIndex].Width; break;
                    case 5: config.ImageLinkWidth = listImageChapter.Columns[e.ColumnIndex].Width; break;
                }
                config.Save();
            }
        }

        public void ToolDisbled()
        {
            toolCheck.Enabled = false;
            toolSave.Enabled = false;
            itemFile.Enabled = false;
            itemHelp.Enabled = false;
            btnBrowse.Enabled = false;
        }
        public void ToolEnabled()
        {
            toolCheck.Enabled = true;
            itemFile.Enabled = true;
            itemHelp.Enabled = true;
            btnBrowse.Enabled = true;
        }
  
        public string AssemblyDescription
        {
            get
            {
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyDescriptionAttribute), false);
                if (attributes.Length == 0)
                {
                    return "";
                }
                return ((AssemblyDescriptionAttribute)attributes[0]).Description;
            }
        }
        public string AssemblyCopyright
        {
            get
            {
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyCopyrightAttribute), false);
                if (attributes.Length == 0)
                {
                    return "";
                }
                return ((AssemblyCopyrightAttribute)attributes[0]).Copyright;
            }
        }
        public string AssemblyCompany
        {
            get
            {
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyCompanyAttribute), false);
                if (attributes.Length == 0)
                {
                    return "";
                }
                return ((AssemblyCompanyAttribute)attributes[0]).Company;
            }
        }
    }

}
