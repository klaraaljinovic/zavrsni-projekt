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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace projekt_KA
{
    public partial class UnosŽivotinje : Form
    {
        public UnosŽivotinje()
        {
            InitializeComponent();
        }
        string pime, ppasmina, pspol, pstatus, pnapomena, pdob, pdolazak;

        private void pasmina_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox2.Text = ppasmina.ToString();
            textBox1.Text = pime.ToString();
            numericUpDown1.Text = pdob.ToString();
            dateTimePicker1.Text = pdolazak.ToString();
            textBox4.Text = pnapomena.ToString();
            string unos = ppasmina + "|" + pime + "|" + pdob + "|" + pdolazak + "|" + pnapomena;
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
