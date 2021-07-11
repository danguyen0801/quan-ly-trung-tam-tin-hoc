using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DTO;
namespace DAO
{
    public class DB_HOCVIEN
    {
        public string Them(DTO_HOCVIEN hv)
        {

            string t = "insert into HocVien values('" + hv.MaHV + "',N'" + hv.HoTen + "',N'" + hv.Gioitinh + "','" + hv.SDT + "','" + hv.Email + "','" + hv.NgaySinh + "',0)";
            DataProvider.Instance.ExecuteNonQuery(t);
            return hv.MaHV;
        }
        public DataTable KiemtraMaSo(string MaHV)
        {
            string t = "select MAHV from HOCVIEN where MaHV='" + MaHV + "'";
            return DataProvider.Instance.ExecuteQuery(t);
        }
    }
}
