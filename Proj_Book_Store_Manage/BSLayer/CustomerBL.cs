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
        public List<string> getAllIDCustomer()
        {
            List<string> dataIDCustomer = new List<string>();
            DataTable dtCustomer = new DataTable();
            dtCustomer = db.LoadData(nameView, CommandType.Text);
            dataIDCustomer.Clear();
            foreach (DataRow row in dtCustomer.Rows)
            {
                dataIDCustomer.Add(row[0].ToString());
            }
            return dataIDCustomer;
        }
        public bool addNewCustomer(string nameCus, string addressCus, string phoneNumber, int idTypeCus, ref string err)
        {
            strSQL = "proc_addNewCustomer";
            parameters = new List<SqlParameter>();

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
        public bool modifyCustomer(int idCus, string nameCus, string addressCus, string phoneNumber, int idTypeCus, ref string err)
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

            parameter = new SqlParameter("@idTypeCus", idTypeCus);
            parameters.Add(parameter);

            return db.ExecuteProcedure(strSQL, CommandType.StoredProcedure, parameters, ref err);
        }
        public bool deleteCustomer(int idCus, ref string err)
        {
            strSQL = "proc_deleteCustomer";
            parameters = new List<SqlParameter>();

            parameter = new SqlParameter("@idCus", idCus);
            parameters.Add(parameter);

            //String sqlString = "exec proc_updateAccount @idAccount = " + idAccount + ", @nameAccount = '" + nameAccount + "', @password = '" + password + "', @typeOfAcc = " + typeOfAcc + ", @idEmployee = " + idEmployee;
            return db.ExecuteProcedure(strSQL, CommandType.StoredProcedure, parameters, ref err);
        }  
    }
}
