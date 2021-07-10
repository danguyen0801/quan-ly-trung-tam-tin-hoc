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
    public class BANGDIEM    {
        public static DataTable XemDiemThi()
        {
            return DB_BANGDIEM.getData();
        }
    }
}
