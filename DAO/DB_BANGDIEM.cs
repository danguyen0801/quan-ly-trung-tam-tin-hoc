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
    public class DB_BANGDIEM: DBConnect
    {
        public static List<DTO_BANGDIEM> DSBangDiemTheoMaMon(string maMon)
        {
            DBConnect _dbContext = new DBConnect();
            using (IDbConnection _dbConnection = _dbContext.CreateConnection())
            {
                var output = _dbConnection.Query<DTO_BANGDIEM>($"select * from BANGDIEM where MAMONHOC = '{maMon}'").ToList();
                return output;
            
        }
    }
}
}
