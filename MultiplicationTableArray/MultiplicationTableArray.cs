using System;

namespace MultiplicationTableArray
{
    class MultiplicationTableArray
    {
        public static void Print(int[,] Array)
        {
            for (int i = 0; i < Array.GetLength(0); ++i)
            {
                Console.WriteLine();
                for (int j = 0; j < Array.GetLength(1); ++j)
                {
                    Console.Write("{0,3}", Array[i,j]);
                }
            }
        }

        public static int[,] GetMultiplicationTable(int size1, int size2)
        {
            int[,] multiplicationTable = new int[size1, size2];
            for (int i = 0; i < size1; ++i)
            {
                for (int j = 0; j < size2; ++j)
                {
                    multiplicationTable[i,j] = (i + 1) * (j + 1);
                }
            }
            return multiplicationTable;
        }

        public static void Main(string[] args)
        {
            Console.WriteLine("Первый множитель");
            int size1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Второй множитель");
            int size2 = Convert.ToInt32(Console.ReadLine());

            Print(GetMultiplicationTable(size1, size2));

        }
    }
}
