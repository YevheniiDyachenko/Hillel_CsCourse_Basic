namespace _11._2_AgeInputExceptionHandling
{
    class Program
    {
        static void Main()
        {
            while (true)
            {
                try
                {
                    Console.Write("Enter your age: ");
                    string input = Console.ReadLine();
                    
                    if (!int.TryParse(input, out int age))
                    {
                        throw new FormatException("The age must be an integer.");
                    }

                    if (age < 0)
                    {
                        throw new FormatException("The age cannot be less than 0.");
                    }

                    Console.WriteLine($"Your age: {age}");
                    break; 
                }
                catch (FormatException ex)
                {
                    Console.WriteLine($"Format error: {ex.Message}");
                }
            }
        }
    }
}