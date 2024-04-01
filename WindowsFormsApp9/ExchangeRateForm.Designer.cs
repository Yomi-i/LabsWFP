namespace WindowsFormsApp9
{
    partial class ExchangeRateForm
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
            this.listBoxExchangeRates = new System.Windows.Forms.ListBox();
            this.textBoxEditUSD = new System.Windows.Forms.TextBox();
            this.textBoxEditEUR = new System.Windows.Forms.TextBox();
            this.textBoxEditGBP = new System.Windows.Forms.TextBox();
            this.textBoxEditJPY = new System.Windows.Forms.TextBox();
            this.buttonUpdateRates = new System.Windows.Forms.Button();
            this.labelExchangeRates = new System.Windows.Forms.Label();
            this.labelEditUSD = new System.Windows.Forms.Label();
            this.labelEditEUR = new System.Windows.Forms.Label();
            this.labelEditGBP = new System.Windows.Forms.Label();
            this.labelEditJPY = new System.Windows.Forms.Label();
            this.SuspendLayout();

            // listBoxExchangeRates
            this.listBoxExchangeRates.FormattingEnabled = true;
            this.listBoxExchangeRates.Location = new System.Drawing.Point(12, 25);
            this.listBoxExchangeRates.Name = "listBoxExchangeRates";
            this.listBoxExchangeRates.Size = new System.Drawing.Size(260, 160);
            this.listBoxExchangeRates.TabIndex = 0;

            // textBoxEditUSD
            this.textBoxEditUSD.Location = new System.Drawing.Point(80, 191);
            this.textBoxEditUSD.Name = "textBoxEditUSD";
            this.textBoxEditUSD.Size = new System.Drawing.Size(50, 20);
            this.textBoxEditUSD.TabIndex = 1;

            // textBoxEditEUR
            this.textBoxEditEUR.Location = new System.Drawing.Point(80, 217);
            this.textBoxEditEUR.Name = "textBoxEditEUR";
            this.textBoxEditEUR.Size = new System.Drawing.Size(50, 20);
            this.textBoxEditEUR.TabIndex = 2;

            // textBoxEditGBP
            this.textBoxEditGBP.Location = new System.Drawing.Point(80, 243);
            this.textBoxEditGBP.Name = "textBoxEditGBP";
            this.textBoxEditGBP.Size = new System.Drawing.Size(50, 20);
            this.textBoxEditGBP.TabIndex = 3;

            // textBoxEditJPY
            this.textBoxEditJPY.Location = new System.Drawing.Point(80, 269);
            this.textBoxEditJPY.Name = "textBoxEditJPY";
            this.textBoxEditJPY.Size = new System.Drawing.Size(50, 20);
            this.textBoxEditJPY.TabIndex = 4;

            // buttonUpdateRates
            this.buttonUpdateRates.Location = new System.Drawing.Point(12, 295);
            this.buttonUpdateRates.Name = "buttonUpdateRates";
            this.buttonUpdateRates.Size = new System.Drawing.Size(206, 23);
            this.buttonUpdateRates.TabIndex = 5;
            this.buttonUpdateRates.Text = "Обновить курсы";
            this.buttonUpdateRates.UseVisualStyleBackColor = true;
            this.buttonUpdateRates.Click += new System.EventHandler(this.buttonUpdateRates_Click);

            // labelExchangeRates
            this.labelExchangeRates.AutoSize = true;
            this.labelExchangeRates.Location = new System.Drawing.Point(12, 9);
            this.labelExchangeRates.Name = "labelExchangeRates";
            this.labelExchangeRates.Size = new System.Drawing.Size(80, 13);
            this.labelExchangeRates.TabIndex = 6;
            this.labelExchangeRates.Text = "Курсы обмена";

            // labelEditUSD
            this.labelEditUSD.AutoSize = true;
            this.labelEditUSD.Location = new System.Drawing.Point(12, 194);
            this.labelEditUSD.Name = "labelEditUSD";
            this.labelEditUSD.Size = new System.Drawing.Size(33, 13);
            this.labelEditUSD.TabIndex = 7;
            this.labelEditUSD.Text = "USD:";

            // labelEditEUR
            this.labelEditEUR.AutoSize = true;
            this.labelEditEUR.Location = new System.Drawing.Point(12, 220);
            this.labelEditEUR.Name = "labelEditEUR";
            this.labelEditEUR.Size = new System.Drawing.Size(31, 13);
            this.labelEditEUR.TabIndex = 8;
            this.labelEditEUR.Text = "EUR:";

            // labelEditGBP
            this.labelEditGBP.AutoSize = true;
            this.labelEditGBP.Location = new System.Drawing.Point(12, 246);
            this.labelEditGBP.Name = "labelEditGBP";
            this.labelEditGBP.Size = new System.Drawing.Size(31, 13);
            this.labelEditGBP.TabIndex = 9;
            this.labelEditGBP.Text = "GBP:";

            // labelEditJPY
            this.labelEditJPY.AutoSize = true;
            this.labelEditJPY.Location = new System.Drawing.Point(12, 272);
            this.labelEditJPY.Name = "labelEditJPY";
            this.labelEditJPY.Size = new System.Drawing.Size(30, 13);
            this.labelEditJPY.TabIndex = 10;
            this.labelEditJPY.Text = "JPY:";

            // ExchangeRateForm
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 330);
            this.Controls.Add(this.labelEditJPY);
            this.Controls.Add(this.labelEditGBP);
            this.Controls.Add(this.labelEditEUR);
            this.Controls.Add(this.labelEditUSD);
            this.Controls.Add(this.labelExchangeRates);
            this.Controls.Add(this.buttonUpdateRates);
            this.Controls.Add(this.textBoxEditJPY);
            this.Controls.Add(this.textBoxEditGBP);
            this.Controls.Add(this.textBoxEditEUR);
            this.Controls.Add(this.textBoxEditUSD);
            this.Controls.Add(this.listBoxExchangeRates);
            this.Name = "ExchangeRateForm";
            this.Text = "Exchange Rates";
            this.Load += new System.EventHandler(this.ExchangeRateForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.ListBox listBoxExchangeRates;
        private System.Windows.Forms.TextBox textBoxEditUSD;
        private System.Windows.Forms.TextBox textBoxEditEUR;
        private System.Windows.Forms.TextBox textBoxEditGBP;
        private System.Windows.Forms.TextBox textBoxEditJPY;
        private System.Windows.Forms.Button buttonUpdateRates;
        private System.Windows.Forms.Label labelExchangeRates;
        private System.Windows.Forms.Label labelEditUSD;
        private System.Windows.Forms.Label labelEditEUR;
        private System.Windows.Forms.Label labelEditGBP;
        private System.Windows.Forms.Label labelEditJPY;
    }
}
