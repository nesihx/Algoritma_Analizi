using System;

namespace Iterativenumara
{
    class Program
    {
        static int enbuyuk(int[] arr)
        {
            if (arr.Length == 0)
            {
                throw new ArgumentException("Dizi boş olamaz.");
            }

            int numara = arr[0]; 

            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] > numara)
                {
                    numara = arr[i];
                }
            }

            return numara;
        }

        static void Main(string[] args)
        {
            int[] myArray = { 10, 5, 20, 15, 30, 40, 10, 60, 75, 1, 35, 24, 98, 14, 41 };
            int result = enbuyuk(myArray);

            Console.WriteLine($"Dizideki en büyük sayı: {result}");
        }
    }
}
