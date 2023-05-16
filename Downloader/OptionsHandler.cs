using Microsoft.VisualBasic.FileIO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Downloader
{
    public static class OptionsHandler
    {
        public static bool IsFinished { get; private set; } = false;

        public static void Handle(int option, string filePath, string url, FileBase fileBase)
        {
            switch (option)
            {
                case 1:
                    Console.Clear();

                    ConsoleInputHandler.ReadInfo(out filePath, out url);
                    var file = new DownloadedFile(url, filePath);

                    var task = file.Download();
                    task.ContinueWith(x => fileBase.AddFile(file));
                    break;
                case 2:
                    Console.Clear();

                    fileBase.PrintAll();

                    Console.ReadKey();
                    break;
                case 3:
                    IsFinished = true;
                    break;
                default:
                    Console.Clear();
                    Console.WriteLine("Incorrect option.");
                    Console.ReadKey();
                    Console.Clear();
                    return;
            }

            Console.Clear();
        }
    }
}
