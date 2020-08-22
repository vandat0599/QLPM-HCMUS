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
    class LoaiBenhDAO : DAO<LoaiBenhDTO>
    {
        DataProvider dp;
        public LoaiBenhDAO()
        {
            dp = new DataProvider();
        }
        public bool create(LoaiBenhDTO t)
        {
            string cmd = "insert into LOAI_BENH(ID_loai_benh,Loai_benh) values (@ID_loai_benh,@Loai_benh)";
            List<SqlParameter> sqlParameters = new List<SqlParameter>();
            SqlParameter p1 = new SqlParameter("ID_loai_benh", t.Id);
            SqlParameter p2 = new SqlParameter("Loai_benh", t.LoaiBenh);
            sqlParameters.Add(p1);
            sqlParameters.Add(p2);
            return dp.ExecuteNonQuery(cmd, sqlParameters);
        }

        public bool delete(LoaiBenhDTO t)
        {
            string cmd = "DELETE FROM LOAI_BENH WHERE ID_loai_benh = @id";
            List<SqlParameter> sqlParameters = new List<SqlParameter>();
            SqlParameter idParam = new SqlParameter("id", t.Id);
            sqlParameters.Add(idParam);
            return dp.ExecuteNonQuery(cmd, sqlParameters);
        }

        public List<LoaiBenhDTO> getAll()
        {
            string cmd = "select * from LOAI_BENH";
            DataTable data = dp.ExecuteQuery(cmd);
            List<LoaiBenhDTO> result = new List<LoaiBenhDTO>();
            foreach (DataRow row in data.Rows)
            {
                result.Add(new LoaiBenhDTO(
                    id: 0,
                    loaiBenh: row["Loai_benh"].ToString())
                    );
            }
            return result;
        }

        public LoaiBenhDTO getById(int id)
        {
            string cmd = "select * from LOAI_BENH where ID_loai_benh = @id";
            DataTable data = dp.ExecuteQuery(cmd);
            if (data.Rows.Count <= 0)
            {
                return null;
            }
            DataRow row = data.Rows[0];
            return new LoaiBenhDTO(
                    id: 0,
                    loaiBenh: row["Loai_benh"].ToString()
                    );
        }

        public bool update(LoaiBenhDTO t)
        {
            string cmd = "update LOAI_BENH set Loai_benh = @Loai_benh where ID_loai_benh = @id";
            List<SqlParameter> sqlParameters = new List<SqlParameter>();
            SqlParameter p1 = new SqlParameter("Loai_benh", t.LoaiBenh);
            SqlParameter p2 = new SqlParameter("id", t.Id);
            sqlParameters.Add(p1);
            sqlParameters.Add(p2);
            return dp.ExecuteNonQuery(cmd, sqlParameters);
        }
    }
}
