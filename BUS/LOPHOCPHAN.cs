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
    public class LOPHOCPHAN
    {
        public DTO_LOPHOCPHAN lhp = new DTO_LOPHOCPHAN();

        public static DataTable GetAllLopHocPhan()
        {
            return DB_LOPHOCPHAN.getData();
        }
        public int TinhSiSo()
        {
            DB_LOPHOCPHAN dblhp = new DB_LOPHOCPHAN();
            DataTable dt = dblhp.Tinhsiso(lhp.MaLopHP1);
            return Int32.Parse(dt.Rows[0][0].ToString());
        }
        public DataTable timLopHocPhan(string MaNhomHP)
        {
            DB_LOPHOCPHAN lhp = new DB_LOPHOCPHAN();
            MONHOC mh = new MONHOC();
            return lhp.TimLophocphan(mh.timMaMonHoc(MaNhomHP));
        }
        public string[] Lophocphankhongdat(string MaHV)
        {
            BANGDIEM db = new BANGDIEM();
            DKHP dk = new DKHP();
            string[] t = new string[100];
            int k = 0;
            DataTable tb1 = db.Dsmonkhongdat(MaHV);
            DataTable tb2 = dk.dslopdk(MaHV);
            for(int i=0;i<tb1.Rows.Count;i++)
            {
                for(int j=0;j<tb2.Rows.Count;j++)
                {
                    DB_LOPHOCPHAN lhp = new DB_LOPHOCPHAN();
                    DataTable tb3 = lhp.dsLopHP(tb2.Rows[j][0].ToString(), tb1.Rows[i][0].ToString());
                    if(tb3.Rows.Count>0)
                    {
                        t[k] = tb3.Rows[0][0].ToString();
                        k++;
                    }    
                }    
            }
            return t;
        }
    }
}
