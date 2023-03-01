using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kalkulator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void OK_Click(object sender, EventArgs e)
        {
            double a, b;
            try
            {
                a = Convert.ToDouble(textBox1.Text);
            }
            catch
            {
                Wynik.Text = "ERR";
                return;
            }

            try
            {
                b = Convert.ToDouble(textBox2.Text);
            }
            catch
            {
                Wynik.Text = "ERR";
                return;
            }

            if (Dodawanie.Checked == true)
                Wynik.Text = Convert.ToString(a + b);
            if (Odejmowaie.Checked == true)
                Wynik.Text = Convert.ToString(a - b);
            if (Mnozenie.Checked == true)
                Wynik.Text = Convert.ToString(a * b);
            if (Dzielenie.Checked == true)
            {
                if (b == 0)
                    Wynik.Text = "#DZIEL/0";
                else
                    Wynik.Text = Convert.ToString(a / b);
            }

            }

        private void Dodawanie_CheckedChanged(object sender, EventArgs e)
        {
            Wynik.Text = "";
        }

        private void Odejmowaie_CheckedChanged(object sender, EventArgs e)
        {
            Wynik.Text = "";
        }

        private void Mnozenie_CheckedChanged(object sender, EventArgs e)
        {
            Wynik.Text = "";
        }

        private void Dzielenie_CheckedChanged(object sender, EventArgs e)
        {
            Wynik.Text = "";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            Wynik.Text = "";
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            Wynik.Text = "";
        }

        private void OK_KeyDown(object sender, KeyEventArgs e)
        {
           
        }
    }
}
