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
    public class CustomerBL
    {
        DBMain db = null;
        String nameView = "view_Customer";
        string strSQL = "";
        SqlParameter parameter;
        List<SqlParameter> parameters;

        public CustomerBL()
        {
            db = new DBMain();
        }
        public DataTable getDataCustomer()
        {
            
            return db.LoadData(nameView, CommandType.Text);
        }
        
        public bool addNewCustomer(string idCustomer, string nameCus, string addressCus, string phoneNumber, string idTypeCus, ref string err)
        {
            strSQL = "proc_addNewCustomer";
            parameters = new List<SqlParameter>();

            parameter = new SqlParameter("@idCustomer", idCustomer);
            parameters.Add(parameter);

            parameter = new SqlParameter("@nameCus", nameCus);
            parameters.Add(parameter);

            parameter = new SqlParameter("@addressCus", addressCus);
            parameters.Add(parameter);

            parameter = new SqlParameter("@phoneNumber", phoneNumber);
            parameters.Add(parameter);

            parameter = new SqlParameter("@idTypeCus", idTypeCus);
            parameters.Add(parameter);

            return db.ExecuteProcedure(strSQL, CommandType.StoredProcedure, parameters, ref err);
        }
        public bool modifyCustomer(string idCus, string nameCus, string addressCus, string phoneNumber, ref string err)
        {
            strSQL = "proc_updateCustomer";
            parameters = new List<SqlParameter>();

            parameter = new SqlParameter("@idCus", idCus);
            parameters.Add(parameter);

            parameter = new SqlParameter("@nameCus", nameCus);
            parameters.Add(parameter);

            parameter = new SqlParameter("@addressCus", addressCus);
            parameters.Add(parameter);

            parameter = new SqlParameter("@phoneNumber", phoneNumber);
            parameters.Add(parameter);

            return db.ExecuteProcedure(strSQL, CommandType.StoredProcedure, parameters, ref err);
        }
        public bool deleteCustomer(string idCus, ref string err)
        {
            strSQL = "proc_deleteCustomer";
            parameters = new List<SqlParameter>();

            parameter = new SqlParameter("@idCus", idCus);
            parameters.Add(parameter);

            //String sqlString = "exec proc_updateAccount @idAccount = " + idAccount + ", @nameAccount = '" + nameAccount + "', @password = '" + password + "', @typeOfAcc = " + typeOfAcc + ", @idEmployee = " + idEmployee;
            return db.ExecuteProcedure(strSQL, CommandType.StoredProcedure, parameters, ref err);
        }
        public List<string> getAllIDCustomer()
        {
            List<string> dataIDCustomer = new List<string>();
            DataTable dtCustomer = new DataTable();
            dtCustomer = db.LoadData(nameView, CommandType.Text);
            foreach (DataRow row in dtCustomer.Rows)
            {
                dataIDCustomer.Add(row[0].ToString());
            }
            return dataIDCustomer;
        }

        public DataTable searchCustomer(string id, string username, ref string err)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = $"select * from dbo.func_searchCustomer('{id}', '{username}')";
            cmd.CommandType = CommandType.Text;

            return db.ExecuteFunction(cmd, ref err);
        }
    }
}
