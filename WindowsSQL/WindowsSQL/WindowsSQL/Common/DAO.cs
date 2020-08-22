using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsSQL.DAO
{
    interface DAO<T>
    {
        void create(T t);
        void update(T t);
        List<T> getAll();
        T getById(int id);
        void delete(T t);
    }
}
