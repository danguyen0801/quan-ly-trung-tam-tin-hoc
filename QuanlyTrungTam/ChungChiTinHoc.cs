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
    public partial class ChungChiTinHoc : Form
    {
        public ChungChiTinHoc()
        {
            InitializeComponent();
        }

        private void Lưu_Click(object sender, EventArgs e)
        {
            string machungchi = machungchitxt.Text;
            string tenchungchi = tenchungchitxt.Text;
            string mahv = mahvcbx.Text;
            DateTime ngaycap = DateTime.Parse(ngaycaptxt.Text);
            string xeploai = xeploaitxt.Text;
            string manhomhp = manhomhpcbx.Text;
            DTO_CHUNGCHITINHOC chungchitinhoc = new DTO_CHUNGCHITINHOC(machungchi, tenchungchi, mahv, ngaycap, xeploai, manhomhp);
            CHUNGCHITINHOC.InSertChungChiTinHoc(chungchitinhoc);
            MessageBox.Show("Bạn đã thêm thành công!");
            dschungchitinhoc.DataSource = CHUNGCHITINHOC.GetAllChungChiTinHoc();
        }

        private void ChungChiTinHoc_Load(object sender, EventArgs e)
        {
            dschungchitinhoc.DataSource = CHUNGCHITINHOC.GetAllChungChiTinHoc();
        }
    }
}
