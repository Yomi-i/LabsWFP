namespace WindowsFormsApp5
{
    partial class CodesForm
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
            this.codesListBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // codesListBox
            // 
            this.codesListBox.FormattingEnabled = true;
            this.codesListBox.Location = new System.Drawing.Point(12, 12);
            this.codesListBox.Name = "codesListBox";
            this.codesListBox.Size = new System.Drawing.Size(776, 420);
            this.codesListBox.TabIndex = 0;
            // 
            // CodesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.codesListBox);
            this.Name = "CodesForm";
            this.Text = "CodesForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox codesListBox;
    }
}