using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
namespace DAO
{
    public class DB_NHOMCHUYENDE
    {
        public DataTable MaNhomCD()
        {
            string t = "select MaNhomCD from NHOMCHUYENDE";
            return DataProvider.Instance.ExecuteQuery(t);
        }
    }
}
