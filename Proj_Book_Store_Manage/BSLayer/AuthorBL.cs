﻿using System;
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
        //private SqlConnection conn = null;
        private String nameView = "view_Author";
        private string err = "";
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

        public bool addNewAuthor(string nameAuthor, string phoneNumber, ref string err)
        {
            strSQL = "proc_addNewAuthor";
            parameters = new List<SqlParameter>();

            parameter = new SqlParameter("@nameAuthor", nameAuthor);
            parameters.Add(parameter);

            parameter = new SqlParameter("@phoneNumber", phoneNumber);
            parameters.Add(parameter);

            return db.ExecuteProcedure(strSQL, CommandType.StoredProcedure, parameters, ref err);

        }
        public bool modifyAuthor(int idAuthor, string nameAuthor, string phoneNumber, ref string err)
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
        public bool deleteAuthor(int idAuthor, ref string err)
        {
            strSQL = "proc_DeleteAuthor";
            parameters = new List<SqlParameter>();

            parameter = new SqlParameter("@idAuthor", idAuthor);
            parameters.Add(parameter);

            return db.ExecuteProcedure(strSQL, CommandType.StoredProcedure, parameters, ref err);
        }
    }
}
