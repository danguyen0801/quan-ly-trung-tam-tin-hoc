using System;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Text;
using DTO;

namespace DAO
{
    public class DB_LICHTHI
    {
        public static void InsertLichThi(DTO_LICHTHI lt)
        {
            SqlConnection Conn = dbConnectionData.HamKetNoi();
            SqlCommand command = new SqlCommand("InsertLichThi", Conn);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("@MALICHTHI", SqlDbType.NVarChar, 20);
            command.Parameters.Add("@MALOPHP", SqlDbType.NVarChar, 20);
            command.Parameters.Add("@PHONGTHI", SqlDbType.NVarChar, 20);
            command.Parameters.Add("@THOIGIANTHI", SqlDbType.Date);
            command.Parameters.Add("@MANV", SqlDbType.NVarChar, 20);
            command.Parameters["@MALICHTHI"].Value = lt.MaLichThi1;
            command.Parameters["@MALOPHP"].Value = lt.MaLopHP1;
            command.Parameters["@PHONGTHI"].Value = lt.PhongThi1;
            command.Parameters["@THOIGIANTHI"].Value = lt.ThoiGianThi1;
            command.Parameters["@MANV"].Value = lt.MaNV1;
            Conn.Open();
            command.ExecuteNonQuery();
            Conn.Close();
        }
    }
}
