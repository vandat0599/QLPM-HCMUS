using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsSQL.DTO
{
    class DonViTinhDTO
    {
        string donViTinh;
        int id;

        public DonViTinhDTO(string donViTinh, int id)
        {
            this.donViTinh = donViTinh;
            this.id = id;
        }

        public string DonViTinh { get => donViTinh; set => donViTinh = value; }
        public int Id { get => id; set => id = value; }
    }
}
