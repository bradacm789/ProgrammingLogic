namespace Lab7;

class Book
{
    private string title;
    private string author;

// Problem 1: Create a Class with a Default Constructor
    public Book()  // Default Constructor
    {
        title = "The Stand";
        author = "Stephen King";
    }

//Problem 2: Add a Parameterized Constructor

public Book(string titleName)
  {
    title = titleName;
    author = "Stephen King";
  }

//Problem 3: Constructor Overloading

public Book(string titleName, string authorName)
  {
    title = titleName;
    author = authorName;
  }  

public string GetTitle()
    {
        return title;
    }

    public void SetTitle(string newTitle)
    {
        title = newTitle;
    }

    public string GetAuthor()
    {
        return author;
    }

    public void SetAuthor(string newAuthor)
    {
        author = newAuthor;
    }

}

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine();
        
        Book book1 = new Book();
        Console.WriteLine(book1.GetTitle());  // Output: Unknown Title

        book1.SetTitle("C# Fundamentals");
        Console.WriteLine(book1.GetTitle());  // Output: C# Fundamentals

        Console.WriteLine();

        Book book2 = new Book("Advanced c#");
        Console.WriteLine(book2.GetTitle());

        Console.WriteLine();

        Book book3 = new Book("Frankenstein", "Mary Shelley");
        Console.WriteLine("Title: " + book3.GetTitle());
        Console.WriteLine("Author: " + book3.GetAuthor());

        Console.WriteLine();

        Book book4 = new Book();
        book4.SetTitle("Dracula");
        book4.SetAuthor("Bram Stoker");
        Console.WriteLine("Title: " + book4.GetTitle());
        Console.WriteLine("Author: " + book4.GetAuthor());

        Console.WriteLine();
    }
}
