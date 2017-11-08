using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
//using Russian_Coder_Simulator;
//using central_form;

namespace Russian_Coder_Simulator
{
    public partial class ProjectS : Form
    {
        oper_form cf;
        public ProjectS()
        {
            InitializeComponent();
            
        }
        Boolean GuiorCmd = false; //Определение что выбрано в скиле проекта Gui или Cmd
        Int32[,] Skill_collection = new Int32[3, 4]; //Сбор всех скилов (Легкий[0,]; Средний [1,]; Сложный [2,]; Gui [,0]; Cmd [,1]; Алгоритмы[,2]; Знание_языка[,3])
        String[] Description = new String[3]; //Describes
        Random number = new Random(); //РАндом для имени + Сложности 
        Int32[] Moves = new Int32 [3]; //Кол ходов
        Boolean OK_NOK = false;
        Int32 [] Time_H = new Int32 [3]; //Кол часов данных на проэкт
        Int32 Continue_modelator = 0; //Выбор для свитча при нажатие кнопки "Продолжить"

        public  void skill_lack(Int32[,] Skill_collection,  Int32 Continue_modelator, ref TextBox Parameters, ref Boolean OK) // проверка на скиллы 
        {
            if (Skill_collection[Continue_modelator - 1, 0] == 0)
            {
                if (Skill_collection[Continue_modelator - 1, 1] <= cf.CNS && Skill_collection[Continue_modelator - 1, 2] <= cf.ALG && Skill_collection[Continue_modelator - 1, 3] <= cf.LNG) //что выше СМД или ГУИ
                {
                    OK = true;
                }
                else
                {
                    if (Skill_collection[Continue_modelator - 1, 1] > cf.CNS)
                    {
                        MessageBox.Show("У вас не достаточно скила Сmd для того чтобы принять этот проект", "Ошибка при выборе проекта", MessageBoxButtons.OK);
                    }
                }
            }
            if (Skill_collection[Continue_modelator - 1, 1] == 0) //Проверка на ок скилл
            {
                if (Skill_collection[Continue_modelator - 1, 0] <= cf.GUI && Skill_collection[Continue_modelator - 1, 2] <= cf.ALG && Skill_collection[Continue_modelator - 1, 3] <= cf.LNG)
                {
                    OK = true;
                }
                else
                {
                    if (Skill_collection[Continue_modelator - 1, 0] > cf.GUI)
                    {
                        MessageBox.Show("У вас не достаточно скила Gui для того чтобы принять этот проект", "Ошибка при выборе проекта", MessageBoxButtons.OK);
                    }
                }
            }
            if (Skill_collection[Continue_modelator - 1, 2] > cf.ALG)
            {
                MessageBox.Show("У вас не достаточно скила Algorythms для того чтобы принять этот проект", "Ошибка при выборе проекта", MessageBoxButtons.OK);
            }
            if (Skill_collection[Continue_modelator - 1, 3] > cf.LNG)
            {
                MessageBox.Show("У вас не достаточно скила Language Skills для того чтобы принять этот проект", "Ошибка при выборе проекта", MessageBoxButtons.OK);
            }
        }

        public  void difficulty_setting(ref Int32 [] Time_H, ref Int32 [] Moves, Int32 Completed,  ref String[] Description, ref Int32[,] Skill_collection, ref Boolean GuiOrCmd, Random number) //Задаёт кол часов для выпол проэкта и кол дней (ходов) в зависимости от кол выпол поэктор + сложности
        {
            //Легкий
            for (Int32 I = 0; I < 3; I++)
            {
                Description[I] = "Нужные навыки: \r\n";
            }
            if (cf.GUI> cf.CNS)
            {
                Skill_collection[0, 0] = cf.GUI;
                GuiOrCmd = true;
                Description[0] = Description[0] + "Gui = " + cf.GUI;
            }
            else
            {
                Skill_collection[0, 1] = cf.CNS;
                GuiOrCmd = false;
                Description[0] = Description[0] + "Cmd = " + cf.CNS;
            }
            Skill_collection[0, 2] = cf.ALG;
            Skill_collection[0, 3] = cf.LNG;
            Description[0] = Description[0] + "\r\nAlgorythms = " + cf.ALG + "\r\nLanguage Skills = " + cf.LNG;
            Moves[0] = 7;
            Time_H[0] = 70;
            //Средний
            switch (number.Next(1, 3))
            {
                case 1:
                    {
                        GuiOrCmd = true;
                        Skill_collection[1, 0] = number.Next(Completed - 5, Completed + 5);
                        Description[1] = Description[1] + "Gui = " + Skill_collection[1, 0];
                        break;
                    }
                case 2:
                    {
                        GuiOrCmd = false;
                        Skill_collection[1, 1] = number.Next(Completed - 5, Completed + 5);
                        Description[1] = Description[1] + "Cmd = " + Skill_collection[1, 1];
                        break;
                    }
            }
            Skill_collection[1, 2] = number.Next(Completed - 5, Completed + 5);
            Skill_collection[1, 3] = number.Next(Completed - 5, Completed + 5);
            Description[1] = Description[1] + "\r\nAlgorythms = " + Skill_collection[1, 2] + "\r\nLanguage Skills = " + Skill_collection[1, 3];
            Moves[1] = 12;
            Time_H[1] = 144;
            //Сложный
            switch (number.Next(1, 3))
            {
                case 1:
                    {
                        GuiOrCmd = true;
                        Skill_collection[2, 0] = number.Next(Completed - 10, Completed + 10);
                        Description[2] = Description[2] + "Gui = " + Skill_collection[2, 0];
                        break;
                    }
                case 2:
                    {
                        GuiOrCmd = false;
                        Skill_collection[2, 1] = number.Next(Completed - 10, Completed + 10);
                        Description[2] = Description[2] + "Cmd = " + Skill_collection[2, 1];
                        break;
                    }
            }
            Skill_collection[2, 2] = number.Next(Completed - 10, Completed + 10);
            Skill_collection[2, 3] = number.Next(Completed - 10, Completed + 10);
            Description[2] = Description[2] + "\r\nAlgorythms = " + Skill_collection[2, 2] + "\r\nLanguage Skills = " + Skill_collection[2, 3];
            Moves[2] = 17;
            Time_H[2] = 238;
        }

