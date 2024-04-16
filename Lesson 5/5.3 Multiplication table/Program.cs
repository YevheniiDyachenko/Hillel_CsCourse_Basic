namespace _5._3_Multiplication_table
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a multiplication table from 1 to 5.
            MultiplicationTable(1, 5);
            
            Console.WriteLine("\n");

            // Create a multiplication table from 6 to 10.
            MultiplicationTable(6, 10);

            Console.ReadLine();
        }

        // Create a multiplication table.
        private static void MultiplicationTable(int min, int max)
        {
            for (int j = 1; j <= 10; j++)
            {
                for (int i = min; i <= max; i++)
                {
                    Console.Write($"{i} * {j} = {i * j} \t");
                }
                
                Console.WriteLine();
            }
        }
    }
}