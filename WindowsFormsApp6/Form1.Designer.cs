namespace WindowsFormsApp6
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
            this.urgencyComboBox = new System.Windows.Forms.ComboBox();
            this.noteTextBox = new System.Windows.Forms.TextBox();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.leaveNoteButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // urgencyComboBox
            // 
            this.urgencyComboBox.FormattingEnabled = true;
            this.urgencyComboBox.Location = new System.Drawing.Point(296, 197);
            this.urgencyComboBox.Name = "urgencyComboBox";
            this.urgencyComboBox.Size = new System.Drawing.Size(200, 21);
            this.urgencyComboBox.TabIndex = 0;
            // 
            // noteTextBox
            // 
            this.noteTextBox.Location = new System.Drawing.Point(296, 145);
            this.noteTextBox.Name = "noteTextBox";
            this.noteTextBox.Size = new System.Drawing.Size(200, 20);
            this.noteTextBox.TabIndex = 1;
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Location = new System.Drawing.Point(296, 171);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker.TabIndex = 2;
            // 
            // leaveNoteButton
            // 
            this.leaveNoteButton.Location = new System.Drawing.Point(296, 224);
            this.leaveNoteButton.Name = "leaveNoteButton";
            this.leaveNoteButton.Size = new System.Drawing.Size(200, 23);
            this.leaveNoteButton.TabIndex = 3;
            this.leaveNoteButton.Text = "Добавить";
            this.leaveNoteButton.UseVisualStyleBackColor = true;
            this.leaveNoteButton.Click += new System.EventHandler(this.leaveNoteButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.leaveNoteButton);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.noteTextBox);
            this.Controls.Add(this.urgencyComboBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox urgencyComboBox;
        private System.Windows.Forms.TextBox noteTextBox;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.Button leaveNoteButton;
    }
}

