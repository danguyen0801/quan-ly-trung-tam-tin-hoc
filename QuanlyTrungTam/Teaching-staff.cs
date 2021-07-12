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
    public partial class Teaching_staff : Form
    {
        public DTO_NVGIAOVU nv = new DTO_NVGIAOVU();
        public Teaching_staff(string maNV)
        { 
            InitializeComponent();
            nv.MaNV = maNV;
        }
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

        private void Register_Button_Click(object sender, EventArgs e)
        {
            Dang_ki_hoc dk = new Dang_ki_hoc();
            dk.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Thuhocphi th = new Thuhocphi();
            th.nv.MaNV = nv.MaNV;
            th.Show();
        }

        private void Semester_Button_Click(object sender, EventArgs e)
        {
            MENU_LapLichThi lt = new MENU_LapLichThi();
            lt.nv.MaNV = nv.MaNV;
            lt.Show();
        }

        private void DKTL_Button_Click(object sender, EventArgs e)
        {
            MENU_LapChungChi cc = new MENU_LapChungChi();
            cc.nv.MaNV = nv.MaNV;
            cc.Show();
        }
        private void Inf_Student_Button_Click(object sender, EventArgs e)
        {
            
            Teaching_staff_set_infoStudent ts = new Teaching_staff_set_infoStudent();
            ts.Show();
        }

        private void logout_button_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Close();
        }

        private void DKMH_Button_Click(object sender, EventArgs e)
        {
            DKLH dk = new DKLH();
            dk.Show();
        }
    }
}
