using System;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        Console.WriteLine("Main Method Started");

        SomeMethod();

        Console.WriteLine("Main Method Completed");
        Console.ReadLine();
    }

    public async static void SomeMethod()
    {
        Console.WriteLine("Some Method Started");

        Thread.Sleep(TimeSpan.FromSeconds(10));
        Console.WriteLine("\n");
        Console.WriteLine("Some Method Completed");
    }
}