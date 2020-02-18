using System;

namespace BeginC
{
    class SimbolCount
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Write string");
            String UserString = Console.ReadLine();
            int DigitCount = 0;
            int LetterCount = 0;
            int WhitespaceCount = 0;
            int OtherSimbolCount = 0;

            for (int i = 0; i < UserString.Length; ++i)
            {
                if (char.IsDigit(UserString[i]))
                {
                    ++DigitCount;
                }
                else if (char.IsLetter(UserString[i]))
                {
                    ++LetterCount;
                }
                else if (char.IsWhiteSpace(UserString[i]))
                {
                    ++WhitespaceCount;
                }
                else
                {
                    ++OtherSimbolCount;
                }

            }

            Console.WriteLine("In your string: {0} digits, {1} letters, {2} Whitespaces, {3} other simbols", DigitCount, LetterCount, WhitespaceCount, OtherSimbolCount);
        }
    }
}
