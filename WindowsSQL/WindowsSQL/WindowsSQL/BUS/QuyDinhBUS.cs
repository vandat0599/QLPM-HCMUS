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
    class QuyDinhBUS : BUS<QuyDinhDTO>
    {

        QuyDinhDAO dao;

        public QuyDinhBUS()
        {
            dao = new QuyDinhDAO();
        }
        public bool create(QuyDinhDTO t)
        {
            return dao.create(t);
        }

        public bool delete(QuyDinhDTO t)
        {
            return dao.delete(t);
        }

        public List<QuyDinhDTO> getAll()
        {
            return dao.getAll();
        }

        public QuyDinhDTO getById(int id)
        {
            return dao.getById(id);
        }

        public bool update(QuyDinhDTO t)
        {
            return dao.update(t);
        }
    }
}
