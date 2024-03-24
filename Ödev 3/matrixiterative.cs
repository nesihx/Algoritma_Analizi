using System;

namespace MatrixMultiplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Matrisin boyutunu girin: ");
            int n = Convert.ToInt32(Console.ReadLine());

            int[,] matris1 = new int[n, n];
            int[,] matris2 = new int[n, n];
            int[,] sonuc = new int[n, n];
            Console.WriteLine("\nİlk matrisin elemanlarını girin:");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write("Eleman [" + i + "][" + j + "]'yi girin: ");
                    matris1[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            Console.WriteLine("\nİkinci matrisin elemanlarını girin:");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write("Eleman [" + i + "][" + j + "]'yi girin: ");
                    matris2[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    for (int k = 0; k < n; k++)
                    {
                        sonuc[i, j] += matris1[i, k] * matris2[k, j];
                    }
                }
            }

            Console.WriteLine("\nMatris çarpımının sonucu:");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(sonuc[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
