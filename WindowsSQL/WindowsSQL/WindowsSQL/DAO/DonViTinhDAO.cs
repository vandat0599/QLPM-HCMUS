using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsSQL;
using WindowsSQL.DAO;
using WindowsSQL.DTO;

namespace DAO
{
    class DonViTinhDAO: DAO<DonViTinhDTO>
    {
        DataProvider dp;
        public DonViTinhDAO()
        {
            dp = new DataProvider();
        }

        public void create(DonViTinhDTO t)
        {
            throw new NotImplementedException();
        }

        public void delete(DonViTinhDTO t)
        {
            throw new NotImplementedException();
        }

        public List<DonViTinhDTO> getAll()
        {
            throw new NotImplementedException();
        }

        public void update(DonViTinhDTO t)
        {
            throw new NotImplementedException();
        }
    }
}
