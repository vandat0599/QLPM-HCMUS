using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsSQL.DAO;
using WindowsSQL.DTO;

namespace WindowsSQL
{


    class PhieuKhamBenhDAO : DAO<PhieuKhamBenhDTO>
    {

        DataProvider dp;
        public PhieuKhamBenhDAO()
        {
            dp = new DataProvider();
        }
        public bool create(PhieuKhamBenhDTO t)
        {
            string cmd = "insert into PHIEU_KHAM_BENH(ID_phieu_kham_benh,ID_benh_nhan,Ngay,Trieu_chung,ID_loai_benh) values (@ID_phieu_kham_benh,@ID_benh_nhan,@Ngay,@Trieu_chung,@ID_loai_benh)";
            List<SqlParameter> sqlParameters = new List<SqlParameter>();
            SqlParameter p1 = new SqlParameter("ID_phieu_kham_benh", t.Id);
            SqlParameter p2 = new SqlParameter("ID_benh_nhan", t.IdBenhNhan);
            SqlParameter p3 = new SqlParameter("Ngay", t.Ngay);
            SqlParameter p4 = new SqlParameter("Trieu_chung", t.TrieuChung);
            SqlParameter p5 = new SqlParameter("ID_loai_benh", t.IdLoaiBenh);
            sqlParameters.Add(p1);
            sqlParameters.Add(p2);
            sqlParameters.Add(p3);
            sqlParameters.Add(p4);
            sqlParameters.Add(p5);
            return dp.ExecuteNonQuery(cmd, sqlParameters);
        }

        public bool delete(PhieuKhamBenhDTO t)
        {
            string cmd = "DELETE FROM PHIEU_KHAM_BENH WHERE ID_phieu_kham_benh = @id";
            List<SqlParameter> sqlParameters = new List<SqlParameter>();
            SqlParameter idParam = new SqlParameter("id", t.Id);
            sqlParameters.Add(idParam);
            return dp.ExecuteNonQuery(cmd, sqlParameters);
        }

        public List<PhieuKhamBenhDTO> getAll()
        {
            string cmd = "select * from PHIEU_KHAM_BENH";
            DataTable data = dp.ExecuteQuery(cmd);
            List<PhieuKhamBenhDTO> result = new List<PhieuKhamBenhDTO>();
            foreach (DataRow row in data.Rows)
            {
                result.Add(new PhieuKhamBenhDTO(
                    id: 0,
                    idBenhNhan: Convert.ToInt32(row["ID_benh_nhan"]),
                    ngay: Convert.ToDateTime(row["Ngay"]),
                    trieuChung: row["Trieu_chung"].ToString(),
                    idLoaiBenh: Convert.ToInt32(row["ID_loai_benh"])
                    ));
            }
            return result;
        }

        public PhieuKhamBenhDTO getById(int id)
        {
            string cmd = "select * from PHIEU_KHAM_BENH where ID_phieu_kham_benh = @id";
            DataTable data = dp.ExecuteQuery(cmd);
            if (data.Rows.Count <= 0)
            {
                return null;
            }
            DataRow row = data.Rows[0];
            return new PhieuKhamBenhDTO(
                    id: 0,
                    idBenhNhan: Convert.ToInt32(row["ID_benh_nhan"]),
                    ngay: Convert.ToDateTime(row["Ngay"]),
                    trieuChung: row["Trieu_chung"].ToString(),
                    idLoaiBenh: Convert.ToInt32(row["ID_loai_benh"])
                    );
        }

        public bool update(PhieuKhamBenhDTO t)
        {
            string cmd = "update PHIEU_KHAM_BENH set ID_benh_nhan = @ID_benh_nhan, Ngay = @Ngay, Trieu_chung = @Trieu_chung, ID_loai_benh = @ID_loai_benh where ID_phieu_kham_benh = @id";
            List<SqlParameter> sqlParameters = new List<SqlParameter>();
            SqlParameter p1 = new SqlParameter("id", t.Id);
            SqlParameter p2 = new SqlParameter("ID_benh_nhan", t.IdBenhNhan);
            SqlParameter p3 = new SqlParameter("Ngay", t.Ngay);
            SqlParameter p4 = new SqlParameter("Trieu_chung", t.TrieuChung);
            SqlParameter p5 = new SqlParameter("ID_loai_benh", t.IdLoaiBenh);
            sqlParameters.Add(p1);
            sqlParameters.Add(p2);
            sqlParameters.Add(p3);
            sqlParameters.Add(p4);
            sqlParameters.Add(p5);
            return dp.ExecuteNonQuery(cmd, sqlParameters);
        }
    }
}
