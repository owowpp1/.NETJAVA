using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json;
using System.Net.Http;

namespace Lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            Task wczytanko= loadRates();
            wczytanko.Wait();

            Console.ReadLine();
        }
        public static async Task loadStudents()
        {
            HttpClient client = new HttpClient();
            string call = "http://radoslaw.idzikowski.staff.iiar.pwr.wroc.pl/instruction/students.json";
            string json = await client.GetStringAsync(call);
            Console.WriteLine(json);

            List<student> students = JsonConvert.DeserializeObject<List<student>>(json);
            foreach (var s in students)
                Console.WriteLine(s.studentId + "\t" + s.studentName);
        }
        public static async Task loadRates()
        {
            
            string walutyParametry = "USD,EUR,GBP,PLN";
            object walutyBaza = "USD";
            string yesno, call, json, czySymbol="";
            int ileznakow=0;
            char znak='x';
            bool poprawnyOdczyt = false;
            HttpClient client = new HttpClient();
            waluty rate;
            decimal mnoznik=1;

            Console.WriteLine("Domyślna baza: USD. Chcesz podać swoją?");
            yesno = Console.ReadLine();
            if (yesno.ToLower() == "yes" || yesno.ToLower() == "y" || yesno.ToLower() == "tak" || yesno.ToLower() == "t")
            {
                while (!poprawnyOdczyt) {
                    Console.Write("Podaj symbol waluty: ");
                    walutyBaza = Console.ReadLine();
                    if (Enum.IsDefined(typeof(WALUTY), walutyBaza))
                    {
                        poprawnyOdczyt = true;
                        call = ("https://openexchangerates.org/api/latest.json?app_id=0c4e952688494f94b916d6c2ef29a9ee&base=USD&symbols=" + walutyBaza);
                        json = await client.GetStringAsync(call);
                        rate = JsonConvert.DeserializeObject<waluty>(json);
                        foreach (KeyValuePair<string, decimal> s in rate.rates)
                            mnoznik = 1 / s.Value;
                    }
                    else Console.WriteLine("Nie ma takiej waluty. Spróbuj ponownie.");
                }     
            }
            poprawnyOdczyt = false;
            Console.WriteLine("Domyślne waluty: USD, EUR, Bri'ish quid, PLN. Chcesz podać swoje?");
            yesno = Console.ReadLine();
            if (yesno.ToLower() == "yes" || yesno.ToLower() == "y" || yesno.ToLower() == "tak" || yesno.ToLower() == "t")
            {
                while (!poprawnyOdczyt)
                {
                    poprawnyOdczyt = true;
                    Console.WriteLine("Podaj symbole walut oddzielone przecinkami:");
                    walutyParametry = Console.ReadLine();
                    walutyParametry = String.Concat(walutyParametry.Where(c => !Char.IsWhiteSpace(c)));
                    for (int i = 0; i < walutyParametry.Length; i++)
                    {
                        znak = walutyParametry[i];
                        ileznakow++;
                        if (znak != ',')
                        {
                            if (ileznakow < 4)
                                czySymbol += znak;
                        }
                        else
                        {
                            czySymbol = "";
                            ileznakow = 0;
                        }
                        if (ileznakow == 3)
                        {
                            if (!Enum.IsDefined(typeof(WALUTY), czySymbol))
                            {
                                Console.WriteLine("Przynajmniej jedna z podanych walut nie istnieje.");
                                poprawnyOdczyt = false;
                                break;
                            }
                        }
                    }
                }
            }

            call = ("https://openexchangerates.org/api/latest.json?app_id=0c4e952688494f94b916d6c2ef29a9ee&base=USD&symbols="+walutyParametry);
            json = await client.GetStringAsync(call);
            Console.WriteLine(json);

            rate= JsonConvert.DeserializeObject<waluty>(json);
                Console.WriteLine("Waluta bazowa: " + walutyBaza);
            foreach (KeyValuePair<string, decimal> s in rate.rates)
                Console.WriteLine("{0}: {1}", s.Key, (s.Value*mnoznik).ToString("0.######"));

        }
    }
}
