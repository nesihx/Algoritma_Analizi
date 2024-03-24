using System;

namespace RecursiveMatrixMultiplication
{
    class Program
    {
        static int[,] MatrisCarpimi(int[,] matris1, int[,] matris2, int n)
        {
            if (n == 1)
            {
                return new int[,] { { matris1[0, 0] * matris2[0, 0] } };
            }

            int nunYarisi = n / 2;

            int[,] a = new int[nunYarisi, nunYarisi];
            int[,] b = new int[nunYarisi, nunYarisi];
            int[,] c = new int[nunYarisi, nunYarisi];
            int[,] d = new int[nunYarisi, nunYarisi];
            int[,] e = new int[nunYarisi, nunYarisi];
            int[,] f = new int[nunYarisi, nunYarisi];
            int[,] g = new int[nunYarisi, nunYarisi];
            int[,] h = new int[nunYarisi, nunYarisi];

            for (int i = 0; i < nunYarisi; i++)
            {
                for (int j = 0; j < nunYarisi; j++)
                {
                    a[i, j] = matris1[i, j];
                    b[i, j] = matris1[i, j + nunYarisi];
                    c[i, j] = matris2[i, j];
                    d[i, j] = matris2[i, j + nunYarisi];
                    e[i, j] = matris1[i + nunYarisi, j];
                    f[i, j] = matris1[i + nunYarisi, j + nunYarisi];
                    g[i, j] = matris2[i + nunYarisi, j];
                    h[i, j] = matris2[i + nunYarisi, j + nunYarisi];
                }
            }

            int[,] p1 = MatrisCarpimi(a, cikar(d, c), nunYarisi);
            int[,] p2 = MatrisCarpimi(topla(a, b), h, nunYarisi);
            int[,] p3 = MatrisCarpimi(topla(e, f), c, nunYarisi);
            int[,] p4 = MatrisCarpimi(f, cikar(g, e), nunYarisi);
            int[,] p5 = MatrisCarpimi(topla(a, e), topla(c, g), nunYarisi);
            int[,] p6 = MatrisCarpimi(cikar(b, a), topla(d, h), nunYarisi);
            int[,] p7 = MatrisCarpimi(cikar(e, f), topla(g, h), nunYarisi);

            int[,] c11 = topla(cikar(topla(p5, p4), p2), p6);
            int[,] c12 = topla(p1, p2);
            int[,] c21 = topla(p3, p4);
            int[,] c22 = cikar(cikar(topla(p1, p5), p3), p7);

            int[,] sonuc = new int[n, n];

            for (int i = 0; i < nunYarisi; i++)
            {
                for (int j = 0; j < nunYarisi; j++)
                {
                    sonuc[i, j] = c11[i, j];
                    sonuc[i, j + nunYarisi] = c12[i, j];
                    sonuc[i + nunYarisi, j] = c21[i, j];
                    sonuc[i + nunYarisi, j + nunYarisi] = c22[i, j];
                }
            }

            return sonuc;
        }

        static int[,] topla(int[,] matris1, int[,] matris2)
        {
            int n = matris1.GetLength(0);
            int[,] sonuc = new int[n, n];

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    sonuc[i, j] = matris1[i, j] + matris2[i, j];
                }
            }

            return sonuc;
        }

        static int[,] cikar(int[,] matris1, int[,] matris2)
        {
            int n = matris1.GetLength(0);
            int[,] sonuc = new int[n, n];

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    sonuc[i, j] = matris1[i, j] - matris2[i, j];
                }
            }

            return sonuc;
        }

        static void Main(string[] args)
        {
            Console.Write("Matrisin boyutunu girin: ");
            int n = Convert.ToInt32(Console.ReadLine());

            int[,] matris1 = new int[n, n];
            int[,] matris2 = new int[n, n];
            Console.WriteLine("\nBirinci matrisin elemanlarını girin:");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write("Eleman [" + i + "][" + j + "]: ");
                    matris1[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            Console.WriteLine("\nİkinci matrisin elemanlarını girin:");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write("Eleman [" + i + "][" + j + "]: ");
                    matris2[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            int[,] sonuc = MatrisCarpimi(matris1, matris2, n);

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
