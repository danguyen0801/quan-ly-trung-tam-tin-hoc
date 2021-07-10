using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_PHIEUHOCPHI
    {
        private string MaPhieu;
        private string MaHV;
        private string MaNV;
        private int TongTien;

        public DTO_PHIEUHOCPHI(string maPhieu, string maHV, string maNV, int tongTien)
        {
            MaPhieu = maPhieu;
            MaHV = maHV;
            MaNV = maNV;
            TongTien = tongTien;
        }

        public string MaPhieu1 { get => MaPhieu; set => MaPhieu = value; }
        public string MaHV1 { get => MaHV; set => MaHV = value; }
        public string MaNV1 { get => MaNV; set => MaNV = value; }
        public int TongTien1 { get => TongTien; set => TongTien = value; }
    }
}
