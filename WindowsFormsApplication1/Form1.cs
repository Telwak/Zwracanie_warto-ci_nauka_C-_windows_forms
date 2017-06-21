using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        enum Ocena
        {
            niedostateczna = 1,
            mierna,
            dostateczna,
            dobra,
            bardzo_dobra,
            celująca 
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        public  int Mnożenie(int a, int b)
        {
            int c = a * b;
            return c;
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool walidacja = Walidacja1(textBox1.Text, textBox2.Text);
            if (!walidacja)
            {
                textBox5.Text = "Błąd!";
                return;
            }

            int pierwsza_wartosc = int.Parse(textBox1.Text);
            int druga_wartosc = int.Parse(textBox2.Text);
            int Wynik = Mnożenie(pierwsza_wartosc, druga_wartosc);
            textBox5.Text = Wynik.ToString();
        }
        public bool Walidacja1(string a, string b)
        {
            if (a == "" || b == "")
            { return false; }
            int n;
            int e;
            bool Pierwsza = int.TryParse(a, out n);
            bool Druga = int.TryParse(a, out e);

            if (Pierwsza || Druga)
            {
                return true;
            }
            else
            {
                return false;
            }

            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            bool walidacja_wynik = Walidacja(textBox3.Text);
            if (!walidacja_wynik)
            {
                textBox4.Text = "Błąd";
                return;
            }

            textBox4.Text = Enum_TO_STRING(textBox3.Text);
        }
        public bool Walidacja(string a)
        {
            int e;
            bool Pierwsza = int.TryParse(a, out e);
            if (Pierwsza)
            {
                return true;
            }
            else
            {
                return false;
            }
         
        }
        public string Enum_TO_STRING(string a)
        {
            int b = int.Parse(a);
 
            switch (b)
            {
                case 1:
                    return Ocena.niedostateczna.ToString();
                    break;

                case 2:
                    return Ocena.mierna.ToString();
                    break;

                case 3:
                    return Ocena.dostateczna.ToString();
                    break;

                case 4:
                    return Ocena.dobra.ToString();
                    break;
                case 5:
                    return Ocena.bardzo_dobra.ToString();
                    break;
                case 6:
                    return Ocena.celująca.ToString();
                    break;
                default:
                    break;
            }
            return "Niepoprawny zakres oceny";

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
