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
    public partial class Teacher : Form
    {
        public Teacher()
        {
            InitializeComponent();
        }

        private void Schedule_Button_Click(object sender, EventArgs e)
        {

            this.Hide();
            var form2 = new Teacher_Calendar();
            form2.Closed += (s, args) => this.Close();
            form2.Show();

        }

        private void Score_input_Button_Click(object sender, EventArgs e)
        {

            this.Hide();
            var form2 = new Teacher_Point();
            form2.Closed += (s, args) => this.Close();
            form2.Show();
        }
    }
}
