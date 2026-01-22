namespace PracticeProblems.App;

public class DatabaseConnection
{
    public bool IsConnected { get; private set; }

    public void Connect()
    {
        // Simulating connection logic
        IsConnected = true;
        Console.WriteLine("Database connected.");
    }

    public void Disconnect()
    {
        // Simulating disconnection logic
        IsConnected = false;
        Console.WriteLine("Database disconnected.");
    }
}
