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
