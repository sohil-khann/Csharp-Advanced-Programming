namespace PracticeProblems.App;

public class PerformanceTask
{
    public string LongRunningTask()
    {
        // Simulate a task that takes 1 second (less than the 2s timeout)
        Thread.Sleep(1000);
        return "Task Completed";
    }
}
