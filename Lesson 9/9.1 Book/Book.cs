namespace _9._1_Book;

class Book
{
    // Properties
    public string title;
    public string author;
    public int yearOfPublication;
    public int numberOfPages;
    
    // Default constructor
    public Book()
    {
        title = "";
        author = "";
        yearOfPublication = 0;
        numberOfPages = 0;
    }
    
    // 1. DisplayInfo Methods 
    public void DisplayInfo()
    {
        Console.WriteLine($"Title: {title}");
        Console.WriteLine($"Author: {author}");
        Console.WriteLine($"Year of publication: {yearOfPublication}");
        Console.WriteLine($"Number of pages: {numberOfPages}");
    }

   // 2. IsThick Methods 
    public void IsThick()
    {
        if (numberOfPages > 500)
        {
            Console.WriteLine("This book is thick!");
        }
        else
        {
            Console.WriteLine("This book is not so thick.");
        }
    }
}