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
    public class CHUNGCHITINHOC
    {
        public static DataTable GetAllChungChiTinHoc()
        {
            return DB_CHUNGCHITINHOC.getData();
        }
        public static void InSertChungChiTinHoc(DTO_CHUNGCHITINHOC ccth)
        {
            DB_CHUNGCHITINHOC.InsertCCTH(ccth);
        }
    }
}
