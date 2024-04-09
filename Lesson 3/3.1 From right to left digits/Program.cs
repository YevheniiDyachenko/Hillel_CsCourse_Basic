
namespace _3._1_From_right_to_left_digits
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Get a three digit number from the user.
            Console.WriteLine("Enter a three digit number: ");
            int number = Convert.ToInt32(Console.ReadLine());
            
            // 1 Variant
            // Calculate the reversed number.
            int reversedNumber =  number/100 + (number/10)%10*10 + number % 10*100;
            
            // Display the reversed number.
            Console.WriteLine($"The Reversed Number is: {reversedNumber}.");
            
            // 2 Variant
            // Get the digits from right to left.
            int firstDigit = number / 100;
            int secondDigit = (number % 100) / 10;
            int thirdDigit = number % 10;
            
            // Display the digits from right to left.
            Console.WriteLine($"The digits from right to left are: {thirdDigit}{secondDigit}{firstDigit}.");
            
            Console.ReadLine();
        }
    }
}