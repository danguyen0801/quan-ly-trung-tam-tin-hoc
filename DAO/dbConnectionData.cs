using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace DAO
{
    public class dbConnectionData
    {
        public static SqlConnection HamKetNoi()
        {
            SqlConnection Conn = new SqlConnection(@"Data Source=THAOTRUONG\SQL;Initial Catalog=QUANLITRUNGTAMTINHOC;Integrated Security=True");
            return Conn;
        }
    }
}
