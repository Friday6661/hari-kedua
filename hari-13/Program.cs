using System;
using System.Collections.Generic;
using System.Diagnostics;

class Game
{
    private int _boardSize;
    private Dictionary<int, int> _snakes;
    private Dictionary<int, int> _ladders;

    public Game(int boardSize)
    {
        _boardSize = boardSize;
        _snakes = new Dictionary<int, int>();
        _ladders = new Dictionary<int, int>();
    }

    public void AddSnake(int start, int end)
    {
        Debug.Assert(start > end, "Posisi awal harus lebih besar dari posisi akhir pada ular.");
        Debug.Assert(start > 0 && start <= _boardSize, "Posisi awal ular harus dalam rentang papan permainan.");
        Debug.Assert(end >= 0 && end < _boardSize, "Posisi akhir ular harus dalam rentang papan permainan.");

        _snakes[start] = end;
    }

    public void AddLadder(int start, int end)
    {
        Debug.Assert(start < end, "Posisi awal harus lebih kecil dari posisi akhir pada tangga.");
        Debug.Assert(start > 0 && start < _boardSize, "Posisi awal tangga harus dalam rentang papan permainan.");
        Debug.Assert(end >= 0 && end < _boardSize, "Posisi akhir tangga harus dalam rentang papan permainan.");

        _ladders[start] = end;
    }

}

class Program
{
    static void Main()
    {
        int boardSize = 100;

        Game game = new Game(boardSize);

        game.AddSnake(14, 7);
        game.AddSnake(21, 17);
        game.AddLadder(4, 16);
        game.AddLadder(9, 28);
    }
}
using System;
using System.Collections.Concurrent;
using System.Net;
using System.Threading;
using HtmlAgilityPack;

class Program
{
    static void Main()
    {
        string[] websites = { "https://example.com", "https://example.org", "https://example.net" };

        // Create a thread-safe queue to hold the website URLs
        ConcurrentQueue<string> websiteQueue = new ConcurrentQueue<string>(websites);

        // Create a countdown event to track the completion of all threads
        CountdownEvent countdownEvent = new CountdownEvent(websites.Length);

        // Start multiple worker threads
        for (int i = 0; i < websites.Length; i++)
        {
            ThreadPool.QueueUserWorkItem(state =>
            {
                string websiteUrl;
                while (websiteQueue.TryDequeue(out websiteUrl))
                {
                    try
                    {
                        // Fetch web page content
                        string pageContent = FetchWebPage(websiteUrl);

                        // Process the data
                        ProcessData(pageContent);

                        Console.WriteLine($"Scraping completed for {websiteUrl}");
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"Error scraping {websiteUrl}: {ex.Message}");
                    }
                    finally
                    {
                        countdownEvent.Signal(); // Signal completion for this thread
                    }
                }
            });
        }

        countdownEvent.Wait(); // Wait for all threads to complete
        Console.WriteLine("All scraping tasks completed.");
    }

    static string FetchWebPage(string url)
    {
        using (var client = new WebClient())
        {
            return client.DownloadString(url);
        }
    }

    static void ProcessData(string pageContent)
    {
        // Use HtmlAgilityPack or other methods to extract and process data from the web page content
        var htmlDocument = new HtmlDocument();
        htmlDocument.LoadHtml(pageContent);

        // Example: Extracting and printing the page title
        var titleNode = htmlDocument.DocumentNode.SelectSingleNode("//title");
        if (titleNode != null)
        {
            string pageTitle = titleNode.InnerText;
            Console.WriteLine($"Page title: {pageTitle}");
        }
    }
}
