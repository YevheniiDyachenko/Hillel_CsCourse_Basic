namespace _4._3_Fizz_Buzz
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Get a number from the user.
            Console.WriteLine("Enter a number from 1 to 100: ");
            int number = Convert.ToInt32(Console.ReadLine());

            //Solution using a ternary operator
            Console.WriteLine((number % 3 == 0 ? "Fizz" : "") + (number % 5 == 0 ? "Buzz" : ""));
            Console.ReadLine();
        }
    }
}