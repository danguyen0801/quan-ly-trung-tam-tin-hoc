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
            command.Parameters["@MaHV"].Value = hv.MaHV;
            command.Parameters["@TenHV"].Value = hv.HoTenHV;
            command.Parameters["@GioiTinh"].Value = hv.Gioitinh;
            command.Parameters["@SDT"].Value = hv.SDT;
            command.Parameters["@Email"].Value = hv.Email;
            command.Parameters["@NgaySinh"].Value = hv.ngaySinh.ToString();
            command.Parameters["@DiemThiTN"].Value = hv.DiemThiTotNghiep;

            conn.Open();
            command.ExecuteNonQuery();
            conn.Close();
        }

        public string Them(DTO_HOCVIEN hv)
        {

            string t = "insert into HocVien values('" + hv.MaHV + "',N'" + hv.HoTen + "',N'" + hv.Gioitinh + "','" + hv.SDT + "','" + hv.Email + "','" + hv.ngaySinh + "',0)";
            DataProvider.Instance.ExecuteNonQuery(t);
            return hv.MaHV;
        }
        public DataTable KiemtraMaSo(string MaHV)
        {
            string t = "select MAHV from HOCVIEN where MaHV='" + MaHV + "'";
            return DataProvider.Instance.ExecuteQuery(t);
        }


        public static List<DTO_HOCVIEN> DsHocVien()
        {
            DBConnect _dbContext = new DBConnect();
            using (IDbConnection _dbConnection = _dbContext.CreateConnection())
            {
                var output = _dbConnection.Query<DTO_HOCVIEN>($"select * from HOCVIEN").ToList();
                return output;
            }
        }
        public static void updateHocVien(DTO_HOCVIEN hv)
        {
            DBConnect _dbContext = new DBConnect();
            using (IDbConnection _dbConnection = _dbContext.CreateConnection())
            {
                var output = _dbConnection.Query<DTO_HOCVIEN>($"UPDATE HOCVIEN SET HOTENHV=N'{hv.HoTenHV}', GIOITINH=N'{hv.Gioitinh}', SDT='{hv.SDT}', EMAIL='{hv.Email}', NGAYSINH='{hv.ngaySinh}' WHERE MAHV='{hv.MaHV}'");



            }
        }
    }
        }
       
            
