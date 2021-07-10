using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_CHUNGCHITINHOC
    {

        private string MaChungChi;
        private string TenChungChi;
        private string MaHV;
        private DateTime NgayCap;
        private string XepLoai;
        private string MaNhomHP;

        public DTO_CHUNGCHITINHOC(string maChungChi, string tenChungChi, string maHV, DateTime ngayCap, string xepLoai, string maNhomHP)
        {
            MaChungChi = maChungChi;
            TenChungChi = tenChungChi;
            MaHV = maHV;
            NgayCap = ngayCap;
            XepLoai = xepLoai;
            MaNhomHP = maNhomHP;
        }

        public string MaChungChi1 { get => MaChungChi; set => MaChungChi = value; }
        public string TenChungChi1 { get => TenChungChi; set => TenChungChi = value; }
        public string MaHV1 { get => MaHV; set => MaHV = value; }
        public DateTime NgayCap1 { get => NgayCap; set => NgayCap = value; }
        public string XepLoai1 { get => XepLoai; set => XepLoai = value; }
        public string MaNhomHP1 { get => MaNhomHP; set => MaNhomHP = value; }
    }

}
