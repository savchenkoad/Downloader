using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Downloader
{
    public class DownloadedFile
    {
        public static event EventHandler? DownloadedSuccesfully;

        public FileInfo File { get; private set; }
        public string Url { get; private set; }

        public DownloadedFile(string url, string filePath)
        {
            File = new FileInfo(filePath);
            Url = url;
        }

        public async Task Download()
        {
            using (HttpClient httpClient = new HttpClient())
            {
                await httpClient.DownloadAsync(Url, File.FullName);
            }
            
            DownloadedSuccesfully?.Invoke(this, EventArgs.Empty);
        }
    }
}
