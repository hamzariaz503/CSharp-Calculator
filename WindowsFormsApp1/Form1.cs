﻿using System;
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
        string CalTotal;
        int num1;
        int num2;
        string option;
        int result;
 

        private void button1_Click(object sender, EventArgs e)
        {

            textBox1.Text = textBox1.Text + "1";
        }
        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "2";
        }
        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "5";
        }
        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "4";
        }
        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "3";
        }
        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "8";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "9";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "0";
        }
        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "7";
        }
        private void button10_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "6";
        }

      
        private void button11_Click(object sender, EventArgs e)
        {
            option = "*";
            num1 = int.Parse(textBox1.Text);

            textBox1.Clear();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            option = "/";
            num1 = int.Parse(textBox1.Text);

            textBox1.Clear();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            result = (0);
            num1 = (0);
            num2 = (0);
        }
        private void button14_Click(object sender, EventArgs e)
        {
            option = "-";
            num1 = int.Parse(textBox1.Text);

            textBox1.Clear();
        }
        private void button15_Click(object sender, EventArgs e)
        {
            option = "+";
            num1 = int.Parse(textBox1.Text);

            textBox1.Clear();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            num2 = int.Parse(textBox1.Text);
    switch (option)
    {
        case "+":
            result = num1 + num2;
            break;
        case "-":
            result = num1 - num2;
            break;
        case "*":
            result = num1 * num2;
            break;
        case "/":
            if (num2 != 0)
                result = num1 / num2;
            else
                MessageBox.Show("Cannot divide by zero!");
            break;
        default:
            MessageBox.Show("Invalid option!");
            break;
    }
    textBox1.Text = result.ToString();
        }
    }
}
