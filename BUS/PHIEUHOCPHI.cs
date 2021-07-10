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
    public class PHIEUHOCPHI
    {
        public static DataTable XemHocPhi()
        {
            return DB_PHIEUHOCPHI.getData();
        }
    }
}
