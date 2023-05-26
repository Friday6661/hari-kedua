namespace taskLib;
using System;

enum TaskStatus
{
    Todo,
    InProgress,
    Done
}
class Task
{
    public string Title { get; set; }
    public TaskStatus Status { get; set; }

    public Task(string title, TaskStatus status)
    {
        Title = title;
        Status = status;
    }

    public void ChangeStatus(TaskStatus newStatus)
    {
        Status = newStatus;
    }
}

