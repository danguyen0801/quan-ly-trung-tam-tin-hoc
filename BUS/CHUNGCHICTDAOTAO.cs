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
    public class CHUNGCHICTDAOTAO
    {
        public static DataTable GetAllBangTotNghiep()
        {
            return DB_CHUNGCHICTDAOTAO.getData();
        }
        public static void InSertBangTotNghiep(DTO_CHUNGCHICTDAOTAO btn)
        {
            DB_CHUNGCHICTDAOTAO.InsertBTN(btn);
        }
    }
}
