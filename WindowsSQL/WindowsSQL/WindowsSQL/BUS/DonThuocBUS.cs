using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsSQL.Common;
using WindowsSQL.DAO;
using WindowsSQL.DTO;

namespace WindowsSQL.BUS
{
    class DonThuocBUS : BUS<DonThuocDTO>
    {

        DonThuocDAO dao;

        public DonThuocBUS()
        {
            dao = new DonThuocDAO();
        }

        public bool create(DonThuocDTO t)
        {
            t.Id = dao.getAll().Count + 1;
            return dao.create(t);
        }

        public bool delete(DonThuocDTO t)
        {
            return dao.delete(t);
        }

        public List<DonThuocDTO> getAll()
        {
            return dao.getAll();
        }

        public DonThuocDTO getById(int id)
        {
            return dao.getById(id);
        }

        public bool update(DonThuocDTO t)
        {
            return dao.update(t);
        }
    }
}
