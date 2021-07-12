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
    public partial class Teacher_Calendar : Form
    {
        LOPHOCPHAN _busLopHocPhan = new LOPHOCPHAN();
        
        List<DTO_LOPHOCPHAN> listHP;
        public DTO_GIANGVIEN gv = new DTO_GIANGVIEN();

        public Teacher_Calendar(string maNV)
        {

            InitializeComponent();
            gv.MaNV = maNV;
            HienThi();

        }
        public Teacher_Calendar()
        {
            InitializeComponent();
            HienThi();
           
        }
        public void HienThi()
        {
           
            listHP = _busLopHocPhan.DSLopHPTheoMaGV(gv.MaNV);
            DataTable dt = new DataTable();
            dataGridView1.DataSource = listHP;
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Schedule_Button_Click(object sender, EventArgs e)
        {
            HienThi();
        }

        private void Scores_Button_Click(object sender, EventArgs e)
        {
            
            var form2 = new Teacher_Point(gv.MaNV);
            
            form2.Show();
            this.Close();
        }
    }
}
