using System;
using System.Diagnostics;
using System.IO;

class Program
{
    static void Main()
    {
        string filePath = @"MyFile.txt";
        int dataSizeInMB = 100; // Ukuran data yang akan ditulis dalam MB

        Console.WriteLine("Mulai pengujian FileStream...");
        TestFileStream(filePath, dataSizeInMB);

        Console.WriteLine("\nMulai pengujian StreamWriter dengan MemoryStream...");
        TestStreamWriter(filePath, dataSizeInMB);

        Console.ReadKey();
    }

    static void TestFileStream(string filePath, int dataSizeInMB)
    {
        byte[] data = GenerateData(dataSizeInMB);

        Stopwatch stopwatch = new Stopwatch();
        stopwatch.Start();

        using (FileStream fileStream = new FileStream(filePath, FileMode.Create, FileAccess.Write))
        {
            fileStream.Write(data, 0, data.Length);
        }

        stopwatch.Stop();
        Console.WriteLine("Pengujian FileStream selesai. Waktu yang dibutuhkan: " + stopwatch.Elapsed);
    }

    static void TestStreamWriter(string filePath, int dataSizeInMB)
    {
        byte[] data = GenerateData(dataSizeInMB);

        Stopwatch stopwatch = new Stopwatch();
        stopwatch.Start();

        using (MemoryStream memoryStream = new MemoryStream())
        using (StreamWriter writer = new StreamWriter(memoryStream))
        {
            writer.Write(data);
            writer.Flush();

            using (FileStream fileStream = new FileStream(filePath, FileMode.Create, FileAccess.Write))
            {
                memoryStream.WriteTo(fileStream);
            }
        }

        stopwatch.Stop();
        Console.WriteLine("Pengujian StreamWriter dengan MemoryStream selesai. Waktu yang dibutuhkan: " + stopwatch.Elapsed);
    }

    static byte[] GenerateData(int sizeInMB)
    {
        int dataSize = sizeInMB * 1024 * 1024;
        byte[] data = new byte[dataSize];

        // Mengisi data dengan byte acak
        new Random().NextBytes(data);

        return data;
    }
}
