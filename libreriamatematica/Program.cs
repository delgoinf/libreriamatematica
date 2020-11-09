using System;

namespace matematicaes
{
    class Program
    {
        static void Main(string[] args)
        {
            int somma = libreriamatematica.Somma(5, 4);
            Console.WriteLine($"la somma intera è: {somma}");
            double sommaDouble = libreriamatematica.Sommad(7.0, 4.0);
            Console.WriteLine($"la somma decimale è: {sommaDouble}");
            double moltiplicazione = libreriamatematica.Moltiplicazione(8, 4);
            Console.WriteLine($"la moltiplicazione è: {moltiplicazione}");
            double divisione = libreriamatematica.Divisione(3, 6);
            Console.WriteLine($"la divisione è: {divisione}");
            long potenza = libreriamatematica.Potenza(4, 4);
            Console.WriteLine($"la potenza è: {potenza}");
            long molt = libreriamatematica.CalcoloFattoriale(10);
            Console.WriteLine($"il fattoriale è {molt}");
            int min = libreriamatematica.Minore(1, 2, 3);
            Console.WriteLine($"il minimo è {min}");
            int max = libreriamatematica.Maggiore(5, 6, 7);
            Console.WriteLine($"il massimo è {max}");
            double inverso = libreriamatematica.Inverso(3);
            Console.WriteLine($"il numero inverso è {inverso}");
            bool pari = libreriamatematica.Pari(8);
            Console.WriteLine($"il numero è pari {pari}");
            bool dispari = libreriamatematica.Dispari(3);
            Console.WriteLine($"il numero è dispari{dispari}");
            bool positivo = libreriamatematica.Positivo(8);
            Console.WriteLine($"il numero è positivo: {positivo}");
            bool negativo = libreriamatematica.Negativo(1);
            Console.WriteLine($"il numero è positivo: {negativo}");
            bool intero = libreriamatematica.Intero(5);
            Console.WriteLine($"il numero è intero: {intero}");


        }
    }
}
