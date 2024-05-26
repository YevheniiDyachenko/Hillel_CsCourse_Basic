namespace _14._2_Event_logging;

// A class that represents a single entry in the logs
public class LogEntry
{
    public DateTime Timestamp { get; set; }
    public string Message { get; set; }

    public LogEntry(string message)
    {
        Timestamp = DateTime.Now;
        Message = message;
    }
}