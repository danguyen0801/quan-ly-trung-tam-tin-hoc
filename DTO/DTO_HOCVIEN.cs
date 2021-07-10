using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_HOCVIEN
    {
        private string MaHV;
        private string HoTenHV;
        private string GioiTinh;
        private string SoDT;
        private DateTime NgaySinh;
        private string Email;
        private int DiemThiTN;

        public string MAHV
        {
            get { return MaHV; }
            set { MaHV = value; }
        }
        public string HOTENHV
        {
            get { return HoTenHV; }
            set { HoTenHV = value; }
        }
        public string GIOITINH
        {
            get { return GioiTinh; }
            set { GioiTinh = value; }
        }    
        public string SDT
        {
            get { return SoDT; }
            set { SoDT = value; }
        }        
        public DateTime NGAYSINH
        {
            get { return NgaySinh; }
            set { NgaySinh = value; }
        }      
        public string EMAIL
        {
            get { return Email; }
            set { Email = value; }
        }      
        public int DIEMTHITN
        {
            get { return DiemThiTN; }
            set { DiemThiTN = value; }
        }
        public DTO_HOCVIEN(string MaHV, string HoTenHV, string GioiTinh, string SoDT, DateTime NgaySinh, string Email, int DiemThiTN)
        {
            this.MaHV = MaHV;
            this.HoTenHV = HoTenHV;
            this.GioiTinh = GioiTinh;
            this.SoDT = SoDT;
            this.NgaySinh = NgaySinh;
            this.Email = Email;
            this.DiemThiTN = DiemThiTN;
        }
    }
}
