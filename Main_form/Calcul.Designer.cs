
namespace Main_form
{
    partial class Calcul
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.function = new System.Windows.Forms.Button();
            this.Multi = new System.Windows.Forms.Button();
            this.Stepen = new System.Windows.Forms.Button();
            this.share = new System.Windows.Forms.Button();
            this.plus = new System.Windows.Forms.Button();
            this.percen_divide = new System.Windows.Forms.Button();
            this.minus = new System.Windows.Forms.Button();
            this.sqrt = new System.Windows.Forms.Button();
            this.exp = new System.Windows.Forms.Button();
            this.NextButton = new System.Windows.Forms.Button();
            this.BackButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.MainMenu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(123, 107);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(140, 25);
            this.textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(330, 107);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(140, 25);
            this.textBox2.TabIndex = 1;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(123, 225);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(346, 25);
            this.textBox3.TabIndex = 2;
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(236, 186);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Результат вычисления";
            // 
            // function
            // 
            this.function.Location = new System.Drawing.Point(228, 280);
            this.function.Name = "function";
            this.function.Size = new System.Drawing.Size(148, 74);
            this.function.TabIndex = 4;
            this.function.Text = "(sin(x)^2-sqrt(exp(x))/sqrt(y^2+x^2)";
            this.function.UseVisualStyleBackColor = true;
            this.function.Click += new System.EventHandler(this.button1_Click);
            // 
            // Multi
            // 
            this.Multi.Location = new System.Drawing.Point(520, 81);
            this.Multi.Name = "Multi";
            this.Multi.Size = new System.Drawing.Size(66, 23);
            this.Multi.TabIndex = 5;
            this.Multi.Text = "*";
            this.Multi.UseVisualStyleBackColor = true;
            this.Multi.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // Stepen
            // 
            this.Stepen.Location = new System.Drawing.Point(612, 82);
            this.Stepen.Name = "Stepen";
            this.Stepen.Size = new System.Drawing.Size(66, 23);
            this.Stepen.TabIndex = 6;
            this.Stepen.Text = "^2";
            this.Stepen.UseVisualStyleBackColor = true;
            this.Stepen.Click += new System.EventHandler(this.Stepen_Click);
            // 
            // share
            // 
            this.share.Location = new System.Drawing.Point(520, 154);
            this.share.Name = "share";
            this.share.Size = new System.Drawing.Size(66, 23);
            this.share.TabIndex = 7;
            this.share.Text = "/";
            this.share.UseVisualStyleBackColor = true;
            this.share.Click += new System.EventHandler(this.share_Click);
            // 
            // plus
            // 
            this.plus.Location = new System.Drawing.Point(612, 154);
            this.plus.Name = "plus";
            this.plus.Size = new System.Drawing.Size(66, 23);
            this.plus.TabIndex = 8;
            this.plus.Text = "+";
            this.plus.UseVisualStyleBackColor = true;
            this.plus.Click += new System.EventHandler(this.plus_Click);
            // 
            // percen_divide
            // 
            this.percen_divide.Location = new System.Drawing.Point(520, 224);
            this.percen_divide.Name = "percen_divide";
            this.percen_divide.Size = new System.Drawing.Size(66, 23);
            this.percen_divide.TabIndex = 9;
            this.percen_divide.Text = "%";
            this.percen_divide.UseVisualStyleBackColor = true;
            this.percen_divide.Click += new System.EventHandler(this.percen_divide_Click);
            // 
            // minus
            // 
            this.minus.Location = new System.Drawing.Point(612, 225);
            this.minus.Name = "minus";
            this.minus.Size = new System.Drawing.Size(66, 23);
            this.minus.TabIndex = 10;
            this.minus.Text = "-";
            this.minus.UseVisualStyleBackColor = true;
            this.minus.Click += new System.EventHandler(this.minus_Click);
            // 
            // sqrt
            // 
            this.sqrt.Location = new System.Drawing.Point(520, 280);
            this.sqrt.Name = "sqrt";
            this.sqrt.Size = new System.Drawing.Size(66, 23);
            this.sqrt.TabIndex = 11;
            this.sqrt.Text = "sqrt";
            this.sqrt.UseVisualStyleBackColor = true;
            this.sqrt.Click += new System.EventHandler(this.sqrt_Click);
            // 
            // exp
            // 
            this.exp.Location = new System.Drawing.Point(612, 280);
            this.exp.Name = "exp";
            this.exp.Size = new System.Drawing.Size(66, 23);
            this.exp.TabIndex = 12;
            this.exp.Text = "exp";
            this.exp.UseVisualStyleBackColor = true;
            this.exp.Click += new System.EventHandler(this.exp_Click);
            // 
            // NextButton
            // 
            this.NextButton.Location = new System.Drawing.Point(578, 384);
            this.NextButton.Name = "NextButton";
            this.NextButton.Size = new System.Drawing.Size(110, 35);
            this.NextButton.TabIndex = 13;
            this.NextButton.Text = "Следующий";
            this.NextButton.UseVisualStyleBackColor = true;
            this.NextButton.Click += new System.EventHandler(this.NextButton_Click);
            // 
            // BackButton
            // 
            this.BackButton.Location = new System.Drawing.Point(23, 384);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(110, 35);
            this.BackButton.TabIndex = 14;
            this.BackButton.Text = "Назад";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(122, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 16);
            this.label2.TabIndex = 15;
            this.label2.Text = "Первое значение";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(327, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 16);
            this.label3.TabIndex = 16;
            this.label3.Text = "Второе значение";
            // 
            // MainMenu
            // 
            this.MainMenu.Location = new System.Drawing.Point(281, 384);
            this.MainMenu.Name = "MainMenu";
            this.MainMenu.Size = new System.Drawing.Size(143, 35);
            this.MainMenu.TabIndex = 17;
            this.MainMenu.Text = "Главное меню";
            this.MainMenu.UseVisualStyleBackColor = true;
            this.MainMenu.Click += new System.EventHandler(this.MainMenu_Click);
            // 
            // Calcul
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(700, 450);
            this.Controls.Add(this.MainMenu);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.NextButton);
            this.Controls.Add(this.exp);
            this.Controls.Add(this.sqrt);
            this.Controls.Add(this.minus);
            this.Controls.Add(this.percen_divide);
            this.Controls.Add(this.plus);
            this.Controls.Add(this.share);
            this.Controls.Add(this.Stepen);
            this.Controls.Add(this.Multi);
            this.Controls.Add(this.function);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Font = new System.Drawing.Font("Matura MT Script Capitals", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Calcul";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calcul";
            this.Load += new System.EventHandler(this.Calcul_Load);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Calcul_MouseMove);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button function;
        private System.Windows.Forms.Button Multi;
        private System.Windows.Forms.Button Stepen;
        private System.Windows.Forms.Button share;
        private System.Windows.Forms.Button plus;
        private System.Windows.Forms.Button percen_divide;
        private System.Windows.Forms.Button minus;
        private System.Windows.Forms.Button sqrt;
        private System.Windows.Forms.Button exp;
        private System.Windows.Forms.Button NextButton;
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button MainMenu;
    }
}