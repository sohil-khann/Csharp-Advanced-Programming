using PracticeProblems.App;

namespace PracticeProblems.Test;

public class PerformanceTaskTests
{
    private PerformanceTask task;

    [SetUp]
    public void Setup()
    {
        task = new PerformanceTask();
    }

    [Test]
    [CancelAfter(2000)] // Using CancelAfter as Timeout is obsolete in newer NUnit
    public void LongRunningTask_ShouldPassWithinTimeout()
    {
        var result = task.LongRunningTask();
        Assert.That(result, Is.EqualTo("Task Completed"));
    }
}
