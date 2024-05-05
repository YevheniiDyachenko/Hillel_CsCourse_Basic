using System;

namespace _9._1_Book
{
    class Program
    {
        static void Main(string[] args)
        {
            // First Book
            Book book1 = new Book();
            book1.title = "The Great Gatsby";
            book1.author = "F. Scott Fitzgerald";
            book1.yearOfPublication = 1925;
            book1.numberOfPages = 180;

            // Second Book
            Book book2 = new Book();
            book2.title = "To the Lighthouse"; 
            book2.author = "Virginia Woolf"; 
            book2.yearOfPublication = 1927;
            book2.numberOfPages = 240; 

            // Third Book
            Book book3 = new Book();
            book3.title = "Pride and Prejudice";
            book3.author = "Jane Austen";
            book3.yearOfPublication = 1813;
            book3.numberOfPages = 279;
            
            // Fourth Book
            Book book4 = new Book();
            book4.title = "The Lord of the Rings";
            book4.author = "J.R.R. Tolkien";
            book4.yearOfPublication = 1954;
            book4.numberOfPages = 1178;
            
            // Fifth Book
            Book book5 = new Book();
            book5.title = "The Catcher in the Rye";
            book5.author = "J.D. Salinger";
            book5.yearOfPublication = 1951;
            book5.numberOfPages = 224;
            
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
                book.DisplayInfo();
                book.IsThick();
                Console.WriteLine();
            }
        }
    }
}