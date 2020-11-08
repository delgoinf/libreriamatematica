using System;

namespace libreriamatematica
{
    class Program
    {
        static void Main(string[] args)
        {
            int somma = libreriamatematica.somma(4,5);
            Console.WriteLine($"la somma {somma}");
            double sommad = libreriamatematica.sommad(4.5, 5.4);
            Console.WriteLine($"la somam {sommad}");
            double sottrazione = libreriamatematica.sottrazione(4, 5);
            Console.WriteLine($"la sottrazione {sottrazione}");
            long potenza = libreriamatematica.potenza(3, 3);
            Console.WriteLine($"la potenza {potenza}");
            double divisione = libreriamatematica.divisione(5, 4);
            Console.WriteLine($"la divisione {divisione}");
            double moltiplicazione = libreriamatematica.moltiplicazione(4, 5);
            Console.WriteLine($"la moltiplicazione {moltiplicazione}");
            int minore = libreriamatematica.minore(4, 6, 8);
            Console.WriteLine($"il minore {minore}");
            int maggiore = libreriamatematica.maggiore(4, 6, 8);
            Console.WriteLine($"il maggiore {maggiore}");
            int inverso = libreriamatematica.inverso(4, 5, 7);
            Console.WriteLine($"il numero inverso {inverso}");
            int pari = libreriamatematica.pari(6, 5, 2);
            Console.WriteLine($"il numero pari {pari}");
            int dispari = libreriamatematica.dispari(5, 8, 6);
            Console.WriteLine($"il numero dispari {dispari}");
            int positivo = libreriamatematica.positivo(6, 4, -7);
            Console.WriteLine($"il numero positivo {positivo}");
            int negativo = libreriamatematica.negativo(7, -9, -7);
            Console.WriteLine($"il numero è negativo {negativo}");
            int intero = libreriamatematica.intero(4.4, 5, 8.6);
            Console.WriteLine($"il numero intero {intero}");



        }
    }
}
