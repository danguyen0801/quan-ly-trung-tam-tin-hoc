using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using DTO;
using System.Data;
namespace QuanlyTrungTam.BUS
{
    public class NHOMCHUYENDE
    {
        public DTO_NHOMHOCPHAN nhp = new DTO_NHOMHOCPHAN();
        public DataTable MaNhom()
        {
            DB_NHOMCHUYENDE dbncd = new DB_NHOMCHUYENDE();
            return dbncd.MaNhomCD();
        }
    }
}
