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
    internal class Book
    {
        DBMain dB;

        List<SqlParameter> parameters;
        SqlParameter parameter;

        public Book()
        {
            dB = new DBMain();
        }

        public DataSet getBook()
        {
            return dB.ExecuteQueryDataSet("GetBook", CommandType.StoredProcedure);
        }

        public DataSet searchBook(int id, string nameBook, string nameAuthor, string nameCategory)
        {
            //if (nameBook == "")
            //    nameBook = null;

            //if (nameAuthor == "")
            //    nameAuthor = null;

            //if (nameCategory == "")
            //    nameCategory = null;

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

        public bool deleteBook(int id, ref string err)
        {
            parameters = new List<SqlParameter>();
            string strSql = "DeleteBook";
            parameter = new SqlParameter("@id", id);
            parameters.Add(parameter);

            return dB.MyExecuteNonQuery(strSql, CommandType.StoredProcedure, parameters, ref err);
        }


        public bool updatehBook(int id, string name, int price, ref string err)
        {
            List<SqlParameter> parameters = new List<SqlParameter>();
            string strSql = "UpdateBook";
            parameter = new SqlParameter("@id", id);
            parameters.Add(parameter);


            parameter = new SqlParameter("@name", name);
            parameters.Add(parameter);

            parameter = new SqlParameter("@price", price);
            parameters.Add(parameter);


            return dB.MyExecuteNonQuery(strSql, CommandType.StoredProcedure, parameters, ref err);
        }
    }
}
