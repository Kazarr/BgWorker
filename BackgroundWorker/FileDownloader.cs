using System;
using System.Threading;

namespace BackgroundWorker
{
    class FileDownloader
    {

        public int FileSize { get; private set; }
        public double Downloaded { get; private set; }

        public bool Aborted { get; set; }

        private double _downloadSpeed;

        public void GenerateRandomFile()
        {
            Random r = new Random(Environment.TickCount);

            Aborted = false;
            Downloaded = 0;
            FileSize = r.Next(50, 1024);

            _downloadSpeed = r.Next(FileSize / 200, FileSize / 20);
        }

        public void DownloadFile(Action<int> reportProgress)
        {
            while (Downloaded < FileSize && !Aborted)
            {
                Thread.Sleep(100);

                Downloaded = Math.Min(Downloaded + _downloadSpeed / 10.0, FileSize);

                reportProgress.Invoke((int)((Downloaded / FileSize) * 100));
            }
        }
    }
}