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
    class ReceiptImportBL
    {
        DBMain db = null;
        String nameView = "view_ReceiptImport";
        string strSQL = "";
        SqlParameter parameter;
        List<SqlParameter> parameters;

        public ReceiptImportBL()
        {
            db = new DBMain();
        }
        public DataTable getDataReceiptImport()
        {
            return db.LoadData(nameView, CommandType.Text);
        }
        public bool addNewReceiptImport(string nameAccount, string passWord, bool typeOfAcc, int idEmployee, ref string err)
        {
            strSQL = "proc_addNewAccount";
            parameters = new List<SqlParameter>();

            parameter = new SqlParameter("@nameAccount", nameAccount);
            parameters.Add(parameter);

            parameter = new SqlParameter("@password", passWord);
            parameters.Add(parameter);

            parameter = new SqlParameter("@typeOfAcc", typeOfAcc);
            parameters.Add(parameter);

            parameter = new SqlParameter("@idEmployee", idEmployee);
            parameters.Add(parameter);

            //String sqlString = "exec"+ @nameAccount = '" + nameAccount + "', @password = '" + passWord + "', @typeOfAcc = " + typeOfAcc.ToString() + ", @idEmployee = " + idEmployee.ToString() ;
            return db.ExecuteProcedure(strSQL, CommandType.StoredProcedure, parameters, ref err);
        }
        public bool modifyReceiptImport(int idAccount, string nameAccount, string password, bool typeOfAcc, int idEmployee, ref string err)
        {
            strSQL = "proc_updateAccount";
            parameters = new List<SqlParameter>();

            parameter = new SqlParameter("@idAccount", idAccount);
            parameters.Add(parameter);

            parameter = new SqlParameter("@nameAccount", nameAccount);
            parameters.Add(parameter);

            parameter = new SqlParameter("@password", password);
            parameters.Add(parameter);

            parameter = new SqlParameter("@typeOfAcc", typeOfAcc);
            parameters.Add(parameter);

            parameter = new SqlParameter("@idEmployee", idEmployee);
            parameters.Add(parameter);

            //String sqlString = "exec proc_updateAccount @idAccount = " + idAccount + ", @nameAccount = '" + nameAccount + "', @password = '" + password + "', @typeOfAcc = " + typeOfAcc + ", @idEmployee = " + idEmployee;
            return db.ExecuteProcedure(strSQL, CommandType.StoredProcedure, parameters, ref err);
        }
        public bool deleteReceiptImport(int idAccount, ref string err)
        {
            strSQL = "proc_DeleteAccount";
            parameters = new List<SqlParameter>();

            parameter = new SqlParameter("@idAccount", idAccount);
            parameters.Add(parameter);

            //String sqlString = "exec proc_updateAccount @idAccount = " + idAccount + ", @nameAccount = '" + nameAccount + "', @password = '" + password + "', @typeOfAcc = " + typeOfAcc + ", @idEmployee = " + idEmployee;
            return db.ExecuteProcedure(strSQL, CommandType.StoredProcedure, parameters, ref err);
        }
    }
}
