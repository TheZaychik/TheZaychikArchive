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
    public partial class achivki : Form
    {
        public achivki()
        {
            InitializeComponent();
        }
        oper_form cf;
        private void achivki_Load(object sender, EventArgs e)
        {
            cf = (oper_form)this.Owner;
            if (cf.BOG == true)
            {
                bog_status.Text = "ДОСТИГНУТО";

            }
            if (cf.Abramovich == true)
            {
                abram_status.Text = "ДОСТИГНУТО";

            }
            if (cf.Gorets == true)
            {
                gorets_status.Text = "ДОСТИГНУТО";

            }
            if (cf.OslikSuslik == true)
            {
                OslikSuslik_status.Text = "ДОСТИГНУТО";

            }
        }

       
    }
}
