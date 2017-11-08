namespace Russian_Coder_Simulator
{
    partial class central_form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(central_form));
            this.gb_igrok = new System.Windows.Forms.GroupBox();
            this.labe_nickname = new System.Windows.Forms.LinkLabel();
            this.pb_igr_avatar = new System.Windows.Forms.PictureBox();
            this.btn_hod = new System.Windows.Forms.Button();
            this.gb_igr_inf = new System.Windows.Forms.GroupBox();
            this.proj_comp = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.hp_z = new System.Windows.Forms.Label();
            this.bt_perehod_inf = new System.Windows.Forms.Button();
            this.nastr_lb = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.zn_CNS = new System.Windows.Forms.Label();
            this.zn_GUI = new System.Windows.Forms.Label();
            this.zn_yazika = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.alg_label = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.data_znach = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.money_znach = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.hp1 = new System.Windows.Forms.Label();
            this.tekushie_pojeckti = new System.Windows.Forms.GroupBox();
            this.label12 = new System.Windows.Forms.Label();
            this.Pov_navikov_info = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.Up = new System.Windows.Forms.Button();
            this.Down = new System.Windows.Forms.Button();
            this.bt_perehod_projekti = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.Indicator1 = new System.Windows.Forms.TextBox();
            this.textbox_projekti = new System.Windows.Forms.TextBox();
            this.save_btn = new System.Windows.Forms.PictureBox();
            this.achivki_pb = new System.Windows.Forms.PictureBox();
            this.gb_igrok.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_igr_avatar)).BeginInit();
            this.gb_igr_inf.SuspendLayout();
            this.tekushie_pojeckti.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.save_btn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.achivki_pb)).BeginInit();
            this.SuspendLayout();
            // 
            // gb_igrok
            // 
            this.gb_igrok.Controls.Add(this.labe_nickname);
            this.gb_igrok.Controls.Add(this.pb_igr_avatar);
            this.gb_igrok.Location = new System.Drawing.Point(26, 25);
            this.gb_igrok.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.gb_igrok.Name = "gb_igrok";
            this.gb_igrok.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.gb_igrok.Size = new System.Drawing.Size(334, 388);
            this.gb_igrok.TabIndex = 0;
            this.gb_igrok.TabStop = false;
            this.gb_igrok.Text = "Игрок";
            // 
            // labe_nickname
            // 
            this.labe_nickname.AutoSize = true;
            this.labe_nickname.Location = new System.Drawing.Point(14, 338);
            this.labe_nickname.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labe_nickname.Name = "labe_nickname";
            this.labe_nickname.Size = new System.Drawing.Size(240, 25);
            this.labe_nickname.TabIndex = 1;
            this.labe_nickname.TabStop = true;
            this.labe_nickname.Text = "<Никнейм отсутсвует>\r\n";
            // 
            // pb_igr_avatar
            // 
            this.pb_igr_avatar.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pb_igr_avatar.Location = new System.Drawing.Point(12, 37);
            this.pb_igr_avatar.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.pb_igr_avatar.Name = "pb_igr_avatar";
            this.pb_igr_avatar.Size = new System.Drawing.Size(248, 296);
            this.pb_igr_avatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_igr_avatar.TabIndex = 0;
            this.pb_igr_avatar.TabStop = false;
            // 
            // btn_hod
            // 
            this.btn_hod.Location = new System.Drawing.Point(884, 731);
            this.btn_hod.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btn_hod.Name = "btn_hod";
            this.btn_hod.Size = new System.Drawing.Size(184, 75);
            this.btn_hod.TabIndex = 1;
            this.btn_hod.Text = "Ход";
            this.btn_hod.UseVisualStyleBackColor = true;
            this.btn_hod.Click += new System.EventHandler(this.btn_hod_Click);
            // 
            // gb_igr_inf
            // 
            this.gb_igr_inf.Controls.Add(this.proj_comp);
            this.gb_igr_inf.Controls.Add(this.label3);
            this.gb_igr_inf.Controls.Add(this.hp_z);
            this.gb_igr_inf.Controls.Add(this.bt_perehod_inf);
            this.gb_igr_inf.Controls.Add(this.nastr_lb);
            this.gb_igr_inf.Controls.Add(this.label10);
            this.gb_igr_inf.Controls.Add(this.zn_CNS);
            this.gb_igr_inf.Controls.Add(this.zn_GUI);
            this.gb_igr_inf.Controls.Add(this.zn_yazika);
            this.gb_igr_inf.Controls.Add(this.label9);
            this.gb_igr_inf.Controls.Add(this.label8);
            this.gb_igr_inf.Controls.Add(this.label7);
            this.gb_igr_inf.Controls.Add(this.label6);
            this.gb_igr_inf.Controls.Add(this.alg_label);
            this.gb_igr_inf.Controls.Add(this.label5);
            this.gb_igr_inf.Controls.Add(this.data_znach);
            this.gb_igr_inf.Controls.Add(this.label2);
            this.gb_igr_inf.Controls.Add(this.money_znach);
            this.gb_igr_inf.Controls.Add(this.label1);
            this.gb_igr_inf.Controls.Add(this.hp1);
            this.gb_igr_inf.Location = new System.Drawing.Point(26, 425);
            this.gb_igr_inf.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.gb_igr_inf.Name = "gb_igr_inf";
            this.gb_igr_inf.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.gb_igr_inf.Size = new System.Drawing.Size(334, 377);
            this.gb_igr_inf.TabIndex = 2;
            this.gb_igr_inf.TabStop = false;
            this.gb_igr_inf.Text = "Информация";
            // 
            // proj_comp
            // 
            this.proj_comp.AutoSize = true;
            this.proj_comp.Location = new System.Drawing.Point(272, 252);
            this.proj_comp.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.proj_comp.Name = "proj_comp";
            this.proj_comp.Size = new System.Drawing.Size(19, 25);
            this.proj_comp.TabIndex = 21;
            this.proj_comp.Text = "-";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 252);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(248, 25);
            this.label3.TabIndex = 20;
            this.label3.Text = "Завершенные проекты:";
            // 
            // hp_z
            // 
            this.hp_z.AutoSize = true;
            this.hp_z.Location = new System.Drawing.Point(72, 40);
            this.hp_z.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.hp_z.Name = "hp_z";
            this.hp_z.Size = new System.Drawing.Size(19, 25);
            this.hp_z.TabIndex = 19;
            this.hp_z.Text = "-";
            // 
            // bt_perehod_inf
            // 
            this.bt_perehod_inf.Location = new System.Drawing.Point(172, 321);
            this.bt_perehod_inf.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.bt_perehod_inf.Name = "bt_perehod_inf";
            this.bt_perehod_inf.Size = new System.Drawing.Size(150, 44);
            this.bt_perehod_inf.TabIndex = 18;
            this.bt_perehod_inf.Text = "Подробнее";
            this.bt_perehod_inf.UseVisualStyleBackColor = true;
            this.bt_perehod_inf.Click += new System.EventHandler(this.bt_perehod_inf_Click);
            // 
            // nastr_lb
            // 
            this.nastr_lb.AutoSize = true;
            this.nastr_lb.Location = new System.Drawing.Point(150, 123);
            this.nastr_lb.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.nastr_lb.Name = "nastr_lb";
            this.nastr_lb.Size = new System.Drawing.Size(19, 25);
            this.nastr_lb.TabIndex = 17;
            this.nastr_lb.Text = "-";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(14, 123);
            this.label10.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(144, 25);
            this.label10.TabIndex = 16;
            this.label10.Text = "Настроение :";
            // 
            // zn_CNS
            // 
            this.zn_CNS.AutoSize = true;
            this.zn_CNS.Location = new System.Drawing.Point(90, 225);
            this.zn_CNS.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.zn_CNS.Name = "zn_CNS";
            this.zn_CNS.Size = new System.Drawing.Size(19, 25);
            this.zn_CNS.TabIndex = 15;
            this.zn_CNS.Text = "-";
            // 
            // zn_GUI
            // 
            this.zn_GUI.AutoSize = true;
            this.zn_GUI.Location = new System.Drawing.Point(80, 200);
            this.zn_GUI.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.zn_GUI.Name = "zn_GUI";
            this.zn_GUI.Size = new System.Drawing.Size(19, 25);
            this.zn_GUI.TabIndex = 14;
            this.zn_GUI.Text = "-";
            // 
            // zn_yazika
            // 
            this.zn_yazika.AutoSize = true;
            this.zn_yazika.Location = new System.Drawing.Point(194, 175);
            this.zn_yazika.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.zn_yazika.Name = "zn_yazika";
            this.zn_yazika.Size = new System.Drawing.Size(19, 25);
            this.zn_yazika.TabIndex = 13;
            this.zn_yazika.Text = "-";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(14, 225);
            this.label9.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(68, 25);
            this.label9.TabIndex = 12;
            this.label9.Text = "CNS :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(14, 200);
            this.label8.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 25);
            this.label8.TabIndex = 11;
            this.label8.Text = "GUI :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 175);
            this.label7.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(163, 25);
            this.label7.TabIndex = 10;
            this.label7.Text = "Знание языка :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 154);
            this.label6.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 25);
            this.label6.TabIndex = 9;
            // 
            // alg_label
            // 
            this.alg_label.AutoSize = true;
            this.alg_label.Location = new System.Drawing.Point(150, 154);
            this.alg_label.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.alg_label.Name = "alg_label";
            this.alg_label.Size = new System.Drawing.Size(19, 25);
            this.alg_label.TabIndex = 8;
            this.alg_label.Text = "-";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 150);
            this.label5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(119, 25);
            this.label5.TabIndex = 7;
            this.label5.Text = "Алгоритм :";
            // 
            // data_znach
            // 
            this.data_znach.AutoSize = true;
            this.data_znach.Location = new System.Drawing.Point(104, 88);
            this.data_znach.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.data_znach.Name = "data_znach";
            this.data_znach.Size = new System.Drawing.Size(19, 25);
            this.data_znach.TabIndex = 6;
            this.data_znach.Text = "-";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 88);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "Дата :";
            // 
            // money_znach
            // 
            this.money_znach.AutoSize = true;
            this.money_znach.Location = new System.Drawing.Point(158, 63);
            this.money_znach.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.money_znach.Name = "money_znach";
            this.money_znach.Size = new System.Drawing.Size(19, 25);
            this.money_znach.TabIndex = 4;
            this.money_znach.Text = "-";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 63);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Деньги ($) :";
            // 
            // hp1
            // 
            this.hp1.AutoSize = true;
            this.hp1.Location = new System.Drawing.Point(14, 38);
            this.hp1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.hp1.Name = "hp1";
            this.hp1.Size = new System.Drawing.Size(53, 25);
            this.hp1.TabIndex = 1;
            this.hp1.Text = "HP :";
            // 
            // tekushie_pojeckti
            // 
            this.tekushie_pojeckti.Controls.Add(this.label12);
            this.tekushie_pojeckti.Controls.Add(this.Pov_navikov_info);
            this.tekushie_pojeckti.Controls.Add(this.label11);
            this.tekushie_pojeckti.Controls.Add(this.Up);
            this.tekushie_pojeckti.Controls.Add(this.Down);
            this.tekushie_pojeckti.Controls.Add(this.bt_perehod_projekti);
            this.tekushie_pojeckti.Controls.Add(this.label4);
            this.tekushie_pojeckti.Controls.Add(this.Indicator1);
            this.tekushie_pojeckti.Controls.Add(this.textbox_projekti);
            this.tekushie_pojeckti.Location = new System.Drawing.Point(374, 25);
            this.tekushie_pojeckti.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.tekushie_pojeckti.Name = "tekushie_pojeckti";
            this.tekushie_pojeckti.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.tekushie_pojeckti.Size = new System.Drawing.Size(672, 579);
            this.tekushie_pojeckti.TabIndex = 3;
            this.tekushie_pojeckti.TabStop = false;
            this.tekushie_pojeckti.Text = "Текущие проекты";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(22, 485);
            this.label12.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(297, 25);
            this.label12.TabIndex = 9;
            this.label12.Text = "Статус повышения навыков:";
            // 
            // Pov_navikov_info
            // 
            this.Pov_navikov_info.Location = new System.Drawing.Point(336, 433);
            this.Pov_navikov_info.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Pov_navikov_info.Multiline = true;
            this.Pov_navikov_info.Name = "Pov_navikov_info";
            this.Pov_navikov_info.ReadOnly = true;
            this.Pov_navikov_info.Size = new System.Drawing.Size(160, 133);
            this.Pov_navikov_info.TabIndex = 9;
            this.Pov_navikov_info.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(448, 60);
            this.label11.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(199, 50);
            this.label11.TabIndex = 8;
            this.label11.Text = "Кол-во часов \r\nна проект за 1 ход";
            // 
            // Up
            // 
            this.Up.Location = new System.Drawing.Point(534, 113);
            this.Up.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Up.Name = "Up";
            this.Up.Size = new System.Drawing.Size(56, 37);
            this.Up.TabIndex = 5;
            this.Up.Text = "+";
            this.Up.UseVisualStyleBackColor = true;
            this.Up.Click += new System.EventHandler(this.Up_Click);
            // 
            // Down
            // 
            this.Down.Location = new System.Drawing.Point(534, 158);
            this.Down.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Down.Name = "Down";
            this.Down.Size = new System.Drawing.Size(56, 38);
            this.Down.TabIndex = 6;
            this.Down.Text = "-";
            this.Down.UseVisualStyleBackColor = true;
            this.Down.Click += new System.EventHandler(this.Down_Click);
            // 
            // bt_perehod_projekti
            // 
            this.bt_perehod_projekti.Location = new System.Drawing.Point(510, 485);
            this.bt_perehod_projekti.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.bt_perehod_projekti.Name = "bt_perehod_projekti";
            this.bt_perehod_projekti.Size = new System.Drawing.Size(150, 44);
            this.bt_perehod_projekti.TabIndex = 4;
            this.bt_perehod_projekti.TabStop = false;
            this.bt_perehod_projekti.Text = "Продробнее";
            this.bt_perehod_projekti.UseVisualStyleBackColor = true;
            this.bt_perehod_projekti.Click += new System.EventHandler(this.bt_perehod_projekti_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(40, 29);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(378, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Информация об выбранном проекте";
            // 
            // Indicator1
            // 
            this.Indicator1.Location = new System.Drawing.Point(454, 121);
            this.Indicator1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Indicator1.Multiline = true;
            this.Indicator1.Name = "Indicator1";
            this.Indicator1.ReadOnly = true;
            this.Indicator1.Size = new System.Drawing.Size(68, 48);
            this.Indicator1.TabIndex = 4;
            this.Indicator1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textbox_projekti
            // 
            this.textbox_projekti.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.textbox_projekti.Location = new System.Drawing.Point(12, 62);
            this.textbox_projekti.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.textbox_projekti.Multiline = true;
            this.textbox_projekti.Name = "textbox_projekti";
            this.textbox_projekti.ReadOnly = true;
            this.textbox_projekti.Size = new System.Drawing.Size(428, 342);
            this.textbox_projekti.TabIndex = 1;
            // 
            // save_btn
            // 
            this.save_btn.Image = ((System.Drawing.Image)(resources.GetObject("save_btn.Image")));
            this.save_btn.Location = new System.Drawing.Point(374, 625);
            this.save_btn.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.save_btn.Name = "save_btn";
            this.save_btn.Size = new System.Drawing.Size(70, 54);
            this.save_btn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.save_btn.TabIndex = 4;
            this.save_btn.TabStop = false;
            this.save_btn.Click += new System.EventHandler(this.save_btn_Click);
            // 
            // achivki_pb
            // 
            this.achivki_pb.Image = ((System.Drawing.Image)(resources.GetObject("achivki_pb.Image")));
            this.achivki_pb.Location = new System.Drawing.Point(448, 621);
            this.achivki_pb.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.achivki_pb.Name = "achivki_pb";
            this.achivki_pb.Size = new System.Drawing.Size(70, 54);
            this.achivki_pb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.achivki_pb.TabIndex = 5;
            this.achivki_pb.TabStop = false;
            this.achivki_pb.Click += new System.EventHandler(this.achivki_pb_Click);
            // 
            // central_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1058, 748);
            this.Controls.Add(this.achivki_pb);
            this.Controls.Add(this.save_btn);
            this.Controls.Add(this.tekushie_pojeckti);
            this.Controls.Add(this.gb_igr_inf);
            this.Controls.Add(this.btn_hod);
            this.Controls.Add(this.gb_igrok);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.ImeMode = System.Windows.Forms.ImeMode.On;
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1084, 819);
            this.MinimumSize = new System.Drawing.Size(1084, 819);
            this.Name = "central_form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RCS v.1.0.3";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.central_form_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseEnter += new System.EventHandler(this.central_form_MouseEnter);
            this.gb_igrok.ResumeLayout(false);
            this.gb_igrok.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_igr_avatar)).EndInit();
            this.gb_igr_inf.ResumeLayout(false);
            this.gb_igr_inf.PerformLayout();
            this.tekushie_pojeckti.ResumeLayout(false);
            this.tekushie_pojeckti.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.save_btn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.achivki_pb)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gb_igrok;
        private System.Windows.Forms.LinkLabel labe_nickname;
        private System.Windows.Forms.PictureBox pb_igr_avatar;
        private System.Windows.Forms.Button btn_hod;
        private System.Windows.Forms.GroupBox gb_igr_inf;
        private System.Windows.Forms.Label hp1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox tekushie_pojeckti;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textbox_projekti;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button bt_perehod_projekti;
        private System.Windows.Forms.Button bt_perehod_inf;
        public System.Windows.Forms.Label alg_label;
        private System.Windows.Forms.TextBox Indicator1;
        private System.Windows.Forms.Button Up;
        private System.Windows.Forms.Button Down;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.PictureBox save_btn;
        public System.Windows.Forms.Label money_znach;
        public System.Windows.Forms.Label data_znach;
        public System.Windows.Forms.Label zn_yazika;
        public System.Windows.Forms.Label zn_CNS;
        public System.Windows.Forms.Label zn_GUI;
        public System.Windows.Forms.Label nastr_lb;
        public System.Windows.Forms.Label hp_z;
        public System.Windows.Forms.Label proj_comp;
        private System.Windows.Forms.PictureBox achivki_pb;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox Pov_navikov_info;
    }
}

