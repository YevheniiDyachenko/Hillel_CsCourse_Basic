namespace _4._1_Сomparing_two_numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Get two numbers from the user.
            Console.WriteLine("Enter the first number: ");
            int number1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the second number: ");
            int number2 = Convert.ToInt32(Console.ReadLine());

            // Compare the two numbers.

            //Variant 1 Using If-Else Operator
            Console.Write("If-Else Operator Result:");
            if (number1 == number2)
            {
                // The numbers are equal.
                Console.WriteLine("The numbers are equal.");
            }
            else if (number1 > number2)
            {
                // The first number is greater.
                Console.WriteLine("The first number is greater.");
            }
            else
            {
                // The second number is greater.
                Console.WriteLine("The second number is greater.");
            }

            Console.ReadLine();

            //Variant 2 Using Ternary Operator
            Console.Write("Ternary Operator Result:");
            Console.WriteLine(number1 == number2 ? "The numbers are equal." :
                number1 > number2 ? "The first number is greater." : "The second number is greater.");
            Console.ReadLine();

            //Variant 3 Using Switch Case Operator
            Console.Write("Switch Case Operator Result:");
            switch (number1 - number2)
            {
                case 0:
                    Console.WriteLine("The numbers are equal.");
                    break;
                case > 0:
                    Console.WriteLine("The first number is greater.");
                    break;
                default:
                    Console.WriteLine("The second number is greater.");
                    break;
            }

            Console.ReadLine();
        }
    }
}