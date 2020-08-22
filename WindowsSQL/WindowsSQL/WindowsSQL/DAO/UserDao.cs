using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsSQL;
using WindowsSQL.DAO;
using WindowsSQL.DTO;

namespace DAO
{
    class UserDAO: DAO<UserDTO>
    {
        DataProvider dp;
        public UserDAO()
        {
            dp = new DataProvider();
        }

        public bool create(UserDTO t)
        {
            throw new NotImplementedException();
        }

        public bool delete(UserDTO t)
        {
            throw new NotImplementedException();
        }

        public List<UserDTO> getAll()
        {
            throw new NotImplementedException();
        }

        public UserDTO getById(int id)
        {
            throw new NotImplementedException();
        }

        public DataTable kiemTraChuPhongMach(string Ten_dang_nhap,string Mat_khau)
        {
            string cmd = "select La_chu_phong_mach from USERS where Ten_dang_nhap = @Ten_dang_nhap and Mat_khau = @Mat_khau";
            List<SqlParameter> sqlParameters = new List<SqlParameter>();
            SqlParameter paramDang_nhap = new SqlParameter("Ten_dang_nhap", Ten_dang_nhap);
            SqlParameter paramMat_khau = new SqlParameter("Mat_khau", Mat_khau);
            sqlParameters.Add(paramDang_nhap);
            sqlParameters.Add(paramMat_khau);
            return dp.ExecuteQuery(cmd, sqlParameters);
        }

        public bool update(UserDTO t)
        {
            throw new NotImplementedException();
        }
    }
}
