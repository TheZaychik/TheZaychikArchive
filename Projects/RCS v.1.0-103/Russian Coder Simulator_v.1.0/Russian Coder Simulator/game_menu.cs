using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using System.IO;
//using Project;
//using ProjectS;

namespace Russian_Coder_Simulator
{
    public partial class central_form : Form
    {
        Int32 H_all = 0;
        oper_form cf;
        Random rnd_case = new Random();
        Int32 rnd_case2;
        public central_form()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) // лоад формы
        {
            cf = (oper_form)this.Owner;
            upd_form();
        }

        public void upd_form()
        {
            // лоад косметики
            try
            {
                if (cf.nick == "")
                {
                    labe_nickname.Text = "ДуРаЧоК БеЗ НиКа";
                }
                else
                {
                    labe_nickname.Text = cf.nick;
                }
                Indicator1.Text = Convert.ToString(H_all);
                pb_igr_avatar.Load(cf.avatar);
                textbox_projekti.Text = "У вас нет принятых проектов";
                form_update(cf.N_of_Proj_compl, cf.ALG, cf.LNG, cf.GUI, cf.CNS, cf.nastroen, cf.money, cf.HP, cf.skill_boost_cap, ref alg_label, ref zn_yazika, ref zn_GUI, ref zn_CNS, ref nastr_lb, ref money_znach, ref hp_z, ref proj_comp, ref Pov_navikov_info);
            }
            catch (InvalidOperationException)
            {
                // Если нет ника 
                if (cf.nick == "")
                {
                    labe_nickname.Text = "ДуРаЧоК БеЗ НиКа";
                }
                else
                {
                    labe_nickname.Text = cf.nick;
                }
                Indicator1.Text = Convert.ToString(H_all);
                cf.avatar = null;
                labe_nickname.Text = cf.nick;
                textbox_projekti.Text = "У вас нет принятых проектов";
                form_update(cf.N_of_Proj_compl, cf.ALG, cf.LNG, cf.GUI, cf.CNS, cf.nastroen, cf.money, cf.HP,cf.skill_boost_cap, ref alg_label, ref zn_yazika, ref zn_GUI, ref zn_CNS, ref nastr_lb, ref money_znach, ref hp_z, ref proj_comp, ref Pov_navikov_info);
            }
        }

        public static void form_update(Int32 N_of_Proj_compl, Int32 ALG, Int32 LNG, Int32 GUI, Int32 CNS, Int32 nastroen, Int32 money, Int32 HP, Int32 skill_cap, ref Label alg_label, ref Label zn_yazika, ref Label zn_GUI, ref Label zn_CNS, ref Label nastr_lb, ref Label money_znach, ref Label hp_z, ref Label proj_comp, ref TextBox pov_navikov_info)
        {
            //Апдейт формы
            alg_label.Text = Convert.ToString(ALG);
            zn_yazika.Text = Convert.ToString(LNG);
            zn_GUI.Text = Convert.ToString(GUI);
            zn_CNS.Text = Convert.ToString(CNS);
            nastr_lb.Text = Convert.ToString(nastroen);
            money_znach.Text = Convert.ToString(money);
            hp_z.Text = Convert.ToString(HP);
            proj_comp.Text = Convert.ToString((N_of_Proj_compl - 10));
            if (skill_cap == 0)
            {
                pov_navikov_info.Text = "Нет повышений";
            }
            else
            {
                pov_navikov_info.Text = Convert.ToString(skill_cap) + " До окнчания повышения";
            }
        }
        /*  Для Макса
           * ──────▄▌██▐▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀█*
           * ───▄▄██▌███ФУРА С ПРОБЕЛАМИ ПРИЕХАЛА████*
           * ▄▄▄▌▐██▌███████████████████████████████*
           * ███████▌███▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄█*
           * ▀▀(@)▀▀▀▀▀▀▀(@)(@)▀▀▀▀▀▀▀▀▀▀▀▀▀▀(@) (@)▀▀▀▀  */

