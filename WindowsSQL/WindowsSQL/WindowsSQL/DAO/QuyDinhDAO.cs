using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsSQL;
namespace DAO
{
    class QuyDinhDAO
    {
        DataProvider dp;
        public QuyDinhDAO()
        {
            dp = new DataProvider();
        }
        public bool quyDinhThayDoiSoBenhNhan(int n)
        {
            string cmd = "update QUY_DINH set So_luong = @So_luong";
            List<SqlParameter> sqlParameters = new List<SqlParameter>();
            SqlParameter paramSo_luong = new SqlParameter("So_luong",n);
            sqlParameters.Add(paramSo_luong);
            return dp.ExecuteNonQuery(cmd, sqlParameters);
        }
        public int getMaxBenhNhan()
        {
            string cmd = "select So_luong from QUY_DINH where Loai = 'Benh_nhan'";
            DataTable dt= dp.ExecuteQuery(cmd);
            return dt.Rows[0].Field<int>(0);
        }
        public int getMaxDonViTinh()
        {
            string cmd = "select So_luong from QUY_DINH where Loai = 'Don_vi_tinh'";
            DataTable dt = dp.ExecuteQuery(cmd);
            return dt.Rows[0].Field<int>(0);
        }
        public int getMaxCachDung()
        {
            string cmd = "select So_luong from QUY_DINH where Loai = 'Cach_dung'";
            DataTable dt = dp.ExecuteQuery(cmd);
            return dt.Rows[0].Field<int>(0);
        }
        public int getMaxLoaiBenh()
        {
            string cmd = "select So_luong from QUY_DINH where Loai = 'Loai_benh'";
            DataTable dt = dp.ExecuteQuery(cmd);
            return dt.Rows[0].Field<int>(0);
        }
        public int getMaxThuoc()
        {
            string cmd = "select So_luong from QUY_DINH where Loai = 'Thuoc'";
            DataTable dt = dp.ExecuteQuery(cmd);
            return dt.Rows[0].Field<int>(0);
        }
    }
}
