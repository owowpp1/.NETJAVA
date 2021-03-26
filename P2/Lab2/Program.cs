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
            //string json = File.ReadAllText("students.json");
            //Console.WriteLine(json);
            load();

            Console.Read();
        }
        public static async void load()
        {
            //HttpClient client = new HttpClient();
            //string call = "http://radoslaw.idzikowski.staff.iiar.pwr.wroc.pl/instruction/students.json";
            //string json = await client.GetStringAsync(call);
            //Console.WriteLine(json);

            //List<student> students = JsonConvert.DeserializeObject<List<student>>(json);
            //foreach (var s in students)
            //    Console.WriteLine(s.studentId + "\t" + s.studentName);
            string walutyParametry = "EUR,GBP,PLN";

            Console.WriteLine("Domyślne waluty: EUR, Bri'ish quid, PLN. Chcesz podać swoje?");
            string yesno = Console.ReadLine();
            if (yesno.ToLower() == "yes" || yesno.ToLower() == "y" || yesno.ToLower() == "tak" || yesno.ToLower() == "t")
            {
                Console.WriteLine("Podaj symbole walut oddzielone przecinkami bez spacji:");
                walutyParametry=Console.ReadLine();
            }
            //Console.WriteLine(walutyParametry);
            HttpClient client = new HttpClient();
            string call = ("https://openexchangerates.org/api/latest.json?app_id=0c4e952688494f94b916d6c2ef29a9ee&base=USD&symbols="+walutyParametry);
            string json = await client.GetStringAsync(call);
            Console.WriteLine(json);

            waluty rate= JsonConvert.DeserializeObject<waluty>(json);
                Console.WriteLine("Waluta bazowa: " + rate.Base);
            foreach (KeyValuePair<string, decimal> s in rate.rates)
                Console.WriteLine("{0}: {1}", s.Key, s.Value);

        }
    }
}
