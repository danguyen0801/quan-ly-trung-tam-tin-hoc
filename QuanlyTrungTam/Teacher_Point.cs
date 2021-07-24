using System;
using System.Collections.Generic;
using System.ComponentModel;
//using System.Data;
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
        public DTO_GIANGVIEN gv = new DTO_GIANGVIEN();
        public Teacher_Point(string maNV)
        {

            InitializeComponent();
            gv.MaNV = maNV;
            HienThi();

        }
        public Teacher_Point()
        {
            InitializeComponent();
            HienThi();
            
        }
        public void HienThi()
        {
            listHP = _busLopHocPhan.DSLopHPTheoMaGV(gv.MaNV);
            
            dataGridView1.DataSource = listHP;
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
        private bool ktDiem()
        {
            if (pointStudentSelected.Text != listBangDiem[dataGridView2.CurrentCell.RowIndex].Diem.ToString())
            {
                if (Convert.ToInt32(pointStudentSelected.Text) < 0 || Convert.ToInt32(pointStudentSelected.Text) > 10)
                {

                    MessageBox.Show("Điểm không hợp lệ! Mời nhập lại");
                    return false;
                }
                if (listBangDiem[dataGridView2.CurrentCell.RowIndex].SoLanthi >= 3){
                    MessageBox.Show("Lỗi! Quy định thi không quá 3 lần");
                    return false;
                }
                return true;
            }
           else return false;
        }

        private void update_button_Click(object sender, EventArgs e)
        {
            if (ktDiem())
            {   string maHV = listBangDiem[dataGridView2.CurrentCell.RowIndex].MaHV;
                string maMH = listBangDiem[dataGridView2.CurrentCell.RowIndex].MaMonHoc;
                int soLanThi = listBangDiem[dataGridView2.CurrentCell.RowIndex].SoLanthi + 1;
                bool isPass=false;
                int Diem = Convert.ToInt32(pointStudentSelected.Text);
                if ( Diem < 5) isPass = false;
                else isPass = true;
                
                _busBangDiem.updateDiem(maHV, maMH, Diem, soLanThi, isPass);
                MessageBox.Show("Cập nhật điểm thành công!");
                int indexLop = dataGridView1.CurrentCell.RowIndex;
                int indexBangDiem = dataGridView2.CurrentCell.RowIndex;
                HienThi();
               
                dataGridView1.CurrentCell = dataGridView1.Rows[indexLop].Cells[0];
                dataGridView2.CurrentCell = dataGridView2.Rows[indexBangDiem].Cells[0];
                idStudentSelected.Text = listBangDiem[dataGridView2.CurrentCell.RowIndex].MaHV;
                pointStudentSelected.Text = listBangDiem[dataGridView2.CurrentCell.RowIndex].Diem.ToString();
            }
        }

        private void dataGridView2_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            update_button.Enabled = true;
        }

        private void Scores_Button_Click(object sender, EventArgs e)
        {
            HienThi();
        }

        private void Schedule_Button_Click(object sender, EventArgs e)
        {
           
            var form2 = new Teacher_Calendar(gv.MaNV);
            form2.Show();
            this.Close();
        }


        private void dataGridView2_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView2.CurrentCell.RowIndex != -1)
            {
                idStudentSelected.Text = listBangDiem[dataGridView2.CurrentCell.RowIndex].MaHV;
                pointStudentSelected.Text = listBangDiem[dataGridView2.CurrentCell.RowIndex].Diem.ToString();
                update_button.Enabled = true;
            }
        }
    }
}
