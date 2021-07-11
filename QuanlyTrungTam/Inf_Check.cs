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

namespace QuanlyTrungTam
{
    public partial class Inf_Check : Form
    {
        public Inf_Check()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void xemThờiKhóaBiểuToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Inf_Edit f = new Inf_Edit();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            dataGridView1.DataSource = PHIEUHOCPHI.XemHocPhi() ;
        }

        private void button1_Click_3(object sender, EventArgs e)
        {
            dataGridView1.DataSource = LICHTHI.XemLichThi();
        }

        private void button1_Click_4(object sender, EventArgs e)
        {
            dataGridView1.DataSource = BANGDIEM.XemDiemThi();
        }

        private void Semester_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Schedule_Button_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = MONHOC.ThoiKhoaBieu();
        }

        private void button1_Click_5(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
