using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DAO;
using DTO;
namespace QuanlyTrungTam.BUS
{
    public class LICHTHI
    {
        public DataTable dslich(string MaHV)
        {
            LOPHOCPHAN l = new LOPHOCPHAN();
            string[] t=l.Lophocphankhongdat(MaHV);
            DB_LICHTHI dbl = new DB_LICHTHI();
            return dbl.laylichthi(t);
        }
    }
}
