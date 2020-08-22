using System;
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
        int idDonViTinh;
        int idCachDung;
        double giaDonVi;

        public ThuocDTO(string tenThuoc, int id, int idDonViTinh, int idCachDung, double giaDonVi)
        {
            this.tenThuoc = tenThuoc;
            this.id = id;
            this.idDonViTinh = idDonViTinh;
            this.idCachDung = idCachDung;
            this.giaDonVi = giaDonVi;
        }

        public string TenThuoc { get => tenThuoc; set => tenThuoc = value; }
        public int Id { get => id; set => id = value; }
        public int IdDonViTinh { get => idDonViTinh; set => idDonViTinh = value; }
        public int IdCachDung { get => idCachDung; set => idCachDung = value; }
        public double GiaDonVi { get => giaDonVi; set => giaDonVi = value; }
    }
}
