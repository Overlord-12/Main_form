using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace Main_form
{
    public partial class StartForm : Form
    {
        public StartForm()
        {
            InitializeComponent();
            
        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void EnterButton_Click(object sender, EventArgs e)
        {

            string text = NameBox.Text;
            if (text == "")
            {
                MessageBox.Show("Введите пожалуйста имя");
                return;
            }
            MainFor mainForm = new MainFor();
            OurInfo info = new OurInfo();
            info.textBox1_TextChanged(text);
            try
            {
                string fileName = "C:\\Users\\Result.txt";

                using (StreamWriter sw = new StreamWriter(new FileStream(fileName, FileMode.Create, FileAccess.Write)))
                {
                    sw.WriteLine($"Ваше имя {text} вы заходили в программу{ DateTime.Now}");
                }
            }
            catch
            {
                MessageBox.Show("Запустите программу от имени администратора");
                return;
            }


            mainForm.Show();
            this.Hide();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

  


    }
   
}
    
