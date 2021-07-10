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
    public class DB_CHUNGCHICTDAOTAO
    {
        public static DataTable getData()
        {
            SqlConnection Conn = dbConnectionData.HamKetNoi();
            SqlCommand command = new SqlCommand("GetAllBangTotNghiep", Conn);
            command.CommandType = CommandType.StoredProcedure;
            Conn.Open();
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = command;
            DataTable dt = new DataTable();
            da.Fill(dt);
            Conn.Close();
            return dt;
        }
        public static void InsertBTN(DTO_CHUNGCHICTDAOTAO btn)
        {
            SqlConnection Conn = dbConnectionData.HamKetNoi();
            SqlCommand command = new SqlCommand("InsertBangTotNghiep", Conn);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("@MACHUNGCHI", SqlDbType.NVarChar, 20);
            command.Parameters.Add("@MAHV", SqlDbType.NVarChar, 20);
            command.Parameters.Add("@NGAYCAP", SqlDbType.Date);
            command.Parameters.Add("@XEPLOAI", SqlDbType.NVarChar, 20);
            command.Parameters.Add("@MaCT", SqlDbType.NVarChar, 20);
            command.Parameters["@MACHUNGCHI"].Value = btn.MaChungChi1;
            command.Parameters["@MAHV"].Value = btn.MaHV1;
            command.Parameters["@NGAYCAP"].Value = btn.NgayCap1;
            command.Parameters["@XEPLOAI"].Value = btn.XepLoai1;
            command.Parameters["@MACT"].Value = btn.MaCT1;
            Conn.Open();
            command.ExecuteNonQuery();
            Conn.Close();
        }
    }
}