        public static String Name1(Random number) //Функция для подбора имени
        {
            String Name = "";
            Int32 Switch_c = number.Next(1, 11);
            switch (Switch_c) //Генерачия рандомного имени
            {
                case 1:
                    {
                        Name = "Квест";
                        break;
                    }
                case 2:
                    {
                        Name = "Файл менеджер";
                        break;
                    }
                case 3:
                    {
                        Name = "Морской бой";
                        break;
                    }
                case 4:
                    {
                        Name = "Гайд по танкам";
                        break;
                    }
                case 5:
                    {
                        Name = "Парашер";
                        break;
                    }
                case 6:
                    {
                        Name = "Шахматы";
                        break;
                    }
                case 7:
                    {
                        Name = "Винлокер";
                        break;
                    }
                case 8:
                    {
                        Name = "Симулятор студента";
                        break;
                    }
                case 9:
                    {
                        Name = "Армяно-заменитель";
                        break;
                    }
                case 10:
                    {
                        Name = "Петросян симулятор";
                        break;
                    }
            }
            return Name;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            cf = (oper_form)this.Owner;
            Easy_name.Text = Name1(number); //Название легкого проекта
            Med_Name.Text = Name1(number); //Название Среднего проекта
            hard_name.Text = Name1(number); //Название Сложного проекта
            difficulty_setting(ref Time_H, ref Moves, cf.N_of_Proj_compl, ref Description, ref Skill_collection, ref GuiorCmd, number);
            
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e) //Уровень Сложности Легкий 
        {
            Parameters.Text = (""); //Сбрасывает Текстбокс с описанием
            Continue_modelator = 1; //Задает значение свитчу в продолжить
            Parameters.Text = (Description[0]); //Добавка инфы в листбокc
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e) //Уровень Сложности Средний
        {
            Parameters.Text = (""); //Сбрасывает Текстбокс с описанием
            Continue_modelator = 2;//Задает значение свитчу в продолжить
            Parameters.Text = (Description[1]); //Добавка инфы в листбокс
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e) //Уровень Сложности Сложный
        {
            Parameters.Text = (""); //Сбрасывает Текстбокс с описанием
            Continue_modelator = 3;//Задает значение свитчу в продолжить
            Parameters.Text = (Description[2]); //Добавка инфы в листбокс
        }

        private void Continue_Click(object sender, EventArgs e) //Кнопка продолжить
        {
            skill_lack(Skill_collection, Continue_modelator, ref Parameters, ref OK_NOK);
            if (OK_NOK == true)
            {
                switch (Continue_modelator) //Распределение бабла 
                {
                    case 1:
                        {
                            cf.Nagrada_project = 200;
                            cf.Proj_Name = Convert.ToString(Easy_name.Text);
                            break;
                        }
                    case 2:
                        {
                            cf.Nagrada_project = 350;
                            cf.Proj_Name = Convert.ToString(Med_Name.Text);
                            break;
                        }
                    case 3:
                        {
                            cf.Nagrada_project = 800;
                            cf.Proj_Name = Convert.ToString(hard_name.Text);
                            break;
                        }
                }
                cf.Moves = Moves[Continue_modelator - 1];
                cf.Time_H = Time_H[Continue_modelator - 1];
                cf.Proj_set = true;
                this.Close();
            }
        }

        
    }
}
