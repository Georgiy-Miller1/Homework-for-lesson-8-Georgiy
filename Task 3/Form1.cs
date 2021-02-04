using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task_3
{
    public partial class Form1 : Form
    {
        double plus, minus, star,b;
        public Form1()
        {
            InitializeComponent();
            label1.Text = "";
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void Button10_Click(object sender, EventArgs e)
        {
            label1.Text += this.button10.Text;
        }

        private void Button17_Click(object sender, EventArgs e)
        {
            label1.Text += this.button17.Text;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
          
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Text += this.button1.Text;
        }

        private void Label1_Click(object sender, EventArgs e)
        {
            label1.Text += this.button11.Text;
        }

        private void Button18_Click(object sender, EventArgs e)
        {
            label1.Text += this.button18.Text;
        }

        private void Button19_Click(object sender, EventArgs e)
        {
            if(plus != 0)
            {
                b = Convert.ToDouble(label1.Text);
                label1.Text = Convert.ToString(plus + b);
            }
        }

        private void Button12_Click(object sender, EventArgs e)
        {
            label1.Text += this.button12.Text;
        }

        private void Button14_Click(object sender, EventArgs e)
        {
            label1.Text += this.button14.Text;
        }

        private void Button16_Click(object sender, EventArgs e)
        {
            label1.Text += this.button16.Text;
        }

        private void Button9_Click(object sender, EventArgs e)
        {
            label1.Text += this.button9.Text;
        }

        private void Button11_Click(object sender, EventArgs e)
        {
            label1.Text += this.button11.Text;
        }

        private void Button13_Click(object sender, EventArgs e)
        {
            label1.Text += this.button13.Text;
        }

        private void Button15_Click(object sender, EventArgs e)
        {
            label1.Text += this.button15.Text;
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            label1.Text += this.button5.Text;
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            label1.Text += this.button6.Text;
        }

        private void Button7_Click(object sender, EventArgs e)
        {
            label1.Text += this.button7.Text;
        }

        private void Button8_Click(object sender, EventArgs e)
        {
            label1.Text += this.button8.Text;
        }

        private void Label1_Click_1(object sender, EventArgs e)
        {

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            label1.Text += this.button2.Text;
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            label1.Text += this.button3.Text;
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            plus = Convert.ToDouble(label1.Text);
            label1.Text = "";
        }
    }
}
