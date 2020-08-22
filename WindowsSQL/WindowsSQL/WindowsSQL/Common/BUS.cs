using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsSQL.Common
{
    interface BUS<T>
    {
        void create(T t);
        void update(T t);
        List<T> getAll();
        void delete(T t);
    }
}
