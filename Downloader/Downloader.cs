using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Downloader
{
    public static class HttpClientExtensions
    {
        public static async Task DownloadAsync(this HttpClient client, string url, string filePath)
        {
            using (WebClient wc = new WebClient())
            {
                await wc.DownloadFileTaskAsync(url, filePath);
            }
        }
    }
}
