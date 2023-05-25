using divideLib;
using System;

public class program
{
    static void Main(string[] args)
    {
        divideOperations divide = new divideOperations();

        try
        {
            Console.WriteLine("Masukan dua angka");
            Console.Write("Masukan angka pertama: ");
            int angka1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Masukan angka kedua: ");
            int angka2 = Convert.ToInt32(Console.ReadLine());

            int hasil = divide.Divide(angka1, angka2);
            Console.WriteLine("Hasil pembagian: " + hasil);
        }
        catch (FormatException)
        {
            Console.WriteLine("Input tidak valid");
        }
        catch (DivideByZeroException e)
        {
            Console.WriteLine("zero exception in main");
        }
    }
}