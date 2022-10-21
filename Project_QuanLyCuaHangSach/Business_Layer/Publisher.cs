using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

using Project_QuanLyCuaHangSach.DB_Layer;


namespace Project_QuanLyCuaHangSach.Business_Layer
{
    internal class Publisher
    {
        SqlParameter parameter;
        DBMain dB;

        public Publisher()
        {
            dB = new DBMain();
        }

        public DataSet getPublishers()
        {
            return dB.ExecuteQueryDataSet("Select * from PUBLISHER", CommandType.Text);
        }

        public bool insertPublisher (string name, string addr, string phoneNumber, ref string err)
        {
            List<SqlParameter> parameters = new List<SqlParameter> ();

            parameter = new SqlParameter("@name", name);
            parameters.Add(parameter);

            parameter = new SqlParameter("@addr", addr);
            parameters.Add(parameter);

            parameter = new SqlParameter("@phoneNumber", phoneNumber);
            parameters.Add(parameter);

            string strSql = "InsertPublisher";
            return dB.MyExecuteNonQuery(strSql, CommandType.StoredProcedure, parameters, ref err);
        }

        public bool updatePublisher(int id, string name, string addr, string phoneNumber, ref string err)
        {
            List<SqlParameter> parameters = new List<SqlParameter>();

            parameter = new SqlParameter("@id", id);
            parameters.Add(parameter);

            parameter = new SqlParameter("@name", name);
            parameters.Add(parameter);

            parameter = new SqlParameter("@addr", addr);
            parameters.Add(parameter);

            parameter = new SqlParameter("@phoneNumber", phoneNumber);
            parameters.Add(parameter);

            string strSql = "UpdatePublisher";
            return dB.MyExecuteNonQuery(strSql, CommandType.StoredProcedure, parameters, ref err);
        }

        public bool deletePublisher(int id, ref string err)
        {
            List<SqlParameter> parameters = new List<SqlParameter>();
            parameter = new SqlParameter("@id", id);
            parameters.Add(parameter);

            string strSql = "DeletePublisher";
            return dB.MyExecuteNonQuery(strSql, CommandType.StoredProcedure, parameters, ref err);
        }

        public bool searchPublisher(int id, string name, ref string err)
        {
            List<SqlParameter> parameters = new List<SqlParameter>();

            parameter = new SqlParameter("@id", id);
            parameters.Add(parameter);

            parameter = new SqlParameter("@name", name);
            parameters.Add(parameter);

            

            string strSql = "SearchPublisher";
            return dB.MyExecuteNonQuery(strSql, CommandType.StoredProcedure, parameters, ref err);
        }
           
    }
}
