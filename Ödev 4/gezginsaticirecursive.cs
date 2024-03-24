using System;
using System.Collections.Generic;
using System.Linq;

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
        EnKisaRotayiBulYineleyici(new List<int>(), sehirler, 0);
    }

    private void EnKisaRotayiBulYineleyici(List<int> simdikiRota, List<int> kalanSehirler, int simdikiMesafe)
    {
        if (kalanSehirler.Count == 0)
        {
            simdikiMesafe += mesafeler[simdikiRota.Last(), simdikiRota.First()];
            if (simdikiMesafe < enIyiMesafe)
            {
                enIyiMesafe = simdikiMesafe;
                enIyiRota = new List<int>(simdikiRota);
            }
            return;
        }

        foreach (var sehir in kalanSehirler)
        {
            var yeniRota = new List<int>(simdikiRota) { sehir };
            var yeniKalanSehirler = new List<int>(kalanSehirler);
            yeniKalanSehirler.Remove(sehir);

            var yeniMesafe = simdikiMesafe;
            if (simdikiRota.Count > 0)
            {
                yeniMesafe += mesafeler[simdikiRota.Last(), sehir];
            }

            EnKisaRotayiBulYineleyici(yeniRota, yeniKalanSehirler, yeniMesafe);
        }
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