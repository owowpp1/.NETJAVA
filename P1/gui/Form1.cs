using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LAB1;

namespace gui
{
    public partial class Form1 : Form
    {
        int seed1=2, seed2=9, miejsca=100;
        public Form1()
        {
            InitializeComponent();
            textBox1.Text = "2";
            textBox2.Text = "9";
            textBox3.Text = "100";
        }
        /*public static bool TryToInt32(object value, out int result)
        {
            try
            {
                result = Convert.ToInt32(value);
                return true;
            }
            catch
            {
                result = 0;
                return false;
            }
        }*/
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Program program = new Program();
            //if (TryToInt32(textBox2.Text, seed2))
            seed2 = Convert.ToInt32(textBox2.Text);

            miejsca = Convert.ToInt32(textBox3.Text);
            seed1 = Convert.ToInt32(textBox1.Text);
            textBox4.Text= ("Spakowano pierwsze " + program.ustaf(seed1, seed2, miejsca) + " przedmiotów.");
        }
    }
}
