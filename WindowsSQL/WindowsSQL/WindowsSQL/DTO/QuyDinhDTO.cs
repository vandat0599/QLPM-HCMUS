using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsSQL.DTO
{
    class QuyDinhDTO
    {
        string loai;
        int soLuong;

        public string Loai { get => loai; set => loai = value; }
        public int SoLuong { get => soLuong; set => soLuong = value; }
    }
}
