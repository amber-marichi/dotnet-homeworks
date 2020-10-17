using System;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            if(radioButton1.Checked)
            {
                int A = Int32.Parse(textBox1.Text);
                int B = Int32.Parse(textBox2.Text);
                int sum = A + B;
                textBox3.Text = Convert.ToString(sum);
            }
            if(radioButton2.Checked)
            {
                int A = Int32.Parse(textBox1.Text);
                int B = Int32.Parse(textBox2.Text);
                int remain = A % B;
                textBox3.Text = Convert.ToString(remain); 
            }
            if (radioButton3.Checked)
            {
                int A = Int32.Parse(textBox1.Text);
                int B = Int32.Parse(textBox2.Text);
                double multi = Math.Pow(A, B);
                textBox3.Text = Convert.ToString(multi);
            }
            if(radioButton4.Checked)
            {
                int A = Int32.Parse(textBox1.Text);
                int B = Int32.Parse(textBox2.Text);
                int divide = A & B;
                textBox3.Text = Convert.ToString(divide);
                //textBox3.Text = textBox1.Text + textBox2.Text;
            }
            if(radioButton5.Checked)
            {
                double A = Int32.Parse(textBox1.Text);
                double B = Int32.Parse(textBox2.Text);
                double divide = A / B;
                textBox3.Text = Convert.ToString(divide);
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
