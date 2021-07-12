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
    public partial class MENU_LapChungChi : Form
    {
        public DTO_NVGIAOVU nv = new DTO_NVGIAOVU();
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
