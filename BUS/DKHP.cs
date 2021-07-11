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
    public class DKHP
    {
        public DTO_DKHP dkhp = new DTO_DKHP();
        public int Dangki()
        {
            LOPHOCPHAN lhp = new LOPHOCPHAN();
            lhp.lhp.MaLopHP1 = dkhp.MAlopHP;
            if (lhp.TinhSiSo() < 30)
            {
                int n = this.Kiemtra();
                if (n == 1)
                {
                    DB_DKHP dk = new DB_DKHP();
                    dk.Dangki(this.dkhp);
                    return 1;
                }
                else
                    return 2;
            }    
            else
                return 0;
        }
        public int Kiemtra()
        {
            DB_DKHP dbdkhp = new DB_DKHP();
            DataTable tb = dbdkhp.Kiemtratontai(this.dkhp);
            if (tb.Rows.Count > 0)
                return 2;
            else
                return 1;
        }
        public DataTable dslopdk(string MaHV)
        {
            DB_DKHP dkhp = new DB_DKHP();
            return dkhp.dsdk(MaHV);
        }
    }
}
