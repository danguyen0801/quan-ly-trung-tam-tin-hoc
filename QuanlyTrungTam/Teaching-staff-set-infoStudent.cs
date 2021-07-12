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
using DTO;
namespace QuanlyTrungTam
{
    public partial class Teaching_staff_set_infoStudent : Form
    {
        HOCVIEN _busHocVien = new HOCVIEN();
        List<DTO_HOCVIEN> lstHocVien;
        DTO_HOCVIEN hocVienChon;
        public Teaching_staff_set_infoStudent()
        {
            InitializeComponent();
            HienThi();
            update_button.Enabled = false;
            Return_Button.Enabled = false;
            
        }
        public void HienThi()
        {
            lstHocVien = _busHocVien.DsHocVien();
            //MessageBox.Show(lstHocVien[7].HoTenHV);
            listStudent.DataSource = lstHocVien;
        }

        private void Schedule_Button_Click(object sender, EventArgs e)
        {

        }

        private void Schedule_Click(object sender, EventArgs e)
        {

        }

        private void Scores_Button_Click(object sender, EventArgs e)
        {
            HienThi();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

     
        private void txbHovaten_TextChanged(object sender, EventArgs e)
        {

        }

        private void Return_Button_Click(object sender, EventArgs e)
        {
            txbHovaten.Text = hocVienChon.HoTenHV;
            txbEmail.Text = hocVienChon.Email;
            txbGioiTinh.Text = hocVienChon.Gioitinh;
            txbNgaySinh.Text = hocVienChon.ngaySinh.ToString();
            txbSĐT.Text = hocVienChon.SDT;
        }
        private bool KTHopLe(DTO_HOCVIEN hv)
        {
            return true;
        }
        private void update_button_Click(object sender, EventArgs e)
        {
             hocVienChon.HoTenHV= txbHovaten.Text;
            hocVienChon.Email = txbEmail.Text;
            hocVienChon.Gioitinh = txbGioiTinh.Text;
            hocVienChon.ngaySinh = DateTime.Parse(txbNgaySinh.Text);
            hocVienChon.SDT = txbSĐT.Text;
            _busHocVien.updateHocVien(hocVienChon);
            MessageBox.Show("Cập nhật thông tin thành công!");
            HienThi();
        }

        private void listStudent_SelectionChanged_1(object sender, EventArgs e)
        {
            hocVienChon = lstHocVien[listStudent.CurrentCell.RowIndex];

            txbHovaten.Text = hocVienChon.HoTenHV;
            txbEmail.Text = hocVienChon.Email;
            txbGioiTinh.Text = hocVienChon.Gioitinh;
            txbNgaySinh.Text = hocVienChon.ngaySinh.ToString();
            txbSĐT.Text = hocVienChon.SDT;
            Return_Button.Enabled = true;
            update_button.Enabled = true;
        }
    }
}
