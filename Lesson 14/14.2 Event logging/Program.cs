namespace _14._2_Event_logging
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Logging events
            Logger.AddLog("Event 1: Program started");
            Logger.AddLog("Event 2: Operation X was performed");
            Logger.AddLog("Event 3: Received data Y");
            Logger.AddLog("Event 4: Program finished");
            Logger.AddLog("Event 5: Error occurred");
            Logger.AddLog("Event 6: Program terminated");

            // Retrieving and displaying all saved logs
            LogEntry[] allLogs = Logger.GetLogs();
            foreach (LogEntry log in allLogs)
            {
                Console.WriteLine($"{log.Timestamp}: {log.Message}");
            }
        }
    }
    
}


