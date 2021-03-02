
namespace Main_form
{
    partial class StartTest
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
            this.label11 = new System.Windows.Forms.Label();
            this.Backutton = new System.Windows.Forms.Button();
            this.MainMenu = new System.Windows.Forms.Button();
            this.next = new System.Windows.Forms.Button();
            this.AnswerB1 = new System.Windows.Forms.RadioButton();
            this.AnswerB2 = new System.Windows.Forms.RadioButton();
            this.AnswerB3 = new System.Windows.Forms.RadioButton();
            this.Answer = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Wide Latin", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(55, 9);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(357, 29);
            this.label11.TabIndex = 46;
            this.label11.Text = "Выберите варианты ответа";
            // 
            // Backutton
            // 
            this.Backutton.Location = new System.Drawing.Point(12, 402);
            this.Backutton.Name = "Backutton";
            this.Backutton.Size = new System.Drawing.Size(116, 36);
            this.Backutton.TabIndex = 48;
            this.Backutton.Text = "Назад";
            this.Backutton.UseVisualStyleBackColor = true;
            this.Backutton.Click += new System.EventHandler(this.Backutton_Click);
            // 
            // MainMenu
            // 
            this.MainMenu.Location = new System.Drawing.Point(296, 402);
            this.MainMenu.Name = "MainMenu";
            this.MainMenu.Size = new System.Drawing.Size(116, 36);
            this.MainMenu.TabIndex = 50;
            this.MainMenu.Text = "Главное меню";
            this.MainMenu.UseVisualStyleBackColor = true;
            this.MainMenu.Click += new System.EventHandler(this.MainMenu_Click);
            // 
            // next
            // 
            this.next.Location = new System.Drawing.Point(614, 402);
            this.next.Name = "next";
            this.next.Size = new System.Drawing.Size(116, 36);
            this.next.TabIndex = 51;
            this.next.Text = "Следующий";
            this.next.UseVisualStyleBackColor = true;
            this.next.Click += new System.EventHandler(this.next_Click);
            // 
            // AnswerB1
            // 
            this.AnswerB1.AutoSize = true;
            this.AnswerB1.Font = new System.Drawing.Font("Roboto", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AnswerB1.Location = new System.Drawing.Point(106, 189);
            this.AnswerB1.Name = "AnswerB1";
            this.AnswerB1.Size = new System.Drawing.Size(176, 33);
            this.AnswerB1.TabIndex = 53;
            this.AnswerB1.TabStop = true;
            this.AnswerB1.Text = "radioButton1";
            this.AnswerB1.UseVisualStyleBackColor = true;
            this.AnswerB1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // AnswerB2
            // 
            this.AnswerB2.AutoSize = true;
            this.AnswerB2.Font = new System.Drawing.Font("Roboto", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AnswerB2.Location = new System.Drawing.Point(106, 243);
            this.AnswerB2.Name = "AnswerB2";
            this.AnswerB2.Size = new System.Drawing.Size(176, 33);
            this.AnswerB2.TabIndex = 54;
            this.AnswerB2.TabStop = true;
            this.AnswerB2.Text = "radioButton2";
            this.AnswerB2.UseVisualStyleBackColor = true;
            this.AnswerB2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // AnswerB3
            // 
            this.AnswerB3.AutoSize = true;
            this.AnswerB3.Font = new System.Drawing.Font("Roboto", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AnswerB3.Location = new System.Drawing.Point(106, 299);
            this.AnswerB3.Name = "AnswerB3";
            this.AnswerB3.Size = new System.Drawing.Size(176, 33);
            this.AnswerB3.TabIndex = 55;
            this.AnswerB3.TabStop = true;
            this.AnswerB3.Text = "radioButton3";
            this.AnswerB3.UseVisualStyleBackColor = true;
            this.AnswerB3.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // Answer
            // 
            this.Answer.AutoSize = true;
            this.Answer.Font = new System.Drawing.Font("Bernard MT Condensed", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Answer.Location = new System.Drawing.Point(109, 113);
            this.Answer.Name = "Answer";
            this.Answer.Size = new System.Drawing.Size(82, 33);
            this.Answer.TabIndex = 56;
            this.Answer.Text = "label1";
            // 
            // StartTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(742, 470);
            this.Controls.Add(this.Answer);
            this.Controls.Add(this.AnswerB3);
            this.Controls.Add(this.AnswerB2);
            this.Controls.Add(this.AnswerB1);
            this.Controls.Add(this.next);
            this.Controls.Add(this.MainMenu);
            this.Controls.Add(this.Backutton);
            this.Controls.Add(this.label11);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "StartTest";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StartTest";
            this.Load += new System.EventHandler(this.StartTest_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button Backutton;
        private System.Windows.Forms.Button MainMenu;
        private System.Windows.Forms.Button next;

        private System.Windows.Forms.RadioButton AnswerB1;
        private System.Windows.Forms.RadioButton AnswerB2;
        private System.Windows.Forms.RadioButton AnswerB3;
        private System.Windows.Forms.Label Answer;
    }
}