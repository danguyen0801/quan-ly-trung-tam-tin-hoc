using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using DTO;
using System.Windows.Forms;
namespace DAO
{
    public class DB_PHIEUHOCPHI
    {

        public static DataTable getData()
        {
            SqlConnection conn = dbConnectionData.HamKetNoi();
            SqlCommand command = new SqlCommand("sp_XemHocPhi", conn);
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
        public DataTable select(string Mahv)
        {
            return DataProvider.Instance.ExecuteQuery("select * FROM PHIEUHOCPHI where MAHV='" + Mahv + "'");
        }
        public void Capnhat(string Maphieu,string MaNV)
        {
            string t = "update PHIEUHOCPHI set MaNV='" + MaNV + "' where Maphieu='" + Maphieu + "'";
            DataProvider.Instance.ExecuteNonQuery(t);

        }
    }
}
