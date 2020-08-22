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

        public QuyDinhDTO(string loai, int soLuong)
        {
            this.loai = loai;
            this.soLuong = soLuong;
        }

        public string Loai { get => loai; set => loai = value; }
        public int SoLuong { get => soLuong; set => soLuong = value; }
    }
}
