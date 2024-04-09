namespace _3._4_Arithmetic_average_of_two_numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Get a numbers from the user.
            Console.WriteLine("Enter the first number: ");
            double firstNumber = Convert.ToDouble(Console.ReadLine());
            
            Console.WriteLine("Enter the second number: ");
            double secondNumber = Convert.ToDouble(Console.ReadLine());
            
            // Calculate the average of two numbers.
            double average = (firstNumber + secondNumber)/2;
            
            // Display the average of two numbers.
            Console.WriteLine($"The average of {firstNumber} and {secondNumber} is {average}.");
            
            Console.ReadLine();
        }
    }
}