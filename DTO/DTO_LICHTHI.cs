using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    class DTO_LICHTHI
    {
        private string MaLichThi;
        private string MalopHP;
        private string PhongThi;
        private DateTime TgThi;
        private string MaNV;

        public DTO_LICHTHI(string maLichThi, string malopHP, string phongThi, DateTime tgThi, string maNV)
        {
            MaLichThi = maLichThi;
            MalopHP = malopHP;
            PhongThi = phongThi;
            TgThi = tgThi;
            MaNV = maNV;
        }

        public string MaLichThi1 { get => MaLichThi; set => MaLichThi = value; }
        public string MalopHP1 { get => MalopHP; set => MalopHP = value; }
        public string PhongThi1 { get => PhongThi; set => PhongThi = value; }
        public DateTime TgThi1 { get => TgThi; set => TgThi = value; }
        public string MaNV1 { get => MaNV; set => MaNV = value; }

    }
}
