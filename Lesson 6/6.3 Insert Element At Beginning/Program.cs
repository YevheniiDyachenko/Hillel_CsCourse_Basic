namespace _6._3_Insert_Element_At_Beginning
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

            // Display th array with new element
            AddElementAtBeginning(arr);
            Console.WriteLine("The array with new element:");
            ResultArray(arr);
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
        
        // Adding an element to the beginning of an array
        static int[] AddElementAtBeginning(int[] arr)
        {
            // Creating a new array extended by one element
            int[] newArray = new int[arr.Length + 2];

            // Copying elements of the original array to a new array, shifting by one element
           // Array.Copy(arr, 0, newArray, 1, arr.Length);
           GenerateRandomElements(newArray);
            // Adding a new item to the beginning of the array
            Random random = new Random();
            int element = random.Next(-100, 101);
            newArray[0] = element;

            // Assigning a reference to a new array
            return arr = newArray;
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