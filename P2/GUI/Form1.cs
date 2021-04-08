using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.Net.Http;
using Lab2;

namespace GUI
{
    public partial class Form1 : Form
    {
        bool Wal_baz_ok  = true;        //Zmienne przechowujące informacje
        bool Wal_1_S_ok  = true;        //o poprawności symboli w okienkach
        bool Wal_2_S_ok  = true;
        bool Wal_3_S_ok  = true;
        bool Wal_4_S_ok  = true;
        bool Wal_5_S_ok  = true;
        bool Wal_6_S_ok  = true;
        bool Wal_7_S_ok  = true;
        bool Wal_8_S_ok  = true;
        bool Wal_9_S_ok  = true;
        bool Wal_10_S_ok = true;

        public Form1()
        {
            InitializeComponent();

        }
        private string UtworzStringa()
        {
            string res=String.Empty;

            if (Wal_1_S_ok) res += ("," + Wal_1_S.Text);        //Jeżeli zawartość textboxu jest poprawna,
            if (Wal_2_S_ok) res += ("," + Wal_2_S.Text);        //dodaj jego treść do stringa
            if (Wal_3_S_ok) res += ("," + Wal_3_S.Text);
            if (Wal_4_S_ok) res += ("," + Wal_4_S.Text);
            if (Wal_5_S_ok) res += ("," + Wal_5_S.Text);
            if (Wal_6_S_ok) res += ("," + Wal_6_S.Text);
            if (Wal_7_S_ok) res += ("," + Wal_7_S.Text);
            if (Wal_8_S_ok) res += ("," + Wal_8_S.Text);
            if (Wal_9_S_ok) res += ("," + Wal_9_S.Text);
            if (Wal_10_S_ok)res += ("," + Wal_10_S.Text);

            Console.WriteLine("Wybrane waluty: " + res);
            return res;     //zwróć utworzonego stringa
        }
        private void KwotaBazy_TextChanged(object sender, EventArgs e)  //Gdy zmieni się tekst w polu z kwotą w walucie bazowej
        {
            if (!decimal.TryParse(KwotaBazy.Text, out _))               //Jeśli zawartości textboxu nie można przeparsować na typ decimal
            {
                KwotaBazy.BackColor = System.Drawing.Color.FromArgb(255, 240, 128, 128);    //ustaw kolor tła na jasnoczerwony
            }
            else                                                        //w przeciwnym wypadku
                KwotaBazy.BackColor = System.Drawing.Color.White;       //ustaw kolor z powrotem na biały
        }
        private void Wal_Baz_TextChanged(object sender, EventArgs e)        //Gdy zmieni się tekst w polu z walutą bazową
        {
            if (!Enum.IsDefined(typeof(WALUTY), Wal_Baz.Text.ToUpper()))    //jeśli jego zawartość nie jest prawidłowym symbolem waluty
            {
                Wal_Baz.BackColor = System.Drawing.Color.FromArgb(255, 240, 128, 128);  //ustaw kolor tła na jasnoczerwony
                Wal_baz_ok = false;                                                     //zapamiętaj, że zawartość niewłaściwa
            }
            else                                                                        //Jeśli zawartość jest symbolem
            {
                Wal_Baz.BackColor = System.Drawing.Color.White;                         //ustaw tło z powrotem na kolor biały
                Wal_baz_ok = true;                                                      //zapamiętaj, że zawartość jest prawidłowa
            }
        }
        private void Wal_1_S_TextChanged(object sender, EventArgs e)        //Pozostałe textboxy obsłużone analogicznie co Wal_Baz
        {
            if (!Enum.IsDefined(typeof(WALUTY), Wal_1_S.Text.ToUpper()))
            {
                Wal_1_S.BackColor = System.Drawing.Color.FromArgb(255, 240, 128, 128);
                Wal_1_S_ok = false;
            }
            else
            {
                Wal_1_S.BackColor = System.Drawing.Color.White;
                Wal_1_S_ok = true;
            }
        }

