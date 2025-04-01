namespace Lab3;

class Program
{
    static void Main(string[] args)
    {
        //Part 1 - Operator Practice
      int a = 10;
      int b = 5;
      int c = 15;
  
      Console.WriteLine("a > b: " + (a >b));
      Console.WriteLine("a < c: " + (a < c));
      Console.WriteLine("a > b and a > c: " + (a > b && a > c));
      Console.WriteLine("a > b or a > c: " + (a > b || a > c));

      //Part 2 - Boolean Logic
      bool isRaining = true;
      bool haveUmbrella = false;

      if (isRaining && !haveUmbrella)
        {
          Console.WriteLine("Take an umbrella!");
        }
      else
        {
          Console.WriteLine("You're good to go!");
        }  

      //Part 3 - Movie Ticket Pricing

      //Part 4 - Using a Switch Statement
    }
}
