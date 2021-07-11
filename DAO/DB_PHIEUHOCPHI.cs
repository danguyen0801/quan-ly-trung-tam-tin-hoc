using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace DAO
{
    public class DB_PHIEUHOCPHI
    {
        public DataTable select(string Maphieu)
        {
            return DataProvider.Instance.ExecuteQuery("select * PHIEUHOCPHI where Maphieu='" + Maphieu + "'");
        }
        public void Capnhat(string Maphieu,string MaNV)
        {
            string t = "update PHIEUHOCPHI set MaNV='" + MaNV + "' where Maphieu='" + Maphieu + "'";
            DataProvider.Instance.ExecuteNonQuery(t);
        }
    }
}
