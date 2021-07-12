using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using System.Data;

namespace BUS
{
    public class LOGIN
    {
        public string con(string acc,string pass)
        {
            DB_LOGIN lg = new DB_LOGIN();
            DataTable dt = lg.connect(acc, pass);
            if (dt.Rows.Count > 0)
            {
                return dt.Rows[0][2].ToString();
            }
            return "Tên tài khoản hoặc mật khẩu sai, vui lòng thử lại!";
        }
    }
}
