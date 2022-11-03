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
    public class EmployeeBL
    {
        DBMain db = null;
        String nameView = "view_Employee";
        string strSQL = "";
        SqlParameter parameter;
        List<SqlParameter> parameters;

        public EmployeeBL()
        {
            db = new DBMain();
        }
        public DataTable getDataEmployee()
        {
            return db.LoadData(nameView, CommandType.Text);
        }
        public bool addNewEmployee(string firstName, string middleName, string lastName, string sex, string addEmp, string phoneNumber, string email, string yearOfBirth, ref string err)
        {
            strSQL = "proc_addNewEmployee";
            parameters = new List<SqlParameter>();

            parameter = new SqlParameter("@firstName", firstName);
            parameters.Add(parameter);

            parameter = new SqlParameter("@middleName", middleName);
            parameters.Add(parameter);

            parameter = new SqlParameter("@lastName", lastName);
            parameters.Add(parameter);

            parameter = new SqlParameter("@sex", sex);
            parameters.Add(parameter);

            parameter = new SqlParameter("@addEmp", addEmp);
            parameters.Add(parameter);

            parameter = new SqlParameter("@phoneNumber", phoneNumber);
            parameters.Add(parameter);

            parameter = new SqlParameter("@email", email);
            parameters.Add(parameter);

            parameter = new SqlParameter("@yearOfBirth", yearOfBirth);
            parameters.Add(parameter);

            return db.ExecuteProcedure(strSQL, CommandType.StoredProcedure, parameters, ref err);
        }
        public bool modifyEmployee(int idEmployee, string firstName, string middleName, string lastName, string sex, string addEmp, string phoneNumber, string email, string yearOfBirth, ref string err)
        {
            strSQL = "proc_updateEmployee";
            parameters = new List<SqlParameter>();

            parameter = new SqlParameter("@idEmployee", idEmployee);
            parameters.Add(parameter);

            parameter = new SqlParameter("@firstName", firstName);
            parameters.Add(parameter);

            parameter = new SqlParameter("@middleName", middleName);
            parameters.Add(parameter);

            parameter = new SqlParameter("@lastName", lastName);
            parameters.Add(parameter);

            parameter = new SqlParameter("@sex", sex);
            parameters.Add(parameter);

            parameter = new SqlParameter("@addEmp", addEmp);
            parameters.Add(parameter);

            parameter = new SqlParameter("@phoneNumber", phoneNumber);
            parameters.Add(parameter);

            parameter = new SqlParameter("@email", email);
            parameters.Add(parameter);

            parameter = new SqlParameter("@yearOfBirth", yearOfBirth);
            parameters.Add(parameter);

            return db.ExecuteProcedure(strSQL, CommandType.StoredProcedure, parameters, ref err);
        }
        public bool deleteEmployee(int idEmp, ref string err)
        {
            strSQL = "proc_deleteEmployee";
            parameters = new List<SqlParameter>();

            parameter = new SqlParameter("@idEmp", idEmp);
            parameters.Add(parameter);

            return db.ExecuteProcedure(strSQL, CommandType.StoredProcedure, parameters, ref err);
        }
        /*public DataTable searchAccount(int idAccount, string userName, string password, bool typeOfAcc, int idEmp, ref string err)
        {
            strSQL = "func_searchAccount";
            parameters = new List<SqlParameter>();

            parameter = new SqlParameter("@idAcc", idAccount);
            parameters.Add(parameter);

            parameter = new SqlParameter("@userName", userName);
            parameters.Add(parameter);

            parameter = new SqlParameter("@password", password);
            parameters.Add(parameter);

            parameter = new SqlParameter("@typeAcc", typeOfAcc);
            parameters.Add(parameter);

            parameter = new SqlParameter("@idEmp", idEmp);
            parameters.Add(parameter);

            //String sqlString = "exec proc_updateAccount @idAccount = " + idAccount + ", @nameAccount = '" + nameAccount + "', @password = '" + password + "', @typeOfAcc = " + typeOfAcc + ", @idEmployee = " + idEmployee;
            return db.ExecuteFunction(strSQL, CommandType.Text, parameters, ref err);
        }*/
    }
}
