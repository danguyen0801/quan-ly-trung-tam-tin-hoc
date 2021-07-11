using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanlyTrungTam.BUS;
using DTO;

namespace QuanlyTrungTam
{
    public partial class Inf_Edit : Form
    {
        public Inf_Edit()
        {
            InitializeComponent();
        }

        private void Inf_Edit_Load(object sender, EventArgs e)
        {
            dataGridView2.DataSource = HOCVIEN.ThongTinCaNhan();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txbMaHV_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string MaHV = txbMaHV.Text;
                string HoTenHV = txbHovaten.Text;
                string GioiTinh = txbGioiTinh.Text;
                string SoDT = txbSĐT.Text;
                string Email = txbEmail.Text;
                DateTime NgaySinh = dateTimePicker1.Value;               
                int DiemThiTN = int.Parse(textBox1.Text);
                DTO_HOCVIEN hv = new DTO_HOCVIEN(MaHV, HoTenHV, GioiTinh, SoDT, Email, NgaySinh, DiemThiTN);
                HOCVIEN.SuaThongTinCaNhan(hv);
                MessageBox.Show("Bạn đã sửa " + HoTenHV + "thành công");
                dataGridView2.DataSource = HOCVIEN.ThongTinCaNhan();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
    }

        private void txbHovaten_TextChanged(object sender, EventArgs e)
        {

        }

        private void txbSĐT_TextChanged(object sender, EventArgs e)
        {

        }

        private void txbNgaySinh_TextChanged(object sender, EventArgs e)
        {

        }

        private void txbNoiSinh_TextChanged(object sender, EventArgs e)
        {

        }

        private void txbGioiTinh_TextChanged(object sender, EventArgs e)
        {

        }

        private void txbEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }      
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView2.DataSource = HOCVIEN.ThongTinCaNhan();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
