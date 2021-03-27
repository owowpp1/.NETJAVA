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
        bool Wal_baz_ok  = true;
        bool Wal_1_S_ok  = true;
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

            if (Wal_1_S_ok) res += ("," + Wal_1_S.Text);
            if (Wal_2_S_ok) res += ("," + Wal_2_S.Text);
            if (Wal_3_S_ok) res += ("," + Wal_3_S.Text);
            if (Wal_4_S_ok) res += ("," + Wal_4_S.Text);
            if (Wal_5_S_ok) res += ("," + Wal_5_S.Text);
            if (Wal_6_S_ok) res += ("," + Wal_6_S.Text);
            if (Wal_7_S_ok) res += ("," + Wal_7_S.Text);
            if (Wal_8_S_ok) res += ("," + Wal_8_S.Text);
            if (Wal_9_S_ok) res += ("," + Wal_9_S.Text);
            if (Wal_10_S_ok)res += ("," + Wal_10_S.Text);

            Console.WriteLine(res);
            return res;
        }
        private void Wal_Baz_TextChanged(object sender, EventArgs e)
        {
            if (!Enum.IsDefined(typeof(WALUTY), Wal_Baz.Text.ToUpper()))
            {
                Wal_Baz.BackColor = System.Drawing.Color.FromArgb(255, 240, 128, 128);
                Wal_baz_ok = false;
            }
            else
            {
                Wal_Baz.BackColor = System.Drawing.Color.White;
                Wal_baz_ok = true;
            }
        }
        private void Wal_1_S_TextChanged(object sender, EventArgs e)
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

        private async void Przycisk_Click(object sender, EventArgs e)
        {
            HttpClient client = new HttpClient();
            waluty rate;
            string call, json;
            decimal mnoznik = 1;
            List<decimal> wyniki= new List<decimal>();
            int i = 0;

            if (Wal_Baz.Text != "USD")
            {
                call = ("https://openexchangerates.org/api/latest.json?app_id=0c4e952688494f94b916d6c2ef29a9ee&base=USD&symbols=" + Wal_Baz.Text);
                json = await client.GetStringAsync(call);
                rate = JsonConvert.DeserializeObject<waluty>(json);
                foreach (KeyValuePair<string, decimal> s in rate.rates)
                    mnoznik = 1 / s.Value;
            }
            Console.WriteLine("Baz: " + Wal_Baz.Text + "\tMnoznik: " + mnoznik.ToString());
            call = ("https://openexchangerates.org/api/latest.json?app_id=0c4e952688494f94b916d6c2ef29a9ee&base=USD&symbols=" + UtworzStringa());
            json = await client.GetStringAsync(call);
            rate = JsonConvert.DeserializeObject<waluty>(json);
            foreach (KeyValuePair<string, decimal> s in rate.rates)
            {
                foreach (Control contrl in this.Controls)
                {
                    if (contrl.Text == s.Key && contrl.Name!="Wal_Baz")
                    {
                        foreach (Control contrl2 in this.Controls)
                        {
                            if (contrl2.Name == contrl.Name.Replace('S', 'W'))
                                contrl2.Text=(s.Value*mnoznik).ToString("0.######");
                        }
                    }
                }
            }
        }
    }
}
