namespace WindowsFormsApp6
{
    partial class NoteForm
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
            this.noteLabel = new System.Windows.Forms.Label();
            this.dateLabel = new System.Windows.Forms.Label();
            this.urgencyLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // noteLabel
            // 
            this.noteLabel.AutoSize = true;
            this.noteLabel.Location = new System.Drawing.Point(133, 71);
            this.noteLabel.Name = "noteLabel";
            this.noteLabel.Size = new System.Drawing.Size(35, 13);
            this.noteLabel.TabIndex = 0;
            this.noteLabel.Text = "label1";
            // 
            // dateLabel
            // 
            this.dateLabel.AutoSize = true;
            this.dateLabel.Location = new System.Drawing.Point(136, 118);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(35, 13);
            this.dateLabel.TabIndex = 1;
            this.dateLabel.Text = "label2";
            // 
            // urgencyLabel
            // 
            this.urgencyLabel.AutoSize = true;
            this.urgencyLabel.Location = new System.Drawing.Point(136, 159);
            this.urgencyLabel.Name = "urgencyLabel";
            this.urgencyLabel.Size = new System.Drawing.Size(35, 13);
            this.urgencyLabel.TabIndex = 2;
            this.urgencyLabel.Text = "label3";
            // 
            // NoteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.urgencyLabel);
            this.Controls.Add(this.dateLabel);
            this.Controls.Add(this.noteLabel);
            this.Name = "NoteForm";
            this.Text = "NoteForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label noteLabel;
        private System.Windows.Forms.Label dateLabel;
        private System.Windows.Forms.Label urgencyLabel;
    }
}