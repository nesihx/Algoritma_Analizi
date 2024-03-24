using System;

namespace FaktoriyelHesaplama
{
    class Program
    {
        static long FaktoriyelH(int n)
        {
            long result = 1;
            for (int i = 1; i <= n; i++)
            {
                result *= i;
            }
            return result;
        }

        static void Main(string[] args)
        {
            Console.Write("Bir sayı girin: ");
            int sayi = Convert.ToInt32(Console.ReadLine());

            long faktoriyel = FaktoriyelH(sayi);
            Console.WriteLine($"Girilen sayının faktöriyeli: {faktoriyel}");
        }
    }
}
