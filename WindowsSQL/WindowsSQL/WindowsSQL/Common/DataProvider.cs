using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;
namespace WindowsSQL
{
    class DataProvider
    {
        public SqlConnection connection { get; set; }
        public DataProvider()
        {
            String sConnectString = ConfigurationManager.ConnectionStrings["CSDB"].ConnectionString.ToString();
            this.connection = new SqlConnection(sConnectString);
        }
        public DataTable ExecuteQuery(String query, List<SqlParameter> sqlParameters = null)
        {
            DataTable dt = new DataTable();
            try
            {
                this.connection.Open();
                SqlCommand cmd = new SqlCommand(query,this.connection);
                cmd.CommandType = CommandType.Text;
                if (sqlParameters != null)
                {
                    foreach(SqlParameter param in sqlParameters)
                    {
                        cmd.Parameters.Add(param);
                    }
                }
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
            }
            catch (Exception ex)
            {

                throw new Exception("Error execute query: "+ex.Message);
            }
            finally
            {
                this.connection.Close();
            }
            return dt;
        }
        public bool ExecuteNonQuery(String query,List<SqlParameter> sqlParameters = null)
        {
            bool flag = true;
            try
            {
                this.connection.Open();
                SqlCommand cmd = new SqlCommand(query, this.connection);
                cmd.CommandType = CommandType.Text;
                if (sqlParameters != null)
                {
                    foreach(SqlParameter param in sqlParameters)
                    {
                        cmd.Parameters.Add(param);
                    }
                }
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                flag = false;
                throw new Exception("Error execute non query: " + ex.Message);
            }
            finally
            {
                this.connection.Close();
            }
            return flag;
        }
    }
}
