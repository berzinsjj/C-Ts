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
        static List<int> Saraksts = new List<int>();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int ievaditais = Convert.ToInt32(textBox1.Text);

            Random rand = new Random();

            for (int i = 0; i < ievaditais; i++)
            {
                Saraksts.Add(rand.Next(0, 11));
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int ievaditais2 = Convert.ToInt32(textBox2.Text);

            label1.Text = Convert.ToString(Saraksts[ievaditais2]);
        }
    }
}
