namespace _9._1_Book;

class Book
{
    // Properties
    private string title;
    private string author;
    private int yearOfPublication;
    private int numberOfPages;

    // Default constructor
    public Book(string title, string author, int yearOfPublication, int numberOfPages)
    {
        this.title = title;
        this.author = author;
        this.yearOfPublication = yearOfPublication;
        this.numberOfPages = numberOfPages;
    }

    // 1. GetBookInfo  Method 
    public string GetBookInfo()
    {
        return $"Title: {title}\n" +
               $"Author: {author}\n" +
               $"Year of publication: {yearOfPublication}\n" +
               $"Number of pages: {numberOfPages}";
    }

    // 2. IsThick Method
    public string IsThick()
    {
        if (numberOfPages > 500)
        {
            return "This book is thick!";
        }
        else
        {
            return "This book is not so thick.";
        }
    }
}