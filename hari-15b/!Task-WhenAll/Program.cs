using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        Console.WriteLine($"Main Thread started");
        List<CreditCard> creditCards = creditCards.GenerateCreditCard(10);
        Console.WriteLine($"Credit Card Generated : {creditCards.Count}");

        ProcessCreditCards(creditCards);

        Console.WriteLine($"Main Thread Completed");
        Console.ReadKey();
    }

    public static async void ProcessCreditCards(List<CreditCard> creditCards)
    {
        var stopwatch = new Stopwatch();
        stopwatch.Start();

        foreach (var creditCard in creditCards)
        {
            var response = await ProcessCreditCards(creditCard);
        }

        stopwatch.Stop();
        Console.WriteLine($"Processing of {creditCards.Count} Credit Cards Done in {stopwatch.ElapsedMilliseconds/ 1000} Seconds");
    }

    public static async Task<string> ProcessCard(CreditCard creditCard)
    {
        await Task.Delay(1000);
        string message = $"Credit Card Number: {creditCard.CardNumber} Name: {creditCard.Name} Processed";
        Console.WriteLine($"Credit Card Number: {creditCard.CardNumber} Processed");
        return message;
    }

    public class CreditCard
    {
        public string CardNumber { get; set; }
        public string Name { get; set; }

        public static List<CreditCard> GenerateCreditCards(int number)
        {
            List<CreditCard> cards = new List<CreditCard>();
            for (int i = 0; i < number; i++)
            {
                CreditCard card = new CreditCard()
                {
                    CardNumber = "1000000" + i,
                    Name = "Credit Card-" + i
                }
            }
        }
    }
}