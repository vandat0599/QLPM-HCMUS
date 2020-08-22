using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsSQL.DAO;
using WindowsSQL.DTO;

namespace WindowsSQL
{
    class PhieuKhamBenhDAO: DAO<PhieuKhamBenhDTO>
    {
        DataProvider dp;
        public PhieuKhamBenhDAO()
        {
            dp = new DataProvider();
        }

        public void create(PhieuKhamBenhDTO t)
        {
            throw new NotImplementedException();
        }

        public void delete(PhieuKhamBenhDTO t)
        {
            throw new NotImplementedException();
        }

        public List<PhieuKhamBenhDTO> getAll()
        {
            throw new NotImplementedException();
        }

        public PhieuKhamBenhDTO getById(int id)
        {
            throw new NotImplementedException();
        }

        public void update(PhieuKhamBenhDTO t)
        {
            throw new NotImplementedException();
        }
    }
}
