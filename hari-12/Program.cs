using FileProcessorLib;
using StandardLib;
using System.IO;

class Program
{
    static void Main()
    {

        string filePath = "/bin/Debug/net7.0/file.txt";
        FileProcessor fileProcessor = new FileProcessor(filePath);
        //Standard standard = new Standard(filePath);

        string content = fileProcessor.ReadFile();
        Console.WriteLine("isi file:");
        Console.WriteLine(content);

        //string content1 = standard.ReadFile();
        //Console.WriteLine("isi file:");
        //Console.WriteLine(content1);

        //fileProcessor.WriteFile("Data tambahan");
        //standard.WriteFile("Data tambahan");

        Console.ReadKey();
    }
}