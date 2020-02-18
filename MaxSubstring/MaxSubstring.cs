using System;

namespace MaxSubstring
{
    class MaxSubstring
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write your string");
            String UserString = Console.ReadLine();

            int MaxSubstring = 1;
            int CurrentSubstring = 1;

            for (int i = 1; i < UserString.Length; ++i)
            {
                if (char.ToLower(UserString[i]) == char.ToLower(UserString[i - 1]))
                {
                    ++CurrentSubstring;
                }
                else if (CurrentSubstring > MaxSubstring)
                {
                    MaxSubstring = CurrentSubstring;
                    CurrentSubstring = 1;
                }
                else
                {
                    CurrentSubstring = 1;
                }
            }

            Console.WriteLine(MaxSubstring > CurrentSubstring ? MaxSubstring : CurrentSubstring);


        }
    }
}
