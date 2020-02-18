using System;

namespace Palindrome
{
    class Palindrome
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write words");
            String UserLine = Console.ReadLine();
            bool IsPalendrom = true;
            for(int i = 0, j = UserLine.Length - 1; i <= j; ++i, --j)
            {
                while(!char.IsLetter(char.ToLower(UserLine[i])))
                {
                    ++i;
                }
                while (!char.IsLetter(char.ToLower(UserLine[j])))
                {
                    --j;
                }
                if (char.ToLower(UserLine[i]) != char.ToLower(UserLine[j]))
                {
                    IsPalendrom = false;
                }
            }
            Console.WriteLine(IsPalendrom);
        }
    }
}
