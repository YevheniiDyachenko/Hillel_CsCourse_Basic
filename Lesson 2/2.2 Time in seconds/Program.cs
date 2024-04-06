namespace _2._2_Time_in_seconds
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int hours = 100;
            int minutes = 100;
            int seconds = 100
                ;

            Console.WriteLine("Enter the number of hours (press Enter to use default time):");
            string inputHours = Console.ReadLine();

            if (inputHours != "") // when user click Enter , then use base value for time 
            {
                hours = Convert.ToInt32(inputHours);

                Console.WriteLine("Enter the number of minutes:");
                minutes = Convert.ToInt32 (Console.ReadLine());

                Console.WriteLine("Enter the number of seconds:");
                seconds = Convert.ToInt32 (Console.ReadLine());
            }

            int totalSeconds = hours * 3600 + minutes * 60 + seconds;

            Console.WriteLine($" Hours: {hours} \n Minutes: {minutes} \n Seconds: {seconds} \n Total in seconds:{totalSeconds}");
            Console.ReadLine();
        }
    }
}
