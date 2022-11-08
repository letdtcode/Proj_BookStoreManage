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
        public static string ServerName = "DESKTOP-MINHDUN";
        public static string DatabaseName = "BOOKSTOREMANAGE";
        public static string UserName= "";
        public static string Password= "";
        private string ConnStr = $@"Data Source={ServerName}; Initial Catalog={DatabaseName};User Id={UserName};Password={Password}";
        private SqlConnection conn = null;
        private SqlCommand cmd = null;
        private SqlDataAdapter adapter = null;
        private DataTable dt = null;
        //private string err = null;

        //public string Err { get => err; set => err = value; }

        public DBMain()
        {
            conn = new SqlConnection(ConnStr);
            cmd = conn.CreateCommand();
            dt = new DataTable();
            //err = "";
      
        }
        public DataTable LoadData(string nameView, CommandType ct)
        {
            dt = new DataTable();
            if (conn.State == ConnectionState.Open)
            {
                conn.Close();
            }
            conn.Open();

            string cmm = "select * from "+ nameView;
            adapter = new SqlDataAdapter(cmm,conn);
            adapter.Fill(dt);
            return dt;
            //conn.Close();
        }
        public DataTable ExecuteFunction(SqlCommand cmdFunction, ref string error)
        {
            error = "";
            dt = new DataTable();
            if (conn.State == ConnectionState.Open)
                conn.Close();
            conn.Open();
            //cmd = new SqlCommand();
            cmd = cmdFunction;
            cmd.Connection = conn;
            try
            {
                adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dt);
            }
            catch (SqlException ex)
            {
                //MessageBox.Show(ex.Message.ToString());
                error = ex.Message;
                dt = null;
            }
            finally
            {
                conn.Close();
            }
            return dt;
        }
        public bool ExecuteProcedure(string sqlProcedure, CommandType ct, List<SqlParameter> parameters, ref string error)
        {
            bool f = false;
            error = "";
            if (conn.State == ConnectionState.Open)
                conn.Close();
            conn.Open();
            //cmd = new SqlCommand();
            cmd.CommandText = sqlProcedure;
            cmd.CommandType = ct;
            cmd.Parameters.Clear();
            foreach (SqlParameter i in parameters)
            {
                cmd.Parameters.Add(i);
            }

            try
            {
                //adapter = new SqlDataAdapter(cmd);
                //dt = new DataTable();
                //adapter.Fill(dt);
                cmd.ExecuteNonQuery();
                f = true;
            }
            catch (SqlException ex)
            {
                //MessageBox.Show(ex.Message.ToString());
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
