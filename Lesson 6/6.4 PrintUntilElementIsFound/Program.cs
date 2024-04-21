namespace _6._4_PrintUntilElementIsFound
{
    class Program
    {
        private static void Main(string[] args)
        {
            //Create an array of 10 elements
            var arr = new int[100];

            //Generate random elements from -100 to 100
            GenerateRandomElements(arr);
            
            //Display array elements
            Console.WriteLine("Array elements:");
            ResultArray(arr);
            Console.WriteLine();

            //Display array elements until the element -1 is found
            Console.WriteLine("Array elements before -1:");
            ResultArrayBefore(arr);
            Console.WriteLine();
        }

        //Generate random elements from -5 to 5
        private static void GenerateRandomElements(int[] arr)
        {
            Random random = new Random();
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = random.Next(-5, 6);
            }
        }
        
        // Display array elements
        private static void ResultArray(int[] arr)
        {
            foreach (var i in arr)
            {
                Console.Write("{0} ", i);
            }

            Console.WriteLine();
        }
        
        // Display array elements until the element -1 is found
        private static void ResultArrayBefore(int[] arr)
        {
            foreach (var i in arr)
            {
                if (i != -1)
                {
                    Console.Write("{0} ", i);
                }
                else
                {
                    break;
                }
            }
            Console.WriteLine();
        }
    }
}