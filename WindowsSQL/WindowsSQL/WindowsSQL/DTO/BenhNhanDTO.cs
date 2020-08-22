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
        string namSinh;
        string diaChi;

        public int Id { get => id; set => id = value; }
        public string HoTen { get => hoTen; set => hoTen = value; }
        public string GioiTinh { get => gioiTinh; set => gioiTinh = value; }
        public string NamSinh { get => namSinh; set => namSinh = value; }
        public string DiaChi { get => diaChi; set => diaChi = value; }
    }
}
