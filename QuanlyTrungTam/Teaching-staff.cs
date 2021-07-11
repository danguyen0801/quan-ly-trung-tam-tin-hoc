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
    }
}
