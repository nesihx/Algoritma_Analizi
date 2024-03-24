using System;

namespace FaktoriyelBulma
{
    class Program
    {
        static long Faktoriyel(int n)
        {
            if (n == 0)
                return 1;
            else
                return n * Faktoriyel(n - 1);
        }

        static void Main(string[] args)
        {
            Console.Write("Bir sayı girin: ");
            int sayi = Convert.ToInt32(Console.ReadLine());

            long faktoriyel = Faktoriyel(sayi);
            Console.WriteLine($"Grilen sayının faktöriyeli: {faktoriyel}");
        }
    }
}
