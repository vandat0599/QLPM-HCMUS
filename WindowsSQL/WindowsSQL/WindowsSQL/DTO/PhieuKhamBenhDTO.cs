using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsSQL.DTO
{
    class PhieuKhamBenhDTO
    {
        int id;
        int idBenhNhan;
        DateTime ngay;
        string trieuChung;
        int idLoaiBenh;

        public int Id { get => id; set => id = value; }
        public int IdBenhNhan { get => idBenhNhan; set => idBenhNhan = value; }
        public DateTime Ngay { get => ngay; set => ngay = value; }
        public string TrieuChung { get => trieuChung; set => trieuChung = value; }
        public int IdLoaiBenh { get => idLoaiBenh; set => idLoaiBenh = value; }
    }
}
