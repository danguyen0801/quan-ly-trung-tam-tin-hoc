using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
namespace QuanlyTrungTam
{
    public partial class Teacher : Form
    {   
        public DTO_GIANGVIEN gv = new DTO_GIANGVIEN();
        public Teacher()
        {
            InitializeComponent();
        }
        public Teacher(string manv)
        {
            InitializeComponent();
            gv.MaNV = manv;
           
        }

        private void Schedule_Button_Click(object sender, EventArgs e)
        {

            
            var form2 = new Teacher_Calendar(gv.MaNV);
            
            this.Hide();
            form2.ShowDialog();
            this.Show();

        }

        private void Score_input_Button_Click(object sender, EventArgs e)
        {
            var form2 = new Teacher_Point(gv.MaNV);
            
            this.Hide();
            form2.ShowDialog();
            this.Show();
        }

        private void logout_button_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Close();
        }
    }
}
