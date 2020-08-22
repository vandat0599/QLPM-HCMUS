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
    class LoaiBenhBUS : BUS<LoaiBenhDTO>
    {

        LoaiBenhDAO dao;

        public LoaiBenhBUS()
        {
            dao = new LoaiBenhDAO();
        }

        public bool create(LoaiBenhDTO t)
        {
            t.Id = dao.getAll().Count + 1;
            return dao.create(t);
        }

        public bool delete(LoaiBenhDTO t)
        {
            return dao.delete(t);
        }

        public List<LoaiBenhDTO> getAll()
        {
            return dao.getAll();
        }

        public LoaiBenhDTO getById(int id)
        {
            return dao.getById(id);
        }

        public bool update(LoaiBenhDTO t)
        {
            return dao.update(t);
        }
    }
}
