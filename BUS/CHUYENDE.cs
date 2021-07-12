using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DTO;
using DAO;
namespace BUS

{
    public class CHUYENDE
    {
        public string[] timMaCD(string MaNhomCD)
        {
            string[] t = new string[100];
            int k = 0;
            DataTable tb = new DataTable();
            DB_CHUYENDE cd = new DB_CHUYENDE();
            tb = cd.TimMaCD(MaNhomCD);
            for (int i = 0; i < tb.Rows.Count; i++)
            {

                t[k] = tb.Rows[i][0].ToString();
                k++;
            }
            return t;
        }
    }
}
