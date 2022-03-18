using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Metody13
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private bool JeAlfanum (string retezec, out int pocetMalPis, out int pocetVelPis, out int pocetJinych)
        {
            bool jeAlfanum = true;
            pocetMalPis = 0;
            pocetVelPis = 0;
            pocetJinych = 0;

            for (int i = 0; i < retezec.Length; ++i)
            {
                if (char.IsLetterOrDigit(retezec[i]))
                {
                    if (char.IsUpper(retezec[i])) ++pocetVelPis;
                    else if (char.IsLower(retezec[i])) ++pocetMalPis;
                }
                else ++pocetJinych;                
            }

            if (pocetJinych > 0) jeAlfanum = false;
            return jeAlfanum;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string s = textBox1.Text;
            int pocet1 = 0, pocet2 = 0, pocet3 = 0;

            if (JeAlfanum(s, out pocet1, out pocet2, out pocet3)) MessageBox.Show("Ano, daný řetězec obsahuje pouze písmena a cifry\n" + "Počet malých čísel v řetězci je: " + pocet1
                + "\nPočet velkých písmen je: " + pocet2 + "\nPočet jiných znaků než alfanumerických je: " + pocet3);
            else MessageBox.Show("Ne, daný řetězec neobsahuje pouze písmena a cifry\n" + "Počet malých čísel v řetězci je: " + pocet1 + "\nPočet velkých písmen je: " + pocet2
                + "\nPočet jiných znaků než alfanumerických je: " + pocet3);
        }
    }
}
