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
    public partial class Lab3 : Form
    {
        public Lab3()
        {
            InitializeComponent();
        }

        private void Lab3_Load(object sender, EventArgs e)
        {

        }

        private void result_Click(object sender, EventArgs e)
        {
            
                int column = Convert.ToInt32(columnBox.Text);
                int row = Convert.ToInt32(rowBox.Text); 
                int[,] array = new int[row, column];
                int check = 0;
                // Код взятый из открытых источников
                string[] param = textBox1.Text.Split(new char[] {','}, StringSplitOptions.RemoveEmptyEntries);
                int[] arr = new int[param.Length];
                if(column*row != arr.Length)
                {
                    MessageBox.Show("Вы ввели неверное количество символов");
                    return;
                }
                for (int i = 0; i < param.Length; i++)
                    arr[i] = int.Parse(param[i]);
                
               
                for (int i = 0; i < row; ++i)
                {
                    for (int j = 0; j < column; ++j)
                    {
                        array[i, j] = arr[check];
                        check++;
                    }

                }
            

                SearchMin(array);
            
            
        }
        private void SearchMin(int[,] array)
        {
            double minValue = array[0,0];
            int row = 0;
            int column = 0;

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if (minValue > array[i,j])
                    {
                        row = i;
                        column = j;
                        minValue = array[i, j]; 
                    }
                }
            }
            MessageBox.Show($"Минимальный элемент равен {Convert.ToString(minValue)}, c индексом{row},{column}");
        }

        private void Main_menu_Click(object sender, EventArgs e)
        {
            MainFor main = new MainFor();
            main.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Test test = new Test();
            test.Show();
            this.Close();
        }

        private void Previous_Click(object sender, EventArgs e)
        {
            Funcion func = new Funcion();
            func.Show();
            this.Close();

        }
        Point lastPoint;
        private void Lab3_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }
    }
}
