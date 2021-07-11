using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using DTO;
using System.Data;
namespace BUS
{
    public class BANGDIEM
    {
        public  List<DTO_BANGDIEM> DSBangDiemTheoMaMon(string maMon)
        {
            return DB_BANGDIEM.DSBangDiemTheoMaMon(maMon);
        }
    }
}
