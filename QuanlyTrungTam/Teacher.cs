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
namespace QuanlyTrungTam
{
    public partial class Teacher : Form
    {
        public DTO_GIANGVIEN gv = new DTO_GIANGVIEN();
        public Teacher()
        {
            InitializeComponent();
        }
    }
}
