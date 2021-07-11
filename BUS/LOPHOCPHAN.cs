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
    public class LOPHOCPHAN
    {
        public static DataTable GetAllLopHocPhan()
        {
            return DB_LOPHOCPHAN.getData();
        }
        public  List<DTO_LOPHOCPHAN> DSLopHPTheoMaGV(string maGV)
        {
            return DB_LOPHOCPHAN.DSLopHPTheoMaGV(maGV);
        }

        
    }
}
