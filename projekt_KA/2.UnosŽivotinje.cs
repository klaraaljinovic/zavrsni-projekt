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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace projekt_KA
{
    public partial class UnosŽivotinje : Form
    {
        public UnosŽivotinje()
        {
            InitializeComponent();
          
        }
        string pime, pvrsta, ppasmina, pspol, pkastriran, pnapomena, pdob, pdolazak, pcjepljen;

       
        private void pasmina_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            pvrsta = comboBox1.Text;
            ppasmina = textBox2.Text;
            pime = textBox1.Text;
            pdob= numericUpDown1.Text;
            pdolazak = dateTimePicker1.Text;
            pnapomena = textBox4.Text;
            StreamReader sr = new StreamReader("ID.txt", true);
            string sID = sr.ReadLine();
            int IDt = int.Parse(sID);
            sr.Close();
            if (musko.Checked)
            {
                pspol = "muško";
            }
            else
            {
                if (zensko.Checked)
                {
                    pspol = "žensko";
                }
                else
                {
                    pspol = "nepoznat";
                }

            }
            if (checkBox2.Checked)
            {
                pkastriran = "kastriran";
            }
            else
            {
                pkastriran = "nekastriran";
            }
            if (checkBox1.Checked)
            {
                pcjepljen = "cjepljen";
            }
            else
            {
                pcjepljen = "necjepljen";
            }
            string unos = IDt + "|" + pime + "|" + pvrsta +"|" + ppasmina + "|" + pdob  + "|" + pdolazak + "|" + pnapomena + "|" + pspol + "|" + pcjepljen + "|" + pkastriran + "|";
            StreamReader srg = new StreamReader("Godine.txt", true);
            string sGod = srg.ReadLine();
            int God = int.Parse(sGod);
            srg.Close();
            God = int.Parse(pdob) + God;
            File.WriteAllText(@"Godine.txt", "");
            StreamWriter swg = new StreamWriter("Godine.txt", true);
            swg.WriteLine(God);
            swg.Close();

            StreamReader sra = new StreamReader("Azil.txt", true);
            string sAzil = sra.ReadLine();
            int Azil = int.Parse(sAzil);
            sra.Close();
            Azil++;
            File.WriteAllText(@"Azil.txt", "");
            StreamWriter swa = new StreamWriter("Azil.txt", true);
            swa.WriteLine(Azil);
            swa.Close();

            if (comboBox1.Text == "Pas")
            {
                StreamWriter sw = new StreamWriter("pas.txt", true);
                sw.WriteLine(unos);
                sw.Close();
                IDt++;
            }
           else if (comboBox1.Text == "Koza")
            {
                StreamWriter sw = new StreamWriter("Koza.txt", true);
                sw.WriteLine(unos);
                sw.Close();
                IDt++;
            }
            else if (comboBox1.Text == "Cincila")
            {
                StreamWriter sw = new StreamWriter("Cincila.txt", true);
                sw.WriteLine(unos);
                sw.Close();
                IDt++;
            }
            else if (comboBox1.Text == "Konj")
            {
                StreamWriter sw = new StreamWriter("Konj.txt", true);
                sw.WriteLine(unos);
                sw.Close();
                IDt++;
            }
            else if (comboBox1.Text == "Maca")
            {
                StreamWriter sw = new StreamWriter("Maca.txt", true);
                sw.WriteLine(unos);
                sw.Close();
                IDt++;
            }

            File.WriteAllText(@"ID.txt", "");
            StreamWriter sw1 = new StreamWriter("ID.txt", true);
            sw1.WriteLine(IDt);
            sw1.Close();
            this.Hide();
            Izbornik izbor = new Izbornik();
            izbor.ShowDialog();
            this.Close();
        }
    }
}
