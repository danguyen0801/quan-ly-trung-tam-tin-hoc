using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_LICHTHI
    {
        private string MaLichThi;
        private string MaLopHP;
        private string PhongThi;
        private DateTime ThoiGianThi;
        private string MaNV;

        public DTO_LICHTHI(string maLichThi, string maLopHP, string phongThi, DateTime thoiGianThi, string maNV)
        {
            MaLichThi = maLichThi;
            MaLopHP = maLopHP;
            PhongThi = phongThi;
            ThoiGianThi = thoiGianThi;
            MaNV = maNV;
        }

        public string MaLichThi1 { get => MaLichThi; set => MaLichThi = value; }
        public string MaLopHP1 { get => MaLopHP; set => MaLopHP = value; }
        public string PhongThi1 { get => PhongThi; set => PhongThi = value; }
        public DateTime ThoiGianThi1 { get => ThoiGianThi; set => ThoiGianThi = value; }
        public string MaNV1 { get => MaNV; set => MaNV = value; }
    }
}
