namespace _3._5_Сircle_area
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Get a radius from the user.
            Console.WriteLine("Enter a radius: ");
            double radius = Convert.ToDouble(Console.ReadLine());
            
            // Calculate the area of a circle.
            double area = Math.PI * Math.Pow(radius,2 );
            
            // Display the area of a circle.
            Console.WriteLine($"The area of a circle with radius {radius} is {area}.");
            
            Console.ReadLine();
        }
    }
}