using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using DTO;
using Dapper;
namespace DAO
{
    public class DB_LOPHOCPHAN:DBConnect
    {
        
        public DataTable TimLophocphan(string[] MaMonHoc)
        {
            DataTable tb = new DataTable();
           
            DataTable tbt = new DataTable();
      
            string t = "select * from LOPHOCPHAN where MaMonHoc='" + MaMonHoc[0] + "'";
            tb = DataProvider.Instance.ExecuteQuery(t);
            for (int i=1;i<=MaMonHoc.Length-1;i++)
            {
                string t2 = "select * from LOPHOCPHAN where MaMonHoc='" + MaMonHoc[i] + "'";
                tbt= DataProvider.Instance.ExecuteQuery(t2);
                foreach (DataRow dr in tbt.Rows)
                {
                    tb.Rows.Add(dr.ItemArray);
                }    
            }
            return tb;
        }
        public DataTable Tinhsiso(string MaLHP)
        {
            string t = "select SiSo from LOPHOCPHAN where MaLopHP='" + MaLHP + "'";
            return DataProvider.Instance.ExecuteQuery(t);
        }
        public DataTable dsLopHP(string MalopHP,string Monhoc)
        {
            string t = "select MalopHP from Lophocphan where MalopHP='" + MalopHP + "' and MaMonhoc='" + Monhoc + "'";
            return DataProvider.Instance.ExecuteQuery(t);
        }
        public static DataTable getData()
        {
            SqlConnection Conn = dbConnectionData.HamKetNoi();
            SqlCommand command = new SqlCommand("GetAllLopHocPhan", Conn);
            command.CommandType = CommandType.StoredProcedure;
            Conn.Open();
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = command;
            DataTable dt = new DataTable();
            da.Fill(dt);
            Conn.Close();
            return dt;
        }
        public static List<DTO_LOPHOCPHAN> DSLopHPTheoMaGV(string maGV)
        {
            DBConnect _dbContext = new DBConnect();
            using (IDbConnection _dbConnection = _dbContext.CreateConnection())
            {
                var output = _dbConnection.Query<DTO_LOPHOCPHAN>($"select * from LOPHOCPHAN where MAGV = '{maGV}'").ToList();
                
                return output;
            }
        }
        
    }
}
