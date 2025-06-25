namespace BlazorServerTaskApp.Data;

public class TaskService
{
    private List<TaskItem> tasks = new List<TaskItem>();
    private int nextId = 1;

    public Task<List<TaskItem>> GetTasksAsync() => Task.FromResult(tasks);

    public Task<TaskItem> GetTaskByIdAsync(int id) =>
        Task.FromResult(tasks.FirstOrDefault(t => t.Id == id));

    public Task AddTaskAsync(TaskItem task)
    {
        task.Id = nextId++;
        tasks.Add(task);
        return Task.CompletedTask;
    }

    public Task UpdateTaskAsync(TaskItem task)
    {
        var existingTask = tasks.FirstOrDefault(t => t.Id == task.Id);
        if (existingTask != null)
        {
            existingTask.Title = task.Title;
            existingTask.IsCompleted = task.IsCompleted;
        }
        return Task.CompletedTask;
    }

    public Task DeleteTaskAsync(int id)
    {
        var task = tasks.FirstOrDefault(t => t.Id == id);
        if (task != null)
        {
            tasks.Remove(task);
        }
        return Task.CompletedTask;
    }
}

public class TaskItem
{
    public int Id { get; set; }
    public string Title { get; set; } = string.Empty;
    public bool IsCompleted { get; set; }
}