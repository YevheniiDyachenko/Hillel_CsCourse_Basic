using System;

namespace _9._1_Book
{
    class Program
    {
        static void Main(string[] args)
        {
            // First Book
            Book book1 = new Book("The Great Gatsby", "F. Scott Fitzgerald", 1925, 180);

            // Second Book
            Book book2 = new Book("To the Lighthouse", "Virginia Woolf", 1927, 240);

            // Third Book
            Book book3 = new Book("Pride and Prejudice", "Jane Austen", 1813, 279);
            
            // Fourth Book
            Book book4 = new Book("The Lord of the Rings", "J.R.R. Tolkien", 1954, 1178);
            
            // Fifth Book
            Book book5 = new Book("The Catcher in the Rye", "J.D. Salinger", 1951, 224);

            
            // Print the books
            Book[] books = { book1, book2, book3, book4, book5 };
            Console.WriteLine("------------");
            Console.WriteLine("Our Books:");
            Console.WriteLine();
            DisplayAllBooksInfo(books);
        }

        // Display all books info
        static void DisplayAllBooksInfo(Book[] books)
        {
            foreach (Book book in books)
            {
                Console.WriteLine("Book #" + (Array.IndexOf(books, book) + 1) + ":");
                Console.WriteLine(book.GetBookInfo());
                Console.WriteLine(book.IsThick());
                Console.WriteLine();
            }
        }
    }
}