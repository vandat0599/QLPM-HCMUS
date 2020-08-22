using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsSQL;
using WindowsSQL.DTO;
using WindowsSQL.DAO;

namespace DAO
{
    class BenhNhanDAO : DAO<BenhNhanDTO>
    {
        DataProvider dp;
        public BenhNhanDAO()
        {
            dp = new DataProvider();
        }
        public bool themBenhNhan(string Ten_benh_nhan,string Gioi_tinh,int Nam_sinh,string Dia_chi)
        {
            QuyDinhDAO _QDD = new QuyDinhDAO();
            int max = _QDD.getMaxBenhNhan();
            DataTable dt = danhSachBenhNhan();
            if (dt.Rows.Count >= max)
                return false;

            string cmd = "insert into BENH_NHAN(Ho_ten,Gioi_tinh,Nam_sinh,Dia_chi) values (@Ho_ten,@Gioi_tinh,@Nam_sinh,@Dia_chi)";
            List<SqlParameter> sqlParameters = new List<SqlParameter>();
            SqlParameter paramHo_ten = new SqlParameter("Ho_ten", Ten_benh_nhan);
            SqlParameter paramGioi_tinh = new SqlParameter("Gioi_tinh", Gioi_tinh);
            SqlParameter paramNam_sinh = new SqlParameter("Nam_sinh", Nam_sinh);
            SqlParameter paramDia_chi = new SqlParameter("Dia_chi", Dia_chi);
            sqlParameters.Add(paramHo_ten);
            sqlParameters.Add(paramGioi_tinh);
            sqlParameters.Add(paramNam_sinh);
            sqlParameters.Add(paramDia_chi);
            return dp.ExecuteNonQuery(cmd, sqlParameters);
        }
        public DataTable danhSachBenhNhan()
        {
            string cmd = "select * from BENH_NHAN";
            return dp.ExecuteQuery(cmd);
        }

        public void create(BenhNhanDTO t)
        {
            throw new NotImplementedException();
        }

        public void update(BenhNhanDTO t)
        {
            throw new NotImplementedException();
        }

        public List<BenhNhanDTO> getAll()
        {
            throw new NotImplementedException();
        }

        public void delete(BenhNhanDTO t)
        {
            throw new NotImplementedException();
        }

        public BenhNhanDTO getById(int id)
        {
            throw new NotImplementedException();
        }
    }
}
