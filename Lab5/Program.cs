using System.Runtime.CompilerServices;

namespace Lab5;

class Program
{
    static void Main(string[] args)
    {
      //Problem 1 - Seasons of the Year
    {
      string[] seasons = new string[4];
      seasons[0] = "Spring";
      seasons[1] = "Summer";
      seasons[2] = "Fall";
      seasons[3] = "Winter";

      foreach (string season in seasons)
      Console.WriteLine("Season: " + season);
    }

    Console.WriteLine();

      //Problem 2 - Days of the Week(1-7)
    {
      string[] days = {"Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };
      string day;
      bool valid = false;

      while (!valid)
      {
      Console.Write("Enter a number (1-7): ");
        day = Console.ReadLine();

        if (day == "1")
        {
            Console.WriteLine("That day is: " + days[0]);
            valid = true;
        }
        else if (day == "2")
        {
            Console.WriteLine("That day is: " + days[1]);
            valid = true;
        }
        else if (day == "3")
        {
            Console.WriteLine("That day is: " + days[2]);
            valid = true;
        }
        else if (day == "4")
        {
            Console.WriteLine("That day is: " + days[3]);
            valid = true;
        }
        else if (day == "5")
        {
            Console.WriteLine("That day is: " + days[4]);
            valid = true;
        }
        else if (day == "6")
        {
            Console.WriteLine("That day is: " + days[5]);
            valid = true;
        }
        else if (day == "7")
        {
            Console.WriteLine("That day is: " + days[6]);
            valid = true;
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a number between 1 and 7.");
        }
      }

      Console.WriteLine();

    }
      //Problem 3 - Favorite Books and Authors
    {
        string[] books = {"The Stand", "The Lion the Witch and the Wardrobe", "Swan Song"};
        string[] authors = {"Stephen King", "C.S. Lewis", "Robert McCammon"};

        for (int i=0; i < books.Length; i++)
        {
          int b = i+1;
          Console.WriteLine("Book " + b +": " + books[i] + " by " + authors[i]);
        }
    }

    Console.WriteLine();

    //Problem 4 - Temperature Tracker
    {
        int[] temperatures = { 65, 72, 78, 70, 68 };

        Array.Sort(temperatures);
        Console.Write("Sorted Temperatures: ");

        foreach (int temp in temperatures)
          {
            Console.Write(temp + " ");
          }

          Console.WriteLine();

        int highTemp = temperatures[temperatures.Length - 1];
        Console.WriteLine("Highest Temperature: " + highTemp);

        int lowTemp = temperatures[0];
        Console.WriteLine("Lowest Temperature: " + lowTemp);
    }

    Console.WriteLine();

    //Problem 5 - Reverse Countdown
    {
        int[] countdown = { 5, 4, 3, 2, 1 };

        Array.Reverse(countdown);
        Console.Write("Countdown: ");

        for (int j=0; j < countdown.Length; j++)
          {
            Console.Write(countdown[j] + " ");
          }
    }
    }
    }