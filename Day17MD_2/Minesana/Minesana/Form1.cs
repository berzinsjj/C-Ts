using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Minesana
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void PirmaPoga_Click(object sender, EventArgs e)
        {
            string input = PirmaIevade.Text;
            
        }

        public void OtraPoga_Click(object sender, EventArgs e)
        {
            string input2 = OtraIevade.Text;

            if (PirmaIevade.Text == input2)
            {
                RezultatuRaditajs.Text = "Uzminejat";
            }
            else
            {
                RezultatuRaditajs.Text = "Neuzminejat " + " vards bija: " + PirmaIevade.Text;
            }
        }
    }
}
