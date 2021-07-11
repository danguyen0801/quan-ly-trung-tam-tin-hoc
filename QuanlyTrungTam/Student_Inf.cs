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
    public partial class Student_Inf : Form
    {
        public Student_Inf()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView1.DataSource = HOCVIEN.ThongTinCaNhan();
            
        }
    }
}
