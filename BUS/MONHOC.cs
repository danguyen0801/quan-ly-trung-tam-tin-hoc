﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using DTO;
using System.Data;

namespace BUS
{
    public class MONHOC
    {

        public static DataTable ThoiKhoaBieu()
        {
            return DB_MONHOC.getData();
        }
        public string[] timMaMonHoc(string MaNhomHP)
        {
            string[] t=new string[100];
            int k = 0;
            DataTable tb = new DataTable();
            DB_MONHOC mh = new DB_MONHOC();
            tb = mh.TimMaMonHoc(MaNhomHP);
            for(int i=0;i<tb.Rows.Count;i++)
            {
                
                t[k] = tb.Rows[i][0].ToString();
                k++;
            }
            return t; 

        }
    }
}
