using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GeneratorCS;

namespace LAB1
{
    public class Program
    {
        static void Main(string[] args)
        {
            Program program = new Program();

            int seed1=2, seed2=9;

            Console.WriteLine("Ile miejsca w plecaczku?");
            int miejsca = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Masz " + miejsca + " kg miejsca w plecaczku.");
            Console.WriteLine("Chcesz podać seedy?");
            string yesno = Console.ReadLine();
            if (yesno.ToLower() == "yes" || yesno.ToLower() == "y" || yesno.ToLower() == "tak" || yesno.ToLower() == "t")
            {
                Console.Write("Podaj seed 1: ");
                seed1 = Convert.ToInt32(Console.ReadLine());
                Console.Write("Podaj seed 2: ");
                seed2 = Convert.ToInt32(Console.ReadLine());
            }

            program.ustaf(seed1, seed2, miejsca);

            Console.ReadKey();
        }
        public int ustaf(int seed1, int seed2, int miejsca)
        {
            const int ileLosujemy = 15;

            RandomNumberGenerator rng = new RandomNumberGenerator(seed1);
            RandomNumberGenerator rng2 = new RandomNumberGenerator(seed2);

            List<List<double>> przedmioty = new List<List<double>>(3);

            for (int i = 0; i < 3; i++)
            {
                przedmioty.Add(new List<double>(ileLosujemy));
            }
            
            for (int j = 0; j < ileLosujemy; j++)
                przedmioty[0].Add(rng.nextInt(1, 29));
            
            for (int j = 0; j < ileLosujemy; j++)
                przedmioty[1].Add(rng2.nextInt(1, 29));
            
            for (int i = 0; i < ileLosujemy; i++)
                przedmioty[2].Add(przedmioty[0][i] / przedmioty[1][i]);

            /*****************WYPISANIE********************/
            Console.WriteLine("Lista przedmiotów:");
            Console.Write("Numer:".PadLeft(10));
            for (int i = 0; i < ileLosujemy; i++)
            {
                Console.Write((i + 1).ToString().PadLeft(5));
            }
            Console.WriteLine();
            Console.Write("Wartość:".PadLeft(10));

            for (int i = 0; i < ileLosujemy; i++)
            {
                Console.Write(przedmioty[0][i].ToString("#0").PadLeft(5));
            }
            Console.WriteLine();
            Console.Write("Waga:".PadLeft(10));
            for (int i = 0; i < ileLosujemy; i++)
            {
                Console.Write(przedmioty[1][i].ToString("#0").PadLeft(5));
            }
            Console.WriteLine();
            Console.Write("Cena/waga:".PadLeft(10));
            for (int i = 0; i < ileLosujemy; i++)
            {
                Console.Write(przedmioty[2][i].ToString("0.##").PadLeft(5));
            }

            /*****************USTAWIENIE*****************/
            double masaPrzedmiotow = 0, wartoscPrzedmiotow = 0;
            int zapakowanych = 0;

            while (zapakowanych < ileLosujemy)
            {
                if (masaPrzedmiotow >= miejsca) break;
                masaPrzedmiotow += przedmioty[1][zapakowanych];
                wartoscPrzedmiotow += przedmioty[0][zapakowanych];
                zapakowanych++;
            }
            if (masaPrzedmiotow > miejsca)
            {
                zapakowanych--;
                masaPrzedmiotow -= przedmioty[1][zapakowanych];
                wartoscPrzedmiotow -= przedmioty[0][zapakowanych];
            }
            Console.WriteLine();
            Console.Write("Zapakowano pierwsze " + zapakowanych + " przedmiotów o łącznej masie " + masaPrzedmiotow + " i wartości " + wartoscPrzedmiotow + ".\n");

            return zapakowanych;

        }
    }
}

