using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Proj_Book_Store_Manage.DBLayer;
using System.Data;
using System.Data.SqlClient;

namespace Proj_Book_Store_Manage.BSLayer
{
    public class CategoryBL
    {
        DBMain db = null;
        String nameView = "view_Category";
        string strSQL = "";
        SqlParameter parameter;
        List<SqlParameter> parameters;

        public CategoryBL()
        {
            db = new DBMain();
        }
        public DataTable getDataCategory()
        {
            return db.LoadData(nameView, CommandType.Text);
        }
        public bool addNewCategory(string idCategory, string nameCategory, string describle, ref string err)
        {
            strSQL = "proc_addNewCategory";
            parameters = new List<SqlParameter>();

            parameter = new SqlParameter("@idCategory", idCategory);
            parameters.Add(parameter);

            parameter = new SqlParameter("@nameCategory", nameCategory);
            parameters.Add(parameter);

            parameter = new SqlParameter("@describleCategory", describle);
            parameters.Add(parameter);

            //String sqlString = "exec"+ @nameAccount = '" + nameAccount + "', @password = '" + passWord + "', @typeOfAcc = " + typeOfAcc.ToString() + ", @idEmployee = " + idEmployee.ToString() ;
            return db.ExecuteProcedure(strSQL, CommandType.StoredProcedure, parameters, ref err);
        }
        public bool modifyCategory(string idCategory, string nameCategory, string describle, ref string err)
        {
            strSQL = "proc_updateCategory";
            parameters = new List<SqlParameter>();

            parameter = new SqlParameter("@idCategory", idCategory);
            parameters.Add(parameter);

            parameter = new SqlParameter("@nameCategory", nameCategory);
            parameters.Add(parameter);

            parameter = new SqlParameter("@describleCategory", describle);
            parameters.Add(parameter);

            return db.ExecuteProcedure(strSQL, CommandType.StoredProcedure, parameters, ref err);
        }
        public bool deleteCategory(string idCategory, ref string err)
        {
            strSQL = "proc_deleteCategory";
            parameters = new List<SqlParameter>();

            parameter = new SqlParameter("@idCategory", idCategory);
            parameters.Add(parameter);

            return db.ExecuteProcedure(strSQL, CommandType.StoredProcedure, parameters, ref err);
        }
        public List<string> getAllNameCategory()
        {
            List<string> dataNameCategory = new List<string>();
            DataTable dtCategory = new DataTable();
            dtCategory = db.LoadData(nameView, CommandType.Text);
            foreach (DataRow row in dtCategory.Rows)
            {
                dataNameCategory.Add(row[1].ToString());
            }
            return dataNameCategory;
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

        public DataTable searchCategory(string id, string username, ref string err)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = $"select * from dbo.func_searchCategory('{id}', '{username}')";
            cmd.CommandType = CommandType.Text;

            return db.ExecuteFunction(cmd, ref err);
        }
    }
}
