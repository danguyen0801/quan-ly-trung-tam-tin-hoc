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
    public partial class MENU_LapLichThi : Form
    {
        public DTO_NVGIAOVU nv = new DTO_NVGIAOVU();
        public MENU_LapLichThi()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LapLichThi lapLichThi = new LapLichThi();
            lapLichThi.Show();
        }

        private void MENU_LapLichThi_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = LOPHOCPHAN.GetAllLopHocPhan();
        }
    }
}
