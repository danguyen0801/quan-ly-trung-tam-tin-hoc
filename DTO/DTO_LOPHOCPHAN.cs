using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_LOPHOCPHAN
    {
        private string MaLopHP;
        private string MaMonHoc;
        private string TenLopHP;
        private string MaGV;
        private int SiSo;
        private DateTime ThoiGianHoc;

        public DTO_LOPHOCPHAN(string maLopHP, string maMonHoc, string tenLopHP, string maGV, int siSo, DateTime thoiGianHoc)
        {
            MaLopHP = maLopHP;
            MaMonHoc = maMonHoc;
            TenLopHP = tenLopHP;
            MaGV = maGV;
            SiSo = siSo;
            ThoiGianHoc = thoiGianHoc;
        }

        public string MaLopHP1 { get => MaLopHP; set => MaLopHP = value; }
        public string MaMonHoc1 { get => MaMonHoc; set => MaMonHoc = value; }
        public string TenLopHP1 { get => TenLopHP; set => TenLopHP = value; }
        public string MaGV1 { get => MaGV; set => MaGV = value; }
        public int SiSo1 { get => SiSo; set => SiSo = value; }
        public DateTime ThoiGianHoc1 { get => ThoiGianHoc; set => ThoiGianHoc = value; }
    }
}
