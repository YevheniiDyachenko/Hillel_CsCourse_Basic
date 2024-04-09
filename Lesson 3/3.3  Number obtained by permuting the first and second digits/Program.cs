namespace _3._3__Number_obtained_by_permuting_the_first_and_second_digits
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Get a three digit number from the user.
            Console.WriteLine("Enter a three digit number: ");
            int number = Convert.ToInt32(Console.ReadLine());
            
            // 1 Variant
            // Calculate the resulted number.
            int reversedNumber =  number/100*10 + (number/10)%10*100+ number % 10;
            
            // Display the resulted number.
            Console.WriteLine($"The Resulted Number is: {reversedNumber}.");
            
            // 2 Variant
            // Get the digits from right to left.
            int firstDigit = number / 100;
            int secondDigit = (number % 100) / 10;
            int thirdDigit = number % 10;
            
            // Display the digits.
            Console.WriteLine($"The result of permuting the first and second digits is: {secondDigit}{firstDigit}{thirdDigit}.");
            
            Console.ReadLine();
        }
    }
}