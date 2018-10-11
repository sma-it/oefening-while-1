using System;

namespace First
{
    class Program
    {
        /* Verdubbel het functieargument tot het getal 1000 overschreden wordt. Geef het laatste product dat je bekomt
          * als functieresultaat.
          */
        public static int VerdubbelGetal(int a)
        {
            // schrijf hier je code
            return 0;
        }

        /* Kwadrateer het eerste functieargument tot het resultaat groter wordt dan het tweede functieargument.
         * Geef als functieresultaat hoe vaak je hebt moeten kwadrateren.
         * Tip: gebruik de functie Math.Pow() bij het kwadrateren.
		 */
        public static int KwadrateerGetal(double a, double b)
        {
            // schrijf hier je code
            return 0;
        }

        /* Het aantal leeuwen in een natuurpark wordt als functieargument doorgegeven. Het aantal groeit jaarlijks met 15%. 
         * Hoeveel jaren duurt het tot er meer dan 1000 leeuwen zijn? Geef dit aantal jaren als functieresultaat.
		 */
        public static int BepaalLeeuwen(double aantal)
        {
            // schrijf hier je code
            return 0;
        }


        /* Bepaal de Fibonaci nummers en tel deze op tot het fibonaci getal de opgegeven maximum (functieargument) overschreidt.
         * Als functieresultaat geef je de som die het opgegeven maximum overschreidt.
         */

        public static int SomFibonaci(int max)
        {
            // schrijf hier je code
            return 0;
        }


        static void Main(string[] args)
        {
            Console.WriteLine("VerdubbelGetal \t\t 1280 \t\t\t" + VerdubbelGetal(20));
            Console.WriteLine("KwadrateerGetal \t 3 \t\t\t" + KwadrateerGetal(5, 10000));
            Console.WriteLine("BepaalLeeuwen \t\t 33 \t\t\t" + BepaalLeeuwen(10));
            Console.WriteLine("SomFibonaci \t\t 88 \t\t\t" + SomFibonaci(30));

            Console.ReadKey();
        }
    }
}
