using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Metody11
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private int PocetSlov(string retezec, out string vyslednyRetezec)
        {
            char[] separator = { ' ' };
            string[] slova = retezec.Split(separator, StringSplitOptions.RemoveEmptyEntries);
            int pocetSlov = slova.Length;

            int i = 0;
            while (i < retezec.Length)
            { 
                if (Char.IsDigit(retezec[i])) retezec = retezec.Remove(i, 1);
                else ++i;
            }

            vyslednyRetezec = retezec;
            return pocetSlov;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string s = textBox1.Text;
            string s2;

            MessageBox.Show("Počet slov v řetězci je: " + PocetSlov(s, out s2) + "\nUpravený řezězec vypadá takto: " + s2);
        }
    }
}
