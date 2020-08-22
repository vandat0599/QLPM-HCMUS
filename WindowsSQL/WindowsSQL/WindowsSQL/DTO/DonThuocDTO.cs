using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsSQL.DTO
{
    class DonThuocDTO
    {
        int id;
        int idPhieuKhamBenh;
        int soLuong;

        public DonThuocDTO(int id, int idPhieuKhamBenh, int soLuong)
        {
            this.id = id;
            this.idPhieuKhamBenh = idPhieuKhamBenh;
            this.soLuong = soLuong;
        }

        public int Id { get => id; set => id = value; }
        public int IdPhieuKhamBenh { get => idPhieuKhamBenh; set => idPhieuKhamBenh = value; }
        public int SoLuong { get => soLuong; set => soLuong = value; }
    }
}
