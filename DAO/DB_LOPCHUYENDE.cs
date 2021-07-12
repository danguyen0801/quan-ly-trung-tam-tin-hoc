using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
namespace DAO
{
    public class DB_LOPCHUYENDE
    {
        public DataTable TimLopchuyende(string[] MaCD)
        {
            DataTable tb = new DataTable();

            DataTable tbt = new DataTable();

            string t = "select * from LOPCHUYENDE where MaCD='" + MaCD[0] + "'";
            tb = DataProvider.Instance.ExecuteQuery(t);
            for (int i = 1; i <= MaCD.Length - 1; i++)
            {
                string t2 = "select * from LOPCHUYENDE where MaCD='" + MaCD[i] + "'";
                tbt = DataProvider.Instance.ExecuteQuery(t2);
                foreach (DataRow dr in tbt.Rows)
                {
                    tb.Rows.Add(dr.ItemArray);
                }
            }
            return tb;
        }
        public DataTable Tinhsiso(string MaLCD)
        {
            string t = "select SiSo from LOPCHUYENDE where MaLopCD='" + MaLCD + "'";
            return DataProvider.Instance.ExecuteQuery(t);
        }
    }
}
