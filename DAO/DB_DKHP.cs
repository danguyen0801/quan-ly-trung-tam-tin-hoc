using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DTO;

namespace DAO
{
    public class DB_DKHP
    {
        public void Dangki(DTO_DKHP dkhp)
        {
            string t = "insert into DKHP values('" + dkhp.MaHV + "','" + dkhp.MAlopHP + "','" + dkhp.Thoigiandk + "')";
            DataProvider.Instance.ExecuteNonQuery(t);
        }
        public DataTable Kiemtratontai(DTO_DKHP dkhp)
        {
            string t = "select * from DKHP where MaHV='" + dkhp.MaHV + "' and MaLopHP='" + dkhp.MAlopHP + "'";
            return DataProvider.Instance.ExecuteQuery(t);
        }
        public DataTable dsdk(string MaHV)
        {
            string t = "select MalopHP from DKHP where MaHV='" + MaHV + "'";
            return DataProvider.Instance.ExecuteQuery(t);
        }
    }
}
