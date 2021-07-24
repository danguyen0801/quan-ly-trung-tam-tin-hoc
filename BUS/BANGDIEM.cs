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
    public class BANGDIEM {
        public static DataTable XemDiemThi()
        {
            return DB_BANGDIEM.getData();
        }
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
    
        public List<DTO_BANGDIEM> DSBangDiemTheoMaMon(string maMon)
        {
            return DB_BANGDIEM.DSBangDiemTheoMaMon(maMon);
        }
        public void updateDiem (string maHV, string maMH,int Diem,int soLanThi,bool isPass)
        {
            DB_BANGDIEM.updateDiem(maHV, maMH, Diem, soLanThi, isPass);
        }
    }
}