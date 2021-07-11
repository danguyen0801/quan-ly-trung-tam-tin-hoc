using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_HOCVIEN
    {
        public string MaHV;
        public string HoTen;
        public string Gioitinh;
        public string SDT;
        public string Email;
        public string NgaySinh;
        public int Diemthitotnghiep;
        public void Khoitao(string MaHV, string HoTen, string Gioitinh, string SDT, string Email, string NgaySinh)
        {
            this.MaHV = MaHV;
            this.HoTen = HoTen;
            this.Gioitinh = Gioitinh;
            this.SDT = SDT;
            this.Email = Email;
            this.NgaySinh = NgaySinh;
            this.Diemthitotnghiep = 0;
        }
        public string MaHV1 { get => MaHV; set => MaHV = value; }
    }
}
