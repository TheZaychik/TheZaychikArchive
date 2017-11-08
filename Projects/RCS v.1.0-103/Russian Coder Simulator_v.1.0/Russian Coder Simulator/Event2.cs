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
    public partial class Event2 : Form
    {
        public Event2()
        {
            InitializeComponent();
        }
        oper_form cf;
       private void dat_deneg_Click(object sender, EventArgs e) // дать  денег 
        {
            if (cf.money < 50) // проверка
            {
                MessageBox.Show("У вас недостаточно денег! Поэтому вы отказались", "Неа!");
                this.Close();
            }
            else
            {
                Random rnd_a = new Random(); // рандом 
                Int32 rnd_a2 = Convert.ToInt32(rnd_a.Next(0, 6));
                if (rnd_a2 == 5)
                {
                    MessageBox.Show("Ты дал бомжу 50$, а взамен он вам дал косячок! +250 к Настроению", "Ммм..."); // если повезло
                    cf.nastroen = cf.nastroen + 250;
                    cf.money = cf.money - 50;
                }
                else
                {
                    MessageBox.Show("Бомж забарл у вас 50$, матюкнулся и ушел.. - 10 к Настроению", "Эх..."); // если нет
                    cf.nastroen = cf.nastroen - 10;
                    cf.money = cf.money - 50;
                }
                this.Close();
            }
        }
        private void Event2_Load(object sender, EventArgs e) // присваивание овнера 
        {
            cf = (oper_form)this.Owner;
        }
        private void otkaz_Click(object sender, EventArgs e) // отказ от эвента
        {
            MessageBox.Show("Вы послали бомжа, и ушли. +5 к Настроению", "No,Bomz,No...");
            cf.nastroen = cf.nastroen + 5;
            this.Close();
        }
    }
}
