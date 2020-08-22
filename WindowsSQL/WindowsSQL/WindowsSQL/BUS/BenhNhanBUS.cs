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
    class BenhNhanBUS : BUS<BenhNhanDTO>
    {

        BenhNhanDAO dao;

        public BenhNhanBUS()
        {
            dao = new BenhNhanDAO();
        }

        public bool create(BenhNhanDTO t)
        {
            t.Id = dao.getAll().Count + 1;
            return dao.create(t);
        }

        public bool delete(BenhNhanDTO t)
        {
            return dao.delete(t);
        }

        public List<BenhNhanDTO> getAll()
        {
            return dao.getAll();
        }

        public BenhNhanDTO getById(int id)
        {
            return dao.getById(id);
        }

        public bool update(BenhNhanDTO t)
        {
            return dao.update(t);
        }
    }
}
