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
    public class AccountBL
    {
        DBMain db = null;
        String nameView = "view_Account";
        string strSQL = "";
        SqlParameter parameter;
        List<SqlParameter> parameters;

        public AccountBL()
        {
            db = new DBMain();
        }
        public DataTable getDataAccount()
        {
            return db.LoadData(nameView, CommandType.Text);
        }
        public bool addNewAccount(string idAccount, string nameAccount, string passWord, int typeOfAcc, string idEmployee, ref string err)
        {
            strSQL = "proc_addNewAccount";
            parameters = new List<SqlParameter>();

            parameter = new SqlParameter("@idAccount", idAccount);
            parameters.Add(parameter);

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
        public bool modifyAccount(string idAccount, string nameAccount, string password, ref string err)
        {
            strSQL = "proc_updateAccount";
            parameters = new List<SqlParameter>();

            parameter = new SqlParameter("@idAccount", idAccount);
            parameters.Add(parameter);

            parameter = new SqlParameter("@nameAccount", nameAccount);
            parameters.Add(parameter);

            parameter = new SqlParameter("@password", password);
            parameters.Add(parameter);

            //String sqlString = "exec proc_updateAccount @idAccount = " + idAccount + ", @nameAccount = '" + nameAccount + "', @password = '" + password + "', @typeOfAcc = " + typeOfAcc + ", @idEmployee = " + idEmployee;
            return db.ExecuteProcedure(strSQL, CommandType.StoredProcedure, parameters, ref err);
        }
        public bool deleteAccount(int idAccount, ref string err)
        {
            strSQL = "proc_DeleteAccount";
            parameters = new List<SqlParameter>();

            parameter = new SqlParameter("@idAccount", idAccount);
            parameters.Add(parameter);

            //String sqlString = "exec proc_updateAccount @idAccount = " + idAccount + ", @nameAccount = '" + nameAccount + "', @password = '" + password + "', @typeOfAcc = " + typeOfAcc + ", @idEmployee = " + idEmployee;
            return db.ExecuteProcedure(strSQL, CommandType.StoredProcedure, parameters, ref err);
        }
        //public DataTable searchAccount(string userName, ref string err)
        //{
        //    //strSQL = "func_searchAccount";
        //    //parameters = new List<SqlParameter>();

        //    //parameter = new SqlParameter("@idAcc", idAccount);
        //    //parameters.Add(parameter);

        //    //parameter = new SqlParameter("@userName", userName);
        //    //parameters.Add(parameter);

        //    //parameter = new SqlParameter("@password", password);
        //    //parameters.Add(parameter);

        //    //parameter = new SqlParameter("@typeAcc", typeOfAcc);
        //    //parameters.Add(parameter);

        //    //parameter = new SqlParameter("@idEmp", idEmp);
        //    //parameters.Add(parameter);

        //    ////String sqlString = "exec proc_updateAccount @idAccount = " + idAccount + ", @nameAccount = '" + nameAccount + "', @password = '" + password + "', @typeOfAcc = " + typeOfAcc + ", @idEmployee = " + idEmployee;
        //    //return db.ExecuteFunction(strSQL, CommandType.Text, parameters, ref err);
        //}
        public DataTable searchAccount(string id, string username, ref string err)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = $"select * from dbo.func_searchAccount ('{id}', '{username}')";
            cmd.CommandType = CommandType.Text;

            return db.ExecuteFunction(cmd, ref err);
        }

    }
}
