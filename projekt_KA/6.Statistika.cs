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
    public partial class Statistika : Form
    {
        public Statistika()
        {
            InitializeComponent();
            StreamReader sr = new StreamReader("Udom.txt", true);
            string sUdom = sr.ReadLine();
            int Udom = int.Parse(sUdom);
            StreamReader sr1 = new StreamReader("Azil.txt", true);
            string sAzil = sr1.ReadLine();
            int Azil = int.Parse(sAzil);
            float suma = Azil + Udom;
            textBox1.Text = suma.ToString();
            textBox2.Text = sUdom;
            textBox3.Text = sAzil;
            StreamReader srg = new StreamReader("Godine.txt", true);
            string sGod = srg.ReadLine();
            float God = float.Parse(sGod);
            float pGod = God / suma;
            textBox4.Text = pGod.ToString();
            srg.Close();
            textBox5.Text = suma.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            UdomiŽivotinju dom = new UdomiŽivotinju();
            dom.ShowDialog();
            this.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
