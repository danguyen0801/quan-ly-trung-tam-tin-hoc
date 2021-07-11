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
    public class DKCHUYENDE
    {
        public DTO_DKCHUYENDE dkcd = new DTO_DKCHUYENDE();
        public int Dangki()
        {
            LOPCHUYENDE lcd = new LOPCHUYENDE();
            lcd.lcd.MaLopCD = dkcd.MAlopCD;
            if (lcd.TinhSiSo() < 30)
            {
                int n = this.Kiemtra();
                if (n == 1)
                {
                    DB_DKCHUYENDE dk = new DB_DKCHUYENDE();
                    dk.Dangki(this.dkcd);
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
            DB_DKCHUYENDE dbdkcd = new DB_DKCHUYENDE();
            DataTable tb = dbdkcd.Kiemtratontai(this.dkcd);
            if (tb.Rows.Count > 0)
                return 2;
            else
                return 1;
        }
    }
}
