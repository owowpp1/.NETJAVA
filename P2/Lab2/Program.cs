using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json;
using System.Net.Http;
using System.Data.Entity;

namespace Lab2
{

    
    class Program
    {
        static void Main(string[] args)
        {
            string yesno="yuh";
            Task wczytanko;
            //Task wczytanko= loadStudents();
            while (yesno.ToLower() == "yes" || yesno.ToLower() == "y" || yesno.ToLower() == "tak" || yesno.ToLower() == "t" || yesno.ToLower() == "yuh")
            {
                wczytanko = loadRates();        //rozpocznij metodę loadRates()
                wczytanko.Wait();               //poczekaj, aż się wykona
                Console.WriteLine("Chcesz jeszcze raz?");
                yesno=Console.ReadLine();
            }
        }

        public static async Task loadStudents() //z zajęć
        {
            HttpClient client = new HttpClient();
            var context = new University();
            var student = new Student();
            string call = "http://radoslaw.idzikowski.staff.iiar.pwr.wroc.pl/instruction/students.json";
            string json = await client.GetStringAsync(call);
            Console.WriteLine(json);

            List<Student> students = JsonConvert.DeserializeObject<List<Student>>(json);
            foreach (var s in students)
            {
                Console.WriteLine(s.ID + "\t" + s.name);
                student.name = s.name;
                student.ID = s.ID;
            }
        }
        public static async Task loadRates()
        {
            
            string walutyParametry = "USD,EUR,GBP,PLN";     //domyślne waluty, na które przeliczamy
            object walutyBaza = "USD";                      //domyślna waluta bazowa
            string yesno, call, json, czySymbol="";         //zmienne pomocnicze
            int ileznakow=0;
            char znak='x';
            bool poprawnyOdczyt = false;                    //czy poprawnie odczytano symbole walut
            //var context = new BazaWalut();
            HttpClient client = new HttpClient();           //klient http
            waluty rate;                                    //zmienna, w której przechowane zostaną wyniki
            decimal mnoznik=1;                              //mnożnik pozwalający zmienić walutę bazową za darmolca

            Console.WriteLine("Domyślna baza: USD. Chcesz podać swoją?");
            yesno = Console.ReadLine();
            if (yesno.ToLower() == "yes" || yesno.ToLower() == "y" || yesno.ToLower() == "tak" || yesno.ToLower() == "t")
            {
                while (!poprawnyOdczyt) {                               //Jeśli nie dokonano poprawnego odczytu symbolu
                    Console.Write("Podaj symbol waluty: ");
                    walutyBaza = Console.ReadLine().ToUpper();          //wejście użytkownika do wielkich liter
                    if (Enum.IsDefined(typeof(WALUTY), walutyBaza))     //jeśli podany przez użytkownika string jest symbolem zdefiniowanym w WALUTY
                    {
                        poprawnyOdczyt = true;                          //zapamiętaj, że dokonano poprawnego odczytu i skonstruuj zapytanie do API
                        call = ("https://openexchangerates.org/api/latest.json?app_id=0c4e952688494f94b916d6c2ef29a9ee&base=USD&symbols=" + walutyBaza);
                        json = await client.GetStringAsync(call);               //pobierz dane z API i zapisz je w zmiennej json
                        rate = JsonConvert.DeserializeObject<waluty>(json);     //deserializuj zawartość zmiennej json
                        foreach (KeyValuePair<string, decimal> s in rate.rates)
                            mnoznik = 1 / s.Value;                              //mnożnik jest odwrotnością wartości niestandardowej waluty w dolarach
                    }
                    else Console.WriteLine("Nie ma takiej waluty. Spróbuj ponownie.");
                }     
            }
            poprawnyOdczyt = false;
            Console.WriteLine("Domyślne waluty: USD, EUR, Bri'ish quid, PLN. Chcesz podać swoje?");
            yesno = Console.ReadLine();
            if (yesno.ToLower() == "yes" || yesno.ToLower() == "y" || yesno.ToLower() == "tak" || yesno.ToLower() == "t")
            {
                while (!poprawnyOdczyt)                     //Jeśli nie dokonano poprawnego odczytu symboli
                {
                    poprawnyOdczyt = true;                  //załóż, że wprowadzone dane będą poprawne
                    Console.WriteLine("Podaj symbole walut oddzielone przecinkami:");
                    walutyParametry = Console.ReadLine().ToUpper();                     //Wejście użytkownika na wielkie litery
                    walutyParametry = String.Concat(walutyParametry.Where(c => !Char.IsWhiteSpace(c))); //usuń spacje
                    for (int i = 0; i < walutyParametry.Length; i++)                    //dla każdego znaku w inpucie użytkownika
                    {
                        znak = walutyParametry[i];                                      //pobierz znak
                        ileznakow++;                                                    //zwiększ ilość zapisanych znaków
                        if (znak != ',')                                                //jeśli znak nie jest przecinkiem
                        {
                            if (ileznakow < 4)                                          //i odczytano mniej niż 4 znaki
                                czySymbol += znak;                                      //dodaj ten znak do stringa (potencjalnego symbolu)
                        }
                        else                            //w przeciwnym wypadku
                        {
                            czySymbol = "";             //wyzeruj potencjalny symbol
                            ileznakow = 0;              //i liczbę zapisanych znaków
                        }
                        if (ileznakow == 3)             //jeżeli zapisano 3 znaki
                        {
                            if (!Enum.IsDefined(typeof(WALUTY), czySymbol.ToUpper()))   //sprawdź, czy potencjalny symbol jest poprawnym symbolem
                            {                                                           //Jeśli nie:
                                Console.WriteLine("Przynajmniej jedna z podanych walut nie istnieje.");
                                poprawnyOdczyt = false;                                 //zapamiętaj, że dokonano nieprawidłowego odczytu
                                ileznakow = 0;                                          //wyzeruj zapamiętane znaki
                                czySymbol = "";                                         //wyzeruj potencjalny symbol
                                break;                                                  //przerwij analizę
                            }
                        }
                        if (ileznakow==4 && znak != ',')                                //jeżeli zapisano 4 znaki i czwarty z nich nie był przecinkiem
                        {
                            Console.WriteLine("Symbole walut mają po 3 znaki. Czy zostały oddzielone przecinkami?");
                            poprawnyOdczyt = false;                                     //zapamiętaj, że dokonano nieprawidłowego odczytu
                            ileznakow = 0;                                              //wyzeruj zapamiętane znaki
                            czySymbol = "";                                             //wyzeruj potencjalny symbol
                            break;                                                      //przerwij analizę
                        }
                    }
                }
            }

            //Utwórz zapytanie do API
            call = ("https://openexchangerates.org/api/latest.json?app_id=0c4e952688494f94b916d6c2ef29a9ee&base=USD&symbols="+walutyParametry.ToUpper());
            json = await client.GetStringAsync(call);       //zapisz odpowiedź z API do zmiennej json
            Console.WriteLine(json);                        //wypisz odpowiedź z API

            rate= JsonConvert.DeserializeObject<waluty>(json);  //zdeserializuj zawartość zmiennej json
            Console.WriteLine("Waluta bazowa: " + walutyBaza);  //wypisz walutę bazową


            foreach (KeyValuePair<string, decimal> s in rate.rates) //dla każdego elementu w słowniku rates
            {
                Console.WriteLine("{0}: {1}", s.Key, (s.Value * mnoznik).ToString("0.######")); //wypisz klucz i wartość ze słownika
            }


            /*************************BAZA DANYCH CO NIE DZIAŁA ELO BENC*******************************/


            //waluty waluta = new waluty { Base = (string)walutyBaza, rates=new Dictionary<string, decimal>() };

            //foreach (KeyValuePair<string, decimal> s in rate.rates)
            //{
            //    waluta.rates.Add(s.Key, (s.Value * mnoznik));
            //    Console.WriteLine("Przepisano {0}: {1} do walutes", s.Key, (s.Value * mnoznik).ToString("0.######"));
            //}
            //Console.WriteLine("Wartości w waluty:");
            //foreach (KeyValuePair<string, decimal> s in waluta.rates)
            //{
            //    Console.WriteLine("Key {0} Value {1}", s.Key, s.Value.ToString("0.######"));
            //}

            //context.Walutes.Add(waluta);
            //context.SaveChanges();
            //Console.WriteLine("Zapisane");
            ////var wypisanko = context.Walutes.SqlQuery("SELECT * FROM Walutes").ToList<waluty>();
            //var wypisanko = (from v in context.Walutes select v).ToList<waluty>();
            //foreach (var l in wypisanko)
            //{
            //    Console.WriteLine("Baza: " + l.Base);
            //    Console.WriteLine("ID: " + l.ID);
            //    foreach (KeyValuePair<string, decimal> s in l.rates)
            //        Console.WriteLine("{0}: {1}", s.Key, (s.Value * mnoznik).ToString("0.######"));
            //}


        }
    }
}
