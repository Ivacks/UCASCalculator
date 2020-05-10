using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UCASCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            String grade = textBox1.Text;
            grade = grade.ToLower();

            if (grade == "f")
            {
                label3.Text = "0-4";
            }
            else if (grade == "d")
            {
                label3.Text = "4-5";
            }
            else if (grade == "c")
            {
                label3.Text = "5-6";
            }
            else if (grade == "b")
            {
                label3.Text = "6-8";
            }
            else if (grade == "a")
            {
                label3.Text = "8-10";
            }
            else
            {
                MessageBox.Show("Enter a valid grade");
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
