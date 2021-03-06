﻿using DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsSQL.Common;
using WindowsSQL.DTO;

namespace WindowsSQL.BUS
{
    class UserBUS : BUS<UserDTO>
    {

        UserDAO dao;

        public UserBUS()
        {
            dao = new UserDAO();
        }

        public bool kiemTraChuPhongMach(string userName, string passWord)
        {
            UserDTO user = dao.getUserByUserName(userName);
            return user != null && user.IsChuPhongMach;
        }

        public UserDTO getUserByUserName(string userName, string passWord)
        {
            return dao.getUserByUserName(userName);
        }

        public bool create(UserDTO t)
        {
            List<UserDTO> users = dao.getAll();
            foreach(UserDTO user in users)
            {
                if (user.UserName.Equals(t.UserName))
                {
                    return false;
                }
            }
            return dao.create(t);
        }

        public bool delete(UserDTO t)
        {
            return dao.delete(t);
        }

        public List<UserDTO> getAll()
        {
            return dao.getAll();
        }

        public UserDTO getById(int id)
        {
            return dao.getById(id);
        }

        public bool update(UserDTO t)
        {
            return dao.update(t);
        }
    }
}
