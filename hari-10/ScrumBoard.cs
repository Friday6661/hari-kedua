namespace ScrumBoardLib;
using taskLib;
using System;
using System.Collections.Generic;

class ScrumBoard
{
    private List<Task> _Tasks;
    public ScrumBoard()
    {
        _Tasks = new List<Task>();
    }

    public void AddTask(Task task)
    {
        _Tasks.Add(task);
    }

    public void DisplayTasks()
    {
        foreach (Task task in _Tasks)
        {
            Console.WriteLine("Task: " + task.Title + "(Status: " + task.Status + ")");
        }
    }

    public void UpdateTaskStatus(string taskTitle, TaskStatus newStatus)
    {
        Task taskToUpdate = _Tasks.Find(taskLib => taskLib.Title == taskTitle);
        if (taskToUpdate != null)
        {
            taskToUpdate.ChangeStatus(newStatus);
            Console.WriteLine($"Task: {taskTitle} status update to: {newStatus}");
        }
        else
        {
            Console.WriteLine($"Task: {taskTitle} not founds");
        }
    }

}