using System;

namespace Tuts
{
     class Program
     {
          static void Main(string[] args)
          {
              Console.WriteLine("----Calculator----");
              symbols = Console.ReadLine("Choose Operand (+,-,/,*)");
          
               //Operand Section
              int value1 = Console.ReadLine(Console.WriteLine("Enter Value 1: "));
              int value2 = Console.ReadLine(Console.WriteLine("Enter Value 2: "));

              if (symbols == "+")
               {
                    solution = value1 + value2;
                    Console.WriteLine(solution);
               }
               else if (symbols == "-")
               {
                    solution = value1 - value2;
                    Console.WriteLine(solution);
               }
               else if (symbols == "/")
               {
                    solution = value1 / value2;
                    Console.WriteLine(solution);
               }
               else if (symbols == "*")
               {
                    solution = value1 * value2;
                    COnsole.WriteLine(solution);
               }
               else
               {
                    Console.WriteLine("Invalid Operand, Try again....");
               }
          }
     }
}
