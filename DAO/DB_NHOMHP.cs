using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
namespace DAO
{
    public class DB_NHOMHP
    {
        public DataTable MaNhomHP()
        {
            string t = "select MaNhomHP from NHOMHP";
            return DataProvider.Instance.ExecuteQuery(t);
        }
    }
}
