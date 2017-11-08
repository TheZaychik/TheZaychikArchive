using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Russian_Coder_Simulator
{
    public partial class game_prew : Form
    {
        oper_form cf;
        Vibor_avatarki vba = new Vibor_avatarki();
        central_form gps = new central_form();
        public game_prew()
        {
            InitializeComponent();
        }
        private void game_prew_Load(object sender, EventArgs e) // загрузка
        {
            cf = (oper_form)this.Owner;
        }
        private void start_new_game_Click(object sender, EventArgs e) // новая игра
        {
            vba.Owner = (oper_form)this.Owner;
            vba.Show();
            this.Hide();   
        }
        private void Zagruzit_Click(object sender, EventArgs e) // загрузка
        {
            cf.zagruzka();
            gps.Owner = (oper_form)this.Owner;
            gps.Show();
            this.Hide();
        }
        private void game_prew_FormClosing(object sender, FormClosingEventArgs e) // убирание мусора
        {
            Application.Exit();
        }

        private void rcs_redux_link_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("В данный момент в разработке!","YOBA,ETO NE DOSTUPNO");

        }

        private void changelog_btn_Click(object sender, EventArgs e)
        {
            changelog cl = new changelog();
            cl.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://vk.com/bidlokodgames");
        }

        
    }
}
