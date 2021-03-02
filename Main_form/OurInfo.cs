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
    public partial class OurInfo : Form
    {
        public OurInfo()
        {
            InitializeComponent();
        }
         
        private void Result_Click(object sender, EventArgs e)
        {
            StreamReader sr = new StreamReader("C:\\Users\\Result.txt");

            MessageBox.Show(sr.ReadToEnd());     
        }
        Point lastPoint;
        private void OurInfo_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        public void textBox1_TextChanged(string text)
        {
          
        }

        private void OurInfo_Load(object sender, EventArgs e)
        {

        }

        private void MainMenu_Click(object sender, EventArgs e)
        {
            MainFor main = new MainFor();
            main.Show();
            this.Close();
           
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            StartForm form1 = new StartForm();
            form1.Close();
            Application.Exit();
            this.Close();
        }
    }
}
