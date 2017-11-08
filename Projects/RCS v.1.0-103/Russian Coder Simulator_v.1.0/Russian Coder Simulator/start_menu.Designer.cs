namespace Russian_Coder_Simulator
{
    partial class game_prew
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(game_prew));
            this.label_nachigr = new System.Windows.Forms.Label();
            this.razrabi_lable = new System.Windows.Forms.Label();
            this.label_game_versh = new System.Windows.Forms.Label();
            this.start_new_game = new System.Windows.Forms.Button();
            this.Zagruzit = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.rcs_redux_link = new System.Windows.Forms.LinkLabel();
            this.changelog_btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label_nachigr
            // 
            this.label_nachigr.AutoSize = true;
            this.label_nachigr.Location = new System.Drawing.Point(12, 9);
            this.label_nachigr.Name = "label_nachigr";
            this.label_nachigr.Size = new System.Drawing.Size(411, 39);
            this.label_nachigr.TabIndex = 0;
            this.label_nachigr.Text = resources.GetString("label_nachigr.Text");
            // 
            // razrabi_lable
            // 
            this.razrabi_lable.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.razrabi_lable.AutoSize = true;
            this.razrabi_lable.Location = new System.Drawing.Point(12, 228);
            this.razrabi_lable.Name = "razrabi_lable";
            this.razrabi_lable.Size = new System.Drawing.Size(159, 13);
            this.razrabi_lable.TabIndex = 1;
            this.razrabi_lable.Text = "(с) Bidlokod Games (2015-2017)";
            // 
            // label_game_versh
            // 
            this.label_game_versh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label_game_versh.AutoSize = true;
            this.label_game_versh.Location = new System.Drawing.Point(387, 230);
            this.label_game_versh.Name = "label_game_versh";
            this.label_game_versh.Size = new System.Drawing.Size(40, 13);
            this.label_game_versh.TabIndex = 2;
            this.label_game_versh.Text = "v.1.0.3";
            // 
            // start_new_game
            // 
            this.start_new_game.Location = new System.Drawing.Point(12, 65);
            this.start_new_game.Name = "start_new_game";
            this.start_new_game.Size = new System.Drawing.Size(242, 67);
            this.start_new_game.TabIndex = 3;
            this.start_new_game.Text = "Начать новою игру";
            this.start_new_game.UseVisualStyleBackColor = true;
            this.start_new_game.Click += new System.EventHandler(this.start_new_game_Click);
            // 
            // Zagruzit
            // 
            this.Zagruzit.Location = new System.Drawing.Point(12, 150);
            this.Zagruzit.Name = "Zagruzit";
            this.Zagruzit.Size = new System.Drawing.Size(242, 66);
            this.Zagruzit.TabIndex = 4;
            this.Zagruzit.Text = "Загрузить ";
            this.Zagruzit.UseVisualStyleBackColor = true;
            this.Zagruzit.Click += new System.EventHandler(this.Zagruzit_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(260, 65);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(173, 151);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // rcs_redux_link
            // 
            this.rcs_redux_link.AutoSize = true;
            this.rcs_redux_link.Location = new System.Drawing.Point(257, 230);
            this.rcs_redux_link.Name = "rcs_redux_link";
            this.rcs_redux_link.Size = new System.Drawing.Size(121, 13);
            this.rcs_redux_link.TabIndex = 6;
            this.rcs_redux_link.TabStop = true;
            this.rcs_redux_link.Text = "Группа разработчиков";
            this.rcs_redux_link.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.rcs_redux_link_LinkClicked);
            // 
            // changelog_btn
            // 
            this.changelog_btn.Location = new System.Drawing.Point(178, 222);
            this.changelog_btn.Name = "changelog_btn";
            this.changelog_btn.Size = new System.Drawing.Size(76, 25);
            this.changelog_btn.TabIndex = 7;
            this.changelog_btn.Text = "Change Log";
            this.changelog_btn.UseVisualStyleBackColor = true;
            this.changelog_btn.Click += new System.EventHandler(this.changelog_btn_Click);
            // 
            // game_prew
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(437, 250);
            this.Controls.Add(this.changelog_btn);
            this.Controls.Add(this.rcs_redux_link);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Zagruzit);
            this.Controls.Add(this.start_new_game);
            this.Controls.Add(this.label_game_versh);
            this.Controls.Add(this.razrabi_lable);
            this.Controls.Add(this.label_nachigr);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(453, 289);
            this.MinimumSize = new System.Drawing.Size(453, 289);
            this.Name = "game_prew";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Начало игры ";
            this.TopMost = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.game_prew_FormClosing);
            this.Load += new System.EventHandler(this.game_prew_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_nachigr;
        private System.Windows.Forms.Label razrabi_lable;
        private System.Windows.Forms.Label label_game_versh;
        private System.Windows.Forms.Button start_new_game;
        private System.Windows.Forms.Button Zagruzit;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.LinkLabel rcs_redux_link;
        private System.Windows.Forms.Button changelog_btn;
    }
}