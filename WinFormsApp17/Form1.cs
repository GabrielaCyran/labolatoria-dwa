using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp17
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
    

        }







       public  double wzrost;



        private void button1_Click(object sender, EventArgs e)
        {

            if ( checkBox1.Checked)
            {



                wzrost = Double.Parse(textBox1.Text);

                label3.Text = (wzrost - 100).ToString();

            }

            if(radioButton1.Checked && checkBox2.Checked)
            {
                 double wspol=0.85;
                
                wzrost = Double.Parse(textBox1.Text);
                label3.Text =((wzrost - 100)*wspol).ToString();
            }

            if(radioButton2.Checked && checkBox2.Checked)
            {
                double wspol = 0.9;
                wzrost = Double.Parse(textBox1.Text);
                label3.Text = ((wzrost - 100) * wspol).ToString();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {


        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {








        }

        private void label3_Click(object sender, EventArgs e)
        {

        }






    }
}
