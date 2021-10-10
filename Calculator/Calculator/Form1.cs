using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
      
        private void button1_Click(object sender, EventArgs e)

        {
            double a, b;

                try
            {
                a = Convert.ToDouble(textBox1.Text);
                b = Convert.ToDouble(textBox2.Text);


                switch (comboBox1.Text)
                {
                    case "+":
                        textBox3.Text = Convert.ToString(a + b);
                        break;
                    case "-":
                        textBox3.Text = Convert.ToString(a - b);
                        break;
                    case "*":
                        textBox3.Text = Convert.ToString(a * b);
                        break;
                    case "/":
                        if (b == 0)
                        {
                            Clear();
                            MessageBox.Show("You cannot divide by zero");
                        }
                        textBox3.Text = Convert.ToString(a / b);
                        break;
                }
            }
            catch (Exception)
            {
                Clear();
                MessageBox.Show("Use the correct values!");
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Clear();
        }
        private void Clear()
        {
            textBox1.Text = " ";
            textBox2.Text = " ";
            textBox3.Text = " ";
            comboBox1.Text = " ";
        }
    }
}
