namespace _3._6_Ways_to_swap_the_values_of_two_variables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Get a two digits from the user.
            Console.WriteLine("Enter the value of the variable \"A\": ");
            int a = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("Enter the value of the variable \"B\": ");
            int b = Convert.ToInt32(Console.ReadLine());
            
            // 1 Variant
            a *= b;
            b = a / b;
            a /= b;
            
            // 2 Variant
            // Works only for positive numbers 
            a -= b;
            b += a;
            a =  Math.Abs(a - b); //Use Math.Abs, because the number A is negative
            
            // 3 Variant
            // Works only for single digit numbers
            a = a * 10 + b;
            b = a / 10;
            a %= 10;
            
            // Display the resulted number.
            Console.WriteLine($"The value of the variable \"A\" after swapping is: {a}");
            Console.WriteLine($"The value of the variable \"B\" after swapping is: {b}");
            
            Console.ReadLine();
        }
    }
}