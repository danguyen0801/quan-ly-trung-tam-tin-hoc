using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_HOCVIEN
    {


        //private string mahv;
        //private string tenhv;
        //private string gioitinh;
        //private string sdt;
        //private string email;
        //private DateTime ngaysinh;
        //private int diemthitn;
        public void Khoitao(string MaHV, string HoTen, string Gioitinh, string SDT, string Email, string NgaySinh)
        {
            this.MaHV = MaHV;
            this.HoTenHV = HoTen;
            this.Gioitinh = Gioitinh;
            this.SDT = SDT;
            this.Email = Email;
            this.ngaySinh = DateTime.Parse(NgaySinh);
            this.DiemThiTotNghiep = 0;
        }
        public DTO_HOCVIEN(string maHV, string tenHV, string gioiTinh, string sDT, string email, DateTime NgaySinh, int diemThiTN)
        {
            MaHV = maHV;
            HoTenHV = tenHV;
            Gioitinh = gioiTinh;
            SDT = sDT;
            Email = email;
            ngaySinh = NgaySinh;
            DiemThiTotNghiep = diemThiTN;
        }
        public DTO_HOCVIEN()
        {

        }

        //public string MaHV1 { get => MaHV; set => MaHV = value; }
        //public string TenHV1 { get => HoTen; set => HoTen = value; }
        //public string GioiTinh1 { get => Gioitinh; set => Gioitinh = value; }
        //public string SDT1 { get => SDT; set => SDT = value; }
        //public string Email1 { get => Email; set => Email = value; }
        //public DateTime NgaySinh1 { get => ngaySinh; set => ngaySinh = value; }
        //public int DiemThiTN1 { get => DiemThiTN; set => DiemThiTN = value; }

        public string MaHV;
        public string HoTenHV;
        public string Gioitinh;
        public string SDT;
        public string Email;
        public DateTime ngaySinh;
        public int DiemThiTotNghiep;
       
      


    }
}
