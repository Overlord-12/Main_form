using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Main_form
{
    public partial class Calcul : Form
    {
        public Calcul()
        {
            InitializeComponent();
        }

        private void Calcul_Load(object sender, EventArgs e)
        {

        }
        private void BackButton_Click(object sender, EventArgs e)
        {
            MainFor mainform = new MainFor();
            mainform.Show();
            this.Close();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            try
            {
                double a = Convert.ToDouble(textBox1.Text);
                double b = Convert.ToDouble(textBox2.Text);
                textBox3.Text = Convert.ToString(a*b);

            }
            catch
            {
                textBox3.Text = "Введены неверные значения";
            }

        }

        private void Stepen_Click(object sender, EventArgs e)
        {
            try
            {
                double a = Convert.ToDouble(textBox1.Text);
                textBox3.Text = Convert.ToString(a*a);
            }
            catch
            {
                textBox3.Text = "Введены неверные значнеия";
            }

        }

        private void share_Click(object sender, EventArgs e)
        {
            try
            {
                double a = Convert.ToDouble(textBox1.Text);
                double b = Convert.ToDouble(textBox2.Text);
                if (b == 0)
                {
                    textBox3.Text = Convert.ToString("На ноль делить нельзя!");
                }
                else
                {
                  
                    textBox3.Text = Convert.ToString(a/b);
                }
            }
            catch
            {
                textBox3.Text = " Введены неверные значения";
            }

        }

        private void plus_Click(object sender, EventArgs e)
        {
            try
            {


                double a = Convert.ToDouble(textBox1.Text);
                double b = Convert.ToDouble(textBox2.Text);
                textBox3.Text = Convert.ToString(a+b);
            }
            catch
            {
                textBox3.Text = "Введены неверные значения";

            }

        }

        private void percen_divide_Click(object sender, EventArgs e)
        {
            try
            {
                double a = Convert.ToDouble(textBox1.Text);
                double b = Convert.ToDouble(textBox2.Text);
                int result;
                result = Convert.ToInt32(a / b);
                textBox3.Text = Convert.ToString(result);
            }
            catch
            {
                textBox3.Text = "Введены неверные значения";
            }

        }

        private void minus_Click(object sender, EventArgs e)
        {
            try
            {
                double a = Convert.ToDouble(textBox1.Text);
                double b = Convert.ToDouble(textBox2.Text);
                textBox3.Text = Convert.ToString(a-b);
            }
            catch
            {
                textBox3.Text = "Введены неверные значения";

            }

        }

        private void sqrt_Click(object sender, EventArgs e)
        {
            try
            {
                double a = Convert.ToDouble(textBox1.Text);
                textBox3.Text = Convert.ToString(Math.Sqrt(a));
            }
            catch
            {
                textBox3.Text = "Введены неверные значения";

            }

        }

        private void exp_Click(object sender, EventArgs e)
        {
            try
            {
                double a = Convert.ToDouble(textBox1.Text);
                textBox3.Text = Convert.ToString(Math.Exp(a));
            }
            catch
            {
                textBox3.Text = "Введены неверные значения";

            }

        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            Funcion func = new Funcion();
            func.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                double a = Convert.ToDouble(textBox1.Text);
                double b = Convert.ToDouble(textBox2.Text);
                double a1 = (a * 3.14) / 180;
                double result;
                double x1;
                double x2;
                x1 = Math.Pow(Math.Sin(a), 2) - Math.Sqrt(Math.Exp(a1));
                x2 = Math.Sqrt(b * b - a1 * a1);
                if (x2 == 0)
                {
                    textBox3.Text = Convert.ToString("0");
                }
                else
                {
                    result = x1 / x2;
                    textBox3.Text = Convert.ToString(result);

                }
            }
            catch
            {
                textBox3.Text = "Произошла ошибка в расчетах";
            }

        }
        Point lastPoint;
        private void Calcul_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void MainMenu_Click(object sender, EventArgs e)
        {
            MainFor main = new MainFor();
            main.Show();
            this.Close();
        }
    }
}
