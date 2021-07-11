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
    public class DB_HOCVIEN : DBConnect
    {
        public static List<DTO_HOCVIEN> DsHocVien()
        {
            DBConnect _dbContext = new DBConnect();
            using (IDbConnection _dbConnection = _dbContext.CreateConnection())
            {
                var output = _dbConnection.Query<DTO_HOCVIEN>($"select * from HOCVIEN").ToList();
                return output;
            }
        }
    }
       
}
