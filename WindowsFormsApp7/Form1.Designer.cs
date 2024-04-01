namespace WindowsFormsApp7
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
            this.streetComboBox = new System.Windows.Forms.ComboBox();
            this.houseTextBox = new System.Windows.Forms.TextBox();
            this.entranceTextBox = new System.Windows.Forms.TextBox();
            this.timeTextBox = new System.Windows.Forms.TextBox();
            this.arrivalPlaceComboBox = new System.Windows.Forms.ComboBox();
            this.commentsTextBox = new System.Windows.Forms.TextBox();
            this.addButton = new System.Windows.Forms.Button();
            this.requestsListBox = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // streetComboBox
            // 
            this.streetComboBox.FormattingEnabled = true;
            this.streetComboBox.Location = new System.Drawing.Point(94, 5);
            this.streetComboBox.Name = "streetComboBox";
            this.streetComboBox.Size = new System.Drawing.Size(121, 21);
            this.streetComboBox.TabIndex = 1;
            // 
            // houseTextBox
            // 
            this.houseTextBox.Location = new System.Drawing.Point(94, 32);
            this.houseTextBox.Name = "houseTextBox";
            this.houseTextBox.Size = new System.Drawing.Size(121, 20);
            this.houseTextBox.TabIndex = 2;
            // 
            // entranceTextBox
            // 
            this.entranceTextBox.Location = new System.Drawing.Point(94, 58);
            this.entranceTextBox.Name = "entranceTextBox";
            this.entranceTextBox.Size = new System.Drawing.Size(121, 20);
            this.entranceTextBox.TabIndex = 3;
            // 
            // timeTextBox
            // 
            this.timeTextBox.Location = new System.Drawing.Point(94, 84);
            this.timeTextBox.Name = "timeTextBox";
            this.timeTextBox.Size = new System.Drawing.Size(121, 20);
            this.timeTextBox.TabIndex = 4;
            // 
            // arrivalPlaceComboBox
            // 
            this.arrivalPlaceComboBox.FormattingEnabled = true;
            this.arrivalPlaceComboBox.Location = new System.Drawing.Point(94, 110);
            this.arrivalPlaceComboBox.Name = "arrivalPlaceComboBox";
            this.arrivalPlaceComboBox.Size = new System.Drawing.Size(121, 21);
            this.arrivalPlaceComboBox.TabIndex = 5;
            // 
            // commentsTextBox
            // 
            this.commentsTextBox.Location = new System.Drawing.Point(94, 137);
            this.commentsTextBox.Name = "commentsTextBox";
            this.commentsTextBox.Size = new System.Drawing.Size(121, 20);
            this.commentsTextBox.TabIndex = 6;
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(94, 163);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(121, 23);
            this.addButton.TabIndex = 7;
            this.addButton.Text = "Отправить";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // requestsListBox
            // 
            this.requestsListBox.FormattingEnabled = true;
            this.requestsListBox.Location = new System.Drawing.Point(221, 5);
            this.requestsListBox.Name = "requestsListBox";
            this.requestsListBox.Size = new System.Drawing.Size(900, 433);
            this.requestsListBox.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Время";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Комментарий";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Поддъезд";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(49, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Улица";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(58, 35);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(30, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Дом";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(49, 110);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(39, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Место";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1132, 450);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.requestsListBox);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.commentsTextBox);
            this.Controls.Add(this.arrivalPlaceComboBox);
            this.Controls.Add(this.timeTextBox);
            this.Controls.Add(this.entranceTextBox);
            this.Controls.Add(this.houseTextBox);
            this.Controls.Add(this.streetComboBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox streetComboBox;
        private System.Windows.Forms.TextBox houseTextBox;
        private System.Windows.Forms.TextBox entranceTextBox;
        private System.Windows.Forms.TextBox timeTextBox;
        private System.Windows.Forms.ComboBox arrivalPlaceComboBox;
        private System.Windows.Forms.TextBox commentsTextBox;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.ListBox requestsListBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}

