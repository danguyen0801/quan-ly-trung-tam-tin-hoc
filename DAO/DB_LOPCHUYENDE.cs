using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using DTO;
using Dapper;
using System.Windows.Forms;
namespace DAO
{
    public class DB_LOPCHUYENDE:DBConnect
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
        public List<DTO_LOPCHUYENDE> Tinhsiso(string MaLCD)
        {
            DBConnect _dbContext = new DBConnect();
            using (IDbConnection _dbConnection = _dbContext.CreateConnection())
            {
                var output = _dbConnection.Query<DTO_LOPCHUYENDE>($"select * from LOPCHUYENDE where MaLopCD='" + MaLCD + "'").ToList();
                MessageBox.Show("select * from LOPCHUYENDE where MaLopCD='" + MaLCD + "'");
                return output;
            }


            //string t = "select SiSo from LOPCHUYENDE where MaLopCD='" + MaLCD + "'";
            //return DataProvider.Instance.ExecuteQuery(t);
        }
    }
}
