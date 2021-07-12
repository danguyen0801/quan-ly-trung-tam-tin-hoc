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
    public class PHIEUHOCPHI
    {

        public static DataTable XemHocPhi()
        {
            return DB_PHIEUHOCPHI.getData();
        }

       
        public void Thuhocphi(string MaNV,string Maphieu)
        {
            DB_PHIEUHOCPHI php = new DB_PHIEUHOCPHI();
            php.Capnhat(Maphieu,MaNV);
        }
        public DataTable Tracuu(string MaHV)
        {
            DB_PHIEUHOCPHI php = new DB_PHIEUHOCPHI();
            return php.select(MaHV);
        }

    }
}
