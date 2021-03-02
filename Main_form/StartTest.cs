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
    public partial class StartTest : Form
    {
        string[] User_Answer = new string[11];
        int check = 0;
        string[] correct_Answer = {
                "Через USB", "Нет", "C", "С левой",
                "Нет", "Да","Да", "drag-and-drop", "Нет", "VEX"
                 };
        int result;
        void DataBase(int check)
        {
            string[] Question = {"Как передавать данные к компьютеру? ", "Программировать роботов сложно?", "На каком языке основан язык VEX?",
        "На какой стороне должен распологаться красный провод при подключении?", "Нужно ли быть программистома, чтобы написать программу для робота? ", "Есть ли циклы в языке VEX? ", "Можно ли самостоятельно писать функции?",
            "Как называется интерфейс предназначенный для новичков","Собрать робота сложно?","Как называется язык на котором программируется робот?"};

            string[] Answer1 = { "Через USB", "Через HDM", "Не знаю" };
            string[] Answer2 = { "Да", "Нет", "Не знаю" };
            string[] Answer3 = { "C", "C++", "Не знаю" };
            string[] Answer4 = { "С левой", "С правой", "Не знаю" };
            string[] Answer5 = { "Да", "Нет", "Не знаю" };
            string[] Answer6 = { "Да", "Нет", "Не знаю" };
            string[] Answer7 = { "Да", "Нет", "Не знаю" };
            string[] Answer8 = { "drag-and-drop", "new-and-old", "Не знаю" };
            string[] Answer9 = { "Да", "Нет", "Не знаю" };
            string[] Answer10 = { "Vex", "Hex", "Не знаю" };
            Answer.Text = Question[check];
            if (check == 0)
            {
                AnswerB1.Text = Answer1[0];
                AnswerB2.Text = Answer1[1];
                AnswerB3.Text = Answer1[2];
            }
            if (check == 1)
            {
                AnswerB1.Text = Answer2[0];
                AnswerB2.Text = Answer2[1];
                AnswerB3.Text = Answer2[2];
            }
            if (check == 2)
            {
                AnswerB1.Text = Answer3[0];
                AnswerB2.Text = Answer3[1];
                AnswerB3.Text = Answer3[2];
            }
            if (check == 3)
            {
                AnswerB1.Text = Answer4[0];
                AnswerB2.Text = Answer4[1];
                AnswerB3.Text = Answer4[2];
            }
            if (check == 4)
            {
                AnswerB1.Text = Answer5[0];
                AnswerB2.Text = Answer5[1];
                AnswerB3.Text = Answer5[2];
            }
            if (check == 5)
            {
                AnswerB1.Text = Answer6[0];
                AnswerB2.Text = Answer6[1];
                AnswerB3.Text = Answer6[2];
            }
            if (check == 6)
            {
                AnswerB1.Text = Answer7[0];
                AnswerB2.Text = Answer7[1];
                AnswerB3.Text = Answer7[2];
            }
            if (check == 7)
            {
                AnswerB1.Text = Answer8[0];
                AnswerB2.Text = Answer8[1];
                AnswerB3.Text = Answer8[2];
            }
            if (check == 8)
            {
                AnswerB1.Text = Answer9[0];
                AnswerB2.Text = Answer9[1];
                AnswerB3.Text = Answer9[2];

            }
            if (check == 9)
            {
                AnswerB1.Text = Answer10[0];
                AnswerB2.Text = Answer10[1];
                AnswerB3.Text = Answer10[2];
            }
        }


        public StartTest()
        {
            InitializeComponent();
            DataBase(check);
         
        }
        void CheckResult()
        {
            if (AnswerB1.Checked)
            {
                User_Answer[check] = AnswerB1.Text;
            }
            if (AnswerB2.Checked)
            {
                User_Answer[check] = AnswerB2.Text;
            }
            if (AnswerB3.Checked)
            {
                User_Answer[check] = AnswerB3.Text;
            }
        }
        void Next()
        {
        
            if (check<=9)
            {
                CheckResult();
                DataBase(check);
            }
            if(check==10)
            {
                next.Text = "Завершить";
            }
             if(check >= 11)
            {
                for (int i = 0; i < User_Answer.Length-2; i++)
                {
                    if (User_Answer[i+1] == correct_Answer[i])
                    {
                        result++;
                    }
                }
                MessageBox.Show($"Вы дали {result} верных ответов");
                this.Close();
                MainFor main = new MainFor();
                main.Show();
            }
            check++;


        }
       public void FileResult(double percent)
        {

            string fileName = "C:\\Users\\Itog.txt";
            if (File.Exists(fileName) != true)
            {
                using (StreamWriter sw = new StreamWriter(new FileStream(fileName, FileMode.Create, FileAccess.Write)))
                {
                    sw.WriteLine($"Вы дали {percent} правильных ответов, это составляет {percent}%");
                }
            }
            else
            {
                using (StreamWriter sw = new StreamWriter(new FileStream(fileName, FileMode.Open, FileAccess.Write)))
                {
                    (sw.BaseStream).Seek(0, SeekOrigin.End);
                    sw.WriteLine($"Вы дали {percent} правильных ответов, это составляет {percent}%");
                }

            }

         
        

        }
        Point lastPoint;
        private void StartTest_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void Backutton_Click(object sender, EventArgs e)
        {
            check--;
            if(check>=0) DataBase(check);
            else
            {
                MainFor main = new MainFor();
                main.Show();
                this.Close();
            }
        }

        private void MainMenu_Click(object sender, EventArgs e)
        {
            MainFor main = new MainFor();
            main.Show();
            this.Close();
        }

        private void StartTest_Load(object sender, EventArgs e)
        {
              
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
          
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        private void next_Click(object sender, EventArgs e)
        {
            Next();
        }

        private void Question_Click(object sender, EventArgs e)
        {

        }
    }
}
