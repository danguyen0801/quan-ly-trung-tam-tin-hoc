﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_BANGDIEM
    {
        private string MaHV;
        private string MaMonHoc;
        private int Diem;
        private bool IsPass;      
        private int SoLanthi;

        public DTO_BANGDIEM(string maHV, string maMonHoc, int diem, bool isPass, int soLanthi)
        {
            MaHV = maHV;
            MaMonHoc = maMonHoc;
            Diem = diem;
            IsPass = isPass;
            SoLanthi = soLanthi;
        }

        public string MaHV1 { get => MaHV; set => MaHV = value; }
        public string MaMonHoc1 { get => MaMonHoc; set => MaMonHoc = value; }
        public int Diem1 { get => Diem; set => Diem = value; }
        public bool IsPass1 { get => IsPass; set => IsPass = value; }
        public int SoLanthi1 { get => SoLanthi; set => SoLanthi = value; }
    }
}
