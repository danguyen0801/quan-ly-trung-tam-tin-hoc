using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DAO;
namespace QuanlyTrungTam.BUS
{
    public class NHOMHP
    {
        public DataTable MaNhom()
        {
            DB_NHOMHP dbnhp = new DB_NHOMHP();
            return dbnhp.MaNhomHP();
        }
    }
}
