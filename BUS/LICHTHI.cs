using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAO;
using System.Data;

namespace QuanlyTrungTam.BUS
{
    public class LICHTHI
    {
        public static void InSertLichThi(DTO_LICHTHI lt)
        {
            DB_LICHTHI.InsertLichThi(lt);
        }
    }
}
