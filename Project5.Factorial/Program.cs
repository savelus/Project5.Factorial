using System;
using System.Threading;

namespace Project5.Factorial
{
    class Program
    {
        static int GetFactorial(int number)
        {
            if (number == 0)
                return 1;
            else
                return number * GetFactorial(--number);
        }

        static int GetLength (int number)
        {
            return number.ToString().Length;
        }

        static void DrawTable (int factorial, int number )
        {
            Console.SetCursorPosition(0, 0);
            int lengthnumber = GetLength(number);
            int lengthfactorial = GetLength(factorial);
            Console.WriteLine("╔" + new string('═', lengthnumber + lengthfactorial + 5) + "╗");
            Console.WriteLine("║ " + number + " ║ " + factorial + " ║");
            Console.WriteLine("╚" + new string('═', lengthnumber + lengthfactorial + 5) + "╝");
        }

        static void Output(int factorial, int number)
        {
            
            int i = 0;
            ConsoleColor[] colors = (ConsoleColor[])ConsoleColor.GetValues(typeof(ConsoleColor));
            while (true)
            {
                Console.BackgroundColor = colors[i % 16];
                Console.ForegroundColor = colors[(i + 1) % 16];
                DrawTable(factorial, number);
                Thread.Sleep (500);
                ++i;
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Введите число, факториал которого хотите получить");
            int number = int.Parse(Console.ReadLine());
            int factorial = GetFactorial(number);
            Console.Clear();
            Output(factorial, number);
            Console.ReadKey();
        }
    }
}
