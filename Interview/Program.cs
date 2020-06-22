using System;

namespace Interview
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("What is your name? ");
            string name = Console.ReadLine();
            Console.WriteLine("Hello, " + name + "!");
            Console.WriteLine("And how old are you, " + name + "?");

            int age = int.Parse(Console.ReadLine());

            if (age >= 21)
            {
                Console.WriteLine("You can have a beer after work if you wanna.");
            }
            else {
                Console.WriteLine("You know you best be drinkin' a rootbeer instead!");
            }

            Console.WriteLine("What is your favorite color?");
            string color = Console.ReadLine();
            ConsoleColor bgColor = (ConsoleColor) Enum.Parse(typeof(ConsoleColor), color);
            Console.BackgroundColor = bgColor;
            Console.Clear();
        }
    }
}

