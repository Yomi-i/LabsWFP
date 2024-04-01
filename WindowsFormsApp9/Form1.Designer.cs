namespace WindowsFormsApp9
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.comboBoxFromCurrency = new System.Windows.Forms.ComboBox();
            this.comboBoxToCurrency = new System.Windows.Forms.ComboBox();
            this.textBoxAmount = new System.Windows.Forms.TextBox();
            this.buttonConvert = new System.Windows.Forms.Button();
            this.labelResult = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.openSecondFormToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listBoxLog = new System.Windows.Forms.ListBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboBoxFromCurrency
            // 
            this.comboBoxFromCurrency.FormattingEnabled = true;
            this.comboBoxFromCurrency.Location = new System.Drawing.Point(12, 37);
            this.comboBoxFromCurrency.Name = "comboBoxFromCurrency";
            this.comboBoxFromCurrency.Size = new System.Drawing.Size(121, 21);
            this.comboBoxFromCurrency.TabIndex = 0;
            // 
            // comboBoxToCurrency
            // 
            this.comboBoxToCurrency.FormattingEnabled = true;
            this.comboBoxToCurrency.Location = new System.Drawing.Point(139, 37);
            this.comboBoxToCurrency.Name = "comboBoxToCurrency";
            this.comboBoxToCurrency.Size = new System.Drawing.Size(121, 21);
            this.comboBoxToCurrency.TabIndex = 1;
            // 
            // textBoxAmount
            // 
            this.textBoxAmount.Location = new System.Drawing.Point(12, 64);
            this.textBoxAmount.Name = "textBoxAmount";
            this.textBoxAmount.Size = new System.Drawing.Size(121, 20);
            this.textBoxAmount.TabIndex = 2;
            // 
            // buttonConvert
            // 
            this.buttonConvert.Location = new System.Drawing.Point(12, 90);
            this.buttonConvert.Name = "buttonConvert";
            this.buttonConvert.Size = new System.Drawing.Size(121, 23);
            this.buttonConvert.TabIndex = 3;
            this.buttonConvert.Text = "Конвертировать";
            this.buttonConvert.UseVisualStyleBackColor = true;
            this.buttonConvert.Click += new System.EventHandler(this.buttonConvert_Click);
            // 
            // labelResult
            // 
            this.labelResult.AutoSize = true;
            this.labelResult.Location = new System.Drawing.Point(12, 126);
            this.labelResult.Name = "labelResult";
            this.labelResult.Size = new System.Drawing.Size(59, 13);
            this.labelResult.TabIndex = 4;
            this.labelResult.Text = "Результат";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openSecondFormToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(496, 24);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // openSecondFormToolStripMenuItem
            // 
            this.openSecondFormToolStripMenuItem.Name = "openSecondFormToolStripMenuItem";
            this.openSecondFormToolStripMenuItem.Size = new System.Drawing.Size(102, 20);
            this.openSecondFormToolStripMenuItem.Text = "Поменять курс";
            this.openSecondFormToolStripMenuItem.Click += new System.EventHandler(this.openSecondFormToolStripMenuItem_Click);
            // 
            // listBoxLog
            // 
            this.listBoxLog.FormattingEnabled = true;
            this.listBoxLog.Location = new System.Drawing.Point(139, 64);
            this.listBoxLog.Name = "listBoxLog";
            this.listBoxLog.Size = new System.Drawing.Size(345, 95);
            this.listBoxLog.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(496, 181);
            this.Controls.Add(this.listBoxLog);
            this.Controls.Add(this.labelResult);
            this.Controls.Add(this.buttonConvert);
            this.Controls.Add(this.textBoxAmount);
            this.Controls.Add(this.comboBoxToCurrency);
            this.Controls.Add(this.comboBoxFromCurrency);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Currency Converter";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.ComboBox comboBoxFromCurrency;
        private System.Windows.Forms.ComboBox comboBoxToCurrency;
        private System.Windows.Forms.TextBox textBoxAmount;
        private System.Windows.Forms.Button buttonConvert;
        private System.Windows.Forms.Label labelResult;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem openSecondFormToolStripMenuItem;
        private System.Windows.Forms.ListBox listBoxLog;
    }
}
