using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Downloader
{
    public static class ConsoleInputHandler
    {
        public static int ReadOption()
        {
            Console.WriteLine("Welcome to the downloader!\n");
            Console.WriteLine("Choose an option: \n" +
                "1. Download file\n" +
                "2. Show downloaded files\n" +
                "3. Exit\n");

            int.TryParse(Console.ReadLine(), out int result);

            return result;
        }

        public static void ReadInfo(out string filePath, out string url)
        {
            Console.Write("Enter the url: ");
            url = Console.ReadLine();

            Console.Write("Enter the path to save: ");
            filePath = Console.ReadLine();
        }
    }
}
