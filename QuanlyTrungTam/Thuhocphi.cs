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
using BUS;
namespace QuanlyTrungTam
{
    public partial class Thuhocphi : Form
    {
        public DTO_NVGIAOVU nv = new DTO_NVGIAOVU();
        public Thuhocphi()
        {
            InitializeComponent();
        }

        private void bXem_Click(object sender, EventArgs e)
        {
            BUS.PHIEUHOCPHI bp = new BUS.PHIEUHOCPHI();
            dataGridView1.DataSource = bp.Tracuu(tMaHV.Text.ToString());
        }

        private void bThu_Click(object sender, EventArgs e)
        {
            BUS.PHIEUHOCPHI bp = new BUS.PHIEUHOCPHI();
            bp.Thuhocphi(nv.MaNV, tMaphieu.Text.ToString());
            MessageBox.Show("đã thu học phí thành công");
        }
    }
}
