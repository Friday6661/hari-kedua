using vectorAdditionLib;
using vectorSubstractionLib;
using System;

public class Program
{
    public static void Main(string[] args)
    {
        // Penjumlahan Vektor
        VectorAddition v1 = new VectorAddition(2, 4);
        VectorAddition v2 = new VectorAddition(3, 6);

        VectorAddition v3 = v1 + v2;
        Console.WriteLine($"VectorAddition: {v1} + {v2} = {v3}");

        // Pengurangan Vektor
        VectorSubstraction v4 = new VectorSubstraction(3, 4);
        VectorSubstraction v5 = new VectorSubstraction(7, 6);
        VectorSubstraction v6 = v5- v4;
        Console.WriteLine($"VectorSubstraction: {v5} - {v4} = {v6}"); 
    }
}