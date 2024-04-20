namespace _6._1_Array_of_10_elements
{
    class Program
    {
        private static void Main(string[] args)
        {
            //Create an array of 10 elements
            var arr = new int[10];

            //Generate random elements from -100 to 100
            GenerateRandomElements(arr);

            //Display array elements
            Console.WriteLine("Array elements:");
            ResultArray(arr);
            Console.WriteLine();

            //Display positive integers
            Console.WriteLine("The number of positive numbers: {0}", CountPositiveNumbers(arr));
            Console.ReadLine();
        }

        //Generate random elements from -100 to 100
        private static void GenerateRandomElements(int[] arr)
        {
            Random random = new Random();
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = random.Next(-100, 101);
            }
        }

        // Count the number of positive integers in an array
        private static int CountPositiveNumbers(int[] arr)
        {
            var count = 0;
            
            // Iterate over the array elements
            // Increment the count if the element is positive
            foreach (var i in arr)
            {
                if (i > 0)
                {
                    count++;
                }
            }
            
            // Return the count of positive integers
            return count;
        }
        
        // Display array elements
        private static void  ResultArray(int[] arr)
        {
            foreach (var i in arr)
            {
                Console.Write("{0} ", i);
            }

            Console.WriteLine();
        }
    }
}
