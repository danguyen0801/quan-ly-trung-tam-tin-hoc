using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
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


    }
}
