namespace Downloader
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string filePath = string.Empty;
            string url = string.Empty;

            FileBase fileBase = new FileBase();
            DownloadedFile.DownloadedSuccesfully += DownloadedFile_DownloadedSuccesfully;

            while (true)
            {
                var option = ConsoleInputHandler.ReadOption();

                OptionsHandler.Handle(option, filePath, url, fileBase);

                if (OptionsHandler.IsFinished)
                    return;
            }
        }

        private static void DownloadedFile_DownloadedSuccesfully(object? sender, EventArgs e)
        {
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"The file has been downloaded succesfully.");
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}