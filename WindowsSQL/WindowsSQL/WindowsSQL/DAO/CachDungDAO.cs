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
    class CachDungDAO : DAO<CachDungDTO>
    {

        DataProvider dp;
        public CachDungDAO()
        {
            dp = new DataProvider();
        }

        public bool create(CachDungDTO t)
        {
            string cmd = "insert into CACH_DUNG(ID_cach_dung,Cach_dung) values (@ID_cach_dung,@Cach_dung)";
            List<SqlParameter> sqlParameters = new List<SqlParameter>();
            SqlParameter p1 = new SqlParameter("ID_cach_dung", t.Id);
            SqlParameter p2 = new SqlParameter("Cach_dung", t.CachDung);
            sqlParameters.Add(p1);
            sqlParameters.Add(p2);
            return dp.ExecuteNonQuery(cmd, sqlParameters);
        }

        public bool delete(CachDungDTO t)
        {
            string cmd = "DELETE FROM CACH_DUNG WHERE ID_cach_dung = @id";
            List<SqlParameter> sqlParameters = new List<SqlParameter>();
            SqlParameter idParam = new SqlParameter("id", t.Id);
            sqlParameters.Add(idParam);
            return dp.ExecuteNonQuery(cmd, sqlParameters);
        }

        public List<CachDungDTO> getAll()
        {
            string cmd = "select * from CACH_DUNG";
            DataTable data = dp.ExecuteQuery(cmd);
            List<CachDungDTO> result = new List<CachDungDTO>();
            foreach (DataRow row in data.Rows)
            {
                result.Add(new CachDungDTO(
                    id: Convert.ToInt32(row["ID_cach_dung"]),
                    cachDung: row["Cach_dung"].ToString()
                    ));
            }
            return result;
        }

        public CachDungDTO getById(int id)
        {
            string cmd = "select * from CACH_DUNG where ID_cach_dung = @id";
            DataTable data = dp.ExecuteQuery(cmd);
            if (data.Rows.Count <= 0)
            {
                return null;
            }
            DataRow row = data.Rows[0];
            return new CachDungDTO(
                    id: Convert.ToInt32(row["ID_cach_dung"]),
                    cachDung: row["Cach_dung"].ToString()
                    );
        }

        public bool update(CachDungDTO t)
        {
            string cmd = "update CACH_DUNG set Cach_dung = @Cach_dung where ID_cach_dung = @id";
            List<SqlParameter> sqlParameters = new List<SqlParameter>();
            SqlParameter p1 = new SqlParameter("Cach_dung", t.CachDung);
            SqlParameter p2 = new SqlParameter("id", t.Id);
            sqlParameters.Add(p1);
            sqlParameters.Add(p2);
            return dp.ExecuteNonQuery(cmd, sqlParameters);
        }
    }
}
