using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanlyTrungTam
{
    public partial class Teaching_staff : Form
    {
        public Teaching_staff()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void TCTT_Button_Click(object sender, EventArgs e)
        {

        }

        private void Inf_Student_Button_Click(object sender, EventArgs e)
        {
            Application.Run(new Teaching_staff_set_infoStudent());
        }
    }
}
