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
        //DBMain db = null;
        //SqlConnection conn = null;
        //String nameView = "view_Account";

        //public AccountBL()
        //{
        //    db = new DBMain();
        //    conn = new SqlConnection();
        //}
        //public DataTable getDataAccount()
        //{
        //    return db.LoadData(nameView, CommandType.Text);
        //}
        //public bool addNewAccount(string nameAccount, string passWord, int typeOfAcc, int idEmployee, ref string err)
        //{
        //    String sqlString = "exec proc_addNewAccount @nameAccount = '" + nameAccount + "', @password = '" + passWord + "', @typeOfAcc = " + typeOfAcc.ToString() + ", @idEmployee = " + idEmployee.ToString();
        //    return db.ExecuteProcedure(sqlString, CommandType.Text, ref err);
        //}
        //public bool modifyAccount(int idAccount, string nameAccount, string password, int typeOfAcc, int idEmployee, ref string err)
        //{
        //    String sqlString = "exec proc_updateAccount @idAccount = " + idAccount + ", @nameAccount = '" + nameAccount + "', @password = '" + password + "', @typeOfAcc = " + typeOfAcc + ", @idEmployee = " + idEmployee;
        //    return db.ExecuteProcedure(sqlString, CommandType.Text, ref err);
        //}
        //public bool deleteAccount(int idAccount, ref string err)
        //{
        //    String sqlString = "exec proc_DeleteAccount @idAccount = " + idAccount;
        //    return db.ExecuteProcedure(sqlString, CommandType.Text, ref err);
        //}
    }
}
