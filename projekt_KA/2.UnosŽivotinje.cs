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
        string pime, ppasmina, pspol, pkastriran, pnapomena, pdob, pdolazak, pcjepljen;

        private void pasmina_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ppasmina = textBox2.Text;
            pime = textBox1.Text;
            pdob= numericUpDown1.Text;
            pdolazak = dateTimePicker1.Text;
            pnapomena = textBox4.Text;
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
            string unos = ppasmina + "|" + pime + "|" + pdob + "|" + pdolazak + "|" + pnapomena + "|" + pspol + "|" + pcjepljen + "|" + pkastriran;
            StreamWriter sw = new StreamWriter("pas.txt", true);
            sw.WriteLine(unos);
            sw.Close();
            this.Hide();
            Izbornik izbor = new Izbornik();
            izbor.ShowDialog();
            this.Close();
        }
    }
}
