namespace _16._1_LINQ
{
    class Program
{
    static void Main()
    {
        Console.InputEncoding = System.Text.Encoding.Unicode;
        Console.OutputEncoding = System.Text.Encoding.Unicode;
        
        // 1. Filtration
        int [] numbers = { 2, 5, 8, 12, 15, 18, 22 };
        IEnumerable<int> outnumbers = numbers.Where(n => n > 10);
        PrintResults("1. Filtration", numbers, outnumbers);
        
        // 2. Sorting
        string[] fruits = { "Яблуко", "Апельсин", "Банан", "Ківі" };
        IOrderedEnumerable<string> sortedFruits = fruits.OrderBy(f => f);
        PrintResults("2. Sorting", fruits, sortedFruits);


        // 3. Deduplication
        List<string> strings = new List<string> { "А", "Б", "В", "А", "Г", "В" };
        IEnumerable<string> distinctStrings = strings.Distinct();
        PrintResults("3. Deduplication", strings, distinctStrings);

        // 4. Calculation
        int[] grades = { 85, 92, 78, 95, 88, 90 };
        var countHighGrades = grades.Count(g => g > 90);
        PrintResults("4. Calculation.", grades, grades);
        Console.WriteLine($"Students with grades greater than 90: {countHighGrades}");

        // 5. Filtering and sorting
        List<Product> products = new List<Product>
        {
            new() { Name = "Milk", Price = 45 },
            new() { Name = "Apple", Price = 55 },
            new() { Name = "Bread", Price = 35 },
            new() { Name = "Tea", Price = 25 },
            new() { Name = "Meat", Price = 60 }
        };
        IOrderedEnumerable<Product> filteredAndSortedProducts = products.Where(p => p.Price < 50).OrderBy(p => p.Price);
        PrintResults("5 Filtering and sorting. (less than 50)", products, filteredAndSortedProducts);

        // 6. Finding the maximum number and its index
        int[] nums = { 10, 25, 8, 45, 15, 30, 55, 5 };
            //  int maxIndex = numbers.IndexOf(nums.Max());
        int maxIndex = Array.IndexOf(nums, nums.Max());
        PrintResults("6. Finding the maximum number and its index", nums, nums);
        Console.WriteLine("Index of the maximum number: " + maxIndex);

    }

    class Product
    {
        public string Name { get; set; }
        public int Price { get; set; }
        
        public override string ToString()
        {
            return $"{Name}: {Price} UAH";
        }
    }
    
    static void PrintResults<T>(string operationName, IEnumerable<T> originalItems, IEnumerable<T> resultItems)
    {
        Console.WriteLine($"\n{operationName}");
        Console.WriteLine("Original items: " + string.Join(", ", originalItems));
        Console.WriteLine("Result items: " + string.Join(", ", resultItems));
        Console.WriteLine("----");
    }
}
    
}

