namespace Lab2;

class Program
{
    static void Main(string[] args)
    {
     //Step 1 - Variable Declarations
      int a = 59;
      double y = 234.56D;
      float x = 1.354F;
      char myLetter = 'Y';
      bool myBool = false;
      string myString = "Here is a string";
  
      Console.WriteLine("a = " + a);
      Console.WriteLine("y = " + y);
      Console.WriteLine("x = " + x);
      Console.WriteLine("The letter is " + myLetter);
      Console.WriteLine("It is " + myBool);
      Console.WriteLine(myString);

   //Step 2 - Type Casting
      double m = 9.78D;
      int myInt = (int) m;
      Console.WriteLine(myInt);

      int b = 59;
      Console.WriteLine("String: " + Convert.ToString(b));

      bool myBool2 = true;
      Console.WriteLine("String: " + Convert.ToString(myBool2));

   //Step 3 - Declare and Use Variables
      Console.WriteLine("Enter your name ");
      string myName = Console.ReadLine();
      Console.WriteLine("Enter your age ");
      int age = Convert.ToInt32(Console.ReadLine());
      Console.WriteLine("Hello " + myName +" happy " + age + " years of life.");

   //Step 4 - Arithmetic Operators
      int num1 = 45;
      int num2 = 3;
      int sum = num1 + num2;
      Console.WriteLine(num1 + " + " + num2 + " = " + sum);
      int difference = num1 - num2;
      Console.WriteLine(num1 + " - " + num2 + " = " + difference);
      int product = num1*3*num2;
      Console.WriteLine(num1 + " x 3 x " + num2 + " = " + product);
      double quotient = num1/2D;
      Console.WriteLine(num1 + "÷" + num2 + " = " + quotient);
      Console.WriteLine("The remainder after dividing " + num1 + " by " + num2 + " is " + num1%num2);

   //Step 5 - Floating Point Precision
      float num3 = 1.123456789F;
      double num4 = 1.123456789D;
      Console.WriteLine("With Float the output is " + num3 + " and with double the output is " + num4 + ". So float allows for fewer deciaml digits than double.");

   //Step 6 - Increment and Decrement
      int num5 = 10;
      num5++;
      Console.WriteLine(num5);
      num5--;
      num5--; //assuming we want to decrease the original value of num5 by 1
      Console.WriteLine(num5);
}
}
