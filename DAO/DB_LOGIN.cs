using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DTO;
using System.Windows.Forms;
namespace DAO
{
    public class DB_LOGIN
    {
        public DataTable connect(string acc,string pass)
        {
            string t = "select * from logintable where taikhoan='" + acc + "' and pass='" + pass + "'";
           
            return DataProvider.Instance.ExecuteQuery(t);
        }
    }
}
