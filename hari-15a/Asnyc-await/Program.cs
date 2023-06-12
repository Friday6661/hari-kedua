using System;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        Console.WriteLine("Main method started");

        SomeMethod();

        Console.WriteLine("Main Method End");
        Console.ReadLine();
    }

    public async static void SomeMethod()
    {
        Console.WriteLine("Some Method Started");
        await Task.Delay(TimeSpan.FromSeconds(10));
        Console.WriteLine("\n");
        Console.WriteLine("Some Method End");
    }
}