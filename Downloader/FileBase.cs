using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Downloader
{
    public class FileBase
    {
        private List<DownloadedFile> _files = new List<DownloadedFile>();

        public void PrintAll()
        {
            if (_files.Count == 0)
            {
                Console.WriteLine("No file has been downloaded yet.");
                return;
            }

            foreach (var item in _files)
            {
                Console.WriteLine(item.File.GetFullInfo());
            }
        }

        public void AddFile(DownloadedFile file)
        {
            _files.Add(file);
        }
    }
}
