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
    public class DB_HOCVIEN
    {

        public static DataTable getData()
        {
            SqlConnection conn = dbConnectionData.HamKetNoi();
            SqlCommand command = new SqlCommand("sp_ThongTinCaNhan", conn);
            command.CommandType = CommandType.StoredProcedure;

            //command.Parameters.AddWithValue("@mahv", SqlDbType.NVarChar).Value = txbUserName.Text.Trim();
            command.Parameters.AddWithValue("@MaHV", SqlDbType.NVarChar).Value = "HV001";
            conn.Open();
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = command;
            DataTable dt = new DataTable();
            da.Fill(dt);
            conn.Close();
            return dt;
        }
        public static void SuaThongTinCaNhan(DTO_HOCVIEN hv)
        {
            SqlConnection conn = dbConnectionData.HamKetNoi();
            SqlCommand command = new SqlCommand("sp_SuaThongTinCaNhan", conn);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("@MaHV", SqlDbType.NVarChar, 20);
            command.Parameters.Add("@TenHV", SqlDbType.NVarChar, 50);
            command.Parameters.Add("@GioiTinh", SqlDbType.NVarChar, 10);
            command.Parameters.Add("@SDT", SqlDbType.NVarChar, 10);
            command.Parameters.Add("@Email", SqlDbType.NVarChar, 50);
            command.Parameters.Add("@NgaySinh", SqlDbType.Date);
            command.Parameters.Add("@DiemThiTN", SqlDbType.Int);
            command.Parameters["@MaHV"].Value = hv.MaHV1;
            command.Parameters["@TenHV"].Value = hv.TenHV1;
            command.Parameters["@GioiTinh"].Value = hv.GioiTinh1;
            command.Parameters["@SDT"].Value = hv.SDT1;
            command.Parameters["@Email"].Value = hv.Email1;
            command.Parameters["@NgaySinh"].Value = hv.NgaySinh1;
            command.Parameters["@DiemThiTN"].Value = hv.DiemThiTN1;

            conn.Open();
            command.ExecuteNonQuery();
            conn.Close();
        }

        public string Them(DTO_HOCVIEN hv)
        {

            string t = "insert into HocVien values('" + hv.MaHV + "',N'" + hv.HoTen + "',N'" + hv.Gioitinh + "','" + hv.SDT + "','" + hv.Email + "','" + hv.NgaySinh + "',0)";
            DataProvider.Instance.ExecuteNonQuery(t);
            return hv.MaHV;
        }
        public DataTable KiemtraMaSo(string MaHV)
        {
            string t = "select MAHV from HOCVIEN where MaHV='" + MaHV + "'";
            return DataProvider.Instance.ExecuteQuery(t);

        }
    }
}
