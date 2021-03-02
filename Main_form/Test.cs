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
    public partial class Test : Form
    {
        public Test()
        {
            InitializeComponent();
        }
          
        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            StartTest test = new StartTest();
            test.Show();
            this.Close();
           


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Main_menu_Click(object sender, EventArgs e)
        {
            MainFor main = new MainFor();
            main.Show();
            this.Close();
        }
        Point lastPoint;
        private void Form2_MouseMove(object sender, MouseEventArgs e)
        {

            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void Previous_Click(object sender, EventArgs e)
        {
            Lab3 laba = new Lab3();
            laba.Show();
            this.Close();
        }

        private void Next_Click(object sender, EventArgs e)
        {
            OurInfo info = new OurInfo();
            info.Show();
            this.Close();
        }
    }
}
