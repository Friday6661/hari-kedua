using System;
using System.Diagnostics;

class PointClass {
    public int X;
    public int Y;

    public PointClass(int x, int y) {
        X = x;
        Y = y;
    }
}

struct PointStruct {
    public int X;
    public int Y;

    public PointStruct(int x, int y) {
        X = x;
        Y = y;
    }
}

class Program {
    static void Main() {
        PointClass pointClass1 = new PointClass(1,2);
        PointClass pointClass2 = pointClass1;

        pointClass2.X = 3;

        Console.WriteLine("Class: ");
        Console.WriteLine($"pointClass1: X = {pointClass1.X}, Y = {pointClass1.Y}");
        Console.WriteLine($"pointClass2: X = {pointClass2.X}, Y = {pointClass2.Y}");

        PointStruct pointStruct1 = new PointStruct(1, 2);
        PointStruct pointStruct2 = pointStruct1;

        pointStruct2.X = 3;

        Console.WriteLine("\nStruct");
        Console.WriteLine($"pointStruct1: X = {pointStruct1.X}, Y = {pointStruct1.Y}");
        Console.WriteLine($"pointStruct2: X = {pointStruct2.X}, Y = {pointStruct2.Y}");

        int iterations = 10000000;

        Stopwatch sw = new Stopwatch();

        sw.Start();
        for (int i = 0; i < iterations; i++) {
            PointClass temp = new PointClass(i, i);
        }
        sw.Stop();
        Console.WriteLine($"\nPerformance Class: {sw.ElapsedMilliseconds} ms");


        sw.Restart();
        for (int i = 0; i<iterations; i++) {
            PointStruct temp = new PointStruct(i, i);
        }
        sw.Stop();
        Console.WriteLine($"Performanace Struct: {sw.ElapsedMilliseconds} ms");
    }
}