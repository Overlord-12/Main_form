
namespace Main_form
{
    partial class Lab3
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
            this.label1 = new System.Windows.Forms.Label();
            this.result = new System.Windows.Forms.Button();
            this.Previous = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.Main_menu = new System.Windows.Forms.Button();
            this.columnBox = new System.Windows.Forms.TextBox();
            this.rowBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(32, 87);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(193, 22);
            this.textBox1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label1.Location = new System.Drawing.Point(29, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(293, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Введите элементы массива,через запятые";
            // 
            // result
            // 
            this.result.Location = new System.Drawing.Point(270, 179);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(191, 39);
            this.result.TabIndex = 2;
            this.result.Text = "Получить результат";
            this.result.UseVisualStyleBackColor = true;
            this.result.Click += new System.EventHandler(this.result_Click);
            // 
            // Previous
            // 
            this.Previous.Location = new System.Drawing.Point(14, 306);
            this.Previous.Name = "Previous";
            this.Previous.Size = new System.Drawing.Size(111, 32);
            this.Previous.TabIndex = 7;
            this.Previous.Text = "Назад";
            this.Previous.UseVisualStyleBackColor = true;
            this.Previous.Click += new System.EventHandler(this.Previous_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(578, 306);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(111, 32);
            this.button1.TabIndex = 8;
            this.button1.Text = "Вперед";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Main_menu
            // 
            this.Main_menu.Location = new System.Drawing.Point(270, 306);
            this.Main_menu.Name = "Main_menu";
            this.Main_menu.Size = new System.Drawing.Size(191, 32);
            this.Main_menu.TabIndex = 9;
            this.Main_menu.Text = "Главное меню";
            this.Main_menu.UseVisualStyleBackColor = true;
            this.Main_menu.Click += new System.EventHandler(this.Main_menu_Click);
            // 
            // columnBox
            // 
            this.columnBox.Location = new System.Drawing.Point(354, 87);
            this.columnBox.Name = "columnBox";
            this.columnBox.Size = new System.Drawing.Size(74, 22);
            this.columnBox.TabIndex = 10;
            // 
            // rowBox
            // 
            this.rowBox.Location = new System.Drawing.Point(518, 87);
            this.rowBox.Name = "rowBox";
            this.rowBox.Size = new System.Drawing.Size(70, 22);
            this.rowBox.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label2.Location = new System.Drawing.Point(351, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 17);
            this.label2.TabIndex = 12;
            this.label2.Text = "Кол-во стобцов";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label3.Location = new System.Drawing.Point(515, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 17);
            this.label3.TabIndex = 13;
            this.label3.Text = "Кол-во строчек";
            // 
            // Lab3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(701, 350);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.rowBox);
            this.Controls.Add(this.columnBox);
            this.Controls.Add(this.Main_menu);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Previous);
            this.Controls.Add(this.result);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Lab3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lab3";
            this.Load += new System.EventHandler(this.Lab3_Load);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Lab3_MouseMove);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button result;
        private System.Windows.Forms.Button Previous;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button Main_menu;
        private System.Windows.Forms.TextBox columnBox;
        private System.Windows.Forms.TextBox rowBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}