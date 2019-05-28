using System;
using System.Threading;

namespace BackgroundWorker
{

    /// <summary>
    /// Class simulating files download.
    /// </summary>
    class FileDownloader
    {

        #region Constants

        /// <summary>
        /// Minimal file size.
        /// </summary>
        private const int MIN_FILE_SIZE = 50;
        /// <summary>
        /// Maximal file size.
        /// </summary>
        private const int MAX_FILE_SIZE = 1024;
        /// <summary>
        /// Factor for minimal download speed.
        /// </summary>
        private const int MIN_DL_SPEED_FACTOR = 200;
        /// <summary>
        /// Factor for maximal download speed.
        /// </summary>
        private const int MAX_DL_SPEED_FACTOR = 15;

        #endregion

        #region Attributes

        /// <summary>
        /// File download speed in MB.
        /// </summary>
        private double _downloadSpeed;

        #endregion

        #region Properties

        /// <summary>
        /// Total file size in MB.
        /// </summary>
        public int FileSize { get; private set; }

        /// <summary>
        /// Downloaded size in MB.
        /// </summary>
        public double Downloaded { get; private set; }

        /// <summary>
        /// Indicated whether a file is downloading.
        /// </summary>
        public bool Downloading { get; private set; }

        #endregion

        /// <summary>
        /// Generates fake file dowload information.
        /// </summary>
        public void GenerateFakeDownloadInformation()
        {
            Random r = new Random(Environment.TickCount);

            Downloaded = 0;
            FileSize = r.Next(MIN_FILE_SIZE, MAX_FILE_SIZE);

            _downloadSpeed = r.Next(FileSize / MIN_DL_SPEED_FACTOR, FileSize / MAX_DL_SPEED_FACTOR);
        }

        /// <summary>
        /// Simulates file download.
        /// </summary>
        /// <param name="reportProgress">Delegate to progress report method.</param>
        /// <param name="cancellationPending">Delegate to check whether download cancellation is pending.</param>
        /// <returns>True, if download was completed successfully; otherwise false.</returns>
        public bool DownloadFile(Action<int> reportProgress, Func<bool> cancellationPending)
        {
            Downloading = true;

            while (Downloaded < FileSize && !cancellationPending.Invoke())
            {
                Thread.Sleep(100);

                Downloaded = Math.Min(Downloaded + _downloadSpeed / 10.0, FileSize);

                reportProgress.Invoke((int)((Downloaded / FileSize) * 100));
            }

            Downloading = false;

            return (Downloaded == FileSize);
        }
    }
}