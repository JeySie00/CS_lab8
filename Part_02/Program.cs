using System.IO;
using System.IO.Compression;

namespace part_02
{
    class Programm
    {
        static void Main()
        {
            Console.WriteLine("Input path to file:");
            string searchPath = Console.ReadLine();

            Console.WriteLine("Input file name :");
            string searchFileName = Console.ReadLine();

            string[] foundFiles = Directory.GetFiles(searchPath, searchFileName, SearchOption.AllDirectories);

            if (foundFiles.Length == 0)
            {
                Console.WriteLine("File not found");
                return;
            }

            Console.WriteLine($"Found {foundFiles.Length} file(s)");


            using FileStream inputStream = File.OpenRead(searchFileName);
            FileStream outputStream = File.OpenWrite("result.gzip");
            using DeflateStream compressStream = new(outputStream, CompressionMode.Compress);
            inputStream.CopyTo(compressStream);

            /*foreach (string filePath in foundFiles)
            {
                ZipFile.CreateFromDirectory("");
            }*/
        }
    }
}