using System.IO;

namespace StandardLib
{
    public class Standard
    {
        private string _filePath;

        public Standard(string filePath)
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
}