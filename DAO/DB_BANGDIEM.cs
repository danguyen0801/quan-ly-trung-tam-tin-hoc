using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Dapper;
using DTO;
namespace DAO
{
    public class DB_BANGDIEM
    {

        public static DataTable getData()
        {
            SqlConnection conn = dbConnectionData.HamKetNoi();
            SqlCommand command = new SqlCommand("sp_XemDiemThi", conn);
            command.CommandType = CommandType.StoredProcedure;

            //command.Parameters.AddWithValue("@mahv", SqlDbType.NVarChar).Value = txbUserName.Text.Trim();
            command.Parameters.AddWithValue("@mahv", SqlDbType.NVarChar).Value = "HV001";
            conn.Open();
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = command;
            DataTable dt = new DataTable();
            da.Fill(dt);
            conn.Close();
            return dt;
        }

        public void Capnhatlanthi(string MaHV)
        {
            string t = "update LICHTHI set Solanthi=2 where MaHV='" + MaHV + "'";
        }
        public DataTable dskhongdat(string MaHV)
        {
            string t = "select * from BANGDIEM where MaHV='" + MaHV + "' and diem<5";
            return DataProvider.Instance.ExecuteQuery(t);
        }

        public static List<DTO_BANGDIEM> DSBangDiemTheoMaMon(string maMon)
        {
            DBConnect _dbContext = new DBConnect();
            using (IDbConnection _dbConnection = _dbContext.CreateConnection())
            {
                var output = _dbConnection.Query<DTO_BANGDIEM>($"select * from BANGDIEM where MAMONHOC = '{maMon}'").ToList();
                return output;

            }
        }

        public static void updateDiem(string maHV, string maMH,int Diem, int soLanThi,bool ispass)
        {
            DBConnect _dbContext = new DBConnect();
            using (IDbConnection _dbConnection = _dbContext.CreateConnection())
            {
                var output = _dbConnection.Query<DTO_BANGDIEM>($"UPDATE BANGDIEM SET DIEM = '{Diem}', SOLANTHI='{soLanThi}', ISPASS='{ispass}' WHERE MAHV='{maHV}' AND MAMONHOC='{maMH}'") ;

            }
        }
    }
}
