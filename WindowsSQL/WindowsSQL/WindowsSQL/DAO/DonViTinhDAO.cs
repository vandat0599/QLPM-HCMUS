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
    class DonViTinhDAO : DAO<DonViTinhDTO>
    {
        DataProvider dp;
        public DonViTinhDAO()
        {
            dp = new DataProvider();
        }

        public bool create(DonViTinhDTO t)
        {
            string cmd = "insert into DON_VI_TINH(ID_don_vi_tinh,Don_vi_tinh) values (@ID_don_vi_tinh,@Don_vi_tinh)";
            List<SqlParameter> sqlParameters = new List<SqlParameter>();
            SqlParameter p1 = new SqlParameter("ID_don_vi_tinh", t.Id);
            SqlParameter p2 = new SqlParameter("Don_vi_tinh", t.DonViTinh);
            sqlParameters.Add(p1);
            sqlParameters.Add(p2);
            return dp.ExecuteNonQuery(cmd, sqlParameters);
        }

        public bool delete(DonViTinhDTO t)
        {
            string cmd = "DELETE FROM DON_VI_TINH WHERE ID_don_vi_tinh = @id";
            List<SqlParameter> sqlParameters = new List<SqlParameter>();
            SqlParameter idParam = new SqlParameter("id", t.Id);
            sqlParameters.Add(idParam);
            return dp.ExecuteNonQuery(cmd, sqlParameters);
        }

        public List<DonViTinhDTO> getAll()
        {
            string cmd = "select * from DON_VI_TINH";
            DataTable data = dp.ExecuteQuery(cmd);
            List<DonViTinhDTO> result = new List<DonViTinhDTO>();
            foreach (DataRow row in data.Rows)
            {
                result.Add(new DonViTinhDTO(
                    id: 0,
                    donViTinh: row["Don_vi_tinh"].ToString())
                    );
            }
            return result;
        }

        public DonViTinhDTO getById(int id)
        {
            string cmd = "select * from DON_VI_TINH where ID_don_vi_tinh = @id";
            DataTable data = dp.ExecuteQuery(cmd);
            if (data.Rows.Count <= 0)
            {
                return null;
            }
            DataRow row = data.Rows[0];
            return new DonViTinhDTO(
                    id: 0,
                    donViTinh: row["Don_vi_tinh"].ToString()
                    );
        }

        public bool update(DonViTinhDTO t)
        {
            string cmd = "update DON_VI_TINH set Don_vi_tinh = @Don_vi_tinh where ID_thuoc = @id";
            List<SqlParameter> sqlParameters = new List<SqlParameter>();
            SqlParameter p1 = new SqlParameter("Don_vi_tinh", t.DonViTinh);
            SqlParameter p2 = new SqlParameter("id", t.Id);
            sqlParameters.Add(p1);
            sqlParameters.Add(p2);
            return dp.ExecuteNonQuery(cmd, sqlParameters);
        }
    }
}
