
namespace Main_form
{
    partial class OurInfo
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
            this.Result = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.MainMenu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Result
            // 
            this.Result.Location = new System.Drawing.Point(131, 100);
            this.Result.Name = "Result";
            this.Result.Size = new System.Drawing.Size(193, 74);
            this.Result.TabIndex = 0;
            this.Result.Text = "Протоколирование";
            this.Result.UseVisualStyleBackColor = true;
            this.Result.Click += new System.EventHandler(this.Result_Click);
            // 
            // Exit
            // 
            this.Exit.Location = new System.Drawing.Point(21, 251);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(122, 40);
            this.Exit.TabIndex = 1;
            this.Exit.Text = "Выход";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // MainMenu
            // 
            this.MainMenu.Location = new System.Drawing.Point(329, 251);
            this.MainMenu.Name = "MainMenu";
            this.MainMenu.Size = new System.Drawing.Size(129, 40);
            this.MainMenu.TabIndex = 2;
            this.MainMenu.Text = "Главное меню";
            this.MainMenu.UseVisualStyleBackColor = true;
            this.MainMenu.Click += new System.EventHandler(this.MainMenu_Click);
            // 
            // OurInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(465, 303);
            this.Controls.Add(this.MainMenu);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.Result);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "OurInfo";
            this.Text = "OurInfo";
            this.Load += new System.EventHandler(this.OurInfo_Load);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.OurInfo_MouseMove);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Result;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.Button MainMenu;
    }
}