using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Text;

namespace matematicaes
{
    class libreriamatematica
    {
        public static int Somma(int a,int b)
        {
            int somma = a + b;
            return somma;
        }
        public static double Sommad(double a , double b)
        {
            double somma = a + b;
            return somma;
        }
        public static double Sottrazione(double a,double b)
        {
            double sottrazione = a - b;
            return sottrazione;
        }
        public static double Moltiplicazione(double a,double b)
        {
            double moltiplicazione = a * b;
            return moltiplicazione;
        }
        public static double Divisione(double a,double b)
        {
            double divisione = a / b;
            return divisione;
        }
        public static long Potenza(int a, int b)
        {
            int i;
            long potenza = 1;
            for (i = 0; i < b; i++)
            {
                potenza *= a;
            }
            return potenza;
        }
        public static int Minore(int a, int b, int c)
        {
           int minore= Math.Min(a, b);Math.Min(minore, c);
            return minore;
        }
        public static long CalcoloFattoriale(int a)
        {
            long fattoriale = 1;
            for(int i = 2; i <= a; i++)
            {
                fattoriale = fattoriale * i;
            }
            return fattoriale;
        }

        internal static double Inverso(double a)
        {
            double inverso = a * -1;
            return inverso;
        }

        internal static bool Pari(int a)
        {
            return a % 2 == 0;
        }

        internal static bool Dispari(int a)
        {
            return !Pari(a);
        }

        internal static bool Negativo(int a)
        {
            return a < 0;
        }

        public static int Maggiore(int a, int b, int c)
        {
            int maggiore = Math.Max(a, b);Math.Max(maggiore, c);
            return maggiore;
        }
        public static int Inverso(int a)
        {
            int iverso = a * -1;
            return iverso;
        }
        public static int Pari(int a, int v) 
        {
            return (a % 2);
        }

        public static bool Positivo (int a)
        {
            return  a > 0;
        }
 
        public static bool Intero(double a)
        {
            return a == (int) a;
        }

    }
}
