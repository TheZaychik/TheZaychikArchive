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
    public partial class pov_navikov : Form
    {
        central_form pm = new central_form();
        oper_form cf;
        public pov_navikov()
        {
            InitializeComponent();
        }
        // НАСТРОЕНИЕ
        private void doshik_Click(object sender, EventArgs e) // покупка дошика
        {
            if (cf.money < 10) // если нет денег
            {
                MessageBox.Show("Недостаточно денег!", "Ошибка!");
            }

            else
            {
                if (cf.Max_time > 0)
                {
                    cf.nastroen = cf.nastroen + 5; // повышение настроения
                    cf.money = cf.money - 10; // вычитание денег
                    cf.Max_time--;
                    upd_form(cf.ALG, cf.LNG, cf.GUI, cf.CNS, cf.nastroen, cf.HP, cf.money, cf.Max_time); // апдейт формы
                }

                else
                {
                    MessageBox.Show("У вас не достаточно времени чтобы выполнит это действие", "Ошибка!");
                }
            }
        }

        private void shavuha_Click(object sender, EventArgs e)
        {
            Random rnd_shav = new Random();
            Int32 rnd_shav2;
            if (cf.money < 35) // если нет денег
            {
                MessageBox.Show("Недостаточно денег!", "Ошибка!");
            }

            else
            {
                if (cf.Max_time > 0)
                {
                    cf.Max_time--;
                    cf.nastroen = cf.nastroen + 20; // повышение настроения
                    cf.money = cf.money - 35; // вычитание денег
                    rnd_shav2 = Convert.ToInt32(rnd_shav.Next(0, 11));
                    if (rnd_shav2 == 5)
                    {
                        cf.Max_time--;
                        MessageBox.Show("Вы отривились шавухой!", "Ой...");
                        cf.nastroen = cf.nastroen - 10;
                        cf.HP = cf.HP - 25;
                    }
                }

                else
                {
                    MessageBox.Show("У вас не достаточно времени чтобы выполнит это действие", "Ошибка!");
                }
                upd_form(cf.ALG, cf.LNG, cf.GUI, cf.CNS, cf.nastroen, cf.HP, cf.money, cf.Max_time); // апдейт формы
            }
        }

        private void restoran_Click(object sender, EventArgs e)
        {
            if (cf.money < 160) // если нет денег
            {
                MessageBox.Show("Недостаточно денег!", "Ошибка!");
            }
            else
            {
                if (cf.Max_time - 2 < 0)
                {
                    MessageBox.Show("У вас не достаточно времени чтобы выполнит это действие", "Ошибка!");
                }
                else
                {
                    cf.nastroen = cf.nastroen +90; // повышение настроения
                    cf.money = cf.money - 160; // вычитание денег
                    cf.Max_time = cf.Max_time - 2;
                    upd_form(cf.ALG, cf.LNG, cf.GUI, cf.CNS, cf.nastroen, cf.HP, cf.money, cf.Max_time); // апдейт формы
                }
            }
        }

        private void putin_Click(object sender, EventArgs e)
        {
            if (cf.money < 500) // если нет денег
            {
                MessageBox.Show("Недостаточно денег!", "Ошибка!");
            }
            else
            {
                if (cf.Max_time - 8 < 0)
                {
                    MessageBox.Show("У вас не достаточно времени чтобы выполнит это действие", "Ошибка!");
                }
                else
                {
                    cf.nastroen = cf.nastroen + 300; // повышение настроения
                    cf.money = cf.money - 500; // вычитание денег
                    cf.Max_time = cf.Max_time - 8;
                
                }
                upd_form(cf.ALG, cf.LNG, cf.GUI, cf.CNS, cf.nastroen, cf.HP, cf.money, cf.Max_time); // апдейт формы
            }
        }

        private void pov_navikov_Load(object sender, EventArgs e)
        {
            cf = (oper_form)this.Owner;
            upd_form(cf.ALG, cf.LNG, cf.GUI, cf.CNS, cf.nastroen, cf.HP, cf.money, cf.Max_time);

        }

        private void upd_form(Int32 ALG, Int32 LNG, Int32 GUI, Int32 CNS, Int32 nastroen, Int32 HP, Int32 money, Int32 Max_time)
        {
            T_L_display.Text = Convert.ToString(Max_time);
            alg_label.Text = Convert.ToString(ALG);
            zn_yazika.Text = Convert.ToString(LNG);
            zn_GUI.Text = Convert.ToString(GUI);
            zn_CNS.Text = Convert.ToString(CNS);
            nastr_lb.Text = Convert.ToString(nastroen);
            hp_znach.Text = Convert.ToString(HP);
            money_znach.Text = Convert.ToString(money);
        }
        // ХП
        private void gemotagen_Click(object sender, EventArgs e)
        {

            if (cf.HP == 100) // если полный запас хп
            {
                MessageBox.Show("У вас полный запас здоровья!", "Зачем ты это делаешь?");
            }
            else
            {
                if (cf.money < 5) // если нет денег
                {
                    MessageBox.Show("Недостаточно денег!", "Ошибка!");
                }
                else
                {
                    if (cf.Max_time > 0)
                    {
                        cf.Max_time--;
                        cf.HP = cf.HP + 10; // повышение HP
                        cf.money = cf.money - 5; // вычитание денег
                        if (cf.HP > 100)// если лечение дало больше 100 хп
                        {
                            cf.HP = 100; // по уставу игры не может быть больше 100 хп
                        }
                    }
                    else
                    {
                        MessageBox.Show("У вас не достаточно времени чтобы выполнит это действие", "Ошибка!");
                    }
                    upd_form(cf.ALG, cf.LNG, cf.GUI, cf.CNS, cf.nastroen, cf.HP, cf.money, cf.Max_time); // апдейт формы
                }
            }
        }

        private void avto_apt_Click(object sender, EventArgs e)
        {
            if (cf.HP == 100) // если полный запас хп
            {
                MessageBox.Show("У вас полный запас здоровья!", "Зачем ты это делаешь?");
            }
            else
            {
                if (cf.money < 15) // если нет денег
                {
                    MessageBox.Show("Недостаточно денег!", "Ошибка!");
                }
                else
                {
                    if (cf.Max_time > 0)
                    {
                        cf.HP = cf.HP + 15; // повышение HP
                        cf.money = cf.money - 15; // вычитание денег
                        cf.Max_time--;
                        if (cf.HP > 100)// если лечение дало больше 100 хп
                        {
                            cf.HP = 100; // по уставу игры не может быть больше 100 хп
                        }
                    }
                    else
                    {
                        MessageBox.Show("У вас не достаточно времени чтобы выполнит это действие", "Ошибка!");
                    }
                    upd_form(cf.ALG, cf.LNG, cf.GUI, cf.CNS, cf.nastroen, cf.HP, cf.money, cf.Max_time); // апдейт формы
                }
            }
        }

        private void germany_Click(object sender, EventArgs e)
        {
            Random rnd_kabz = new Random();
            Int32 rnd_kabz2;
            rnd_kabz2 = Convert.ToInt32(rnd_kabz.Next(0, 2));
            if (cf.HP == 100) // если полный запас хп
            {
                MessageBox.Show("У вас полный запас здоровья!", "Зачем ты это делаешь?");
            }
            else
            {
                if (cf.money < 1000) // если нет денег
                {
                    MessageBox.Show("Недостаточно денег!", "Ошибка!");
                }
                else
                {
                    if (cf.Max_time - 10 > 0)
                    {
                        cf.HP = cf.HP + 50; // повышение HP
                        cf.money = cf.money - 1000; // вычитание денег
                        cf.Max_time = cf.Max_time - 10;
                        if (cf.HP > 100)// если лечение дало больше 100 хп
                        {
                            cf.HP = 100; // по уставу игры не может быть больше 100 хп
                        }
                        if (rnd_kabz2 == 0)
                        {
                            MessageBox.Show("По пути из больницы, вы встретили Кобзона, и он подарил вам пирамидку (+25 к Настроению)", "Опа!");
                            cf.nastroen = cf.nastroen + 25;
                        }
                    }
                    else
                    {
                        MessageBox.Show("У вас не достаточно времени чтобы выполнит это действие", "Ошибка!");
                    }
                    upd_form(cf.ALG, cf.LNG, cf.GUI, cf.CNS, cf.nastroen, cf.HP, cf.money, cf.Max_time); // апдейт формы
                }

            }
        }


        private void poliklin_Click(object sender, EventArgs e)
        {
            if (cf.HP == 100) // если полный запас хп
            {
                MessageBox.Show("У вас полный запас здоровья!", "Зачем ты это делаешь?");
            }
            else
            {
                if (cf.money < 25) // если нет денег
                {
                    MessageBox.Show("Недостаточно денег!", "Ошибка!");
                }
                else
                {
                    if (cf.Max_time - 4 < 0)
                    {
                        cf.Max_time = cf.Max_time - 4;
                        cf.HP = cf.HP + 25; // повышение HP
                        cf.money = cf.money - 25; // вычитание денег
                        if (cf.HP > 100)// если лечение дало больше 100 хп
                        {
                            cf.HP = 100; // по уставу игры не может быть больше 100 хп
                        }
                    }
                    else
                    {
                        MessageBox.Show("У вас не достаточно времени чтобы выполнит это действие", "Ошибка!");
                    }
                    upd_form(cf.ALG, cf.LNG, cf.GUI, cf.CNS, cf.nastroen, cf.HP, cf.money, cf.Max_time); // апдейт формы
                }
            }
        }

        // НАВЫКИ

        private void msdn_Click(object sender, EventArgs e)
        {
            if (cf.Proj_set == true)
            {
                MessageBox.Show("Вы не можете улучшать навыки во время проекта!", "Ошибка!");
            }
            else
            {
                if (cf.Max_time == 24)
                {
                    if (cf.skill_boost_cap == 0)
                    {
                        cf.nastroen = cf.nastroen - 10;
                        cf.ALG = cf.ALG + 5;
                        cf.LNG = cf.LNG + 2;
                        cf.Max_time = 0;
                    }
                    else
                    {
                        MessageBox.Show("Вы уже в данный момент повышаете навыки, дождитесь оконыания и потом попробуйте снова", "Ошибка!");
                    }
                }
                else
                {
                    MessageBox.Show("У вас не достаточно времени чтобы выполнит это действие", "Ошибка!");
                }
            }
        }

        private void mayki_Click(object sender, EventArgs e)
        {
            if (cf.Proj_set == true)
            {
                MessageBox.Show("Вы не можете улучшать навыки во время проекта!", "Ошибка!");
            }
            else
            {
                if (cf.money < 1000)
                {
                    MessageBox.Show("Недостаточно денег!", "Ошибка!");
                }
                else
                {
                    if (cf.Max_time == 24)
                    {
                        if (cf.skill_boost_cap == 0)
                        {
                            cf.nastroen = cf.nastroen - 30;
                            cf.ALG = cf.ALG + 15;
                            cf.LNG = cf.LNG + 20;
                            cf.CNS = cf.CNS + 21;
                            cf.GUI = cf.GUI + 21;
                            cf.money = cf.money - 1000;
                            cf.skill_boost_cap = 4;
                            cf.Max_time = 0;
                        }
                        else
                        {
                            MessageBox.Show("Вы уже в данный момент повышаете навыки, дождитесь оконыания и потом попробуйте снова", "Ошибка!");
                        }
                    }
                    else
                    {
                        MessageBox.Show("У вас не достаточно времени чтобы выполнит это действие", "Ошибка!");
                    }
                }
            }
        }

        private void timofey_Click(object sender, EventArgs e)
        {
            if (cf.Proj_set == true)
            {
                MessageBox.Show("Вы не можете улучшать навыки во время проекта!", "Ошибка!");
            }
            else
            {
                if (cf.Max_time == 24)
                {
                    if (cf.skill_boost_cap == 0)
                    {
                        cf.nastroen = cf.nastroen + 5;
                        cf.HP = cf.HP - 10;
                        cf.ALG = cf.ALG + 5;
                        cf.LNG = cf.LNG + 2;
                        cf.CNS = cf.CNS + 3;
                        cf.GUI = cf.GUI + 3;
                        cf.skill_boost_cap = 2;
                        cf.Max_time = 0;
                    }
                    else
                    {
                        MessageBox.Show("Вы уже в данный момент повышаете навыки, дождитесь оконыания и потом попробуйте снова", "Ошибка!");
                    }
                }
                else
                {
                    MessageBox.Show("У вас не достаточно времени чтобы выполнит это действие", "Ошибка!");
                }
            }
        }

        private void unium_Click(object sender, EventArgs e)
        {
            if (cf.Proj_set == true)
            {
                MessageBox.Show("Вы не можете улучшать навыки во время проекта!", "Ошибка!");
            }
            else
            {
                if (cf.money < 200)
                {
                    MessageBox.Show("Недостаточно денег!", "Ошибка!");
                }
                else
                {
                    if (cf.Max_time == 24)
                    {
                        if (cf.skill_boost_cap == 0)
                        {
                            cf.nastroen = cf.nastroen + 10;
                            cf.ALG = cf.ALG + 10;
                            cf.LNG = cf.LNG + 5;
                            cf.CNS = cf.CNS + 2;
                            cf.GUI = cf.GUI + 2;
                            cf.skill_boost_cap = 3;
                            cf.money = cf.money - 200;
                            cf.Max_time = 0;
                        }
                        else
                        {
                            MessageBox.Show("Вы уже в данный момент повышаете навыки, дождитесь оконыания и потом попробуйте снова", "Ошибка!");
                        }
                    }
                    else
                    {
                        MessageBox.Show("У вас не достаточно времени чтобы выполнит это действие", "Ошибка!");
                    }
                }
            }
        }

        private void pov_navikov_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }
    } 
}