       private static void Game_core(ref Int32 Time_H, ref Int32 Moves, ref String Proj_Name, ref Int32 Money, ref Int32 proj_comple, ref Boolean Proj_set, ref Int32 HP, ref Int32 nastoren, ref Int32 Nagrada_project, ref Boolean BOG, ref Boolean Abramovich, ref Boolean Gorets, ref Boolean OslikSuslik, ref Int32 ALG, ref Int32 CNS, ref Int32 GUI, ref Int32 LNG, ref Int32 day) //Основная функция игры 
        {
           //выполнение проекта 
            if (Time_H <= 0 && Proj_set == true)
            {
                Proj_Name = null;
                MessageBox.Show("Вы выполнили ваше текущее задание!", "Поздраляем!", MessageBoxButtons.OK);
                Money = Money + Nagrada_project;
                proj_comple++;
                Proj_set = false;
            }
           // Дедукция хп при невыполнение проекта 
            if (Moves <= 0 && Proj_set == true)
            {
                HP = HP - 25;
                MessageBox.Show("Вы не смогли выполнить задания за поставленный отрезок времени, и за это вы получаете пиндюлей!", "ИТС ПИНДЮЛИ ТАЙМ!!", MessageBoxButtons.OK);
                Proj_set = false;
                Proj_Name = null;
            }
           // Смерть 
            if (HP <= 0)
            {
                MessageBox.Show("Вы умерли!", "Game Over", MessageBoxButtons.OK);
                Application.Exit();
            }
            if (nastoren < -200)
            {
                MessageBox.Show("У вас слишком низкое настроение, поэтому вы вскрылись!", "Game Over", MessageBoxButtons.OK);
                Application.Exit();
            }
            // Проверка на ачивки
            if (ALG > 70 && CNS > 70 && GUI > 70 && LNG > 70)
            {
                BOG = true;
            }
            if (Money > 70000)
            {
                Abramovich = true;
            }
            if (day > 1000)
            {
                Gorets = true;
            }
            if (nastoren > 2000)
            {
                OslikSuslik = true;
            }
            if (BOG == true && Abramovich == true && Gorets == true && OslikSuslik == true)
            {
                MessageBox.Show("Вы настолько е*анутые, что прошли эту игру! Круто!", "Поздравляем!!!");
                Application.Exit();
            }
        }

        public static void Proj_parameters(ref TextBox Project, String Proj_Name, Int32 Time_H, Int32 Moves) // Апдейт текстбокса 
        {
            if (Proj_Name == null)
            {
                Project.Text = "У вас нет принятых проектов";
            }
            else
            {
                Project.Text = "Ваш проект " + Proj_Name + "\r\nЧасы оставшиеся до выполнения проекта " + Time_H + "\r\nОсталось ходов " + Moves;
            }
        }

        private void btn_hod_Click(object sender, EventArgs e) // ход
        {
            if (H_all > cf.Max_time)
            {
                MessageBox.Show("Вы слишком много часов выделили на проект, уменьшите количество часов!", "Ошибка");
            }
            else
            {
                cf.Moves--; // Редукция часов которые идут на выполнение проекта 
                if (cf.nastroen < 50)
                {
                    cf.Time_H = cf.Time_H - (H_all / 4 * 3);
                }
                if (cf.nastroen < 0)
                {
                    cf.Time_H = cf.Time_H - (H_all / 2);
                }
                if (cf.nastroen < -75)
                {
                    cf.Time_H = cf.Time_H - (H_all / 4 * 1);
                }
                if (cf.nastroen > 50)
                {
                    cf.Time_H = cf.Time_H - H_all;
                }
                cf.nastroen--;
                for (Int32 i = H_all; i > 4; i--)
                {
                    cf.nastroen--;
                }
                nastr_lb.Text = Convert.ToString(cf.nastroen);
                data_znach.Text = Convert.ToString(cf.day++); // 1 ход - 1 день
                Indicator1.Text = Convert.ToString(H_all);
                // Рандомный случай------------------------------------------
                rnd_case2 = Convert.ToInt32(rnd_case.Next(0, 31)); // рнд от 1 до 12
                if (rnd_case2 == 4) // Гопники
                {
                    cf.nastroen = cf.nastroen - 20;
                    cf.HP = cf.HP - 30;
                    cf.money = cf.money - 50;
                    MessageBox.Show("По пути домой вас гопнули. -20 к Настроению, -30 к НР, -50$", "Опа!");
                }
                if (rnd_case2 == 2) // Ваша 2D тян бросила вас
                {
                    cf.nastroen = cf.nastroen - 40;
                    MessageBox.Show("Ваша 2D тян с двача вас бросила. -40 к Настроению", "Плак-плак...");
                }
                if (rnd_case2 == 8)
                {
                    cf.money = cf.money + 100;
                    cf.nastroen = cf.nastroen + 10;
                    MessageBox.Show("По пути в универ, на остановке 410-ого автобуса, вы нашли 100$! +10 к Настроению, +100$", "Юху!");
                }
                if (rnd_case2 == 20) // Эвент с типом
                {
                    Event1 e1 = new Event1();
                    e1.Owner = cf;
                    e1.Show();
                }
                if (rnd_case2 == 15) // Эвент с бомжом 
                {
                    Event2 e2 = new Event2();
                    e2.Owner = cf;
                    e2.Show();
                 }
                if (rnd_case2 == 25) // Эвент с дождиком 
                {
                    Event3 e3 = new Event3();
                    e3.Owner = cf;
                    e3.Show();
                }
                if (cf.skill_boost_cap != 0) // Останавливет фарм скилов 
                {
                    cf.skill_boost_cap--;
                    cf.Max_time = 0;
                }
                if (cf.skill_boost_cap == 0)
                {
                    cf.Max_time = 24;
                }
                // Вызов всех нужных функций 
                Game_core(ref cf.Time_H, ref cf.Moves, ref cf.Proj_Name, ref cf.money, ref cf.N_of_Proj_compl, ref cf.Proj_set, ref cf.HP, ref cf.nastroen, ref cf.Nagrada_project, ref cf.BOG, ref cf.Abramovich, ref cf.Gorets, ref cf.OslikSuslik, ref cf.ALG, ref cf.CNS, ref cf.GUI, ref cf.LNG, ref cf.day);
                form_update(cf.N_of_Proj_compl, cf.ALG, cf.LNG, cf.GUI, cf.CNS, cf.nastroen, cf.money, cf.HP, cf.skill_boost_cap, ref alg_label, ref zn_yazika, ref zn_GUI, ref zn_CNS, ref nastr_lb, ref money_znach, ref hp_z, ref proj_comp, ref Pov_navikov_info);
                Proj_parameters(ref textbox_projekti, cf.Proj_Name, cf.Time_H, cf.Moves);
                ActiveForm.Update();
            }
        }

