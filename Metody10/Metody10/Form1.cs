using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Metody10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private bool ObsahujeCislici (string retezec, out int cifSoucet, out int soucetSudCif, out int soucetLichCif)
        {
            bool obsahujeCislici = false;
            cifSoucet = 0;
            soucetSudCif = 0;
            soucetLichCif = 0;

            char[] Cifry = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };

            foreach (char znak in retezec)
            {
                if (Cifry.Contains(znak))
                {
                    int cifra = int.Parse(znak.ToString());
                    obsahujeCislici = true;
                    cifSoucet += cifra;
                    if (cifra % 2 == 0) soucetSudCif += cifra;
                    else soucetLichCif += cifra;
                }
            }

            return obsahujeCislici;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string s = textBox1.Text;
            int v1, v2, v3;

            if (ObsahujeCislici(s, out v1, out v2, out v3)) MessageBox.Show("Ano, daný řetězec obsahuje čifru\n" + "Součet všech cifer je: " + v1 +
                "\nSoučet všech sudých cifer je: " + v2 + "\nSoučet všech lichých cifer je: " + v3);
            else MessageBox.Show("Ne, daný řetězec neobsahuje cifru");
        }
    }
}
