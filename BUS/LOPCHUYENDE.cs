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
    public class LOPCHUYENDE
    {
        public DTO_LOPCHUYENDE lcd = new DTO_LOPCHUYENDE();
        public LOPCHUYENDE()
        {

        }
        public LOPCHUYENDE(string maLop)
        {
            lcd.MaLopCD = maLop;
        }
        public int TinhSiSo()
        {
            DB_LOPCHUYENDE dblhp = new DB_LOPCHUYENDE();
          
                List<DTO_LOPCHUYENDE>lst= dblhp.Tinhsiso(lcd.MaLopCD);
            return 0;
            //return Int32.Parse(dt.Rows[0][0].ToString());
        }
        public DataTable TimlopCD(string MaNhomCD)
        {
            DB_LOPCHUYENDE lcd = new DB_LOPCHUYENDE();
            CHUYENDE cd = new CHUYENDE();
            return lcd.TimLopchuyende(cd.timMaCD(MaNhomCD));
        }
    }
}
