using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsSQL.DTO
{
    class LoaiBenhDTO
    {
        int id;
        string loaiBenh;

        public int Id { get => id; set => id = value; }
        public string LoaiBenh { get => loaiBenh; set => loaiBenh = value; }
    }
}
