using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
namespace DAO
{
    public class DB_CHUYENDE
    {
        public DataTable TimMaCD(string MaNhomCD)
        {
            string t = "select MaCD from CHUYENDE where MaNhomCD='" + MaNhomCD + "'";
            return DataProvider.Instance.ExecuteQuery(t);
        }
    }
}
