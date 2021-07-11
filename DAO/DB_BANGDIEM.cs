using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data;
namespace DAO
{
    public class DB_BANGDIEM
    {
        public void Capnhatlanthi(string MaHV)
        {
            string t = "update LICHTHI set Solanthi=2 where MaHV='" + MaHV + "'";
        }
        public DataTable dskhongdat(string MaHV)
        {
            string t = "select * from BANGDIEM where MaHV='" + MaHV + "' and diem<5";
            return DataProvider.Instance.ExecuteQuery(t);
        }

    }
}
