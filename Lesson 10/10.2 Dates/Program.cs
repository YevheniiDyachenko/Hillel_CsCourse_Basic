using System.Text;

namespace _10._2_Dates
{
    class Program
    {
        static void Main()
        {
            int day, month, year;

            do
            {
                // Requesting data input from the user
                Console.WriteLine("Enter the day:");
                day = int.Parse(Console.ReadLine());

                Console.WriteLine("Enter the month:");
                month = int.Parse(Console.ReadLine());

                Console.WriteLine("Enter the year:");
                year = int.Parse(Console.ReadLine());

                // Checking the correctness of the entered data
                if (IsValidDate(day, month, year))
                {
                    // Creating StringBuilder to construct the date string
                    StringBuilder dateString = new StringBuilder();
                    dateString.Append(day);
                    dateString.Append('-');
                    dateString.Append(month);
                    dateString.Append('-');
                    dateString.Append(year);

                    // Displaying the date in the format "day-month-year"
                    Console.WriteLine($"Date in the format day-month-year: {dateString}");
                    break;
                }
            } while (true);
        }

        private static bool IsValidDate(int day, int month, int year)
        {
            if (day < 1 || day > 31 || month < 1 || month > 12 || year < 1)
            {
                Console.Clear();
                Console.WriteLine("Incorrect data. Please enter a value within the valid range.");
                Console.WriteLine("Day: between 1 and 31.");
                Console.WriteLine("Month: between 1 and 12.");
                Console.WriteLine("Year: greater than 0");
                Console.WriteLine("Press any key to continue...");
                Console.ReadLine();
                Console.Clear();
                return false;
            }

            return true;
        }
    }
}