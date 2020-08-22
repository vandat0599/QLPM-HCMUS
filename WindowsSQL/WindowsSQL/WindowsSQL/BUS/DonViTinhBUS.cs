using DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsSQL.Common;
using WindowsSQL.DTO;

namespace WindowsSQL.BUS
{
    class DonViTinhBUS : BUS<DonViTinhDTO>
    {
        DonViTinhDAO dao;

        public DonViTinhBUS()
        {
            dao = new DonViTinhDAO();
        }

        public bool create(DonViTinhDTO t)
        {
            t.Id = dao.getAll().Count + 1;
            return dao.create(t);
        }

        public bool delete(DonViTinhDTO t)
        {
            return dao.delete(t);
        }

        public List<DonViTinhDTO> getAll()
        {
            return dao.getAll();
        }

        public DonViTinhDTO getById(int id)
        {
            return dao.getById(id);
        }

        public bool update(DonViTinhDTO t)
        {
            return dao.update(t);
        }
    }
}
