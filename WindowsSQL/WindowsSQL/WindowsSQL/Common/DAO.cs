using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsSQL.DAO
{
    interface DAO<T>
    {
        bool create(T t);
        bool update(T t);
        List<T> getAll();
        T getById(int id);
        bool delete(T t);
    }
}
