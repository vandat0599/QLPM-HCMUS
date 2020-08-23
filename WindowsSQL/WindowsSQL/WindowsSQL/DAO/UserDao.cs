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
            string cmd = "insert into USERS(Ho_ten,Ten_dang_nhap,Mat_khau,La_chu_phong_mach) values (@Ho_ten,@Ten_dang_nhap,@Mat_khau,@La_chu_phong_mach)";
            List<SqlParameter> sqlParameters = new List<SqlParameter>();
            SqlParameter p1 = new SqlParameter("Ho_ten", t.HoTen);
            SqlParameter p2 = new SqlParameter("Ten_dang_nhap", t.UserName);
            SqlParameter p3 = new SqlParameter("Mat_khau", t.PassWord);
            SqlParameter p4 = new SqlParameter("La_chu_phong_mach", t.IsChuPhongMach);
            sqlParameters.Add(p1);
            sqlParameters.Add(p2);
            sqlParameters.Add(p3);
            sqlParameters.Add(p4);
            return dp.ExecuteNonQuery(cmd, sqlParameters);
        }

        public bool delete(UserDTO t)
        {
            string cmd = "DELETE FROM USERS WHERE Ten_dang_nhap = @id";
            List<SqlParameter> sqlParameters = new List<SqlParameter>();
            SqlParameter idParam = new SqlParameter("id", t.UserName);
            sqlParameters.Add(idParam);
            return dp.ExecuteNonQuery(cmd, sqlParameters);
        }

        public List<UserDTO> getAll()
        {
            string cmd = "select * from USERS";
            DataTable data = dp.ExecuteQuery(cmd);
            List<UserDTO> result = new List<UserDTO>();
            foreach (DataRow row in data.Rows)
            {
                result.Add(new UserDTO(
                    hoTen: row["Ho_ten"].ToString(),
                    userName: row["Ten_dang_nhap"].ToString(),
                    passWord: row["Mat_khau"].ToString(),
                    isChuPhongMach: Convert.ToBoolean(row["La_chu_phong_mach"])
                    ));
            }
            return result;
        }

        public UserDTO getById(int id)
        {
            throw new NotImplementedException();
        }
           
        public UserDTO getUserByUserName(string userName)
        {
            string cmd = "select * from USERS where Ten_dang_nhap = @userName";
            List<SqlParameter> sqlParameters = new List<SqlParameter>();
            SqlParameter p1 = new SqlParameter("userName", userName);
            sqlParameters.Add(p1);
            DataTable data = dp.ExecuteQuery(cmd, sqlParameters);
            if (data.Rows.Count <= 0)
            {
                return null;
            }
            DataRow row = data.Rows[0];
            return new UserDTO(
                    hoTen: row["Ho_ten"].ToString(),
                    userName: row["Ten_dang_nhap"].ToString(),
                    passWord: row["Mat_khau"].ToString(),
                    isChuPhongMach: Convert.ToBoolean(row["La_chu_phong_mach"])
                    );
        }
       

        public bool update(UserDTO t)
        {
            string cmd = "update USERS set Mat_khau = @Mat_khau where Ten_dang_nhap = @id";
            List<SqlParameter> sqlParameters = new List<SqlParameter>();
            SqlParameter p1 = new SqlParameter("Mat_khau", t.PassWord);
            SqlParameter p2 = new SqlParameter("id", t.UserName);
            sqlParameters.Add(p1);
            sqlParameters.Add(p2);
            return dp.ExecuteNonQuery(cmd, sqlParameters);
        }
    }
}
