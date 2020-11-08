using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Text;

namespace libreriamatematica
{
    class libreriamatematica
    {
        public static int somma(int a,int b)
        {
            int somma = a + b;
            return somma;
        }
        public static double sommad(double a , double b)
        {
            double somma = a + b;
            return somma;
        }
        public static double sottrazione(double a,double b)
        {
            double sottrazione = a - b;
            return sottrazione;
        }
        public static double moltiplicazione(double a,double b)
        {
            double moltiplicazione = a * b;
            return moltiplicazione;
        }
        public static double divisione(double a,double b)
        {
            double divisione = a / b;
            return divisione;
        }
        public static long potenza(int a, int b)
        {
            long potenza = a ^ a;
            return potenza;
        }
        public static int minore(int a, int b, int c)
        {
           int minore= Math.Min(a, b);Math.Min(minore, c);
            return minore;
        }

        internal static int inverso(int v1, int v2, int v3)
        {
            throw new NotImplementedException();
        }

        internal static int pari(int v1, int v2, int v3)
        {
            throw new NotImplementedException();
        }

        internal static int dispari(int v1, int v2, int v3)
        {
            throw new NotImplementedException();
        }

        internal static int positivo(int v1, int v2, int v3)
        {
            throw new NotImplementedException();
        }

        internal static int negativo(int v1, int v2, int v3)
        {
            throw new NotImplementedException();
        }

        internal static int intero(double v1, int v2, double v3)
        {
            throw new NotImplementedException();
        }

        public static int maggiore(int a, int b, int c)
        {
            int maggiore = Math.Max(a, b);Math.Max(maggiore, c);
            return maggiore;
        }
        public static int inverso(int a)
        {
            int iverso = a * -1;
            return iverso;
        }
        public static int pari(int a, int v) 
        {
            return (a % 2);
        }
        public static int dispari (int a, int v)
        {
            return (a % 3);
        }
        public static bool positivo (int a)
        {
            return  a > 0;
        }
        public static bool negativo (int a)
        {
            return a < 0;
        }
        public static bool intero(double a)
        {
            return a == (int) a;
        }

    }
}
