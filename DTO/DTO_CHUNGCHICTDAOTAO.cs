using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_CHUNGCHICTDAOTAO
    {
        private string MaChungChi;
        private string MaHV;
        private DateTime NgayCap;
        private string XepLoai;
        private string MaCT;

        public DTO_CHUNGCHICTDAOTAO(string maChungChi, string maHV, DateTime ngayCap, string xepLoai, string maCT)
        {
            MaChungChi = maChungChi;
            MaHV = maHV;
            NgayCap = ngayCap;
            XepLoai = xepLoai;
            MaCT = maCT;
        }

        public string MaChungChi1 { get => MaChungChi; set => MaChungChi = value; }
        public string MaHV1 { get => MaHV; set => MaHV = value; }
        public DateTime NgayCap1 { get => NgayCap; set => NgayCap = value; }
        public string XepLoai1 { get => XepLoai; set => XepLoai = value; }
        public string MaCT1 { get => MaCT; set => MaCT = value; }


    }
}
