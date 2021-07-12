using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DTO;
namespace DAO
{
    public class DB_DKCHUYENDE
    {
        public void Dangki(DTO_DKCHUYENDE dkcd)
        {
            string t = "insert into DKHP values('" + dkcd.MaHV + "','" + dkcd.MAlopCD + "','" + dkcd.Thoigiandk + "')";
            DataProvider.Instance.ExecuteNonQuery(t);
        }
        public DataTable Kiemtratontai(DTO_DKCHUYENDE dkcd)
        {
            string t = "select * from DKHP where MaHV='" + dkcd.MaHV + "' and MaLopHP='" + dkcd.MAlopCD + "'";
            return DataProvider.Instance.ExecuteQuery(t);
        }
    }
}