        private void Wal_2_S_TextChanged(object sender, EventArgs e)
        {
            if (!Enum.IsDefined(typeof(WALUTY), Wal_2_S.Text.ToUpper()))
            {
                Wal_2_S.BackColor = System.Drawing.Color.FromArgb(255, 240, 128, 128);
                Wal_2_S_ok = false;
            }
            else
            {
                Wal_2_S.BackColor = System.Drawing.Color.White;
                Wal_2_S_ok = true;
            }
        }

        private void Wal_3_S_TextChanged(object sender, EventArgs e)
        {
            if (!Enum.IsDefined(typeof(WALUTY), Wal_3_S.Text.ToUpper()))
            {
                Wal_3_S.BackColor = System.Drawing.Color.FromArgb(255, 240, 128, 128);
                Wal_3_S_ok = false;
            }
            else
            {
                Wal_3_S.BackColor = System.Drawing.Color.White;
                Wal_3_S_ok = true;
            }
        }

        private void Wal_4_S_TextChanged(object sender, EventArgs e)
        {
            if (!Enum.IsDefined(typeof(WALUTY), Wal_4_S.Text.ToUpper()))
            {
                Wal_4_S.BackColor = System.Drawing.Color.FromArgb(255, 240, 128, 128);
                Wal_4_S_ok = false;
            }
            else
            {
                Wal_4_S.BackColor = System.Drawing.Color.White;
                Wal_4_S_ok = true;
            }
        }

        private void Wal_5_S_TextChanged(object sender, EventArgs e)
        {
            if (!Enum.IsDefined(typeof(WALUTY), Wal_5_S.Text.ToUpper()))
            {
                Wal_5_S.BackColor = System.Drawing.Color.FromArgb(255, 240, 128, 128);
                Wal_5_S_ok = false;
            }
            else
            {
                Wal_5_S.BackColor = System.Drawing.Color.White;
                Wal_5_S_ok = true;
            }
        }

        private void Wal_6_S_TextChanged(object sender, EventArgs e)
        {
            if (!Enum.IsDefined(typeof(WALUTY), Wal_6_S.Text.ToUpper()))
            {
                Wal_6_S.BackColor = System.Drawing.Color.FromArgb(255, 240, 128, 128);
                Wal_6_S_ok = false;
            }
            else
            {
                Wal_6_S.BackColor = System.Drawing.Color.White;
                Wal_6_S_ok = true;
            }
        }

        private void Wal_7_S_TextChanged(object sender, EventArgs e)
        {
            if (!Enum.IsDefined(typeof(WALUTY), Wal_7_S.Text.ToUpper()))
            {
                Wal_7_S.BackColor = System.Drawing.Color.FromArgb(255, 240, 128, 128);
                Wal_7_S_ok = false;
            }
            else
            {
                Wal_7_S.BackColor = System.Drawing.Color.White;
                Wal_7_S_ok = true;
            }
        }

        private void Wal_8_S_TextChanged(object sender, EventArgs e)
        {
            if (!Enum.IsDefined(typeof(WALUTY), Wal_8_S.Text.ToUpper()))
            {
                Wal_8_S.BackColor = System.Drawing.Color.FromArgb(255, 240, 128, 128);
                Wal_8_S_ok = false;
            }
            else
            {
                Wal_8_S.BackColor = System.Drawing.Color.White;
                Wal_8_S_ok = true;
            }
        }

        private void Wal_9_S_TextChanged(object sender, EventArgs e)
        {
            if (!Enum.IsDefined(typeof(WALUTY), Wal_9_S.Text.ToUpper()))
            {
                Wal_9_S.BackColor = System.Drawing.Color.FromArgb(255, 240, 128, 128);
                Wal_9_S_ok = false;
            }
            else
            {
                Wal_9_S.BackColor = System.Drawing.Color.White;
                Wal_9_S_ok = true;
            }
        }

        private void Wal_10_S_TextChanged(object sender, EventArgs e)
        {
            if (!Enum.IsDefined(typeof(WALUTY), Wal_10_S.Text.ToUpper()))
            {
                Wal_10_S.BackColor = System.Drawing.Color.FromArgb(255, 240, 128, 128);
                Wal_10_S_ok = false;
            }
            else
            {
                Wal_10_S.BackColor = System.Drawing.Color.White;
                Wal_10_S_ok = true;
            }
        }

