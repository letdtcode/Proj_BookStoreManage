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
        public bool addNewTypeCustomer(string nameTypeCus, int pointMark, int valueTypeCus, ref string err)
        {
            strSQL = "proc_addNewTypeCustomer";
            parameters = new List<SqlParameter>();

            parameter = new SqlParameter("@nameTypeCus", nameTypeCus);
            parameters.Add(parameter);

            parameter = new SqlParameter("@pointMark", pointMark);
            parameters.Add(parameter);

            parameter = new SqlParameter("@valueTypeCus", valueTypeCus);
            parameters.Add(parameter);

            return db.ExecuteProcedure(strSQL, CommandType.StoredProcedure, parameters, ref err);
        }
        public bool modifyTypeCustomer(int idTypeCus, string nameTypeCus, int pointMark, int valueTypeCus, ref string err)
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
        public bool deleteAccount(int idTypeCus, ref string err)
        {
            strSQL = "proc_deleteTypeCustomer";
            parameters = new List<SqlParameter>();

            parameter = new SqlParameter("@idTypeCus", idTypeCus);
            parameters.Add(parameter);

            return db.ExecuteProcedure(strSQL, CommandType.StoredProcedure, parameters, ref err);
        }
    }
}
