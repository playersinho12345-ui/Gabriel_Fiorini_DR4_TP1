using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio05.Models
{
    public class DownloadManager
    {

        public event EventHandler DownloadCompleted;

        public void StartDownload()
        {
            Console.WriteLine("Iniciando Download...");
            Thread.Sleep(5000);

            DownloadCompleted?.Invoke(this, EventArgs.Empty);
        }

    }
}
