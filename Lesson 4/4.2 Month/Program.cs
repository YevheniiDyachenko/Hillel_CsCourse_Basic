namespace _4._2_Month
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Get the month number from the user.
            Console.WriteLine("Enter the month number:");
            int month = Convert.ToInt32(Console.ReadLine());

            // Display the result.
            Console.Write("If-Else Operator Result:\t");
            IfElseOperatorResult(month);

            Console.Write("Ternary Operator Result:\t");
            TernaryOperatorResult(month);

            Console.Write("Switch Case Operator Result:\t");
            SwitchCaseOperatorResult(month);
            
            Console.ReadLine();
        }
        
        // Compare the month number to the different seasons.

        //Variant 1 Using If-Else Operator
        static void IfElseOperatorResult(int month)
        {
            if (month > 0 && month < 3 || month == 12)
            {
                Console.WriteLine("Winter");
            }
            else if (month >= 3 && month < 6)
            {
                Console.WriteLine("Spring");
            }
            else if (month >= 6 && month < 9)
            {
                Console.WriteLine("Summer");
            }
            else if (month >= 9 && month < 12)
            {
                Console.WriteLine("Autumn");
            }
            else
            {
                Console.WriteLine("There is no such month on this planet");
            }
        }

        //Variant 2 Using Ternary Operator
        static void TernaryOperatorResult(int month)
        {
            Console.WriteLine(month >= 3 && month < 6 ? "Spring" :
                month >= 6 && month < 9 ? "Summer" :
                month >= 9 && month < 12 ? "Autumn" :
                month == 1 || month == 2 || month == 12 ? "Winter" : "There is no such month on this planet");
        }

        //Variant 3 Using Switch Case Operator
        static void SwitchCaseOperatorResult(int month)
        {
            switch (month)
            {
                case 1:
                case 2:
                case 12:
                    Console.WriteLine("Winter");
                    break;

                case 3:
                case 4:
                case 5:
                    Console.WriteLine("Spring");
                    break;

                case 6:
                case 7:
                case 8:
                    Console.WriteLine("Summer");
                    break;

                case 9:
                case 10:
                case 11:
                    Console.WriteLine("Autumn");
                    break;

                default:
                    Console.WriteLine("There is no such month on this planet");
                    break;
            }
        }
    }
}