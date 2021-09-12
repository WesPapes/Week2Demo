using System;

class Program {
  public static void Main (string[] args) {
    /*Console.WriteLine("Enter your name");
    string profName = Console.WriteLine();
    profName = "Mrs. " + profName;
    Console.WriteLine("Hello " + profName);

    Console.WriteLine("Enter your age");
    int age = Convert.ToInt32(Console.ReadLine());//"35"
    Console.WriteLine("Your age is " + age);

    //456.987
    Console.WriteLine("Enter what you paid for your shirt");
    double cost = Convert.ToDouble(Console.ReadLine()));

    Console.WriteLine("+, -, *, /, %");
*/
    Console.WriteLine("Enter selling price");
    double sp = Convert.ToDouble(Console.ReadLine());

    Console.WriteLine("Enter tax as %");
    double tax = Convert.ToDouble(Console.ReadLine());

    double fp = sp + (sp-tax/100);

    Console.WriteLine("Final price is $ " + fp);

  }
}