using System;

namespace DecimalToBinary
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Bir Sayi Giriniz:");
            int sayi=Convert.ToInt32(Console.ReadLine());
            Console.Write($"Sayının ikili temsillemesi: ");
            onluktanikilye(sayi);
            Console.WriteLine();
        }
        //iteratif algoritmanın zaman karmaşıklığı da O(log n)'dir
        static void onluktanikilye(int n)
        {
        //İteratif algoritma, sabit boyutlu bir dizi (binaryArray) kullanır ve bu nedenle bellek karmaşıklığı O(1)'dir.
            int[] binaryArray = new int[32]; 
            int i = 0;
            while (n > 0)
            {
                binaryArray[i] = n % 2;
                n = n / 2;
                i++;
            }
            for (int j = i - 1; j >= 0; j--)
            {
                Console.Write(binaryArray[j]);
            }
        }
    }
}
