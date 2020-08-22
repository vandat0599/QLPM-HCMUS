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
    class CachDungBUS : BUS<CachDungDTO>
    {

        CachDungDAO dao;

        public CachDungBUS()
        {
            dao = new CachDungDAO();
        }

        public bool create(CachDungDTO t)
        {
            t.Id = dao.getAll().Count + 1;
            return dao.create(t);
        }

        public bool delete(CachDungDTO t)
        {
            return dao.delete(t);
        }

        public List<CachDungDTO> getAll()
        {
            return dao.getAll();
        }

        public CachDungDTO getById(int id)
        {
            return dao.getById(id);
        }

        public bool update(CachDungDTO t)
        {
            return dao.update(t);
        }
    }
}
