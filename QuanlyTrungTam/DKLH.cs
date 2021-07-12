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
    public partial class DKLH : Form
    {
        public DTO_HOCVIEN hv = new DTO_HOCVIEN();
        DKHP bus_DKHP = new DKHP();
        public DKLH(string maHV)
        {
            InitializeComponent();
            hv.MaHV = maHV;
        }
        public DKLH()
        {
            InitializeComponent();
        }

        private void DKLH_Load(object sender, EventArgs e)
        {
            ////MessageBox.Show(hv.MaHV);
            //dataGridView1.DataSource = bus_DKHP.dslopdk(hv.MaHV);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            if(cbbLoaidaotao.Text.ToString()=="Chuyên đề")
            {
                LOPCHUYENDE lcd = new LOPCHUYENDE();
                dataGridView1.DataSource = lcd.TimlopCD(cbbNhom.Text.ToString());
            }
            else
            {
                LOPHOCPHAN lhp = new LOPHOCPHAN();
                dataGridView1.DataSource = lhp.timLopHocPhan(cbbNhom.Text.ToString());
            }    
        }

        private void cbbLoaidaotao_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbLoaidaotao.Text.ToString() == "Chuyên đề")
            {
                NHOMCHUYENDE ncd = new NHOMCHUYENDE();
                cbbNhom.DataSource = ncd.MaNhom();
                cbbNhom.DisplayMember = "MaNhomCD";

            }
            else
            {
                NHOMHP nhp = new NHOMHP();
                cbbNhom.DataSource = nhp.MaNhom();
                cbbNhom.DisplayMember = "MaNhomHP";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(cbbLoaidaotao.Text=="Chuyên đề") 
            {
                DKCHUYENDE dkcd = new DKCHUYENDE(hv.MaHV, tMalop.Text.ToString());
                int n = dkcd.Dangki();
                if (n == 1)
                    MessageBox.Show("đăng kí lớp học thành công");
                else
                {
                    if (n == 0)
                    {
                        MessageBox.Show("Lớp đã đủ Sĩ số");
                    }
                    else
                        MessageBox.Show("học viên đã đăng kí lớp này");
                }
            }
            else
            {
                DKHP dkhp = new DKHP();
                dkhp.dkhp.MaHV = hv.MaHV;
                dkhp.dkhp.MAlopHP = tMalop.Text.ToString();
                int n = dkhp.Dangki();
                if (n == 1)
                    MessageBox.Show("đăng kí lớp học thành công");
                else
                {
                    if (n == 0)
                    {
                        MessageBox.Show("Lớp đã đủ Sĩ số");
                    }
                    else
                        MessageBox.Show("học viên đã đăng kí lớp này");
                }
            }    
                
             
        }
    }
}
