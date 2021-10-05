using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Day_19md
{
    public partial class Form1 : Form
    {
        List<String> firstList = new List<String>();
        List<String> secondList = new List<String>();
        List<String> tridList = new List<String>();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            firstList.Add(richTextBox1.Text);

            if (firstList.Count == 3)
            {
                label1.Text = "IR jau 3";
            }

            for (int i = 0; i < firstList.Count; i++)
            {
                // if it is List<String>
                if (firstList[i].Equals(richTextBox1.Text))
                {
                    firstList.RemoveAt(i);
                }

            }

            String result = "";

            for (int i = 0; i <firstList.Count; i++)
            {
                result += Convert.ToString(firstList[i]);
            }

            label1.Text = result;

            

        }

        private void button2_Click(object sender, EventArgs e)
        {
          
           

        }
    }
}
