using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAO;
using System.Data;
namespace QuanlyTrungTam.BUS
{
    public class HOCVIEN
    {
        public DTO_HOCVIEN hv=new DTO_HOCVIEN();
        public string ThemHV()
        {
            DB_HOCVIEN hvdb = new DB_HOCVIEN();
            return hvdb.Them(hv);
        }
        public Boolean KiemtraMaSo()
        {
            DB_HOCVIEN hvdb = new DB_HOCVIEN();
            DataTable tb = hvdb.KiemtraMaSo(hv.MaHV);
            if (tb.Rows.Count == 0)
                return true;
            else
                return false;
        }
    }
}
