using System;
using System.Threading.Tasks;

class Program
{
	static async Task Main()
	{
		Task task = new Task(() => Console.WriteLine("Hello, Task Start!"));
		task.Start();
		task.Wait(); // Wait for the task to complete

		Task task1 = Task.Run(() => Console.WriteLine("Hello, Task.Run!"));
		task1.Wait(); // Wait for the task to complete
		
		Task.Run(() => Console.WriteLine("Hello, Task Run Immediately!")); // Same as above
		Task<int> task2 = Task.Run(() => Add(5, 6));

		int result = task2.Result;
		Console.WriteLine($"Result: {result}");
	}

	static async Task<int> Add(int x, int y)
	{
		return x + y;
	}
}
