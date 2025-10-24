using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projekt_KA
{
    public partial class UdomiŽivotinju : Form
    {
        int Udom;
        int Azil;
        
        public UdomiŽivotinju()
        {
            InitializeComponent();
            StreamReader sro = new StreamReader("Udom.txt", true);
            string sUdom = sro.ReadLine();
            Udom = int.Parse(sUdom);
            sro.Close();
            StreamReader sr2 = new StreamReader("Azil.txt", true);
            string sAzil = sr2.ReadLine();
            Azil = int.Parse(sAzil);
            sr2.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        { 
            if (textBox2.Text=="Pas" ) {

                StreamReader sr = new StreamReader("pas.txt", true);
                string pas = sr.ReadToEnd();
                sr.Close();
                string[] dijelovi = pas.Split('|');
                for (int i = 0; i < dijelovi.Length; i++)
                {

                    if (dijelovi[i] == textBox1.Text && dijelovi[i + 1] == textBox2.Text && dijelovi[i + 2] == textBox3.Text && dijelovi[i + 3] == textBox4.Text)
                    {
                        MessageBox.Show("Životinja je uspješno udomljena!");
                        File.WriteAllText(@"Udom.txt", "");
                        StreamWriter sw1 = new StreamWriter("Udom.txt", true);
                        Udom++;
                        sw1.WriteLine(Udom);
                        sw1.Close();
                        File.WriteAllText(@"Azil.txt", "");
                        StreamWriter sw2 = new StreamWriter("Azil.txt", true);
                        Azil--;
                        sw2.WriteLine(Azil);
                        sw2.Close();
                        break;

                    }
                    if (i == dijelovi.Length - 1) {
                        MessageBox.Show("Unesena nepostojeća životinja!");
                    }
                }
            }
            else if (textBox2.Text == "Maca")
            {
                StreamReader sr = new StreamReader("maca.txt", true);
                string pas = sr.ReadToEnd();
                sr.Close();
                string[] dijelovi = pas.Split('|');
                for (int i = 0; i < dijelovi.Length; i++)
                {

                    if (dijelovi[i] == textBox1.Text && dijelovi[i + 1] == textBox2.Text && dijelovi[i + 2] == textBox3.Text && dijelovi[i + 3] == textBox4.Text)
                    {
                        MessageBox.Show("Životinja je uspješno udomljena!");
                        File.WriteAllText(@"Udom.txt", "");
                        StreamWriter sw1 = new StreamWriter("Udom.txt", true);
                        Udom++;
                        sw1.WriteLine(Udom);
                        sw1.Close();
                        File.WriteAllText(@"Azil.txt", "");
                        StreamWriter sw2 = new StreamWriter("Azil.txt", true);
                        Azil--;
                        sw2.WriteLine(Azil);
                        sw2.Close();
                        break;

                    }
                    if (i == dijelovi.Length - 1)
                    {
                        MessageBox.Show("Unesena nepostojeća životinja!");
                    }
                }

            }
            else if (textBox2.Text == "Konj")
            {
                StreamReader sr = new StreamReader("Konj.txt", true);
                string pas = sr.ReadToEnd();
                sr.Close();
                string[] dijelovi = pas.Split('|');
                for (int i = 0; i < dijelovi.Length; i++)
                {

                    if (dijelovi[i] == textBox1.Text && dijelovi[i + 1] == textBox2.Text && dijelovi[i + 2] == textBox3.Text && dijelovi[i + 3] == textBox4.Text)
                    {
                        MessageBox.Show("Životinja je uspješno udomljena!");
                        File.WriteAllText(@"Udom.txt", "");
                        StreamWriter sw1 = new StreamWriter("Udom.txt", true);
                        Udom++;
                        sw1.WriteLine(Udom);
                        sw1.Close();
                        File.WriteAllText(@"Azil.txt", "");
                        StreamWriter sw2 = new StreamWriter("Azil.txt", true);
                        Azil--;
                        sw2.WriteLine(Azil);
                        sw2.Close();
                        break;

                    }
                    if (i == dijelovi.Length - 1)
                    {
                        MessageBox.Show("Unesena nepostojeća životinja!");
                    }
                }

            }
            else if (textBox2.Text == "Cincila")
            {
                StreamReader sr = new StreamReader("Cincila.txt", true);
                string pas = sr.ReadToEnd();
                sr.Close();
                string[] dijelovi = pas.Split('|');
                for (int i = 0; i < dijelovi.Length; i++)
                {

                    if (dijelovi[i] == textBox1.Text && dijelovi[i + 1] == textBox2.Text && dijelovi[i + 2] == textBox3.Text && dijelovi[i + 3] == textBox4.Text)
                    {
                        MessageBox.Show("Životinja je uspješno udomljena!");
                        File.WriteAllText(@"Udom.txt", "");
                        StreamWriter sw1 = new StreamWriter("Udom.txt", true);
                        Udom++;
                        sw1.WriteLine(Udom);
                        sw1.Close();
                        File.WriteAllText(@"Azil.txt", "");
                        StreamWriter sw2 = new StreamWriter("Azil.txt", true);
                        Azil--;
                        sw2.WriteLine(Azil);
                        sw2.Close();
                        break;

                    }
                    if (i == dijelovi.Length - 1)
                    {
                        MessageBox.Show("Unesena nepostojeća životinja!");
                    }
                }

            }
            else if (textBox2.Text == "Koza")
            {
                StreamReader sr = new StreamReader("Koza.txt", true);
                string pas = sr.ReadToEnd();
                sr.Close();
                string[] dijelovi = pas.Split('|');
                for (int i = 0; i < dijelovi.Length; i++)
                {

                    if (dijelovi[i] == textBox1.Text && dijelovi[i + 1] == textBox2.Text && dijelovi[i + 2] == textBox3.Text && dijelovi[i + 3] == textBox4.Text)
                    {
                        MessageBox.Show("Životinja je uspješno udomljena!");
                        File.WriteAllText(@"Udom.txt", "");
                        StreamWriter sw1 = new StreamWriter("Udom.txt", true);
                        Udom++;
                        sw1.WriteLine(Udom);
                        sw1.Close();
                        File.WriteAllText(@"Azil.txt", "");
                        StreamWriter sw2 = new StreamWriter("Azil.txt", true);
                        Azil--;
                        sw2.WriteLine(Azil);
                        sw2.Close();
                        break;

                    }
                    if (i == dijelovi.Length - 1)
                    {
                        MessageBox.Show("Unesena nepostojeća životinja!");
                    }
                }

            }

        }
    }
}
