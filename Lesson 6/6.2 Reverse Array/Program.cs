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

            // Display 1 variant Reversed array (using new array)
            int[] newArray = ReverseArrayNewArray(arr);
            Console.WriteLine("The reversed array (using New Array) :");
            ResultArray(newArray);
            Console.WriteLine();
            
            //Display 2 variant Reversed array (using Array.Reverse)
            ReverseArrayReverse(arr);
            Console.WriteLine("The reversed array (using Array.Reverse):");
            ResultArray(arr);
            Console.WriteLine();
            
            //Display 3 variant Reversed array (using a swap of values)
            ReverseArraySwap(arr);
            ReverseArraySwap(arr); //used twice to reverse array, because it was reversed before by ReverseArrayReverse method
            Console.WriteLine("The reversed array (using a swap of values):");
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
        
        //Reverse the array (using new array)
        private static int [] ReverseArrayNewArray(int[] arr)
        {
            int[] reversedArray = new int[arr.Length];
            
            int index = arr.Length;
            foreach (int i in arr)
            {
                reversedArray[index-1] = i;
                index--;
            }
            
            return reversedArray;
        }
        
        //Reverse the array (using Array.Reverse)
        private static void ReverseArrayReverse(int[] arr)
        {
            Array.Reverse(arr);
        }
        
        //Reverse the array (using a swap of values)
        private static void ReverseArraySwap(int[] arr)
        {
            int min = 0;
            int max = arr.Length - 1;
            while (min < max)
            {
                arr[min] += arr[max];
                arr[max] = arr[min] - arr[max]; 
                arr[min] -= arr[max];
                min++;
                max--;
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
    }
}