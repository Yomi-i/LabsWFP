namespace WindowsFormsApp5
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.listBox = new System.Windows.Forms.ListBox();
            this.productNameComboBox = new System.Windows.Forms.ComboBox();
            this.countryComboBox = new System.Windows.Forms.ComboBox();
            this.weightTextBox = new System.Windows.Forms.TextBox();
            this.showCodesButton = new System.Windows.Forms.Button();
            this.generateCodeButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBox
            // 
            this.listBox.FormattingEnabled = true;
            this.listBox.Location = new System.Drawing.Point(12, 286);
            this.listBox.Name = "listBox";
            this.listBox.Size = new System.Drawing.Size(776, 147);
            this.listBox.TabIndex = 0;
            // 
            // productNameComboBox
            // 
            this.productNameComboBox.FormattingEnabled = true;
            this.productNameComboBox.Location = new System.Drawing.Point(12, 38);
            this.productNameComboBox.Name = "productNameComboBox";
            this.productNameComboBox.Size = new System.Drawing.Size(121, 21);
            this.productNameComboBox.TabIndex = 1;
            // 
            // countryComboBox
            // 
            this.countryComboBox.FormattingEnabled = true;
            this.countryComboBox.Location = new System.Drawing.Point(12, 65);
            this.countryComboBox.Name = "countryComboBox";
            this.countryComboBox.Size = new System.Drawing.Size(121, 21);
            this.countryComboBox.TabIndex = 2;
            // 
            // weightTextBox
            // 
            this.weightTextBox.Location = new System.Drawing.Point(12, 12);
            this.weightTextBox.Name = "weightTextBox";
            this.weightTextBox.Size = new System.Drawing.Size(121, 20);
            this.weightTextBox.TabIndex = 3;
            // 
            // showCodesButton
            // 
            this.showCodesButton.Location = new System.Drawing.Point(668, 257);
            this.showCodesButton.Name = "showCodesButton";
            this.showCodesButton.Size = new System.Drawing.Size(120, 23);
            this.showCodesButton.TabIndex = 4;
            this.showCodesButton.Text = "Отправить";
            this.showCodesButton.UseVisualStyleBackColor = true;
            this.showCodesButton.Click += new System.EventHandler(this.showCodesButton_Click);
            // 
            // generateCodeButton
            // 
            this.generateCodeButton.Location = new System.Drawing.Point(12, 92);
            this.generateCodeButton.Name = "generateCodeButton";
            this.generateCodeButton.Size = new System.Drawing.Size(121, 23);
            this.generateCodeButton.TabIndex = 5;
            this.generateCodeButton.Text = "Сгенерировать";
            this.generateCodeButton.UseVisualStyleBackColor = true;
            this.generateCodeButton.Click += new System.EventHandler(this.generateCodeButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.generateCodeButton);
            this.Controls.Add(this.showCodesButton);
            this.Controls.Add(this.weightTextBox);
            this.Controls.Add(this.countryComboBox);
            this.Controls.Add(this.productNameComboBox);
            this.Controls.Add(this.listBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox;
        private System.Windows.Forms.ComboBox productNameComboBox;
        private System.Windows.Forms.ComboBox countryComboBox;
        private System.Windows.Forms.TextBox weightTextBox;
        private System.Windows.Forms.Button showCodesButton;
        private System.Windows.Forms.Button generateCodeButton;
    }
}

