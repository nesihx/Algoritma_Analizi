using System;

namespace ikilisayidonusturucu
{
    class Program
    {
        static void Main(string[] args)
        {
        //Özyinelemeli algoritmanın derinliği, girdi olarak verilen ondalık sayının logaritmasıdır (log2(n))
            Console.Write("Sayi Giriniz:");
            int numara=Convert.ToInt32(Console.ReadLine());
            Console.Write($"Sayının ikili temsillemesi: ");
            onluktanikiliye(numara);
            Console.WriteLine();
        }
        //özyinelemeli algoritmanın karmaşıklığı O(log n)'dir.
        static void onluktanikiliye(int n)
        {
            if (n > 1)
                onluktanikiliye(n / 2);

            Console.Write(n % 2);
        }
    }
}
