using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsSQL.DTO
{
    class BenhNhanDTO
    {
        int id;
        string hoTen;
        string gioiTinh;
        int namSinh;
        string diaChi;

        public BenhNhanDTO(int id, string hoTen, string gioiTinh, int namSinh, string diaChi)
        {
            this.id = id;
            this.hoTen = hoTen;
            this.gioiTinh = gioiTinh;
            this.namSinh = namSinh;
            this.diaChi = diaChi;
        }

        public int Id { get => id; set => id = value; }
        public string HoTen { get => hoTen; set => hoTen = value; }
        public string GioiTinh { get => gioiTinh; set => gioiTinh = value; }
        public int NamSinh { get => namSinh; set => namSinh = value; }
        public string DiaChi { get => diaChi; set => diaChi = value; }
    }
}
