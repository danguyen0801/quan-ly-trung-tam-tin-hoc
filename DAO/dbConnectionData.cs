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
            SqlConnection Conn = new SqlConnection(@"Data Source=LAPTOP-QJ711BS2\SQLEXPRESS;Initial Catalog=QUANLITRUNGTAMTINHOC;Integrated Security=True");
            return Conn;
        }
    }
}
