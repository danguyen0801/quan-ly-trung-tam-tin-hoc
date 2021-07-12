using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
namespace QuanlyTrungTam
{
    public partial class Dang_ki_hoc : Form
    {
        public Dang_ki_hoc()
        {
            InitializeComponent();
        }

        private void bDangki_Click(object sender, EventArgs e)
        {
            string MaHV = tMaHV.Text.ToString();
            string Hoten = tHoten.Text.ToString();
            string Gioitinh = cbbGioitinh.Text.ToString();
            string sdt = tSDT.Text.ToString();
            string Email = tEmail.Text.ToString();
            DateTime datetime = dtpNgaysinh.Value;
            string NgaySinh = datetime.Date.ToString();
            HOCVIEN hv = new HOCVIEN();
            hv.hv.Khoitao(MaHV, Hoten, Gioitinh, sdt, Email, NgaySinh);
            if (hv.KiemtraMaSo() == true)
            {
                string t = hv.ThemHV();
                MessageBox.Show("đã thêm học viên " + t + " thành công");
            }
            else
            {
                MessageBox.Show("Đã tồn tại mã học viên vui lòng nhập mã học viên khác");
            }
        }
    }
}
