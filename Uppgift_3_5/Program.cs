using System;
namespace calcuator
{
    class Program
    {
        static void Main(string[] args)
        {
            string yn;
            do
            {
                Console.WriteLine("Type a number:");
                int num1 = int.Parse(Console.ReadLine());
                Console.WriteLine("Type a second number:");
                int num2 = int.Parse(Console.ReadLine());
                Console.WriteLine("Now choose which way you want to calculate it. (+ - * / % ^)");
                string count = Console.ReadLine();

                switch (count)
                {
                    case "+":
                        Console.WriteLine("The addition of your numbers is: " + (num1 + num2));
                        Console.ReadKey();
                        break;
                    case "-":
                        Console.WriteLine("The substraction of your numbers is: " + (num1 - num2));
                        Console.ReadKey();
                        break;
                    case "*":
                        Console.WriteLine("The multiplikation of your nubers is: " + (num1 * num2));
                        Console.ReadKey();
                        break;
                    case "/":
                        Console.WriteLine("The division of your numbers is: " + (num1 / num2));
                        Console.ReadKey();
                        break;
                    case "%":
                        Console.WriteLine("The modulo of your numbers is: " + (num1 % num2));
                        Console.ReadKey();
                        break;
                    case "^":
                        Console.WriteLine(num1 + " to the power of " + num2 + " is: " + Math.Pow(num1, num2));
                        Console.ReadKey();
                        break;
                    default:
                        Console.WriteLine("Tell the program creator to add this thing please!");
                        Console.ReadLine();
                        break;

                }

                Console.WriteLine("Do you want to continue? (y/n)");
                yn = Console.ReadLine();
            }
            while (yn == "y" || yn == "Y");
        }
    }
}
