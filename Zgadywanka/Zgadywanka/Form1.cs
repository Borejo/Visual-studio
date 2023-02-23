using System.Threading;
using System.Threading.Tasks;

namespace Zgadywanka
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Wyzeruj()
        {
            if (Ekran.Text.StartsWith("Zgaduj"))
            {
                Ekran.Text = "";
            }
            if (Ekran.Text.StartsWith("Za duza"))
            {
                Ekran.Text = "";
            }
            if (Ekran.Text.StartsWith("Za mala"))
            {
                Ekran.Text = "";
            }
            if (Ekran.Text.StartsWith("Brawo"))
            {
                Ekran.Text = "";
            }
        }
        int liczba_od, liczba_do;
        int licznik = 1;
        int wylosowana;
        bool jest_wylosowana = false;
        bool zakres_wybrany = false;
        private void button1_Click(object sender, EventArgs e)
        {
            if (jest_wylosowana && zakres_wybrany)
            {
                Wyzeruj();
                Ekran.Text += "1";
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (jest_wylosowana && zakres_wybrany)
            {
                Wyzeruj();
                Ekran.Text += "2";
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (jest_wylosowana && zakres_wybrany)
            {
                Wyzeruj();
                Ekran.Text += "3";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (jest_wylosowana && zakres_wybrany)
            {
                Wyzeruj();
                Ekran.Text += "4";
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (jest_wylosowana && zakres_wybrany)
            {
                Wyzeruj();
                Ekran.Text += "5";
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (jest_wylosowana && zakres_wybrany)
            {
                Wyzeruj();
                Ekran.Text += "6";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (jest_wylosowana && zakres_wybrany)
            {
                Wyzeruj();
                Ekran.Text += "7";
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (jest_wylosowana && zakres_wybrany)
            {
                Wyzeruj();
                Ekran.Text += "8";
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (jest_wylosowana && zakres_wybrany)
            {
                Wyzeruj();
                Ekran.Text += "9";
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (jest_wylosowana && zakres_wybrany)
            {
                Wyzeruj();
                Ekran.Text += "0";
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (zakres_wybrany)
            {
                Ekran.Text = "Zgaduj";
                jest_wylosowana = true;
                Random rand = new Random();
                wylosowana = rand.Next(liczba_od, liczba_do);
            }
        }


        private void button9_Click(object sender, EventArgs e)
        {
            if (zakres_wybrany && jest_wylosowana)
            {
                    int wartosc = Convert.ToInt32(Ekran.Text);
                    if (wylosowana == wartosc)
                    {
                    Ekran.Text = "";
                        Ekran.Text = "Brawo za: " + licznik + "x";
                        licznik = 1;
                        zakres_wybrany = false;
                        jest_wylosowana = false;
                    Task.Delay(5000).Wait();
                    Ekran.Text = "↓Podaj zakres↓";
                    }
                    if (wylosowana > wartosc)
                    {
                        Ekran.Text = "Za mala";
                        licznik++;
                    }
                    if (wylosowana < wartosc)
                    {
                        Ekran.Text = "Za duza";
                        licznik++;
                    }
            }

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void zatwierz_zakres_Click(object sender, EventArgs e)
        {
            liczba_od = Convert.ToInt32(zakres_od.Value);
            liczba_do = Convert.ToInt32(zakres_do.Value);
            zakres_wybrany = true;
            Ekran.Text = "Kliknij *";

        }
    }
}