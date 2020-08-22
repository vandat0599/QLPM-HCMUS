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

        public bool create(BenhNhanDTO t)
        {
            string cmd = "insert into BENH_NHAN(Ho_ten,Gioi_tinh,Nam_sinh,Dia_chi) values (@Ho_ten,@Gioi_tinh,@Nam_sinh,@Dia_chi)";
            List<SqlParameter> sqlParameters = new List<SqlParameter>();
            SqlParameter paramHo_ten = new SqlParameter("Ho_ten", t.HoTen);
            SqlParameter paramGioi_tinh = new SqlParameter("Gioi_tinh", t.GioiTinh);
            SqlParameter paramNam_sinh = new SqlParameter("Nam_sinh", t.NamSinh);
            SqlParameter paramDia_chi = new SqlParameter("Dia_chi", t.DiaChi);
            sqlParameters.Add(paramHo_ten);
            sqlParameters.Add(paramGioi_tinh);
            sqlParameters.Add(paramNam_sinh);
            sqlParameters.Add(paramDia_chi);
            return dp.ExecuteNonQuery(cmd, sqlParameters);
        }

        public bool update(BenhNhanDTO t)
        {
            string cmd = "update BENH_NHAN set Ho_ten = @Ho_ten, Gioi_tinh = @Gioi_tinh, Nam_sinh = @Nam_sinh, Dia_chi = @Dia_chi where ID_benh_nhan = @id";
            List<SqlParameter> sqlParameters = new List<SqlParameter>();
            SqlParameter paramHo_ten = new SqlParameter("Ho_ten", t.HoTen);
            SqlParameter paramGioi_tinh = new SqlParameter("Gioi_tinh", t.GioiTinh);
            SqlParameter paramNam_sinh = new SqlParameter("Nam_sinh", t.NamSinh);
            SqlParameter paramDia_chi = new SqlParameter("Dia_chi", t.DiaChi);
            SqlParameter paramId = new SqlParameter("id", t.Id);
            sqlParameters.Add(paramHo_ten);
            sqlParameters.Add(paramGioi_tinh);
            sqlParameters.Add(paramNam_sinh);
            sqlParameters.Add(paramDia_chi);
            sqlParameters.Add(paramId);
            return dp.ExecuteNonQuery(cmd, sqlParameters);
        }

        public List<BenhNhanDTO> getAll()
        {
            string cmd = "select * from BENH_NHAN";
            DataTable data = dp.ExecuteQuery(cmd);
            List<BenhNhanDTO> result = new List<BenhNhanDTO>();
            foreach(DataRow row in data.Rows)
            {
                result.Add(new BenhNhanDTO(
                    id: Convert.ToInt32(row["ID_benh_nhan"]), 
                    hoTen: row["Ho_ten"].ToString(), 
                    gioiTinh: row["Gioi_tinh"].ToString(), 
                    namSinh: Convert.ToInt32(row["Nam_sinh"]), 
                    diaChi: row["Dia_chi"].ToString()
                    ));
            }
            return result;

        }

        public bool delete(BenhNhanDTO t)
        {
            string cmd = "DELETE FROM BENH_NHAN WHERE ID_benh_nhan = @id";
            List<SqlParameter> sqlParameters = new List<SqlParameter>();
            SqlParameter idParam = new SqlParameter("id", t.Id);
            sqlParameters.Add(idParam);
            return dp.ExecuteNonQuery(cmd, sqlParameters);
        }

        public BenhNhanDTO getById(int id)
        {
            string cmd = "select * from BENH_NHAN where ID_benh_nhan = @id";
            DataTable data = dp.ExecuteQuery(cmd);
            if (data.Rows.Count <= 0)
            {
                return null;
            }
            DataRow row = data.Rows[0];
            return new BenhNhanDTO(
                    id: Convert.ToInt32(row["ID_benh_nhan"]),
                    hoTen: row["Ho_ten"].ToString(),
                    gioiTinh: row["Gioi_tinh"].ToString(),
                    namSinh: Convert.ToInt32(row["Nam_sinh"]),
                    diaChi: row["Dia_chi"].ToString()
                    );

        }
    }
}
