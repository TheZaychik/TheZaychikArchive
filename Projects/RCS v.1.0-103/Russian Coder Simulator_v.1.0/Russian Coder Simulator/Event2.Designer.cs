namespace Russian_Coder_Simulator
{
    partial class Event2
    {
        /// <summary>
        /// Требуется переменная конструктора.
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
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Event2));
            this.dat_deneg = new System.Windows.Forms.Button();
            this.otkaz = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dat_deneg
            // 
            this.dat_deneg.Location = new System.Drawing.Point(174, 133);
            this.dat_deneg.Name = "dat_deneg";
            this.dat_deneg.Size = new System.Drawing.Size(101, 40);
            this.dat_deneg.TabIndex = 9;
            this.dat_deneg.Text = "Дать 50$";
            this.dat_deneg.UseVisualStyleBackColor = true;
            this.dat_deneg.Click += new System.EventHandler(this.dat_deneg_Click);
            // 
            // otkaz
            // 
            this.otkaz.Location = new System.Drawing.Point(389, 135);
            this.otkaz.Name = "otkaz";
            this.otkaz.Size = new System.Drawing.Size(101, 40);
            this.otkaz.TabIndex = 8;
            this.otkaz.Text = "Отказаться";
            this.otkaz.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(171, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(282, 26);
            this.label1.TabIndex = 7;
            this.label1.Text = "На улице вы встречаете бомжа,  он просит у вас 50$. \r\nЧто вы сделаете? ";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(6, 14);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(159, 161);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // Event2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(509, 184);
            this.ControlBox = false;
            this.Controls.Add(this.dat_deneg);
            this.Controls.Add(this.otkaz);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(525, 223);
            this.MinimumSize = new System.Drawing.Size(525, 223);
            this.Name = "Event2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Карма";
            this.Load += new System.EventHandler(this.Event2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button dat_deneg;
        private System.Windows.Forms.Button otkaz;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}