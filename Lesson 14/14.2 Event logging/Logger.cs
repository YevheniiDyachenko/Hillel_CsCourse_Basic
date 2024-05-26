namespace _14._2_Event_logging;

// Static class for managing logs
public static class Logger
{
    private static LogEntry[] logs = new LogEntry[0];

    // Method for adding a new log
    public static void AddLog(string message)
    {
        var newLogs = new LogEntry[logs.Length + 1]; // Create a new array of logs with one more element
        Array.Copy(logs, newLogs, logs.Length); // Copy existing logs to a new array
        newLogs[newLogs.Length - 1] = new LogEntry(message); // Add a new log to the end of the new array
        logs = newLogs; // Update the logs field with a new array
    }


    // Method to get all saved logs
    public static LogEntry[] GetLogs()
    {
        return logs;
    }
}
