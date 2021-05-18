using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp18
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                 this.textBox1.Font = new System.Drawing.Font("Times New Roman", 10);


            }
            if (radioButton2.Checked)
            {
                this.textBox1.Font= new System.Drawing.Font("Times New Roman", 20);

            }
            if(radioButton3.Checked)
            {
               this.textBox1.Font=new  System.Drawing.Font("Times New Roman", 30);
            }
             
             if(checkBox1.Checked )
            {
                this.textBox1.Font = new Font(this.textBox1.Font, FontStyle.Bold);

              


            }

            if (checkBox2.Checked)
            {
                this.textBox1.Font = new Font(this.textBox1.Font, FontStyle.Italic);
            }

             if(checkBox3.Checked)
            {
                this.textBox1.Font= new Font(this.textBox1.Font, FontStyle.Underline);
            }

             if(radioButton4.Checked)
            {
                textBox1.ForeColor = Color.Red;
            }
             if(radioButton5.Checked)
            {
                textBox1.ForeColor = Color.Blue;
            }
             if(radioButton6.Checked)
            {
                textBox1.ForeColor = Color.Orange;
            }
        }

       
    }
}
