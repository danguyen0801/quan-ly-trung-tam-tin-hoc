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

        public DTO_HOCVIEN(string maHV, string tenHV, string gioiTinh, string sDT, string email, DateTime ngaySinh, int diemThiTN)
        {
            MaHV = maHV;
            TenHV = tenHV;
            GioiTinh = gioiTinh;
            SDT = sDT;
            Email = email;
            NgaySinh = ngaySinh;
            DiemThiTN = diemThiTN;
        }

        public string MaHV1 { get => MaHV; set => MaHV = value; }
        public string TenHV1 { get => TenHV; set => TenHV = value; }
        public string GioiTinh1 { get => GioiTinh; set => GioiTinh = value; }
        public string SDT1 { get => SDT; set => SDT = value; }
        public string Email1 { get => Email; set => Email = value; }
        public DateTime NgaySinh1 { get => NgaySinh; set => NgaySinh = value; }
        public int DiemThiTN1 { get => DiemThiTN; set => DiemThiTN = value; }

        public string MaHV;
        public string HoTen;
        public string Gioitinh;
        public string SDT;
        public string Email;
        public string NgaySinh;
        public int Diemthitotnghiep;
       
        public string MaHV1 { get => MaHV; set => MaHV = value; }

    }
}
