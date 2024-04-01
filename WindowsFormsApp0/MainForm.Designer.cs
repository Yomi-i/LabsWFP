namespace WindowsFormsApp0
{
    partial class MainForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.lengthTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.latinTextBox = new System.Windows.Forms.TextBox();
            this.digitsTextBox = new System.Windows.Forms.TextBox();
            this.generateButton = new System.Windows.Forms.Button();
            this.listBoxPasswords = new System.Windows.Forms.ListBox();
            this.showPasswordsButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Длина пароля:";
            // 
            // lengthTextBox
            // 
            this.lengthTextBox.Location = new System.Drawing.Point(111, 12);
            this.lengthTextBox.Name = "lengthTextBox";
            this.lengthTextBox.Size = new System.Drawing.Size(50, 20);
            this.lengthTextBox.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Латинские символы:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Цифры:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Прочие символы:";
            // 
            // latinTextBox
            // 
            this.latinTextBox.Location = new System.Drawing.Point(124, 38);
            this.latinTextBox.Name = "latinTextBox";
            this.latinTextBox.Size = new System.Drawing.Size(37, 20);
            this.latinTextBox.TabIndex = 5;
            // 
            // digitsTextBox
            // 
            this.digitsTextBox.Location = new System.Drawing.Point(94, 64);
            this.digitsTextBox.Name = "digitsTextBox";
            this.digitsTextBox.Size = new System.Drawing.Size(67, 20);
            this.digitsTextBox.TabIndex = 6;
            // 
            // generateButton
            // 
            this.generateButton.Location = new System.Drawing.Point(15, 119);
            this.generateButton.Name = "generateButton";
            this.generateButton.Size = new System.Drawing.Size(146, 23);
            this.generateButton.TabIndex = 7;
            this.generateButton.Text = "Генерировать пароль";
            this.generateButton.UseVisualStyleBackColor = true;
            this.generateButton.Click += new System.EventHandler(this.generateButton_Click);
            // 
            // listBoxPasswords
            // 
            this.listBoxPasswords.FormattingEnabled = true;
            this.listBoxPasswords.Location = new System.Drawing.Point(15, 148);
            this.listBoxPasswords.Name = "listBoxPasswords";
            this.listBoxPasswords.Size = new System.Drawing.Size(208, 147);
            this.listBoxPasswords.TabIndex = 8;
            // 
            // showPasswordsButton
            // 
            this.showPasswordsButton.Location = new System.Drawing.Point(15, 301);
            this.showPasswordsButton.Name = "showPasswordsButton";
            this.showPasswordsButton.Size = new System.Drawing.Size(146, 23);
            this.showPasswordsButton.TabIndex = 9;
            this.showPasswordsButton.Text = "Показать пароли";
            this.showPasswordsButton.UseVisualStyleBackColor = true;
            this.showPasswordsButton.Click += new System.EventHandler(this.showPasswordsButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(235, 336);
            this.Controls.Add(this.showPasswordsButton);
            this.Controls.Add(this.listBoxPasswords);
            this.Controls.Add(this.generateButton);
            this.Controls.Add(this.digitsTextBox);
            this.Controls.Add(this.latinTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lengthTextBox);
            this.Controls.Add(this.label1);
            this.Name = "MainForm";
            this.Text = "Генератор паролей";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox lengthTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox latinTextBox;
        private System.Windows.Forms.TextBox digitsTextBox;
        private System.Windows.Forms.Button generateButton;
        private System.Windows.Forms.ListBox listBoxPasswords;
        private System.Windows.Forms.Button showPasswordsButton;
    }
}
