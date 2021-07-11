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
using QuanlyTrungTam.BUS;

namespace QuanlyTrungTam
{
    public partial class LapLichThi : Form
    {
        public LapLichThi()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string malichthi = malichthitxt.Text;
            string malophp = malophpcbx.Text;
            string phongthi = phongthitxt.Text;
            DateTime thoigianthi = DateTime.Parse(thoigianthitxt.Text);
            string manv = manvcbx.Text;
            DTO_LICHTHI lichthi = new DTO_LICHTHI(malichthi, malophp, phongthi, thoigianthi, manv);
            LICHTHI.InSertLichThi(lichthi);
            MessageBox.Show("Bạn đã thêm thành công!");
        }
    }
}
