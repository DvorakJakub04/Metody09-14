using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Metody14
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private bool Identicke (string retezec1, string retezec2, out int pocetLisicich, out int indPrvOdl)
        {
            bool identicke = true;
            pocetLisicich = 0;
            indPrvOdl = -1;
            int velikost = -1;

            if (retezec1.Length == retezec2.Length) velikost = retezec1.Length;
            else if (retezec1.Length > retezec2.Length)
            {
                pocetLisicich = retezec1.Length - retezec2.Length;
                velikost = retezec2.Length;
                indPrvOdl = retezec2.Length;
            }
            else if (retezec2.Length > retezec1.Length)
            {
                pocetLisicich = retezec2.Length - retezec1.Length;
                velikost = retezec1.Length;
                indPrvOdl = retezec1.Length;
            }

            for (int i = 0; i < velikost; ++i) if (retezec1[i] != retezec2[i])
                {
                    ++pocetLisicich;
                    if (indPrvOdl == -1) indPrvOdl = i;
                }
                        
            if (pocetLisicich > 0) identicke = false;
            return identicke;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string s1 = textBox1.Text;
            string s2 = textBox2.Text;
            int pocet = 0, index;

            if (Identicke(s1, s2, out pocet, out index)) MessageBox.Show("Ano, řetězce jsou indentické");
            else MessageBox.Show("Ne, řetězce nejsou identické" + "\nPočet lišících se znaků je: " + pocet + "\nIndex prvního líšíciho se prvku je: " + index);
        }
    }
}
