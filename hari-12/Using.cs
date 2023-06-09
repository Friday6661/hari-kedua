namespace FileProcessorLib;
using System.IO;

class FileProcessor
{
    private string _filePath;

    public FileProcessor(string filePath)
    {
        _filePath = filePath;
    }
    public string ReadFile()
    {
        using (StreamReader reader = new StreamReader(_filePath))
        {
            return reader.ReadToEnd();
        }
    }
    public void WriteFile(string content)
    {
        using (StreamWriter writer = new StreamWriter(_filePath))
        {
            writer.WriteLine(content);
        }
    }
}