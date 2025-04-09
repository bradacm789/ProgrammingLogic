namespace Lab4;

class Program
{
    static void Main(string[] args)
    {
        //Part 1 - Simple For Loop
      for (int i = 1; i < 11; i++)
    {
      Console.WriteLine(i);
    }

    {
        Console.WriteLine(" ");
    }

      //Problem 2 - Even Numbers from 1 to 20
      for (int j = 1; j < 21; j++)
    {
      if (j % 2 == 0)
      {Console.WriteLine(j);}
    }

    {
        Console.WriteLine(" ");
    }

    //Problem 3 - While Loop Countdown
      int k = 5;
      while (k > 0)
    {
      {
        Console.WriteLine(k);
        k--;
      } 
    }

    {
        Console.WriteLine(" ");
    }

    //Problem 4 - Do/While User Input
    int n;
    do
      {
        Console.Write("Enter a number greater than 100:");
        n = Convert.ToInt32(Console.ReadLine());
      }
      while (n <100);

    {
      Console.WriteLine(" ");
    }

    //Problem 5 - While Loop - Multiples of 10 from 10 to 1000
    int m = 10;
    while (m < 1001)
      {
        Console.WriteLine(m);
        m+=10;
      }

    {
      Console.WriteLine(" ");
    }

    //Problem 6 - Pattern Printer(Using Nested Loops)
    for (int a = 1; a < 11; a++)
    {
        for (int b = 1; b <= a; b++)
        {
            Console.Write("*");
        }
        Console.WriteLine();
    }

    }
}
