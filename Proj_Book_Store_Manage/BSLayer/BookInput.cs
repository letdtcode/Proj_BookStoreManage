using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

using Proj_Book_Store_Manage.DBLayer;


namespace Proj_Book_Store_Manage.BSLayer
{
    internal class BookInput
    {
        List<SqlParameter> parameters;
        SqlParameter parameter;

        DBMain dB;

        public BookInput ()
        {
            dB = new DBMain ();
        }

        public DataSet getBook ()
        {
            string strSQL = "GetBook";
            return dB.ExecuteQueryDataSet(strSQL, CommandType.StoredProcedure);
        }

        //public bool insertBook ()

        public DataSet searchBook(int id, string nameBook, string nameAuthor, string nameCategory)
        {
            parameters = new List<SqlParameter>();

            parameter = new SqlParameter("@id", id);
            parameters.Add(parameter);

            parameter = new SqlParameter("@nameBook", nameBook);
            parameters.Add(parameter);

            parameter = new SqlParameter("@nameAuthor", nameAuthor);
            parameters.Add(parameter);

            parameter = new SqlParameter("@nameCategory", nameCategory);
            parameters.Add(parameter);

            string strSQL = "SearchBook";
            return dB.ExecuteQueryDataSet(strSQL, CommandType.StoredProcedure, parameters);
        }
    }
}
