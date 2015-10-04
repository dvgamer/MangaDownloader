using System;
using System.ComponentModel;
using System.IO;
using System.Windows.Forms;


namespace MangaDownloader
{
    public partial class Initialize : Form
    {
        MainDownloader mainDownload;
        BackgroundWorker mainProcess = new BackgroundWorker();
        Boolean Loading = true;
        String preLoaderText = "Please Wait...";
        public Initialize()
        {
            InitializeComponent();
        }

        private void Initialize_Load(object sender, EventArgs e)
        {
            mainProcess.WorkerReportsProgress = true;
            mainProcess.WorkerSupportsCancellation = true;
            mainProcess.DoWork += new DoWorkEventHandler(PreloadApp);
            mainProcess.ProgressChanged += new ProgressChangedEventHandler(PreloadAppChanged);
            mainProcess.RunWorkerCompleted += new RunWorkerCompletedEventHandler(PreloadAppCompleted);
            // Process VerifyCheck Start
            if (mainProcess.IsBusy != true) { mainProcess.RunWorkerAsync(); }
        }

        private void Initialize_Click(object sender, EventArgs e)
        {
            if (!Loading)
            {
                mainDownload.Enabled = true;
                this.Hide();
            }
        }
        
        public void PreloadApp(object sender, DoWorkEventArgs e)
        {
            mainDownload = new MainDownloader(this);
            try
            {                
                String[] filePaths = Directory.GetFiles(@"Plugins\", "*.mdl");
                if (filePaths.Length < 1)
                {
                    e.Cancel = true;
                }
                else
                {
                    mainProcess.ReportProgress(0);
                    //System.Threading.Thread.Sleep(2000);
                    foreach (String path in filePaths)
                    {
                        mainProcess.ReportProgress(0);
                        String[] fileName = path.Split('\\');
                        //preLoaderText = fileName[1];
                        //mainDownload.LoadPlugins(path);
                        System.Threading.Thread.Sleep(1000);
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                e.Cancel = true;
            }
        }

        /// <summary>
        ///  Process VerifyCheck Changed
        /// </summary>
        private void PreloadAppChanged(object sender, ProgressChangedEventArgs e)
        {
            lblIntialize.Text = preLoaderText.ToString();
        }

        /// <summary>
        ///  Process VerifyCheck Completed
        /// </summary>
        private void PreloadAppCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if ((e.Cancelled == true))
            {
                Application.Exit();
            }
            else if (!(e.Error == null))
            {
                MessageBox.Show("Error: " + e.Error.Message);
            }
            else
            {
                mainDownload.Show();
                Loading = false;
                this.Hide();
            }
        }


    }
}
