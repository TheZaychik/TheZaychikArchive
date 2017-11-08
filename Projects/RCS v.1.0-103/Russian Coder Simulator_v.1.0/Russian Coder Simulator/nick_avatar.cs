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
    public partial class Vibor_avatarki : Form
    {
        central_form cf2 = new central_form();
        public String per_a, per_b;
        oper_form cf;
  
        
        public Vibor_avatarki()
        {
            InitializeComponent();
        }
        public static void skill_check(ref Int32 skill, TextBox skill_user) // проверка введенного текста
        {
            if (skill_user.Text == "")
            {
                skill = 0;
            }
            else
            {
                skill = Convert.ToInt32(skill_user.Text);
            }
        }

        private void Vibor_avatarki_Load(object sender, EventArgs e) // загрузка
        {
            cf = (oper_form)this.Owner;
            cf2.Owner = cf;
        }   

        private void zagr_ava_Click(object sender, EventArgs e) // кароч, тут ниже юзается метод костыля. мы 2 раза приравниваем переменные чтобы они добрались до централки, иначе они не записываются
        {
            if (DialogResult.OK == open_ava.ShowDialog())
            {
                pb_vib_ava.Load(open_ava.FileName);
                cf.avatar = open_ava.FileName;
            }
        }

        private void nick_set_Click(object sender, EventArgs e) // та же фигня
        {
            cf.nick = Convert.ToString(textBox_vib_nicka.Text);
             try
            {
                skill_check(ref cf.ALG, alg);  // навыки
                skill_check(ref cf.LNG, lng);
                skill_check(ref cf.GUI, gui);
                skill_check(ref cf.CNS, cns);
            }
            catch (FormatException)
            {
                MessageBox.Show("Пожалуйста введите цифры, а не буквы и/или знаки", "Ошибка - введены не только цифры", MessageBoxButtons.OK);
            }


            // проверка на ввод очков
            if ((cf.ALG + cf.LNG + cf.GUI + cf.CNS) > 8 || (cf.ALG + cf.LNG + cf.GUI + cf.CNS) < 8)
            {
                MessageBox.Show("Вы использовали слишком много/мало очков! Перераспределите очки!", "Ошибка!");


            }
            else
            {
                cf2.Show();
                this.Hide();
            }
        }
            
        

        private void Vibor_avatarki_FormClosing(object sender, FormClosingEventArgs e) // закрытите формы 
        {
            Application.Exit();
        }

        
    }
}
