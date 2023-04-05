using System;

namespace FirstApplication.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What's your name?");
            string name = Console.ReadLine();
            Console.WriteLine("Hello, {0}!", name);
            Console.WriteLine("How old are you?");
            string age = Console.ReadLine();
            Console.WriteLine("Where do you live?");
            string city = Console.ReadLine();
            Console.WriteLine("{0} is a wonderful city!", city);
            Console.WriteLine("Let's check your information, your name is {0}, your age is {1}, you live in {2}.", name, age, city);
        }
    }
}