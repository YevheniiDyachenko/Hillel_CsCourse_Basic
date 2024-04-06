namespace _2._2_Time_in_seconds
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //creating and initializing variables
            int hours = 100;
            int minutes = 100;
            int seconds = 100;

            //getting values from the console
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

            //calculation of the result
            int totalSeconds = hours * 3600 + minutes * 60 + seconds;

            //output of the result
            Console.WriteLine($" Hours: {hours} \n Minutes: {minutes} \n Seconds: {seconds} \n Total in seconds:{totalSeconds}");
            Console.ReadLine();
        }
    }
}
