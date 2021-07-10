using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

using DTO;

namespace DAO
{
    public class DB_CHUNGCHITINHOC
    {
        public static DataTable getData()
        {
            SqlConnection Conn = dbConnectionData.HamKetNoi();
            SqlCommand command = new SqlCommand("GetAllChungChiTinHoc", Conn);
            command.CommandType = CommandType.StoredProcedure;
            Conn.Open();
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = command;
            DataTable dt = new DataTable();
            da.Fill(dt);
            Conn.Close();
            return dt;
        }
        public static void InsertCCTH(DTO_CHUNGCHITINHOC ccth)
        {
            SqlConnection Conn = dbConnectionData.HamKetNoi();
            SqlCommand command = new SqlCommand("InsertChungChiTinHoc", Conn);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("@MACHUNGCHI", SqlDbType.NVarChar, 20);
            command.Parameters.Add("@TENCHUNGCHI", SqlDbType.NVarChar, 20);
            command.Parameters.Add("@MAHV", SqlDbType.NVarChar, 20);
            command.Parameters.Add("@NGAYCAP", SqlDbType.Date);
            command.Parameters.Add("@XEPLOAI", SqlDbType.NVarChar, 20);
            command.Parameters.Add("@MaNhomHP", SqlDbType.NVarChar, 20);
            command.Parameters["@MACHUNGCHI"].Value = ccth.MaChungChi1;
            command.Parameters["@TENCHUNGCHI"].Value = ccth.TenChungChi1;
            command.Parameters["@MAHV"].Value = ccth.MaHV1;
            command.Parameters["@NGAYCAP"].Value = ccth.NgayCap1;
            command.Parameters["@XEPLOAI"].Value = ccth.XepLoai1;
            command.Parameters["@MaNhomHP"].Value = ccth.MaNhomHP1;
            Conn.Open();
            command.ExecuteNonQuery();
            Conn.Close();
        }
    }
}
