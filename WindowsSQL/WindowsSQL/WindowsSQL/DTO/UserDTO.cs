using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsSQL.DTO
{
    class UserDTO
    {
        string hoTen;
        string userName;
        string passWord;
        bool isChuPhongMach;

        public string HoTen { get => hoTen; set => hoTen = value; }
        public string UserName { get => userName; set => userName = value; }
        public string PassWord { get => passWord; set => passWord = value; }
        public bool IsChuPhongMach { get => isChuPhongMach; set => isChuPhongMach = value; }
    }
}
