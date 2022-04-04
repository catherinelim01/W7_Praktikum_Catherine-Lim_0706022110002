using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace W7_Praktikum_Catherine_Lim_0706022110002
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        char[] arrayHuruf = { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z'};
        string output;
        int angkaSatu, angkaDua, selisih;
      
        private void buttonKonversi_Click(object sender, EventArgs e)
        {
            string kalimat = textBoxKalimat.Text.ToUpper();
            char[] karakter = kalimat.ToCharArray();

            char[] hurufString = textBoxHuruf.Text.ToUpper().ToCharArray();
            char[] hurufStringDua = textBoxHurGanti.Text.ToUpper().ToCharArray();

            for (int i = 0; i < arrayHuruf.Count(); i++)
            {
                if (hurufString [0] == arrayHuruf[i])
                {
                    angkaSatu = i;
                }
            }

            for (int i = 0; i < arrayHuruf.Count(); i++)
            {
                if (hurufStringDua[0] == arrayHuruf[i])
                {
                    angkaDua = i;
                }
            }

            selisih = angkaDua - angkaSatu;

            for (int i = 0; i < karakter.Count(); i++)
            {
                for (int j = 0; j < arrayHuruf.Count(); j++)
                {
                    if (karakter[i] == arrayHuruf[j])
                    {
                         output += arrayHuruf[j + selisih];
                    }
                }
            }
            labelOutput.Text = output;

        }
    }
}
