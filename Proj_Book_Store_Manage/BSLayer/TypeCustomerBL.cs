using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using Proj_Book_Store_Manage.DBLayer;

namespace Proj_Book_Store_Manage.BSLayer
{
    public class TypeCustomerBL
    {
        private DBMain db = null;
        private String nameView = "view_TypeCustomer";
        private string strSQL = "";
        private SqlParameter parameter;
        private List<SqlParameter> parameters;

        public TypeCustomerBL()
        {
            db = new DBMain();
        }
        public DataTable getDataTypeCustomer()
        {
            return db.LoadData(nameView, CommandType.Text);
        }
        public bool addNewTypeCustomer(string idTypeCustomer, string nameTypeCus, int pointMark, int valueTypeCus, ref string err)
        {
            strSQL = "proc_addNewTypeCustomer";
            parameters = new List<SqlParameter>();

            parameter = new SqlParameter("@idTypeCustomer", idTypeCustomer);
            parameters.Add(parameter);

            parameter = new SqlParameter("@nameTypeCus", nameTypeCus);
            parameters.Add(parameter);

            parameter = new SqlParameter("@pointMark", pointMark);
            parameters.Add(parameter);

            parameter = new SqlParameter("@valueTypeCus", valueTypeCus);
            parameters.Add(parameter);

            return db.ExecuteProcedure(strSQL, CommandType.StoredProcedure, parameters, ref err);
        }
        public bool modifyTypeCustomer(string idTypeCus, string nameTypeCus, int pointMark, int valueTypeCus, ref string err)
        {
            strSQL = "proc_updateTypeCustomer";
            parameters = new List<SqlParameter>();

            parameter = new SqlParameter("@idTypeCus", idTypeCus);
            parameters.Add(parameter);

            parameter = new SqlParameter("@nameTypeCus", nameTypeCus);
            parameters.Add(parameter);

            parameter = new SqlParameter("@pointMark", pointMark);
            parameters.Add(parameter);

            parameter = new SqlParameter("@valueTypeCus", valueTypeCus);
            parameters.Add(parameter);

            return db.ExecuteProcedure(strSQL, CommandType.StoredProcedure, parameters, ref err);
        }
        public bool deleteTypeCustomer(string idTypeCus, ref string err)
        {
            strSQL = "proc_deleteTypeCustomer";
            parameters = new List<SqlParameter>();

            parameter = new SqlParameter("@idTypeCus", idTypeCus);
            parameters.Add(parameter);

            return db.ExecuteProcedure(strSQL, CommandType.StoredProcedure, parameters, ref err);
        }
        /*public List<string> getAllIDTypeCus()
        {
            List<string> dataIDTypeCus = new List<string>();
            DataTable dtTypeCustomer = new DataTable();
            dtTypeCustomer = db.LoadData(nameView, CommandType.Text);
            foreach (DataRow row in dtTypeCustomer.Rows)
            {
                dataIDTypeCus.Add(row[0].ToString());
            }
            return dataIDTypeCus;
        }*/
        public DataTable searchTypeCustomer(string id, string username, ref string err)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = $"select * from dbo.func_searchTypeCustomer('{id}', '{username}')";
            cmd.CommandType = CommandType.Text;

            return db.ExecuteFunction(cmd, ref err);
        }
    }
}
