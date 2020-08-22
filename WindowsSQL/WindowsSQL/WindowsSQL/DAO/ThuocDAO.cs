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
    class ThuocDAO : DAO<ThuocDTO>
    {

        DataProvider dp;
        public ThuocDAO()
        {
            dp = new DataProvider();
        }
        public bool create(ThuocDTO t)
        {
            string cmd = "insert into THUOC(Ten_thuoc,ID_thuoc,ID_don_vi_tinh,ID_cach_dung,Gia_don_vi) values (@Ten_thuoc,@ID_thuoc,@ID_don_vi_tinh,@ID_cach_dung,@Gia_don_vi)";
            List<SqlParameter> sqlParameters = new List<SqlParameter>();
            SqlParameter p1 = new SqlParameter("Ten_thuoc", t.TenThuoc);
            SqlParameter p2 = new SqlParameter("ID_thuoc", t.Id);
            SqlParameter p3 = new SqlParameter("ID_don_vi_tinh", t.IdDonViTinh);
            SqlParameter p4 = new SqlParameter("ID_cach_dung", t.IdCachDung);
            SqlParameter p5 = new SqlParameter("Gia_don_vi", t.GiaDonVi);
            sqlParameters.Add(p1);
            sqlParameters.Add(p2);
            sqlParameters.Add(p3);
            sqlParameters.Add(p4);
            sqlParameters.Add(p5);
            return dp.ExecuteNonQuery(cmd, sqlParameters);
        }

        public bool delete(ThuocDTO t)
        {
            string cmd = "DELETE FROM THUOC WHERE ID_thuoc = @id";
            List<SqlParameter> sqlParameters = new List<SqlParameter>();
            SqlParameter idParam = new SqlParameter("id", t.Id);
            sqlParameters.Add(idParam);
            return dp.ExecuteNonQuery(cmd, sqlParameters);
        }

        public List<ThuocDTO> getAll()
        {
            string cmd = "select * from THUOC";
            DataTable data = dp.ExecuteQuery(cmd);
            List<ThuocDTO> result = new List<ThuocDTO>();
            foreach (DataRow row in data.Rows)
            {
                result.Add(new ThuocDTO(
                    tenThuoc: row["Ten_thuoc"].ToString(),
                    id: 0,
                    idCachDung: Convert.ToInt32(row["ID_cach_dung"]),
                    idDonViTinh: Convert.ToInt32(row["ID_don_vi_tinh"]),
                    giaDonVi: Convert.ToDouble(row["Gia_don_vi"])
                    ));
            }
            return result;
        }

        public ThuocDTO getById(int id)
        {
            string cmd = "select * from THUOC where ID_thuoc = @id";
            DataTable data = dp.ExecuteQuery(cmd);
            if (data.Rows.Count <= 0)
            {
                return null;
            }
            DataRow row = data.Rows[0];
            return new ThuocDTO(
                    tenThuoc: row["Ten_thuoc"].ToString(),
                    id: 0,
                    idCachDung: Convert.ToInt32(row["ID_cach_dung"]),
                    idDonViTinh: Convert.ToInt32(row["ID_don_vi_tinh"]),
                    giaDonVi: Convert.ToDouble(row["Gia_don_vi"])
                    );
        }

        public bool update(ThuocDTO t)
        {
            string cmd = "update THUOC set Ten_thuoc = @Ten_thuoc,ID_don_vi_tinh = @ID_don_vi_tinh,ID_cach_dung = @ID_cach_dung,Gia_don_vi = @Gia_don_vi where ID_thuoc = @id";
            List<SqlParameter> sqlParameters = new List<SqlParameter>();
            SqlParameter p1 = new SqlParameter("Ten_thuoc", t.TenThuoc);
            SqlParameter p2 = new SqlParameter("ID_don_vi_tinh", t.IdDonViTinh);
            SqlParameter p3 = new SqlParameter("ID_cach_dung", t.IdCachDung);
            SqlParameter p4 = new SqlParameter("Gia_don_vi", t.GiaDonVi);
            SqlParameter p5 = new SqlParameter("id", t.Id);
            sqlParameters.Add(p1);
            sqlParameters.Add(p2);
            sqlParameters.Add(p3);
            sqlParameters.Add(p4);
            sqlParameters.Add(p5);
            return dp.ExecuteNonQuery(cmd, sqlParameters);
        }
    }
}
