namespace PracticeProblems.Test;

using PracticeProblems.App;
using NUnit.Framework;

[TestFixture]
public class DatabaseConnectionTests
{
    private DatabaseConnection connection;

    [SetUp]
    public void Setup()
    {
        // This runs before each test
        connection = new DatabaseConnection();
        connection.Connect();
    }

    [TearDown]
    public void TearDown()
    {
        // This runs after each test
        connection.Disconnect();
    }

    [Test]
    public void TestConnection_IsEstablished()
    {
        Assert.That(connection.IsConnected, Is.True, "Database should be connected after Setup.");
    }

    [Test]
    public void TestConnection_RemainsActiveDuringTest()
    {
        // Simple test to ensure the connection state is maintained
        Assert.That(connection.IsConnected, Is.True);
    }
}
