namespace Russian_Coder_Simulator
{
    partial class Vibor_avatarki
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Vibor_avatarki));
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_vib_nicka = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pb_vib_ava = new System.Windows.Forms.PictureBox();
            this.open_ava = new System.Windows.Forms.OpenFileDialog();
            this.zagr_ava = new System.Windows.Forms.Button();
            this.Dalee = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.label5 = new System.Windows.Forms.Label();
            this.cns = new System.Windows.Forms.TextBox();
            this.gui = new System.Windows.Forms.TextBox();
            this.lng = new System.Windows.Forms.TextBox();
            this.alg = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pb_vib_ava)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Никнейм";
            // 
            // textBox_vib_nicka
            // 
            this.textBox_vib_nicka.Location = new System.Drawing.Point(12, 25);
            this.textBox_vib_nicka.Name = "textBox_vib_nicka";
            this.textBox_vib_nicka.Size = new System.Drawing.Size(100, 20);
            this.textBox_vib_nicka.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Аватар";
            // 
            // pb_vib_ava
            // 
            this.pb_vib_ava.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pb_vib_ava.Location = new System.Drawing.Point(12, 64);
            this.pb_vib_ava.Name = "pb_vib_ava";
            this.pb_vib_ava.Size = new System.Drawing.Size(100, 127);
            this.pb_vib_ava.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_vib_ava.TabIndex = 3;
            this.pb_vib_ava.TabStop = false;
            // 
            // open_ava
            // 
            this.open_ava.FileName = "openFileDialog1";
            // 
            // zagr_ava
            // 
            this.zagr_ava.Location = new System.Drawing.Point(12, 197);
            this.zagr_ava.Name = "zagr_ava";
            this.zagr_ava.Size = new System.Drawing.Size(75, 23);
            this.zagr_ava.TabIndex = 4;
            this.zagr_ava.Text = "Загрузить";
            this.zagr_ava.UseVisualStyleBackColor = true;
            this.zagr_ava.Click += new System.EventHandler(this.zagr_ava_Click);
            // 
            // Dalee
            // 
            this.Dalee.Location = new System.Drawing.Point(306, 198);
            this.Dalee.Name = "Dalee";
            this.Dalee.Size = new System.Drawing.Size(74, 22);
            this.Dalee.TabIndex = 5;
            this.Dalee.Text = "Далее";
            this.Dalee.UseVisualStyleBackColor = true;
            this.Dalee.Click += new System.EventHandler(this.nick_set_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(343, 22);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(13, 13);
            this.linkLabel1.TabIndex = 19;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "8";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(199, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(138, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "Кол-во поинтов навыков :";
            // 
            // cns
            // 
            this.cns.Location = new System.Drawing.Point(346, 172);
            this.cns.Name = "cns";
            this.cns.Size = new System.Drawing.Size(34, 20);
            this.cns.TabIndex = 17;
            // 
            // gui
            // 
            this.gui.Location = new System.Drawing.Point(346, 128);
            this.gui.Name = "gui";
            this.gui.Size = new System.Drawing.Size(34, 20);
            this.gui.TabIndex = 16;
            // 
            // lng
            // 
            this.lng.Location = new System.Drawing.Point(346, 86);
            this.lng.Name = "lng";
            this.lng.Size = new System.Drawing.Size(34, 20);
            this.lng.TabIndex = 15;
            // 
            // alg
            // 
            this.alg.Location = new System.Drawing.Point(346, 45);
            this.alg.Name = "alg";
            this.alg.Size = new System.Drawing.Size(34, 20);
            this.alg.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(199, 179);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "CNS";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(199, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "GUI";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(198, 93);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Знание языка";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(199, 52);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "Алгоритмы";
            // 
            // Vibor_avatarki
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(392, 226);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cns);
            this.Controls.Add(this.gui);
            this.Controls.Add(this.lng);
            this.Controls.Add(this.alg);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.Dalee);
            this.Controls.Add(this.zagr_ava);
            this.Controls.Add(this.pb_vib_ava);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox_vib_nicka);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(408, 265);
            this.MinimumSize = new System.Drawing.Size(408, 265);
            this.Name = "Vibor_avatarki";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Выберите аватар, никнейм и скиллы ";
            this.TopMost = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Vibor_avatarki_FormClosing);
            this.Load += new System.EventHandler(this.Vibor_avatarki_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pb_vib_ava)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_vib_nicka;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pb_vib_ava;
        private System.Windows.Forms.OpenFileDialog open_ava;
        private System.Windows.Forms.Button zagr_ava;
        private System.Windows.Forms.Button Dalee;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox cns;
        private System.Windows.Forms.TextBox gui;
        private System.Windows.Forms.TextBox lng;
        private System.Windows.Forms.TextBox alg;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}