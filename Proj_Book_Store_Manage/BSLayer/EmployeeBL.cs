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
        public bool addNewEmployee(string idEmployee, string firstName, string middleName, string lastName, string sex, string addEmp, string phoneNumber, string email, DateTime yearOfBirth, ref string err)
        {
            strSQL = "proc_addNewEmployee";
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
        public bool modifyEmployee(string idEmployee, string firstName, string middleName, string lastName, string sex, string addEmp, string phoneNumber, string email, DateTime yearOfBirth, ref string err)
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
        public bool deleteEmployee(string idEmp, ref string err)
        {
            strSQL = "proc_deleteEmployee";
            parameters = new List<SqlParameter>();

            parameter = new SqlParameter("@idEmp", idEmp);
            parameters.Add(parameter);

            return db.ExecuteProcedure(strSQL, CommandType.StoredProcedure, parameters, ref err);
        }
        public List<string> getAllIDEmployee()
        {
            List<string> dataIDEmp = new List<string>();
            DataTable dtEmp = new DataTable();
            dtEmp = db.LoadData(nameView, CommandType.Text);
            foreach (DataRow row in dtEmp.Rows)
            {
                dataIDEmp.Add(row[0].ToString());
            }
            return dataIDEmp;
        }
        public DataTable searchEmployee(string id, string username, ref string err)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = $"select * from dbo.func_searchEmployee('{id}', N'{username}')";
            cmd.CommandType = CommandType.Text;

            return db.ExecuteFunction(cmd, ref err);
        }
    }
}
