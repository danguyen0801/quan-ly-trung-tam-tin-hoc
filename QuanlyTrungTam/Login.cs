using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using BUS;
namespace QuanlyTrungTam
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        
        private void signIn_Button_Click(object sender, EventArgs e)
        {
            BUS.LOGIN lg = new BUS.LOGIN();
            string t = lg.con(txbUserName.Text.ToString(), txbPassword.Text.ToString());
            if (t == "Học viên")
            {
                Student st = new Student();
                st.hv.MaHV = txbUserName.Text.ToString();
                st.Show();
                this.Hide();
            }
            else if (t == "Giáo vụ")
            {

                Teaching_staff ts = new Teaching_staff();

                ts.nv.MaNV = txbUserName.Text.ToString();
                ts.Show();
                this.Hide();

            }
            else if (t == "Giảng viên")
            {
                Teacher tc = new Teacher();
                tc.gv.MaNV = txbUserName.Text.ToString();
                tc.Show();
                this.Hide();
            }
            
        }
    }
}
