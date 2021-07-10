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
    public class LICHTHI
    {
        public static DataTable XemLichThi()
        {
            return DB_LICHTHI.getData();
        }
    }
}
