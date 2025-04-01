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
    Console.WriteLine("Enter your age.");
    int userAge = int.Parse(Console.ReadLine());

    if (userAge <5)
      {
        Console.WriteLine("Ticket is free!");
      }
    else if (userAge >=5 && userAge <13)
      {
        Console.WriteLine("Child ticket: $5");
      }
    else if (userAge >=13 && userAge <65)
      {
        Console.WriteLine("Standard ticket: $10");
      }
    else
      {
        Console.WriteLine("Senior ticket: $6");
      }

      //Part 4 - Using a Switch Statement
      Console.WriteLine("Using numbers 1-7, enter a day of the week.");
      int day = Convert.ToInt32(Console.ReadLine());

      switch (day)
      {
      case 1:
        Console.WriteLine("Monday");
        break;
      case 2:
        Console.WriteLine("Tuesday");
        break;
      case 3:
        Console.WriteLine("Wednesday");
        break;
      case 4:
        Console.WriteLine("Thursday");
        break;
      case 5:
        Console.WriteLine("Friday");
        break;
      case 6:
        Console.WriteLine("Saturday");
        break;
      case 7:
        Console.WriteLine("Sunday");
        break;
      default:
        Console.WriteLine("Invalid Day!");
        break;
      }
    }
}
