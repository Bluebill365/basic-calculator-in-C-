using System;

namespace Tuts
{
     class Program
     {
          static void Main(string[] args)
          {

               int number1, number2, result;
               string answer;

              Console.WriteLine("----Calculator----");
              Console.WriteLine("Enter the first number: ");
             number1 = Convert.ToInt32(Console.ReadLine());

             Console.WriteLine("Enter the second number: ");
             number2 = Convert.ToInt32(Console.ReadLine());

             Console.WriteLine("Enter your Operations (+, -, *, /): ");
             answer = Console.ReadLine();

             if (answer == "+")
               {
                    result = number1 + number2;
                    Console.WriteLine("Answer: " + result);
               }
               else if (answer == "-")
               {
                    result = number1 - number2;
                    Console.WriteLine("Answer: " + result);
               }
             Console.ReadKey();
          }
     }
}
