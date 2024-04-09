namespace _3._2_Calculates_the_square_of_any_given_number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Get a number from the user.
            Console.WriteLine("Enter a number: ");
            int number = Convert.ToInt32(Console.ReadLine());
            
            // 1 Variant
            // Calculate the square of a given number.
            int square = number * number;
            
            // Display the square of a given number.
            Console.WriteLine($"The square of {number} is {square}.");
            
            // 2 Variant
            // Calculate the square of a given number with Math class.
            int square2 = (int)Math.Pow(number, 2);
            
            // Display the square of a given number.
            Console.WriteLine($"The square of {number} is {square2}.");
            
            Console.ReadLine();
        }
    }
}            