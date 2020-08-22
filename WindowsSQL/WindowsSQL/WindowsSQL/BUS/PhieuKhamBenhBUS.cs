using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsSQL.Common;
using WindowsSQL.DTO;

namespace WindowsSQL.BUS
{
    class PhieuKhamBenhBUS : BUS<PhieuKhamBenhDTO>
    {

        PhieuKhamBenhDAO dao;

        public PhieuKhamBenhBUS()
        {
            dao = new PhieuKhamBenhDAO();
        }
        public bool create(PhieuKhamBenhDTO t)
        {
            t.Id = dao.getAll().Count + 1;
            return dao.create(t);
        }

        public bool delete(PhieuKhamBenhDTO t)
        {
            return dao.delete(t);
        }

        public List<PhieuKhamBenhDTO> getAll()
        {
            return dao.getAll();
        }

        public PhieuKhamBenhDTO getById(int id)
        {
            return dao.getById(id);
        }

        public bool update(PhieuKhamBenhDTO t)
        {
            return dao.update(t);
        }
    }
}
