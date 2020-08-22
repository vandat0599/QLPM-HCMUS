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
    class ThuocBUS : BUS<ThuocDTO>
    {

        ThuocDAO dao;

        public ThuocBUS()
        {
            dao = new ThuocDAO();
        }

        public bool create(ThuocDTO t)
        {
            t.Id = dao.getAll().Count + 1;
            return dao.create(t);
        }

        public bool delete(ThuocDTO t)
        {
            return dao.delete(t);
        }

        public List<ThuocDTO> getAll()
        {
            return dao.getAll();
        }

        public ThuocDTO getById(int id)
        {
            return dao.getById(id);
        }

        public bool update(ThuocDTO t)
        {
            return dao.update(t);
        }
    }
}