        private async void Przycisk_Click(object sender, EventArgs e)       //Gdy kliknięty zostanie przycisk
        {
            if (Wal_baz_ok)                                                 //Wykonaj cokolwiek wyłącznie jeśli podano właściwą walutę bazową
            {
                HttpClient client = new HttpClient();                       //Funkcje analogiczne co w przypadku aplikacji konsolowej
                waluty rate;
                string call, json;
                decimal mnoznik = 1;
                decimal kwota_bazy;

                if(!decimal.TryParse(KwotaBazy.Text, out kwota_bazy))       //Jeśli zawartość pola z kwotą nie jest decimalem
                {
                    kwota_bazy = 100;                                       //ustaw wartość po chamsku na 100
                    KwotaBazy.Text = kwota_bazy.ToString();                 //i wypisz ją do textboxu
                }
                    
                //List<decimal> wyniki = new List<decimal>();

                if (Wal_Baz.Text != "USD")                  //jeśli wybrano inną walutę bazową, niż USD, wyznacz mnożnik
                {
                    call = ("https://openexchangerates.org/api/latest.json?app_id=0c4e952688494f94b916d6c2ef29a9ee&base=USD&symbols=" + Wal_Baz.Text);
                    json = await client.GetStringAsync(call);
                    rate = JsonConvert.DeserializeObject<waluty>(json);
                    foreach (KeyValuePair<string, decimal> s in rate.rates)
                        mnoznik = 1 / s.Value;
                }
                Console.WriteLine("Baz: " + Wal_Baz.Text + "\tMnoznik: " + mnoznik.ToString());
                //Wyślij zapytanie z utworzonym stringiem
                call = ("https://openexchangerates.org/api/latest.json?app_id=0c4e952688494f94b916d6c2ef29a9ee&base=USD&symbols=" + UtworzStringa());
                json = await client.GetStringAsync(call);
                rate = JsonConvert.DeserializeObject<waluty>(json);
                foreach (KeyValuePair<string, decimal> s in rate.rates)     //Dla każdego elementu w dictionary
                {
                    foreach (Control contrl in this.Controls)               //Przeszukaj wszystkie elementy GUI
                    {
                        if (contrl.Text == s.Key && contrl.Name != "Wal_Baz")   //Jeśli zawartość elementu GUI zgodna z kluczem słownika
                        {                                                       //i nie jest to pole waluty bazowej
                            foreach (Control contrl2 in this.Controls)          //Przeszukaj wszystkie elementy GUI
                            {
                                if (contrl2.Name == contrl.Name.Replace('S', 'W'))              //Jeśli nazwa odpowiada nazwie pierwszego elementu
                                    contrl2.Text = (s.Value * mnoznik*kwota_bazy).ToString("0.######");    //Wypisz value ze słownika
                            }
                        }
                    }
                }
                foreach (Control contrl in this.Controls)                       //Ponownie przeszukaj wszystkie elementy GUI
                {
                    if ((!Enum.IsDefined(typeof(WALUTY), contrl.Text.ToUpper())) && contrl.GetType() == typeof(TextBox) && contrl.Name.EndsWith("S"))
                    {       //Jeśli element jest textboxem, jego nazwa kończy się na "S" (Symbol), oraz jego zawartość nie jest właściwym symbolem
                        foreach (Control contrl2 in this.Controls)              //Przeszukaj wszystkie elementy GUI
                        {
                            if (contrl2.Name == contrl.Name.Replace('S', 'W'))  //jeżeli nazwa elementu odpowiada nazwie pierwszego elementu
                            {
                                contrl2.Text = "Błędny symbol";                         //Wypisz informację o niewłaściwym symbolu
                                contrl2.BackColor = System.Drawing.Color.FromArgb(255, 220, 220, 220);  //Ustaw tło na jasnoszare
                            }
                        }
                    }
                }
            }
            else Console.WriteLine("Niewłaściwa waluta bazowa.");
        }

    }
}
