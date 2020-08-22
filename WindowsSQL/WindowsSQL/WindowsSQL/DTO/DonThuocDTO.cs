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

        public int Id { get => id; set => id = value; }
        public int IdPhieuKhamBenh { get => idPhieuKhamBenh; set => idPhieuKhamBenh = value; }
        public int SoLuong { get => soLuong; set => soLuong = value; }
    }
}
