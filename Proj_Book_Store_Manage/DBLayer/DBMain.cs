using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace Proj_Book_Store_Manage.DBLayer
{
    public class DBMain
    {
        SqlConnection conn;
        SqlCommand cmd;
        SqlDataAdapter adapter;

        string strconn = @"Data Source=DESKTOP-MINHDUN;Initial Catalog=BOOKSTOREMANAGE;Integrated Security=True";

        public DBMain()
        {
            this.conn = new SqlConnection(strconn);
            this.cmd = conn.CreateCommand();
        }

        public DataSet ExecuteQueryDataSet(string strSQL, CommandType ct)
        {
            if (conn.State == ConnectionState.Open)
            {
                conn.Close();
            }

            conn.Open();
            cmd.CommandText = strSQL;
            cmd.CommandType = ct;
            adapter = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            adapter.Fill(ds);
            return ds;
        }


        public DataSet ExecuteQueryDataSet(string strSQL, CommandType ct, List<SqlParameter> parameters)
        {
            if (conn.State == ConnectionState.Open)
            {
                conn.Close();
            }

            conn.Open();
            cmd.CommandText = strSQL;
            cmd.CommandType = ct;

            foreach (SqlParameter parameter in parameters)
            {
                cmd.Parameters.Add(parameter);
            }

            adapter = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            adapter.Fill(ds);
            return ds;
        }

      

        public bool MyExecuteNonQuery(string strSQL, CommandType ct, ref string error)
        {
            bool f = false;
            if (conn.State == ConnectionState.Open)
                conn.Close();
            conn.Open();
            cmd.CommandText = strSQL;
            cmd.CommandType = ct;
            try
            {
                cmd.ExecuteNonQuery();
                f = true;
            }
            catch (SqlException ex)
            {
                error = ex.Message;
            }
            finally
            {
                conn.Close();
            }
            return f;
        }

        public bool MyExecuteNonQuery(string strSQL, CommandType ct, List<SqlParameter> parameters, ref string error)
        {
            bool f = false;
            if (conn.State == ConnectionState.Open)
                conn.Close();
            conn.Open();
            cmd.CommandText = strSQL;
            cmd.CommandType = ct;

            foreach (SqlParameter i in parameters)
            {
                cmd.Parameters.Add(i);
            }

            try
            {
                cmd.ExecuteNonQuery();
                f = true;
            }
            catch (SqlException ex)
            {
                error = ex.Message;
            }
            finally
            {
                conn.Close();
            }
            return f;
        }
    }
}
