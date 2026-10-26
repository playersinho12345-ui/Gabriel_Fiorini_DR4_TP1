using Exercicio05.Models;

namespace Exercicio05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DownloadManager donwload = new();

            donwload.DownloadCompleted += OnDownloadCompleted;

            donwload.StartDownload();
        }

        static void OnDownloadCompleted(object? sender, EventArgs e)
        {
            Console.WriteLine("Download concluído!");
        }
    }
}
