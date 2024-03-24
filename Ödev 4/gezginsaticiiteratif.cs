using System;
using System.Linq;
using System.Collections.Generic;

class TSP
{
    private int[,] mesafeler;
    private List<int> enIyiRota;
    private int enIyiMesafe = int.MaxValue;

    public TSP(int[,] mesafeler)
    {
        this.mesafeler = mesafeler;
    }

    public void EnKisaRotayiBul()
    {
        var sehirler = Enumerable.Range(0, mesafeler.GetLength(0)).ToList();
        Permütasyon(sehirler, 0);
    }

    private void Permütasyon(List<int> sehirler, int baslangic)
    {
        if (baslangic == sehirler.Count)
        {
            RotaKontrol(sehirler);
            return;
        }

        for (int i = baslangic; i < sehirler.Count; i++)
        {
            Takas(sehirler, baslangic, i);
            Permütasyon(sehirler, baslangic + 1);
            Takas(sehirler, baslangic, i); 
        }
    }

    private void RotaKontrol(List<int> rota)
    {
        int mesafe = 0;
        for (int i = 0; i < rota.Count - 1; i++)
        {
            mesafe += mesafeler[rota[i], rota[i + 1]];
        }
        mesafe += mesafeler[rota[rota.Count - 1], rota[0]];

        if (mesafe < enIyiMesafe)
        {
            enIyiMesafe = mesafe;
            enIyiRota = new List<int>(rota);
        }
    }

    private void Takas(List<int> liste, int indexA, int indexB)
    {
        int tmp = liste[indexA];
        liste[indexA] = liste[indexB];
        liste[indexB] = tmp;
    }

    public void EnIyiRotayiYazdir()
    {
        Console.WriteLine($"En kısa rota mesafesi: {enIyiMesafe}");
        Console.Write("Rota: ");
        foreach (var sehir in enIyiRota)
        {
            Console.Write($"{sehir} ");
        }
        Console.WriteLine();
    }
}

class Program
{
    static void Main()
    {
        int[,] mesafeler = {
            { 0, 2, 9, 10 },
            { 1, 0, 6, 4 },
            { 15, 7, 0, 8 },
            { 6, 3, 12, 0 }
        };

        TSP tsp = new TSP(mesafeler);
        tsp.EnKisaRotayiBul();
        tsp.EnIyiRotayiYazdir();
    }
}