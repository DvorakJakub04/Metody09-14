using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Metody12
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private bool ObsahujeSlovo (string retezec, out string nejdelsiSlovo, out string nejkratsiSlovo)
        {
            bool obsahujeSlovo = false;
            string[] separator = { " " };
            string[] slova = retezec.Split(separator, StringSplitOptions.RemoveEmptyEntries);
            nejdelsiSlovo = "xxx";
            nejkratsiSlovo = "xxx";

            if (slova.Length > 0)
            {
                obsahujeSlovo = true;
                nejdelsiSlovo = slova[0];
                nejkratsiSlovo = slova[0];
                foreach (string slovo in slova)
                {
                    if (slovo.Length > nejdelsiSlovo.Length) nejdelsiSlovo = slovo;
                    if (slovo.Length < nejkratsiSlovo.Length) nejkratsiSlovo = slovo;
                }
            }

            return obsahujeSlovo;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string s = textBox1.Text;
            string nejdelsiSlovo, nejkratsiSlovo;

            if (ObsahujeSlovo(s, out nejdelsiSlovo, out nejkratsiSlovo)) MessageBox.Show("Ano, daný řetězec obsahuje alespoň jedno slovo" + "\nNejdelší slovo v řetezci je: " + nejdelsiSlovo
                + "\nNejkratší slovo v řetězci je: " + nejkratsiSlovo);
            else MessageBox.Show("Ne, řetězec neobsahuje žádné slovo");
        }
    }
}
