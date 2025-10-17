using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projekt_KA
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 unos = new Form2();
            unos.ShowDialog();
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void izlaz_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Close();
        }

        private void statistika_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form6 stat = new Form6();
            stat.ShowDialog();
            this.Close();
        }

        private void pregled_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3 preg = new Form3();
            preg.ShowDialog();
            this.Close();
        }

    }
}

