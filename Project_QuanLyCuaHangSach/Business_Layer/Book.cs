using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Project_QuanLyCuaHangSach.DB_Layer;
using System.Data.SqlClient;

namespace Project_QuanLyCuaHangSach.Business_Layer
{
    internal class Book
    {
        DBMain db;

        
        SqlParameter parameter;

        public Book()
        {
            db = new DBMain();
        }

        public DataSet getBook ()
        {
            return db.ExecuteQueryDataSet("GetBook", CommandType.StoredProcedure);
        }

        public DataSet searchBook (int id, string name)
        {
            List<SqlParameter> parameters = new List<SqlParameter>();
            string strSql = "SearchBook";
            parameter = new SqlParameter("@id", id);
            parameters.Add(parameter);


            parameter = new SqlParameter("@name", name);
            parameters.Add(parameter);


            return db.ExecuteQueryDataSet (strSql, CommandType.StoredProcedure, parameters);
        }

        public bool deleteBook (int id, ref string err)
        {
            List<SqlParameter> parameters = new List<SqlParameter>();
            string strSql = "DeleteBook";
            parameter = new SqlParameter("@id", id);
            parameters.Add(parameter);

            return db.MyExecuteNonQuery(strSql, CommandType.StoredProcedure, parameters, ref err);
        }


        public bool updatehBook(int id, string name, int price, ref string err)
        {
            List<SqlParameter> parameters = new List<SqlParameter> ();
            string strSql = "UpdateBook";
            parameter = new SqlParameter("@id", id);
            parameters.Add(parameter);


            parameter = new SqlParameter("@name", name);
            parameters.Add(parameter);

            parameter = new SqlParameter("@price", price);
            parameters.Add(parameter);


            return db.MyExecuteNonQuery(strSql, CommandType.StoredProcedure, parameters, ref err);
        }

    }
}
