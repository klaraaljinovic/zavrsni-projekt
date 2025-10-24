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
    public partial class PregledŽivotinje : Form
    {
        public PregledŽivotinje()
        {
            InitializeComponent();
     


           

        }

        private void izlaz2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Izbornik izbor = new Izbornik();
            izbor.ShowDialog();
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void prikaz_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Pas")
            {
                List<string> stringList = new List<string>();
                StreamReader sr = new StreamReader("pas.txt");
                string line = sr.ReadLine();

                while (line != null)
                {
                    stringList.Add(line);
                    line = sr.ReadLine();
                }

                listBox1.DataSource = stringList;
            }
            else if (comboBox1.Text == "Maca")
            {
                List<string> stringList2 = new List<string>();
                StreamReader sr2 = new StreamReader("Maca.txt");
                string line2 = sr2.ReadLine();

                while (line2 != null)
                {
                    stringList2.Add(line2);
                    line2 = sr2.ReadLine();
                }

                listBox1.DataSource = stringList2;
            }
            else if (comboBox1.Text == "Konj")
            {
                List<string> stringList2 = new List<string>();
                StreamReader sr2 = new StreamReader("Konj.txt");
                string line2 = sr2.ReadLine();

                while (line2 != null)
                {
                    stringList2.Add(line2);
                    line2 = sr2.ReadLine();
                }

                listBox1.DataSource = stringList2;
            }
            else if (comboBox1.Text == "Koza")
            {
                List<string> stringList2 = new List<string>();
                StreamReader sr2 = new StreamReader("Koza.txt");
                string line2 = sr2.ReadLine();

                while (line2 != null)
                {
                    stringList2.Add(line2);
                    line2 = sr2.ReadLine();
                }

                listBox1.DataSource = stringList2;
            }
            else if (comboBox1.Text == "Cincila")
            {
                List<string> stringList2 = new List<string>();
                StreamReader sr2 = new StreamReader("Cincila.txt");
                string line2 = sr2.ReadLine();

                while (line2 != null)
                {
                    stringList2.Add(line2);
                    line2 = sr2.ReadLine();
                }

                listBox1.DataSource = stringList2;
            }
        }
    }
}
