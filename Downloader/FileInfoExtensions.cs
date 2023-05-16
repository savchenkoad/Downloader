using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Downloader
{
    public static class FileInfoExtensions
    {
        public static string GetFullInfo(this FileInfo fileInfo)
        {
            return $"Name: {fileInfo.Name}\n" +
                $"Path: {fileInfo.FullName}\n" +
                $"Extension: {fileInfo.Extension}\n" +
                $"Size: {fileInfo.Length} bytes\n";
        }
    }
}
