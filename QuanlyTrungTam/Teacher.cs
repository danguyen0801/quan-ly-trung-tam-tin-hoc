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
            
            Application.Run(new Teacher_Calendar());
        }

        private void Score_input_Button_Click(object sender, EventArgs e)
        {
            
            Application.Run(new Teacher_Point());
        }
    }
}
