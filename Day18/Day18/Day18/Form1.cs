using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Day18
{

    public partial class Form1 : Form
    {
        int count = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Poga_Click(object sender, EventArgs e)
        {
            count++;
            RezultataRaditajs.Text = count.ToString();

            if (count == 10)
            {
                count = -1;
            }
        }
    }
}
