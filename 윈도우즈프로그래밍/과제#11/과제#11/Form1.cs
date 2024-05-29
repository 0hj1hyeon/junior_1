using System;
using System.Data;

namespace 과제_11
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button26_Click(object sender, EventArgs e)
        {
            calbox.Text += '0';
        }

        private void button4_Click(object sender, EventArgs e)
        {
            calbox.Text = "";
            resultbox.Text = "";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            double num = double.Parse(calbox.Text);
            num *= num;
            calbox.Text = "";
            calbox.Text = num.ToString();
        }

        private void seven_Click(object sender, EventArgs e)
        {
            calbox.Text += '7';
        }

        private void eight_Click(object sender, EventArgs e)
        {
            calbox.Text += '8';
        }

        private void nine_Click(object sender, EventArgs e)
        {
            calbox.Text += '9';
        }

        private void four_Click(object sender, EventArgs e)
        {
            calbox.Text += '4';
        }

        private void five_Click(object sender, EventArgs e)
        {
            calbox.Text += '5';
        }

        private void six_Click(object sender, EventArgs e)
        {
            calbox.Text += '6';
        }

        private void one_Click(object sender, EventArgs e)
        {
            calbox.Text += '1';
        }

        private void two_Click(object sender, EventArgs e)
        {
            calbox.Text += '2';
        }

        private void three_Click(object sender, EventArgs e)
        {
            calbox.Text += '3';
        }

        private void eras_Click(object sender, EventArgs e)
        {
            calbox.Text = calbox.Text.Remove(calbox.Text.Length - 1);
        }

        private void caleras_Click(object sender, EventArgs e)
        {
            calbox.Text = "";
        }

        private void sin_Click(object sender, EventArgs e)
        {
            double num = Math.Sin(double.Parse(calbox.Text) * (Math.PI / 180));
            calbox.Text = "";
            calbox.Text = num.ToString();
        }

        private void cos_Click(object sender, EventArgs e)
        {
            double num = Math.Cos(double.Parse(calbox.Text) * (Math.PI / 180));
            calbox.Text = "";
            calbox.Text = num.ToString();
        }

        private void tan_Click(object sender, EventArgs e)
        {
            double num = Math.Tan(double.Parse(calbox.Text) * (Math.PI / 180));
            calbox.Text = "";
            calbox.Text = num.ToString();
        }

        private void facto_Click(object sender, EventArgs e)
        {
            int num = int.Parse(calbox.Text);
            int result = 1;
            for (int i = 1; i <= num; i++)
            {
                result *= i;
            }
            calbox.Text = "";
            calbox.Text = result.ToString();
        }

        private void log_Click(object sender, EventArgs e)
        {
            double num = Math.Log10(double.Parse(calbox.Text));
            calbox.Text = "";
            calbox.Text = num.ToString();
        }

        private void point_Click(object sender, EventArgs e)
        {
            calbox.Text += '.';
        }

        private void chasym_Click(object sender, EventArgs e)
        {
            double num = -1 * double.Parse(calbox.Text);
            calbox.Text = "";
            calbox.Text = num.ToString();
        }

        private void root_Click(object sender, EventArgs e)
        {
            double num = Math.Sqrt(double.Parse(calbox.Text));
            calbox.Text = "";
            calbox.Text = num.ToString();
        }

        private void divx_Click(object sender, EventArgs e)
        {
            double num = 1 / double.Parse(calbox.Text);
            calbox.Text = "";
            calbox.Text = num.ToString();
        }

        private void add_Click(object sender, EventArgs e)
        {
            resultbox.Text += calbox.Text + "+";
            calbox.Text = "";
        }

        private void sub_Click(object sender, EventArgs e)
        {
            resultbox.Text += calbox.Text + "-";
            calbox.Text = "";
        }

        private void mul_Click(object sender, EventArgs e)
        {
            resultbox.Text += calbox.Text + "*";
            calbox.Text = "";
        }

        private void div_Click(object sender, EventArgs e)
        {
            resultbox.Text += calbox.Text + "/";
            calbox.Text = "";
        }

        private void eq_Click(object sender, EventArgs e)
        {
            if (calbox != null)
            {
                var result = new DataTable().Compute(resultbox.Text + calbox.Text, null);
                resultbox.Text = "";
                calbox.Text = "";
                calbox.Text = result.ToString();
            }
        }
    }
}