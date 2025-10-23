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

        private void izlaz2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Izbornik izbor = new Izbornik();
            izbor.ShowDialog();
            this.Close();
        }
    }
}
