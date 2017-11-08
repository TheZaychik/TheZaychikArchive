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
    public partial class Event1 : Form
    {
        oper_form cf;
        public Event1()
        {   
            InitializeComponent();
        }
        private void Event1_Load(object sender, EventArgs e)
        {
            cf = (oper_form)this.Owner;
        }
        private void vlozit_Click(object sender, EventArgs e) // если вы вложите
        {
            if (cf.money < 500) // проверка
            {
                MessageBox.Show("У вас недостаточно денег! Поэтому вы отказались", "Неа!");
                this.Close();

            }
            else
            {
                Random rnd_a = new Random(); // рандом на удау
                Int32 rnd_a2 = Convert.ToInt32(rnd_a.Next(0, 6));
                if (rnd_a2 == 5)
                {
                    MessageBox.Show("Тот тип и впрям был прав! Вам запалтили 1500$! + 100 к Настроению", "Ох, е*ать!"); // если повезло
                    cf.nastroen = cf.nastroen + 100;
                    cf.money = cf.money + 1500;
                }
                else
                {
                    MessageBox.Show("Вас обманули.. -500$, -50 к Настроению", "Эх..."); // если нет
                    cf.nastroen = cf.nastroen - 50;
                    cf.money = cf.money - 500;
                }
                this.Close();
            }
         }

        private void otkaz_Click(object sender, EventArgs e) //Отказ от предложения 
        {
            MessageBox.Show("Вы решили не рисковать, и отказались. Однако вы слегка взгрустнули. -5 к Настроению", "Эх...");
            cf.nastroen = cf.nastroen - 5;
            this.Close();
        }    
    }
}
