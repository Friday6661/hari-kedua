using System.Collections.Generic;
using System.IO;
using System.Text.Json;

public class SnakeandLadder
{
    public Dictionary<string, snakeValue>? snake { get; set; }
    public Dictionary<string, ladderValue>? ladder { get; set; }
}

public class snakeValue
{
    public int head { get; set; }
    public int tail { get; set; }

}

public class ladderValue
{
    public int bottom { get; set; }
    public int top { get; set; }
}
class Program
{
    static void Main()
    {
        SnakeandLadder snakesandladders = new SnakeandLadder
        {
            snake = new Dictionary<string, snakeValue>
            {
                ["snake1"] = new snakeValue { head = 99, tail = 1},
                ["snake2"] = new snakeValue { head = 97, tail = 35},
                ["snake3"] = new snakeValue { head = 96, tail = 45}
            },
            ladder = new Dictionary<string, ladderValue>
            {
                ["ladder1"] = new ladderValue { bottom = 3, top = 98},
                ["ladder2"] = new ladderValue { bottom = 4, top = 65},
                ["ladder3"] = new ladderValue { bottom = 6, top = 90}
            }
        };

        var options = new JsonSerializerOptions { WriteIndented = true };
        string jsonString = JsonSerializer.Serialize(snakesandladders, options);
        
        File.WriteAllText("snakesandladders.json", jsonString);

        string jsonFromFile = File.ReadAllText("snakesandladders.json");

        SnakeandLadder deserializedSnakeAndLadder = JsonSerializer.Deserialize<SnakeandLadder>(jsonFromFile);

        foreach (var snake in deserializedSnakeAndLadder.snake)
        {
            Console.WriteLine($"Snake: {snake.Key}, Head: {snake.Value.head}, Tail: {snake.Value.tail}");
        }

        foreach (var ladder in deserializedSnakeAndLadder.ladder)
        {
            Console.WriteLine($"Ladder: {ladder.Key}, Bottom: {ladder.Value.bottom}, Top: {ladder.Value.top}");
        }

    }
}