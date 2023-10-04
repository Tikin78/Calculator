using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {

            try
            {
                Console.WriteLine("Podaj pierwsza liczbę: ");
                //var number1 = int.Parse(Console.ReadLine());
                if (!int.TryParse(Console.ReadLine(), out int number1))
                    throw new Exception("Podana wartość jest nieprawidłowa.");

                Console.WriteLine("Jaką operację chcesz wykonać? Możliwe operacje to: '+', '-','/','*'");
                var action = Console.ReadLine();

                Console.WriteLine("Podaj 2 liczbę:");
                //var number2 = int.Parse(Console.ReadLine());
                if (!int.TryParse(Console.ReadLine(), out int number2))
                    throw new Exception("Podana wartość jest nieprawidłowa.");

                var result = Calculate(number1, number2, action);



                Console.WriteLine("Wynik twojego działania to: " + result);

            }

            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);

            }
        }
            private static int Calculate(int number1, int number2, string action)

            {
                switch (action)
                {
                    case "+":
                        return number1 + number2;
                        
                    case "-":
                        return number1 - number2;
                        
                    case "/":
                        return number1 / number2;
                        
                    case "*":
                        return number1 * number2;
                        
                    default:
                        throw new Exception("Wybrałeś złą operację!");

                }
            }
        }
    }



