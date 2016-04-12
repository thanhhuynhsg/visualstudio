using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //this.Text = "Hello"; //set title
            //this.textbox1.Text = "Monkeys";

            //this.btn1.Text = "OK";
            this.btn1.Click += new EventHandler(button1_Click); // get click event
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //set name = textbox1   
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //set name = btn1
            double h = Convert.ToDouble(txt.Text);
            double w = Convert.ToDouble(txt2.Text);
            double bmi = w / (h*h);
            MessageBox.Show("Chỉ số BMI của bạn: " +bmi); //show message
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
