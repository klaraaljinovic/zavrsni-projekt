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
        public UdomiŽivotinju()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            StreamReader sr = new StreamReader("pas.txt", true);
            string pas= sr.ReadLine();
            sr.Close();
            string[] dijelovi = pas.Split('|');
            for (int i = 0; i < dijelovi.Length; i++)
            {
                
                if (dijelovi[i] == textBox1.Text && dijelovi[i + 1] == textBox2.Text && dijelovi[i + 2] == textBox3.Text && dijelovi[i + 3] == textBox4.Text)
                {
                    MessageBox.Show("Životinja je uspješno udomljena!");
                    break;
                  
                }
                if (i == dijelovi.Length-1) {
                    MessageBox.Show("Unesena nepostojeća životinja!");
                }
            }
            
        }
    }
}
