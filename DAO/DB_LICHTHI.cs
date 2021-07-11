using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace DAO
{
    public class DB_LICHTHI
    {
        public DataTable laylichthi(string[] Malop)
        {
            string t = "select * from lICHTHI where MalopHP='" + Malop[0] + "'";
            DataTable tb= DataProvider.Instance.ExecuteQuery(t);
            for(int i=1;i<Malop.Length;i++)
            {
                string t2 = "select * from LICHTHI where MaLopHP='" + Malop[i] + "'";
                DataTable tbt = DataProvider.Instance.ExecuteQuery(t2);
                foreach (DataRow dr in tbt.Rows)
                {
                    tb.Rows.Add(dr.ItemArray);
                }
            }
            return tb;
        }
    }
}
