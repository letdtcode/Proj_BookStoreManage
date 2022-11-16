using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Proj_Book_Store_Manage.DBLayer;
using System.Data;
using System.Data.SqlClient;

namespace Proj_Book_Store_Manage.BSLayer
{
    public class AuthorBL
    {
        private DBMain db = null;
        private String nameView = "view_Author";
        SqlParameter parameter;
        List<SqlParameter> parameters;
        string strSQL = "";

        public AuthorBL()
        {
            db = new DBMain();
            //conn = new SqlConnection();
        }
        public DataTable getDataAuthor()
        {
            return db.LoadData(nameView, CommandType.Text);
        }

        public bool addNewAuthor(string idAuthor, string nameAuthor, string phoneNumber, ref string err)
        {
            strSQL = "proc_addNewAuthor";
            parameters = new List<SqlParameter>();

            parameter = new SqlParameter("@idAuthor", idAuthor);
            parameters.Add(parameter);

            parameter = new SqlParameter("@nameAuthor", nameAuthor);
            parameters.Add(parameter);

            parameter = new SqlParameter("@phoneNumber", phoneNumber);
            parameters.Add(parameter);

            return db.ExecuteProcedure(strSQL, CommandType.StoredProcedure, parameters, ref err);

        }
        public bool modifyAuthor(string idAuthor, string nameAuthor, string phoneNumber, ref string err)
        {
            strSQL = "proc_updateAuthor";
            parameters = new List<SqlParameter>();

            parameter = new SqlParameter("@idAuthor", idAuthor);
            parameters.Add(parameter);

            parameter = new SqlParameter("@nameAuthor", nameAuthor);
            parameters.Add(parameter);

            parameter = new SqlParameter("@phoneNumber", phoneNumber);
            parameters.Add(parameter);

            return db.ExecuteProcedure(strSQL, CommandType.StoredProcedure, parameters, ref err);
        }
        public bool deleteAuthor(string idAuthor, ref string err)
        {
            strSQL = "proc_DeleteAuthor";
            parameters = new List<SqlParameter>();

            parameter = new SqlParameter("@idAuthor", idAuthor);
            parameters.Add(parameter);

            return db.ExecuteProcedure(strSQL, CommandType.StoredProcedure, parameters, ref err);
        }
        public List<string> getAllNameAuthor()
        {
            List<string> dataNameAuthor = new List<string>();
            DataTable dtAuthor = new DataTable();
            dtAuthor = db.LoadData(nameView, CommandType.Text);
            foreach (DataRow row in dtAuthor.Rows)
            {
                dataNameAuthor.Add(row[1].ToString());
            }
            return dataNameAuthor;
        }

        public DataTable searchAuthor(string id, string username, ref string err)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = $"select * from dbo.func_searchAuthor ('{id}', N'{username}')";
            cmd.CommandType = CommandType.Text;

            return db.ExecuteFunction(cmd, ref err);
        }
    }
}
