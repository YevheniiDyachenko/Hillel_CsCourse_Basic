namespace _2._3_Book_Information
{
    internal class Program
    {
        static void Main(string[] args)
        {            
            //creating and initializing variables
            string title = "The Lord of the Rings";
            string author = "J. R. R. Tolkien";
            ushort year = 1954;
            double price = 49.99;

            //getting values from the console
            Console.WriteLine("Enter the TITLE of the book (press Enter to use default book):");
            string inputTitle = Console.ReadLine();

            if (inputTitle != "") // when user click Enter , then use the base book 
            {
                title = inputTitle;

                Console.WriteLine("Enter the AUTHOR of the book:");
                author = Console.ReadLine();

                Console.WriteLine("Enter the YEAR of the book:");
                year = Convert.ToUInt16(Console.ReadLine());

                Console.WriteLine("Enter the PRICE of the book:");
                price = Convert.ToDouble(Console.ReadLine());
            }

            //creating formatted string
            string bookInfo = $" Title: {title}\n Author: {author}\n Year: {year}\n Price: {price} UAH";

            //output of the result
            Console.WriteLine("Book Information:");
            Console.WriteLine(bookInfo);
            Console.ReadLine();
        }
    }

}
