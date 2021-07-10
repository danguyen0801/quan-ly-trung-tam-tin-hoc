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
    class LOPHOCPHAN
    {
        public static DataTable GetAllLopHocPhan()
        {
            return DB_LOPHOCPHAN.getData();
        }
    }
}
