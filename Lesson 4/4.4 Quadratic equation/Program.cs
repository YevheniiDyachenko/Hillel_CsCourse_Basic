namespace _4._4_Quadratic_equation_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Generate the coefficients a, b, c  using the Random class.
            int a = GenerateCoefficient(-100, 100);
            int b = GenerateCoefficient(-100, 100);
            int c = GenerateCoefficient(-100, 100);

            // Display the equation in the console.
            Console.WriteLine($"The equation is: {a}x^2 + ({b}x) + ({c})= 0");

            // Calculate the discriminant.
            double discriminant = CalculateDiscriminant(a, b, c);

            // Display the discriminant in the console.
            Console.WriteLine($"The discriminant is: {discriminant}");

            // Calculate the roots.
             (double root1, double root2) = CalculateRoots(a, b, discriminant);

            // Inform the user about the number of roots.
            switch (discriminant)
            {
                case 0:
                    Console.WriteLine($"The equation has one root: x = {root1}");
                    break;
                case > 0:
                    Console.WriteLine($"The equation has two roots: x1 = {root1} and  x2 = {root2}");
                    break;
                default:
                    Console.WriteLine("The equation has no roots.");
                    break;
            }
        }

// Random class for generating coefficients
        static int GenerateCoefficient(int min, int max)
        {
            Random rand = new Random();
            return rand.Next(min, max);
        }

// Calculate the discriminant.
        static double CalculateDiscriminant(int a, int b, int c)
        {
            return b * b - 4 * a * c;
        }

// Calculate the roots.
        static (double, double) CalculateRoots(int a, int b, double discriminant)
        {
            double root1 = (-b + Math.Sqrt(discriminant)) / (2 * a);
            double root2 = (-b - Math.Sqrt(discriminant)) / (2 * a);
            return (root1, root2);
        }
    }
}