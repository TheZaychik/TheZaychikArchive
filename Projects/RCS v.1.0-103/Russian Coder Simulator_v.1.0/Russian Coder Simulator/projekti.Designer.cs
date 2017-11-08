namespace Russian_Coder_Simulator
{
    partial class ProjectS
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProjectS));
            this.Parameters = new System.Windows.Forms.TextBox();
            this.hard_name = new System.Windows.Forms.Label();
            this.Med_Name = new System.Windows.Forms.Label();
            this.Easy_name = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Continue = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // Parameters
            // 
            this.Parameters.Location = new System.Drawing.Point(12, 194);
            this.Parameters.Multiline = true;
            this.Parameters.Name = "Parameters";
            this.Parameters.ReadOnly = true;
            this.Parameters.Size = new System.Drawing.Size(251, 122);
            this.Parameters.TabIndex = 20;
            // 
            // hard_name
            // 
            this.hard_name.AutoSize = true;
            this.hard_name.Location = new System.Drawing.Point(86, 161);
            this.hard_name.Name = "hard_name";
            this.hard_name.Size = new System.Drawing.Size(35, 13);
            this.hard_name.TabIndex = 19;
            this.hard_name.Text = "label3";
            // 
            // Med_Name
            // 
            this.Med_Name.AutoSize = true;
            this.Med_Name.Location = new System.Drawing.Point(86, 138);
            this.Med_Name.Name = "Med_Name";
            this.Med_Name.Size = new System.Drawing.Size(35, 13);
            this.Med_Name.TabIndex = 18;
            this.Med_Name.Text = "label3";
            // 
            // Easy_name
            // 
            this.Easy_name.AutoSize = true;
            this.Easy_name.Location = new System.Drawing.Point(86, 115);
            this.Easy_name.Name = "Easy_name";
            this.Easy_name.Size = new System.Drawing.Size(35, 13);
            this.Easy_name.TabIndex = 17;
            this.Easy_name.Text = "label3";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(353, 74);
            this.label2.TabIndex = 16;
            this.label2.Text = "Тимофей выделил вам 3 новых проекта! \r\nВы можете выбрать один из них, разной слож" +
                "ности.\r\nНо запомни, чем сложнее проект, тем больше он будет занимать времени, ск" +
                "илла и ресурсов!";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Continue
            // 
            this.Continue.Location = new System.Drawing.Point(269, 284);
            this.Continue.Name = "Continue";
            this.Continue.Size = new System.Drawing.Size(96, 32);
            this.Continue.TabIndex = 15;
            this.Continue.Text = "Продолжить";
            this.Continue.UseVisualStyleBackColor = true;
            this.Continue.Click += new System.EventHandler(this.Continue_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Уровень сложности проекта";
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(12, 159);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(72, 17);
            this.radioButton3.TabIndex = 13;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "Сложный";
            this.radioButton3.UseVisualStyleBackColor = true;
            this.radioButton3.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(12, 136);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(68, 17);
            this.radioButton2.TabIndex = 12;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Средний";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(12, 113);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(62, 17);
            this.radioButton1.TabIndex = 11;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Легкий";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // ProjectS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CausesValidation = false;
            this.ClientSize = new System.Drawing.Size(377, 326);
            this.Controls.Add(this.Parameters);
            this.Controls.Add(this.hard_name);
            this.Controls.Add(this.Med_Name);
            this.Controls.Add(this.Easy_name);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Continue);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.radioButton3);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(393, 365);
            this.MinimumSize = new System.Drawing.Size(393, 365);
            this.Name = "ProjectS";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Проекты";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Parameters;
        private System.Windows.Forms.Label hard_name;
        private System.Windows.Forms.Label Med_Name;
        private System.Windows.Forms.Label Easy_name;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Continue;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
    }
}