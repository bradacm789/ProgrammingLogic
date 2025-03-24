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
      Console.WriteLine("It is " + myLetter);
      Console.WriteLine(myString);

   //Step 2 - Type Casting
      double y = 9.78D;
      int myInt = (int) y;
      Console.WriteLine(myInt);

      int a = 59;
      Console.WriteLine("String: " + Convert.ToString(a));

      bool myBool2 = true;
      Console.WriteLine("String: " + Convert.ToString(myBool2));

   //Step 3 - Declare and Use Variables
      Console.WriteLine("Enter your name ");
      string myName = Console.ReadLine();
      Console.WriteLine("Enter your age ");
      int age = Convert.ToInt32(Console.ReadLine());
      Console.WriteLine("Hello " + myName +" happy " + age + " years of life.");
}
