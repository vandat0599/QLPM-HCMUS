using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsSQL.DTO;

namespace WindowsSQL.DAO
{
    class DonThuocDAO : DAO<DonThuocDTO>
    {

        DataProvider dp;
        public DonThuocDAO()
        {
            dp = new DataProvider();
        }

        public bool create(DonThuocDTO t)
        {
            string cmd = "insert into DON_THUOC(ID_thuoc,ID_phieu_kham_benh,So_luong) values (@ID_thuoc,@ID_phieu_kham_benh,@So_luong)";
            List<SqlParameter> sqlParameters = new List<SqlParameter>();
            SqlParameter p1 = new SqlParameter("ID_thuoc", t.Id);
            SqlParameter p2 = new SqlParameter("ID_phieu_kham_benh", t.IdPhieuKhamBenh);
            SqlParameter p3 = new SqlParameter("So_luong", t.SoLuong);
            sqlParameters.Add(p1);
            sqlParameters.Add(p2);
            sqlParameters.Add(p3);
            return dp.ExecuteNonQuery(cmd, sqlParameters);
        }

        public bool delete(DonThuocDTO t)
        {
            string cmd = "DELETE FROM DON_THUOC WHERE ID_thuoc = @id";
            List<SqlParameter> sqlParameters = new List<SqlParameter>();
            SqlParameter idParam = new SqlParameter("id", t.Id);
            sqlParameters.Add(idParam);
            return dp.ExecuteNonQuery(cmd, sqlParameters);
        }

        public List<DonThuocDTO> getAll()
        {
            string cmd = "select * from DON_THUOC";
            DataTable data = dp.ExecuteQuery(cmd);
            List<DonThuocDTO> result = new List<DonThuocDTO>();
            foreach (DataRow row in data.Rows)
            {
                result.Add(new DonThuocDTO(
                    id: 0,
                    idPhieuKhamBenh: Convert.ToInt32(row["ID_phieu_kham_benh"]),
                    soLuong: Convert.ToInt32(row["So_luong"])
                    ));
            }
            return result;
        }

        public DonThuocDTO getById(int id)
        {
            string cmd = "select * from DON_THUOC where ID_thuoc = @id";
            DataTable data = dp.ExecuteQuery(cmd);
            if (data.Rows.Count <= 0)
            {
                return null;
            }
            DataRow row = data.Rows[0];
            return new DonThuocDTO(
                    id: 0,
                    idPhieuKhamBenh: Convert.ToInt32(row["ID_phieu_kham_benh"]),
                    soLuong: Convert.ToInt32(row["So_luong"])
                    );
        }

        public bool update(DonThuocDTO t)
        {
            string cmd = "update DON_THUOC set ID_phieu_kham_benh = @ID_phieu_kham_benh, So_luong = @So_luong where ID_thuoc = @id";
            List<SqlParameter> sqlParameters = new List<SqlParameter>();
            SqlParameter p1 = new SqlParameter("ID_phieu_kham_benh", t.IdPhieuKhamBenh);
            SqlParameter p2 = new SqlParameter("So_luong", t.SoLuong);
            SqlParameter p3 = new SqlParameter("id", t.Id);

            sqlParameters.Add(p1);
            sqlParameters.Add(p2);
            sqlParameters.Add(p3);
            return dp.ExecuteNonQuery(cmd, sqlParameters);
        }
    }
}
