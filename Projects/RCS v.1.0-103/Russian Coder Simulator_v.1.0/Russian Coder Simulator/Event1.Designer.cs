namespace Russian_Coder_Simulator
{
    partial class Event1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Event1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.otkaz = new System.Windows.Forms.Button();
            this.vlozit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(13, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(159, 161);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(178, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(332, 52);
            this.label1.TabIndex = 3;
            this.label1.Text = "К вам подходит странный человек и предлагает\r\nвложиться в его компанию. Вы должны" +
    " вложить в \r\nего компанию 500$, а он вам через пару часов вернет в 3 раза \r\nболь" +
    "ше. Что вы решите?";
            // 
            // otkaz
            // 
            this.otkaz.Location = new System.Drawing.Point(396, 134);
            this.otkaz.Name = "otkaz";
            this.otkaz.Size = new System.Drawing.Size(101, 40);
            this.otkaz.TabIndex = 4;
            this.otkaz.Text = "Отказаться";
            this.otkaz.UseVisualStyleBackColor = true;
            this.otkaz.Click += new System.EventHandler(this.otkaz_Click);
            // 
            // vlozit
            // 
            this.vlozit.Location = new System.Drawing.Point(181, 132);
            this.vlozit.Name = "vlozit";
            this.vlozit.Size = new System.Drawing.Size(101, 40);
            this.vlozit.TabIndex = 5;
            this.vlozit.Text = "Вложить 500$";
            this.vlozit.UseVisualStyleBackColor = true;
            this.vlozit.Click += new System.EventHandler(this.vlozit_Click);
            // 
            // Event1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(509, 184);
            this.ControlBox = false;
            this.Controls.Add(this.vlozit);
            this.Controls.Add(this.otkaz);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(525, 223);
            this.MaximumSize = new System.Drawing.Size(525, 223);
            this.Name = "Event1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Авантюра!";
            this.Load += new System.EventHandler(this.Event1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button otkaz;
        private System.Windows.Forms.Button vlozit;
    }
}