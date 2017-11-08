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
    public partial class oper_form : Form
    {
        public oper_form()
        {
            InitializeComponent();
        }
        
        public void oper_form_Load(object sender, EventArgs e)
        {
            game_prew gp = new game_prew();
            gp.Owner = this;
            gp.Show();
        }
        
        // Массив для обработки данных
         String[] mas_var = new String[22];
        // Очки
        public Int32 money = 500;
        public Int32 HP = 100;
        public Int32 day = 1;
        public Int32 nastroen = 100;
        // Навыки
        public Int32 ALG;
        public Int32 LNG;
        public Int32 GUI;
        public Int32 CNS;
        // Кастом
        public String nick;
        public String avatar;
        public String Proj_Name;
        public Int32 Time_H = -1;  //Кол часов данных на проэкт
        public Int32 Moves;
        public Int32 N_of_Proj_compl = 10; //Кол законченных проектов
        public Boolean Proj_set = false;
        public Int32 Max_time = 24;
        public Int32 Nagrada_project;
        public Int32 skill_boost_cap = 0;
        // Ачивки
        public Boolean BOG = false;
        public Boolean Abramovich = false;
        public Boolean Gorets = false;
        public Boolean OslikSuslik = false;
       public void oper_form_Shown(object sender, EventArgs e)
        {
            this.Hide();
        }
       public void Save() // сохранение
       {
           if (DialogResult.OK == saveFileDialog.ShowDialog())
           {

               mas_var[0] = Convert.ToString(money);
               mas_var[1] = Convert.ToString(HP);
               mas_var[2] = Convert.ToString(day);
               mas_var[3] = Convert.ToString(nastroen);
               mas_var[4] = Convert.ToString(ALG);
               mas_var[5] = Convert.ToString(LNG);
               mas_var[6] = Convert.ToString(GUI);
               mas_var[7] = Convert.ToString(CNS);
               mas_var[8] = nick;
               mas_var[9] = avatar;
               mas_var[10] = Proj_Name;
               mas_var[11] = Convert.ToString(Time_H);
               mas_var[12] = Convert.ToString(Moves);
               mas_var[13] = Convert.ToString(N_of_Proj_compl);
               mas_var[14] = Convert.ToString(Proj_set);
               mas_var[15] = Convert.ToString(Max_time);
               mas_var[16] = Convert.ToString(Nagrada_project);
               mas_var[17] = Convert.ToString(BOG);
               mas_var[18] = Convert.ToString(Abramovich);
               mas_var[19] = Convert.ToString(Gorets);
               mas_var[20] = Convert.ToString(OslikSuslik);
               mas_var[21] = Convert.ToString(skill_boost_cap);
               using (System.IO.StreamWriter file = new System.IO.StreamWriter(saveFileDialog.FileName))
               {
                   for (Int32 i = 0; i < 22; i++)
                   {
                       file.WriteLine(mas_var[i]);
                   }
               }
               MessageBox.Show("Игра сохранена!", "Сохранение");
           }
       }

       public void zagruzka()
       {
           if (DialogResult.OK == loadFileDialog.ShowDialog())
           {

               using (System.IO.StreamReader file = new System.IO.StreamReader(loadFileDialog.FileName))
               {
                   for (Int32 i = 0; i < 22; i++)
                   {
                       mas_var[i] = file.ReadLine();
                   }
               }
               money = Convert.ToInt32(mas_var[0]);
               HP = Convert.ToInt32(mas_var[1]);
               day = Convert.ToInt32(mas_var[2]);
               nastroen = Convert.ToInt32(mas_var[3]);
               ALG = Convert.ToInt32(mas_var[4]);
               LNG = Convert.ToInt32(mas_var[5]);
               GUI = Convert.ToInt32(mas_var[6]);
               CNS = Convert.ToInt32(mas_var[7]);
               nick = mas_var[8];
               avatar = mas_var[9];
               Proj_Name = mas_var[10];
               Time_H = Convert.ToInt32(mas_var[11]);
               Moves = Convert.ToInt32(mas_var[12]);
               N_of_Proj_compl = Convert.ToInt32(mas_var[13]);
               Proj_set = Convert.ToBoolean(mas_var[14]);
               Max_time = Convert.ToInt32(mas_var[15]);
               Nagrada_project = Convert.ToInt32(mas_var[16]);
               BOG = Convert.ToBoolean(mas_var[17]);
               Abramovich = Convert.ToBoolean(mas_var[18]);
               Gorets = Convert.ToBoolean(mas_var[19]);
               OslikSuslik = Convert.ToBoolean(mas_var[20]);
               skill_boost_cap = Convert.ToInt32(mas_var[21]);
           }
           else
           {
               Application.Exit();
           }
       }
    }
}
