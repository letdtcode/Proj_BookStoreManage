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
        public static string ServerName = "DUCTHANH\\SQLEXPRESS";
        public static string DatabaseName = "BOOKSTOREMANAGE";
        public static string UserName= "";
        public static string Password= "";
        private string ConnStr = $@"Data Source={ServerName}; Initial Catalog={DatabaseName};User Id={UserName};Password={Password}";
        private SqlConnection conn = null;
        private SqlCommand cmd = null;
        private SqlDataAdapter adapter = null;
        private DataTable dt = null;

        public DBMain()
        {
                conn = new SqlConnection(ConnStr);
                cmd = conn.CreateCommand();
                dt = new DataTable();
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
            conn.Close();
            return dt;
        }
        public DataTable ExecuteFunction(SqlCommand cmdFunction, ref string error)
        {
            error = "";
            dt = new DataTable();
            if (conn.State == ConnectionState.Open)
                conn.Close();
            conn.Open();
            cmd = cmdFunction;
            cmd.Connection = conn;
            try
            {
                adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dt);
            }
            catch (SqlException ex)
            {
                error = ex.Message;
                MessageBox.Show(error);
                dt = null;
            }
            finally
            {
                conn.Close();
            }
            return dt;
        }

        //dư -- có thể xóa
        public string ExecuteFunctionToString(SqlCommand cmdFunction, ref string error)
        {
            string valueReturn = null;
            error = "";
            if (conn.State == ConnectionState.Open)
                conn.Close();
            conn.Open();
            cmd = cmdFunction;
            cmd.Connection = conn;
            try
            {
                valueReturn = cmd.ExecuteScalar().ToString();
            }
            catch (SqlException ex)
            {
                error = ex.Message;
                MessageBox.Show(error);
            }
            finally
            {
                conn.Close();
            }
            return valueReturn;
        }
        public int ExecuteFunctionToInt(SqlCommand cmdFunction, ref string error)
        {
            int valueReturn = -1;
            error = "";
            if (conn.State == ConnectionState.Open)
                conn.Close();
            conn.Open();
            cmd = cmdFunction;
            cmd.Connection = conn;
            try
            {
                valueReturn = int.Parse(cmd.ExecuteScalar().ToString());
            }
            catch (SqlException ex)
            {
                error = ex.Message;
                MessageBox.Show(error);
            }
            finally
            {
                conn.Close();
            }
            return valueReturn;
        }
        //Trả về true, false thực thi procedure
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

            if (parameters != null)
            {
                foreach (SqlParameter i in parameters)
                {
                    cmd.Parameters.Add(i);
                }
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

        // Trả về table thực thi procedure
        public DataTable Procedure(string sqlProcedure, CommandType ct, List<SqlParameter> parameters, ref string error)
        {
            //bool f = false;
            error = "";
            if (conn.State == ConnectionState.Open)
                conn.Close();
            conn.Open();

            cmd.CommandText = sqlProcedure;
            cmd.CommandType = ct;
            cmd.Parameters.Clear();
            foreach (SqlParameter i in parameters)
            {
                cmd.Parameters.Add(i);
            }

            try
            {
                adapter = new SqlDataAdapter(cmd);
                dt = new DataTable();
                adapter.Fill(dt);
            }
            catch (SqlException ex)
            {
                error = ex.Message;
            }
            finally
            {
                conn.Close();
            }
            return dt;
        }
    }
}
