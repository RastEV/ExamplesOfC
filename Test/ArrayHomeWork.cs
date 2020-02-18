using System;

namespace Test
{
    class ArrayHomeWork
    {
        public static double GetMaxNumber(double[] Array)
        {
            double epsilon = 0.0000001;
            double MaxNumber = Array[0];
            foreach(double e in Array)
            {
                if (MaxNumber - e < epsilon)
                {
                    MaxNumber = e;
                }
            }
            return MaxNumber;
        }

        public static String[] ToUpperRegister(String[] strings)
        {
            String Temp;
            for (int i = 0; i < strings.Length; ++i)
            {
                Temp = strings[i].ToUpper();
                strings[i] = Temp;
            }
            return strings;
        }

        public static void Print(String[] Array)
        {
            for(int i = 0; i < Array.Length; ++i)
            {
                Console.WriteLine(Array[i]);
            }
        }

        public static int GetAverage(int[] Numbers)
        {
            int Sum = 0;
            int Count = 0;
            foreach(int e in Numbers)
            {
                if (e % 2 == 0)
                {
                    Sum += e;
                    ++Count;
                }
            }
            return Sum / Count;
        }
        public static int FindNumber(double[] Array, double Number)
        {
            double epsilon = 0.0000001;
            for (int i = 0; i < Array.Length; ++i)
            {
                if (Math.Abs(Array[i] - Number) < epsilon)
                {
                    return i;
                }
            }
            return -1;
        }

        public static void TurnArray(String[] Array)
        {
            String Temp;
            for (int i = 0, j = Array.Length - 1; i < j; ++i, --j)
            {
                Temp = Array[j];
                Array[j] = Array[i];
                Array[i] = Temp;
            }
        }

        public static bool CheckSort(int[] Array)
        {
            bool SortComplete = true;
            for(int i = 1; i < Array.Length; ++i)
            {
                if (Array[i] < Array[i - 1])
                {
                    SortComplete = false;
                }
            }
            return SortComplete;
        }
        public static void Main(string[] args)
        {
            //GetMaxNumber
            double[] Array = {1.5, 6.4, 2.6, 3.6, 6.5, 6};
            Console.WriteLine(GetMaxNumber(Array));
            Console.WriteLine("What number you want to find?");
            //FindNumber
            double UserNumber = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(FindNumber(Array, UserNumber));
            //ToUpper
            String[] StringArray = { "this ", "text ", "in ", "upper ", "case" };
            ToUpperRegister(StringArray);
            Print(StringArray);
            //Average
            int[] Numbers = { 1, 3, 4, 5, 6, 7, 9, 2, 3};
            Console.WriteLine(GetAverage(Numbers));
            //TurnArray
            TurnArray(StringArray);
            Print(StringArray);
            //CheckSort
            int[] SortedNumbers = { 1, 2, 3, 4, 5, 6 };
            Console.WriteLine(CheckSort(Numbers));
            Console.WriteLine(CheckSort(SortedNumbers));
        }
    }
}
