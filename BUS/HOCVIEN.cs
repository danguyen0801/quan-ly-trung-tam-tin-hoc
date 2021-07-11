using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using DTO;
using System.Data;

namespace QuanlyTrungTam.BUS
{
    public class HOCVIEN
    {
        public static DataTable ThongTinCaNhan()
        {
            return DB_HOCVIEN.getData();
        }
        public static void  SuaThongTinCaNhan(DTO_HOCVIEN hv)
        {
            DB_HOCVIEN.SuaThongTinCaNhan(hv);
        }
    }
}
