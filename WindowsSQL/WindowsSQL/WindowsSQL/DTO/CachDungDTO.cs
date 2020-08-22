using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsSQL.DTO
{
    class CachDungDTO
    {
        int id;
        string cachDung;

        public CachDungDTO(int id, string cachDung)
        {
            this.id = id;
            this.cachDung = cachDung;
        }

        public int Id { get => id; set => id = value; }
        public string CachDung { get => cachDung; set => cachDung = value; }
    }
}
