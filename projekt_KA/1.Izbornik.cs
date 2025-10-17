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
    public partial class Izbornik : Form
    {
        public Izbornik()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            UnosŽivotinje unos = new UnosŽivotinje();
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
            Statistika stat = new Statistika();
            stat.ShowDialog();
            this.Close();
        }

        private void pregled_Click(object sender, EventArgs e)
        {
            this.Hide();
            PregledŽivotinje preg = new PregledŽivotinje();
            preg.ShowDialog();
            this.Close();
        }

    }
}

