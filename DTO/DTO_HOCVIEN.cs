using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_HOCVIEN
    {
        //<<<<<<< HEAD
        //        private string MaHV;
        //        private string TenHV;
        //        private string GioiTinh;
        //        private string SDT;
        //        private string Email;
        //        private DateTime NgaySinh;       
        //        private int DiemThiTN;
        public void Khoitao(string MaHV, string HoTen, string Gioitinh, string SDT, string Email, string NgaySinh)
        {
            this.MaHV = MaHV;
            this.HoTen = HoTen;
            this.Gioitinh = Gioitinh;
            this.SDT = SDT;
            this.Email = Email;
            this.ngaySinh = DateTime.Parse(NgaySinh);
            this.DiemThiTN = 0;
        }
        public DTO_HOCVIEN(string maHV, string tenHV, string gioiTinh, string sDT, string email, DateTime NgaySinh, int diemThiTN)
        {
            MaHV = maHV;
            HoTen = tenHV;
            Gioitinh = gioiTinh;
            SDT = sDT;
            Email = email;
            ngaySinh = NgaySinh;
            DiemThiTN = diemThiTN;
        }
        public DTO_HOCVIEN()
        {

        }

        public string MaHV1 { get => MaHV; set => MaHV = value; }
        public string TenHV1 { get => HoTen; set => HoTen = value; }
        public string GioiTinh1 { get => Gioitinh; set => Gioitinh = value; }
        public string SDT1 { get => SDT; set => SDT = value; }
        public string Email1 { get => Email; set => Email = value; }
        public DateTime NgaySinh1 { get => ngaySinh; set => ngaySinh = value; }
        public int DiemThiTN1 { get => DiemThiTN; set => DiemThiTN = value; }

        public string MaHV;
        public string HoTen;
        public string Gioitinh;
        public string SDT;
        public string Email;
        public DateTime ngaySinh;
        public int DiemThiTN;
       
      

    }
}