        private void bt_perehod_projekti_Click(object sender, EventArgs e) // Выбор проекта 
        {
            if (cf.skill_boost_cap == 0)
            {
                ProjectS Select_Proj = new ProjectS();
                Select_Proj.Owner = cf;
                Select_Proj.Show();
            }
            else
            {
                MessageBox.Show("На данный момент вы повышаете навыки, подождите пока вы закончите и попробуйте снова", "Ошибка!");
            }
        }

        private void bt_perehod_inf_Click(object sender, EventArgs e) // Повышение навков 
        {
            pov_navikov pn = new pov_navikov();
            pn.Owner = cf;
            pn.Show();
        }

        private void central_form_FormClosing(object sender, FormClosingEventArgs e) // При закрытии 
        {
            Application.Exit();
        }

        private void central_form_MouseEnter(object sender, EventArgs e) //Апдейт формы
        {
            Proj_parameters(ref textbox_projekti, cf.Proj_Name, cf.Time_H, cf.Moves);
            form_update(cf.N_of_Proj_compl, cf.ALG, cf.LNG, cf.GUI, cf.CNS, cf.nastroen, cf.money, cf.HP, cf.skill_boost_cap, ref alg_label, ref zn_yazika, ref zn_GUI, ref zn_CNS, ref nastr_lb, ref money_znach, ref hp_z, ref proj_comp, ref Pov_navikov_info);
        }

        private void Up_Click(object sender, EventArgs e) //Повышение часов выделяемых на проект 
        {
            if (H_all >= cf.Max_time)
            {
                MessageBox.Show("Слишком ного часов, больше нельзя увеличить кол часов", "Ошибка", MessageBoxButtons.OK);
            }
            else
            {
                H_all++;
                Indicator1.Text = Convert.ToString(H_all);
            }
        }

        private void Down_Click(object sender, EventArgs e) //Понижение часов выделяемых на проект 
        {
            if (H_all <= 0)
            {
                MessageBox.Show("Слишком мало часов, больше нельзя уменьшать кол часов", "Ошибка", MessageBoxButtons.OK);
            }
            else
            {
                H_all--;
                Indicator1.Text = Convert.ToString(H_all);
            }
        }

        private void save_btn_Click(object sender, EventArgs e) //Сохранение 
        {
            cf.Save();
        }

        private void achivki_pb_Click(object sender, EventArgs e) //Ачивки 
        {
            achivki achv = new achivki();
            achv.Owner = cf;
            achv.Show();
        }
    }
}
