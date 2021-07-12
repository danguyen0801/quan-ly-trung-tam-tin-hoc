using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_LOPHOCPHAN
    {
        //private string MaLopHP;
        //private string MaMonHoc;
        //private string TenLopHP;
        //private string MaGV;
        //private int SiSo;
        //private DateTime ThoiGianHoc;




        public DTO_LOPHOCPHAN(string maLopHP1, string maMonHoc1, string tenLopHP1, string maGV1, int siSo1, DateTime thoiGianHoc1)
        {
            MaLopHP = maLopHP1;
            MaMonHoc = maMonHoc1;
            TenLopHP = tenLopHP1;
            MaGV = maGV1;
            SiSo = siSo1;
            ThoiGianHoc = thoiGianHoc1;
        }
        public DTO_LOPHOCPHAN() {
        }


        public string MaLopHP { get ; set ; }
        public string MaMonHoc { get; set; }
        public string TenLopHP { get ; set ; }
        public string MaGV { get; set; }
        public int SiSo { get; set; }
        public DateTime ThoiGianHoc { get ; set ; }
    }
}
