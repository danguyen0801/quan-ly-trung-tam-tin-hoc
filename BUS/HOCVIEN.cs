using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using DTO;
using System.Data;


namespace BUS
{
    public class HOCVIEN
    {
        public static DataTable ThongTinCaNhan()
        {
            return DB_HOCVIEN.getData();
        }
        public static void SuaThongTinCaNhan(DTO_HOCVIEN hv)
        {
            DB_HOCVIEN.SuaThongTinCaNhan(hv);
        }

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

        public  List<DTO_HOCVIEN> DsHocVien()
        {   
            return DB_HOCVIEN.DsHocVien();
        }
        public void updateHocVien(DTO_HOCVIEN hv)
        {
            DB_HOCVIEN.updateHocVien(hv);
        }
    }
}
