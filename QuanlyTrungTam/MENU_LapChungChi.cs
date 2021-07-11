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
    public partial class MENU_LapChungChi : Form
    {
        public MENU_LapChungChi()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ChungChiCTDaoTao bangTotNghiep = new ChungChiCTDaoTao();
            bangTotNghiep.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ChungChiTinHoc chungChiTinHoc = new ChungChiTinHoc();
            chungChiTinHoc.Show();
        }
    }
}
