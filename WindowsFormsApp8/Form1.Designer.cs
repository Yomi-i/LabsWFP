namespace WindowsFormsApp8
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
        /// содержимое этого метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnLoad = new System.Windows.Forms.Button();
            this.lblStatus = new System.Windows.Forms.Label();
            this.cmbWashMode = new System.Windows.Forms.ComboBox();
            this.trackTemperature = new System.Windows.Forms.TrackBar();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnHistory = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.trackTemperature)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(12, 12);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(100, 50);
            this.btnLoad.TabIndex = 0;
            this.btnLoad.Text = "Загружено";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(12, 65);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(0, 13);
            this.lblStatus.TabIndex = 1;
            // 
            // cmbWashMode
            // 
            this.cmbWashMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbWashMode.FormattingEnabled = true;
            this.cmbWashMode.Items.AddRange(new object[] {
            "Режим 1",
            "Режим 2",
            "Режим 3"});
            this.cmbWashMode.Location = new System.Drawing.Point(12, 100);
            this.cmbWashMode.Name = "cmbWashMode";
            this.cmbWashMode.Size = new System.Drawing.Size(121, 21);
            this.cmbWashMode.TabIndex = 2;
            // 
            // trackTemperature
            // 
            this.trackTemperature.Location = new System.Drawing.Point(12, 140);
            this.trackTemperature.Name = "trackTemperature";
            this.trackTemperature.Size = new System.Drawing.Size(200, 45);
            this.trackTemperature.TabIndex = 3;
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(12, 191);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 4;
            this.btnStart.Text = "Пуск";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnReset
            // 
            this.btnReset.Enabled = false;
            this.btnReset.Location = new System.Drawing.Point(93, 191);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 5;
            this.btnReset.Text = "Сброс";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnHistory
            // 
            this.btnHistory.Location = new System.Drawing.Point(174, 191);
            this.btnHistory.Name = "btnHistory";
            this.btnHistory.Size = new System.Drawing.Size(75, 23);
            this.btnHistory.TabIndex = 6;
            this.btnHistory.Text = "История";
            this.btnHistory.UseVisualStyleBackColor = true;
            this.btnHistory.Click += new System.EventHandler(this.btnHistory_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.btnHistory);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.trackTemperature);
            this.Controls.Add(this.cmbWashMode);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.btnLoad);
            this.Name = "Form1";
            this.Text = "Стиральная машина";
            ((System.ComponentModel.ISupportInitialize)(this.trackTemperature)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.ComboBox cmbWashMode;
        private System.Windows.Forms.TrackBar trackTemperature;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnHistory; // Добавленная кнопка "История"
    }
}
