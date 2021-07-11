using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;
using BUS;
using DTO;
namespace QuanlyTrungTam
{
    public partial class Teacher_Point : Form
    {  LOPHOCPHAN _busLopHocPhan = new LOPHOCPHAN();
        BANGDIEM _busBangDiem = new BANGDIEM();
        List<DTO_LOPHOCPHAN> listHP;
        List<DTO_BANGDIEM> listBangDiem;
        public Teacher_Point()
        {
            InitializeComponent();
            HienThi();
            
        }
        public void HienThi()
        {
            listHP = _busLopHocPhan.DSLopHPTheoMaGV("GV 06");
            DataTable dt = new DataTable();
            dataGridView1.DataSource = listHP;
            Scores_Button.Enabled = false;
            update_button.Enabled = false;
        }
        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            listBangDiem = _busBangDiem.DSBangDiemTheoMaMon(listHP[dataGridView1.CurrentCell.RowIndex].MaMonHoc);
            dataGridView2.DataSource = listBangDiem;
            nameClass.Text = listHP[dataGridView1.CurrentCell.RowIndex].TenLopHP;
            time.Text = listHP[dataGridView1.CurrentCell.RowIndex].ThoiGianHoc.ToString();
            subject.Text = listHP[dataGridView1.CurrentCell.RowIndex].MaMonHoc;
        }

        private void update_button_Click(object sender, EventArgs e)
        {
            dataGridView2.Update();  
        }

        private void dataGridView2_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            update_button.Enabled = true;
        }
    }
}
