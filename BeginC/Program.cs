using System;

namespace BeginC
{
    class Program
    {
        public static void print(int number)
        {
            Console.WriteLine(number);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Program.print(55);
            String pass = "1234";
            Console.WriteLine("Введите пароль");
            String userPass = Console.ReadLine();

            if (userPass == pass)
            {
                Console.WriteLine("Пароль верен");
            }
            else if (userPass.Length > pass.Length)
            {
                Console.WriteLine("Слишком длинный пароль");
            }
            else if (userPass.Length < pass.Length)
            {
                Console.WriteLine("Короткий пароль");
            }
            else
            {
                Console.WriteLine("Не верный пароль");
            }
        }
    }
}
