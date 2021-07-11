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
            dataGridView1.DataSource = MONHOC.ThoiKhoaBieu();
        }

        private void Schedule_Button_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = MONHOC.ThoiKhoaBieu();
        }

        private void button1_Click_5(object sender, EventArgs e)
        {
            
           
            this.Close();
        }

        private void Inf_Button_Click(object sender, EventArgs e)
        {
            Inf_Edit f = new Inf_Edit();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void Fee_Button_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = PHIEUHOCPHI.XemHocPhi();
        }

        private void Semester_Button_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = LICHTHI.XemLichThi();
        }

        private void Scores_Button_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = BANGDIEM.XemDiemThi();
        }
    }
}
