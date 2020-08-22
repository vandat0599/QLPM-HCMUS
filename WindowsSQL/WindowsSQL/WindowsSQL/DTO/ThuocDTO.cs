﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsSQL.DTO
{
    class ThuocDTO
    {
        string tenThuoc;
        int id;
        int donViTinh;
        int idCachDung;
        float giaDonVi;

        public string TenThuoc { get => tenThuoc; set => tenThuoc = value; }
        public int IdThuoc { get => id; set => id = value; }
        public int DonViTinh { get => donViTinh; set => donViTinh = value; }
        public int IdCachDung { get => idCachDung; set => idCachDung = value; }
        public float GiaDonVi { get => giaDonVi; set => giaDonVi = value; }
    }
}
