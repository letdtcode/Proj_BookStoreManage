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
    public class AuthorBL
    {
        //DBMain db = null;
        //SqlConnection conn = null;
        //String nameView = "view_Author";

        //public AuthorBL()
        //{
        //    db = new DBMain();
        //    conn = new SqlConnection();
        //}
        //public DataTable getDataAuthor()
        //{
        //    return db.LoadData(nameView, CommandType.Text);
        //}
        //public bool addNewAuthor(string nameAuthor, string phoneNumber)
        //{
        //    String sqlString = "exec proc_addNewAuthor @nameAuthor = '" + nameAuthor + "', @phoneNumber = '" + phoneNumber + "'";
        //    return db.ExecuteProcedure(sqlString, CommandType.Text);
        //}
        //public bool modifyAuthor(int idAuthor, string nameAuthor, string phoneNumber)
        //{
        //    String sqlString = "exec proc_updateAuthor @idAuthor = " + idAuthor + " @nameAuthor = '" + nameAuthor + "', @phoneNumber = '" + phoneNumber + "'";
        //    return db.ExecuteProcedure(sqlString, CommandType.Text);
        //}
        //public bool deleteAuthor(int idAuthor)
        //{
        //    String sqlString = "exec proc_DeleteAuthor @idAuthor = " + idAuthor;
        //    return db.ExecuteProcedure(sqlString, CommandType.Text);
        //}
    }
}
