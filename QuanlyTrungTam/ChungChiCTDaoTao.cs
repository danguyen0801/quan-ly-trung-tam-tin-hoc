using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using DTO;
using BUS;
namespace QuanlyTrungTam
{
    public partial class ChungChiCTDaoTao : Form
    {
        public ChungChiCTDaoTao()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string machungchi = machungchitxt.Text;
            string mahv = mahvcbx.Text;
            DateTime ngaycap = DateTime.Parse(ngaycaptxt.Text);
            string xeploai = xeploaitxt.Text;
            string mact = mactcbx.Text;
            DTO_CHUNGCHICTDAOTAO bangtotnghiep = new DTO_CHUNGCHICTDAOTAO(machungchi, mahv, ngaycap, xeploai, mact);
            CHUNGCHICTDAOTAO.InSertBangTotNghiep(bangtotnghiep);
            MessageBox.Show("Bạn đã thêm thành công!");
            dschungchictdaotao.DataSource = CHUNGCHICTDAOTAO.GetAllBangTotNghiep();
        }

        private void ChungChiCTDaoTao_Load(object sender, EventArgs e)
        {
            dschungchictdaotao.DataSource = CHUNGCHICTDAOTAO.GetAllBangTotNghiep();
        }



        private void mahvcbx_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
