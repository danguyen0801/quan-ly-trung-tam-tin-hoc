using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DTO;
using DAO;
namespace QuanlyTrungTam.BUS
{
    public class BANGDIEM
    {
        public void Dangkithillai(string MaHV)
        {
            DB_BANGDIEM bd = new DB_BANGDIEM();
            bd.Capnhatlanthi(MaHV);
        }
        public DataTable Dsmonkhongdat(string MaHV)
        {
            DB_BANGDIEM dbbd = new DB_BANGDIEM();
            return dbbd.dskhongdat(MaHV);
        }
    }
}
