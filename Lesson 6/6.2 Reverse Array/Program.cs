namespace _6._2_Reverse_Array
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

            //1 variant Display Reversed array
            ReverseArray(arr);
            Console.WriteLine("The reversed array:");
            ResultArray(arr);
            Console.WriteLine();
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

        //Reverse the array
        private static void ReverseArray(int[] arr)
        {
            Array.Reverse(arr);
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
    }
}