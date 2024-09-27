using System;

namespace ConsoleApp21
{
    internal class Program
    {
        private static double result;

        public static void Main()
        {

            {





                // Task3
                Console.WriteLine("Task Third");

                double x = 4;
                double y = 5;

                Console.WriteLine("1 - Додавання");
                Console.WriteLine("2 - Віднімання");
                Console.WriteLine("3 - Множення");
                Console.WriteLine("4 - Ділення");
                Console.WriteLine("5 - Піднесення до степеня");
                Console.Write("Введіть номер операції: ");

                switch (Convert.ToInt32(Console.ReadLine()))
                {
                    case 1:
                        result = x + y;
                        Console.WriteLine("Результат додавання: " + result);
                        break;


                    case 2:
                        result = x - y;
                        Console.WriteLine("Результат віднімання: " + result);
                        break;

                    case 3:
                        result = x * y;
                        Console.WriteLine("Результат множення: " + result);
                        break;

                    case 4:
                        if (y != 0)
                        {
                            result = x / y;
                            Console.WriteLine("Результат ділення: " + result);
                        }
                        else
                        {
                            Console.WriteLine("Помилка: Ділення на нуль!");
                        }
                        break;

                    case 5:
                        result = Math.Pow(x, y);
                        Console.WriteLine("Результат піднесення до степеня: " + result);
                        break;

                    default:
                        Console.WriteLine("Неправильний номер операції.");
                        break;
                }
            }
        }
    }
}