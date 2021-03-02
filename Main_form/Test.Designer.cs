
namespace Main_form
{
    partial class Test
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
            this.Main_menu = new System.Windows.Forms.Button();
            this.Previous = new System.Windows.Forms.Button();
            this.Next = new System.Windows.Forms.Button();
            this.Start = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Main_menu
            // 
            this.Main_menu.Location = new System.Drawing.Point(163, 271);
            this.Main_menu.Name = "Main_menu";
            this.Main_menu.Size = new System.Drawing.Size(139, 32);
            this.Main_menu.TabIndex = 10;
            this.Main_menu.Text = "Главное меню";
            this.Main_menu.UseVisualStyleBackColor = true;
            this.Main_menu.Click += new System.EventHandler(this.Main_menu_Click);
            // 
            // Previous
            // 
            this.Previous.Location = new System.Drawing.Point(12, 271);
            this.Previous.Name = "Previous";
            this.Previous.Size = new System.Drawing.Size(111, 32);
            this.Previous.TabIndex = 11;
            this.Previous.Text = "Назад";
            this.Previous.UseVisualStyleBackColor = true;
            this.Previous.Click += new System.EventHandler(this.Previous_Click);
            // 
            // Next
            // 
            this.Next.Location = new System.Drawing.Point(340, 271);
            this.Next.Name = "Next";
            this.Next.Size = new System.Drawing.Size(111, 32);
            this.Next.TabIndex = 12;
            this.Next.Text = "Вперед";
            this.Next.UseVisualStyleBackColor = true;
            this.Next.Click += new System.EventHandler(this.Next_Click);
            // 
            // Start
            // 
            this.Start.Location = new System.Drawing.Point(175, 103);
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(127, 60);
            this.Start.TabIndex = 13;
            this.Start.Text = "Начать тестирование";
            this.Start.UseVisualStyleBackColor = true;
            this.Start.Click += new System.EventHandler(this.button1_Click);
            // 
            // Test
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(470, 315);
            this.Controls.Add(this.Start);
            this.Controls.Add(this.Next);
            this.Controls.Add(this.Previous);
            this.Controls.Add(this.Main_menu);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Test";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form2_MouseMove);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Main_menu;
        private System.Windows.Forms.Button Previous;
        private System.Windows.Forms.Button Next;
        private System.Windows.Forms.Button Start;
    }
}