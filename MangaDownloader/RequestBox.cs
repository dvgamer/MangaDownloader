using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Net;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Xml;
using HaKkoDownloader;

namespace MangaDownloader
{
    public partial class RequestBox : Form
    {
        MainDownloader formMain;
        String tmpClipboard;
        Dictionary<String, String[]> urlManga = new Dictionary<String, String[]>();
        Dictionary<String, String[]> tmpManga = new Dictionary<String, String[]>();
        List<String> namePlugins = new List<String>();
        BackgroundWorker urlProcess = new BackgroundWorker();

        public RequestBox(MainDownloader mainform)
        {
            InitializeComponent();
            formMain = mainform;

            timer.Interval = 500;
            timer.Start();
        }

        private void RequestBox_Load(object sender, EventArgs e)
        {
            formMain.ToolDisbled();
        }

        private void RequestBox_Closing(Object sender, FormClosingEventArgs e)
        {
            if (urlProcess.IsBusy) { e.Cancel = true; } else { formMain.ToolEnabled(); }
        }

        private void toolClose_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void toolSelected_Click(object sender, EventArgs e)
        {

        }

        private void toolUnSelected_Click(object sender, EventArgs e)
        {

        }

        private void toolPaste_Click(object sender, EventArgs e)
        {
            toolPaste.Visible = false;
            // Process VerifyCheck Cancellation
            if (urlProcess.WorkerSupportsCancellation == true) { urlProcess.CancelAsync(); }
        }

        private void toolDownload_Click(object sender, EventArgs e)
        {

        }

        private void timer_Tick(object sender, EventArgs e)
        {
            if (Clipboard.GetText() != tmpClipboard)
            {
                tmpClipboard = Clipboard.GetText();
                // Process VerifyURL Start
                urlProcess = new BackgroundWorker();
                urlProcess.DoWork += new DoWorkEventHandler(VerifyURL);
                urlProcess.RunWorkerCompleted += new RunWorkerCompletedEventHandler(VerifyURLCompleted);
                if (urlProcess.IsBusy != true) { urlProcess.RunWorkerAsync(); }
            }
        }

        /// <summary>
        ///  Process VerifyURL
        /// </summary>
        public void VerifyURL(object sender, DoWorkEventArgs e)
        {            

        }

        /// <summary>
        ///  Process VerifyURL Completed
        /// </summary>
        private void VerifyURLCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if ((e.Cancelled == true))
            {
                toolProcessText.Text = "Canceled!";
                toolProgressBar.Value = 0;
            }
            else if (!(e.Error == null))
            {
                toolProcessText.Text = ("Error: " + e.Error.Message);
                toolProgressBar.Value = 0;
            }
            else
            {
                toolPaste.Enabled = true;
                toolProgressBar.Maximum = urlManga.Count;
                ltbAddress.Items.Clear();
                if (urlManga.Count != 0)
                {
                    toolProgressBar.Visible = true;
                    toolProcessText.Visible = true;
                    toolPaste.Visible = true;

                    foreach (KeyValuePair<String, String[]> item in urlManga)
                    {
                        ltbAddress.Items.Add(item.Value[0]);
                        ltbAddress.CheckBoxes = Convert.ToBoolean(item.Value[3]);
                    }
                    // Process VerifyCheck Start
                    urlProcess = new BackgroundWorker();
                    urlProcess.WorkerReportsProgress = true;
                    urlProcess.WorkerSupportsCancellation = true;
                    urlProcess.DoWork += new DoWorkEventHandler(VerifyCheck);
                    urlProcess.ProgressChanged += new ProgressChangedEventHandler(VerifyCheckChanged);
                    urlProcess.RunWorkerCompleted += new RunWorkerCompletedEventHandler(VerifyCheckCompleted);
                    if (urlProcess.IsBusy != true) { urlProcess.RunWorkerAsync(); }
                }
                else
                {
                    toolProgressBar.Visible = false;
                    toolProcessText.Visible = false;
                    toolPaste.Visible = false;
                }
            }
        }

        /// <summary>
        ///  Process VerifyCheck
        /// </summary>
        public void VerifyCheck(object sender, DoWorkEventArgs e)
        {            
            int valProcess = 0;     
            foreach (KeyValuePair<String, String[]> item in urlManga)
            {
                if ((urlProcess.CancellationPending == true)) { e.Cancel = true; break; }
                if (!Convert.ToBoolean(item.Value[2]))
                {
                    valProcess++;
                    urlProcess.ReportProgress(valProcess);
                    try
                    {

                    }
                    catch
                    {
                        
                    }
                }
            }
        }

        /// <summary>
        ///  Process VerifyCheck Changed
        /// </summary>
        private void VerifyCheckChanged(object sender, ProgressChangedEventArgs e)
        {
            toolProgressBar.Value = e.ProgressPercentage;
            toolProcessText.Text = (e.ProgressPercentage * Math.Ceiling(100.0 / (double)urlManga.Count)) + "%";
        }

        /// <summary>
        ///  Process VerifyCheck Completed
        /// </summary>
        private void VerifyCheckCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if ((e.Cancelled == true))
            {
                toolProcessText.Text = "Canceled!";
                toolProgressBar.Value = 0;
            }
            else if (!(e.Error == null))
            {
                toolProcessText.Text = ("Error: " + e.Error.Message);
                toolProgressBar.Value = 0;
            }
            else
            {
                toolProgressBar.Visible = false;
                toolProcessText.Visible = false;
                toolPaste.Visible = false;
                ltbAddress.Items.Clear();
                foreach (KeyValuePair<String, String[]> item in tmpManga)
                {
                    ltbAddress.Items.Add(item.Value[0]);
                    //ltbAddress.CheckedItems[] = Convert.ToBoolean(item.Value[3]);
                }
            }

        }        
    }
}
