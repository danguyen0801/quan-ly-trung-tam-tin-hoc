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
    public partial class Dangkithilai : Form
    {
        public Dangkithilai(string maHV)
        {
            InitializeComponent();
            hv.MaHV = maHV;
        }
        public Dangkithilai()
        {
            InitializeComponent();
        }
        public DTO_HOCVIEN hv = new DTO_HOCVIEN();
        private void bXem_Click(object sender, EventArgs e)
        {
            LICHTHI lt = new LICHTHI();
            DataTable tb = lt.dslich(hv.MaHV);
            if (tb.Rows.Count == 0)
                MessageBox.Show("Thi sinh khong co mon de thi lai");
            else
                dataGridView1.DataSource = tb;
        }

        private void bDangki_Click(object sender, EventArgs e)
        {
            if(dataGridView1.Rows.Count==0)
            {
                MessageBox.Show("khong co mon de dang ki");
            }
            else
            {
                BANGDIEM bbd = new BANGDIEM();
                bbd.Dangkithillai(hv.MaHV);
                MessageBox.Show("đã đăng kí thành công");
            }    
        }
    }
}
