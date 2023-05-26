// Dashboard Scrum
using ScrumBoardLib;
using System;

public class Program
{
    public static void Main(string[] args)
    {
        ScrumBoard scrumBoard = new ScrumBoard();

        taskLib.Task task1 = new taskLib.Task($"Penambahan Kelas Baru ", taskLib.TaskStatus.InProgress);
        taskLib.Task task2 = new taskLib.Task($"Menghapus penggunaan Console.WriteLine di Method ", taskLib.TaskStatus.Todo);
        taskLib.Task task3 = new taskLib.Task($"Refactor Code ", taskLib.TaskStatus.Done);

        scrumBoard.AddTask(task1);
        scrumBoard.AddTask(task2);
        scrumBoard.AddTask(task3);

        Console.WriteLine("================================================================");
        scrumBoard.DisplayTasks();
        Console.WriteLine("================================================================");

        // Lead Project mengubah status tugas
        scrumBoard.UpdateTaskStatus("Penambahan Kelas Baru ", taskLib.TaskStatus.Done);
        Console.WriteLine("================================================================");

        scrumBoard.DisplayTasks();
    }
}