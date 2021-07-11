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
        public Teaching_staff_set_infoStudent()
        {
            InitializeComponent();
            HienThi();
            button4.Enabled = false;
            Return_Button.Enabled = false;
            Scores_Button.Enabled = false;
        }
        public void HienThi()
        {
            lstHocVien = _busHocVien.DsHocVien();
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

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void listStudent_SelectionChanged(object sender, EventArgs e)
        { DTO_HOCVIEN hocVienChon = lstHocVien[listStudent.CurrentCell.RowIndex];
            txbMaHV.Text = hocVienChon.MaHV;
            txbHovaten.Text = hocVienChon.HoTenHV;
            txbEmail.Text = hocVienChon.Email;
            txbGioiTinh.Text = hocVienChon.GioiTinh;
            txbNgaySinh.Text = hocVienChon.NgaySinh.ToString();
            txbSĐT.Text = hocVienChon.SDT;
            
        }
    }
}
