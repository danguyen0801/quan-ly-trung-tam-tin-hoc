using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_MONHOC
    {
        private string MaMH;
        private string MaNhomHP;
        private string TenMonHoc;
        private string HinhThucDT;
        private int GiaTien;

        public DTO_MONHOC(string maMH, string maNhomHP, string tenMonHoc, string hinhThucDT, int giaTien)
        {
            MaMH = maMH;
            MaNhomHP = maNhomHP;
            TenMonHoc = tenMonHoc;
            HinhThucDT = hinhThucDT;
            GiaTien = giaTien;
        }

        public string MaMH1 { get => MaMH; set => MaMH = value; }
        public string MaNhomHP1 { get => MaNhomHP; set => MaNhomHP = value; }
        public string TenMonHoc1 { get => TenMonHoc; set => TenMonHoc = value; }
        public string HinhThucDT1 { get => HinhThucDT; set => HinhThucDT = value; }
        public int GiaTien1 { get => GiaTien; set => GiaTien = value; }
    }
}
