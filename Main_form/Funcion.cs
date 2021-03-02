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
    public partial class Funcion : Form
    {
        public Funcion()
        {
            InitializeComponent();
        }

        private void Funcion_Load(object sender, EventArgs e)
        {

        }

        private void chart1_Click(object sender, EventArgs e)
        {
            try
            {
                double a = Convert.ToDouble(textBox1.Text);
                double b = Convert.ToDouble(textBox2.Text);
                double c = Convert.ToDouble(textBox3.Text);
                double x = -100;
                for (x = 0; x < 10; x++)
                {
                    double y1 = a * (x * x) + b * x + c;
                    chart1.Series[0].Points.AddXY(x, y1);
                    continue;
                }
                double y = a * (x * x) + b * x + c;
                if (y == 0)
                {
                    MessageBox.Show($"Параболла пересекает график функции в точке x = {x} и y = 0 ");
                }
                else
                {
                    MessageBox.Show($"График функции не пересекает оси координат");
                }
            }
            catch
            {
                MessageBox.Show("Введены неверные значения");
                
            }
           

        }

        private void button1_Click(object sender, EventArgs e)
        {

            double a = Convert.ToDouble(textBox1.Text);
            double b = Convert.ToDouble(textBox2.Text);
            double c = Convert.ToDouble(textBox3.Text);


            double d = (b * b) - 4 * a * c;

            if (d < 0)
            {
                MessageBox.Show("Уравнение не имеет корней");
            }
            else if (d == 0)
            {
                double x = (-b / (2 * a));
                MessageBox.Show($"Уравнение имеет один корень x = {x}");
            }
            else if (d > 0)
            {
                double x1 = (-b + Math.Sqrt(d)) / (2 * a);
                double x2 = (b + Math.Sqrt(d)) / (2 * a);
                MessageBox.Show($"Уравнение имеет два корня x1 = {x1} ,x2 = {x2}");
            }
            if (a < 0)
            {
                double min = -b / 2 * a;
                MessageBox.Show($" Максимум функции x = {min}");
                double max = a * (min * min) + b * min + c;
                MessageBox.Show($"Максимум функции y = {max}");
            }
            else if (a > 0)
            {
                double max = -b / 2 * a;
                MessageBox.Show($"Максимум функции {max}");
                double min = a * (max * max) + b * max + c;
                MessageBox.Show($"Минимум функции {min}");
            }
            if (a > 0)
            {
                double result = -b / (2 * a);
                MessageBox.Show($"График функции убывает на  отрезке от (-Беск  до {result} и возрастает от {result} до + Бесконеч");
            }
            else if (a < 0)
            {
                double result = -b / (2 * a);
                MessageBox.Show($"График функции возрастает на отрезке (- Беск до {result} и убывает от {result} до + Беск");
            }
            else if (a == 0 && b == 0)
                MessageBox.Show("Промежутков возрастания и убывания нет");
            else if (b < 0)
            {
                double result = -b / (2 * a);
                MessageBox.Show("График функции убывает на отрезке(от - Беск до + Беск)");
            }
            else
                MessageBox.Show("График функции возрастает на отрезке(от -Беск до + Беск");
            /*
             * Проверка функции на четность не четность.
             */
            double numb = 1;
            double numb1 = -1;
            double itog1 = a * numb * numb + b * numb;
            double itog = a * numb1 * numb1 + b * numb1;
            if (itog == itog1)
            {
                MessageBox.Show("Функция четная");
            }
            else
                MessageBox.Show("Функция нечетная");
        }

        private void Main_menu_Click(object sender, EventArgs e)
        {
            MainFor main = new MainFor();
            main.Show();
            this.Close();
        }

        private void Net_lab_Click(object sender, EventArgs e)
        {
            Lab3 lab = new Lab3();
            lab.Show();
            this.Close();
        }

        private void Previous_Click(object sender, EventArgs e)
        {
            Calcul calc = new Calcul();
            calc.Show();
            this.Close();
        }
        Point lastPoint;
        private void Funcion_MouseMove(object sender, MouseEventArgs e)
        {

            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }
    }
}

