using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace BackgroundWorker
{
    public partial class frmMain : Form
    {

        /// <summary>
        /// File download simulator.
        /// </summary>
        FileDownloader _downloader;

        public frmMain()
        {
            InitializeComponent();

            _downloader = new FileDownloader();
        }

        private void cmdStart_Click(object sender, System.EventArgs e)
        {
            if (!_downloader.Downloading)
            {
                cmdStart.Text = "Cancel";
                lblStatus.Text = string.Empty;
                progress.Value = 0;

                bgw.RunWorkerAsync();
            }
            else
            {
                bgw.CancelAsync();
                _downloader.Aborted = true;
            }
        }

        private void cmdClose_Click(object sender, System.EventArgs e)
        {
            Close();
        }

        private void bgw_DoWork(object sender, DoWorkEventArgs e)
        {
            _downloader.GenerateFakeDownloadInformation();
            _downloader.DownloadFile(bgw.ReportProgress);
        }

        private void bgw_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            MethodInvoker invoker = () => progress.Value = e.ProgressPercentage;
            progress.BeginInvoke(invoker);

            invoker = () => lblDownloaded.Text = $"{_downloader.Downloaded:###,##0}/{_downloader.FileSize:###,##0} MB";
            lblDownloaded.BeginInvoke(invoker);
        }

        private void bgw_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (_downloader.Aborted)
            {
                lblStatus.ForeColor = Color.DarkRed;
                lblStatus.Text = "Download aborted.";
                lblDownloaded.Text = "-/- MB";
                progress.Value = 0;
            }
            else
            {
                lblStatus.ForeColor = Color.DarkGreen;
                lblStatus.Text = "Download finished.";
            }

            cmdStart.Text = "Download";
        }

    }
}
