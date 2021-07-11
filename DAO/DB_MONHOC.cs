using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
namespace DAO
{
    public class DB_MONHOC
    {
        public DataTable TimMaMonHoc(string MaNhomHP)
        {
            string t = "select MaMonHoc from Monhoc where MaNhomHP='"+MaNhomHP+"'";
            return DataProvider.Instance.ExecuteQuery(t);
        }
    }
}
