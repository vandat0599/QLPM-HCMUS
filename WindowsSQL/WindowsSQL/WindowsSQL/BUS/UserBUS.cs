using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsSQL.Common;
using WindowsSQL.DTO;

namespace WindowsSQL.BUS
{
    class UserBUS : BUS<UserDTO>
    {
        public UserDTO getById(int id)
        {
            throw new NotImplementedException();
        }

        void BUS<UserDTO>.create(UserDTO t)
        {
            throw new NotImplementedException();
        }

        void BUS<UserDTO>.delete(UserDTO t)
        {
            throw new NotImplementedException();
        }

        List<UserDTO> BUS<UserDTO>.getAll()
        {
            throw new NotImplementedException();
        }

        void BUS<UserDTO>.update(UserDTO t)
        {
            throw new NotImplementedException();
        }
    }
}
