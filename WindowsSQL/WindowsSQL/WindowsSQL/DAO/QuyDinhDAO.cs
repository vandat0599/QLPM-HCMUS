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
    class QuyDinhDAO: DAO<QuyDinhDTO>
    {
        DataProvider dp;
        public QuyDinhDAO()
        {
            dp = new DataProvider();
        }

        public bool create(QuyDinhDTO t)
        {
            string cmd = "insert into QUY_DINH(Loai,So_luong) values (@Loai,@So_luong)";
            List<SqlParameter> sqlParameters = new List<SqlParameter>();
            SqlParameter p1 = new SqlParameter("Loai", t.Loai);
            SqlParameter p2 = new SqlParameter("So_luong", t.SoLuong);
            sqlParameters.Add(p1);
            sqlParameters.Add(p2);
            return dp.ExecuteNonQuery(cmd, sqlParameters);
        }

        public bool update(QuyDinhDTO t)
        {
            string cmd = "update QUY_DINH set So_luong = @So_luong where Loai = @Loai";
            List<SqlParameter> sqlParameters = new List<SqlParameter>();
            SqlParameter p1 = new SqlParameter("So_luong", t.SoLuong);
            SqlParameter p2 = new SqlParameter("Loai", t.Loai);
            sqlParameters.Add(p1);
            sqlParameters.Add(p2);
            return dp.ExecuteNonQuery(cmd, sqlParameters);
        }

        public List<QuyDinhDTO> getAll()
        {
            string cmd = "select * from QUY_DINH";
            DataTable data = dp.ExecuteQuery(cmd);
            List<QuyDinhDTO> result = new List<QuyDinhDTO>();
            foreach (DataRow row in data.Rows)
            {
                result.Add(new QuyDinhDTO(
                    loai: row["Loai"].ToString(),
                    soLuong: Convert.ToInt32(row["So_luong"]))
                    );
            }
            return result;
        }

        public bool delete(QuyDinhDTO t)
        {
            string cmd = "DELETE FROM QUY_DINH WHERE Loai = @Loai";
            List<SqlParameter> sqlParameters = new List<SqlParameter>();
            SqlParameter idParam = new SqlParameter("Loai", t.Loai);
            sqlParameters.Add(idParam);
            return dp.ExecuteNonQuery(cmd, sqlParameters);
        }

        public QuyDinhDTO getById(int id)
        {
            string cmd = "select * from PHIEU_KHAM_BENH where ID_phieu_kham_benh = @id";
            DataTable data = dp.ExecuteQuery(cmd);
            if (data.Rows.Count <= 0)
            {
                return null;
            }
            DataRow row = data.Rows[0];
            return new QuyDinhDTO(
                    loai: row["Loai"].ToString(),
                    soLuong: Convert.ToInt32(row["So_luong"]));
        }
    }
}
