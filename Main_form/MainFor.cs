using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows;

   
namespace Main_form
{
  
    public partial class MainFor : Form
    {
       
        public MainFor()
        {
            InitializeComponent();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void вариантToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Test form = new Test();
            form.Show();
            this.Close();
        }

        private void вариант2ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Lab3 lab3 = new Lab3();
            lab3.Show();
            this.Close();
        }

        private void вариант2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Funcion func = new Funcion();
            func.Show();
            this.Close();
        }

        private void вариантToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Calcul calc = new Calcul();
            calc.Show();
            this.Close();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            StartForm form1 = new StartForm();
            form1.Close();
            Application.Exit();
            this.Close();
        }

        private void протоколированиеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            OurInfo info = new OurInfo();
            info.Show();
        }

        private void MainFor_Load(object sender, EventArgs e)
        {
           
        }

        private void MainFor_MouseDoubleClick(object sender, MouseEventArgs e)
        {

        }
        Point lastPoint;
        private void MainFor_MouseMove(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
          
        }
    }
}
