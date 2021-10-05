using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Poga_Click(object sender, EventArgs e)
        {
            try
            {
                int pirmais = Convert.ToInt32(TekstuIerakstitajs.Text);
                int otrais = Convert.ToInt32(TekstuIerakstitajs2.Text);

                int result = pirmais + otrais;
                RezultatuRaditajs.Text = Convert.ToString(result);
            }
            catch
            {
                RezultatuRaditajs.Text = "Ievadi skaitli";
            }
            
        }
    }
}
