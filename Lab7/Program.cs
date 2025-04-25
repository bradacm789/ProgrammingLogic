namespace Lab7;

// Problem 1: Create a Class with a Default Constructor
class Book
{
    private string title;

    public Book()  // Default Constructor
    {
        title = "The Stand";
    }

    public string GetTitle()
    {
        return title;
    }

    public void SetTitle(string newTitle)
    {
        title = newTitle;
    }

//Problem 2: Add a Parameterized Constructor

public Book(string titleName)
  {
    title = titleName;
  }


}

class Program
{
    static void Main(string[] args)
    {
        Book book1 = new Book();
        Console.WriteLine(book1.GetTitle());  // Output: Unknown Title

        book1.SetTitle("C# Fundamentals");
        Console.WriteLine(book1.GetTitle());  // Output: C# Fundamentals

        Console.WriteLine();

        Book book2 = new Book("Advanced c#");
        Console.WriteLine(book2.GetTitle());
    }
}
