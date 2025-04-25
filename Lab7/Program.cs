namespace Lab7;

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
}

class Program
{
    static void Main(string[] args)
    {
        Book book1 = new Book();
        Console.WriteLine(book1.GetTitle());  // Output: Unknown Title

        book1.SetTitle("C# Fundamentals");
        Console.WriteLine(book1.GetTitle());  // Output: C# Fundamentals
    }
}
