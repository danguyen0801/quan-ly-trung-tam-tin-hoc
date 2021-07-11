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
    public partial class Student : Form
    {
        public Student()
        {
            InitializeComponent();
        }
        public DTO_HOCVIEN hv = new DTO_HOCVIEN();

        private void DKMH_Button_Click(object sender, EventArgs e)
        {
            DKLH dklp = new DKLH();
            dklp.hv.MaHV = hv.MaHV;
            dklp.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void DKTL_Button_Click(object sender, EventArgs e)
        {
            Dangkithilai dk = new Dangkithilai();
            dk.hv.MaHV = hv.MaHV;
            dk.Show();
        }
        private void TCTT_Button_Click(object sender, EventArgs e)
        {
            Inf_Check f = new Inf_Check();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }
    }
}
