using System;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

using DTO;
namespace DAO
{
    public class DB_LICHTHI
    {


        public static DataTable getData()
        {
            SqlConnection conn = dbConnectionData.HamKetNoi();
            SqlCommand command = new SqlCommand("sp_XemLichThi", conn);
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
            command.Parameters["@MALOPHP"].Value = lt.MalopHP1;
            command.Parameters["@PHONGTHI"].Value = lt.PhongThi1;
            command.Parameters["@THOIGIANTHI"].Value = lt.TgThi1;
            command.Parameters["@MANV"].Value = lt.MaNV1;
            Conn.Open();
            command.ExecuteNonQuery();
            Conn.Close();

        }

       

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
