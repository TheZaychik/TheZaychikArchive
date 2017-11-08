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
    public partial class Event3 : Form
    {
        oper_form cf;
        public Event3()
        {
            InitializeComponent();
        }
        private void Event3_Load(object sender, EventArgs e)
        {
            cf = (oper_form)this.Owner;
        }
        private void otkaz_Click(object sender, EventArgs e) //  продолжение 
        {
            cf.skill_boost_cap = cf.skill_boost_cap + 4;
            MessageBox.Show("Вы не можете ничего делать 4 хода. Настроение - 50", "Ой...");
            cf.nastroen = cf.nastroen - 50;
            this.Close();
            
        }

       
    }
}
