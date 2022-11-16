using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

using Proj_Book_Store_Manage.DBLayer;
namespace Proj_Book_Store_Manage.BSLayer
{
    public class LoginBL
    {       
        DBMain db;
        public LoginBL()
        {
            db = new DBMain();
        }
        public LoginBL(string user, string password)
        {
            DBMain.UserName = user;
            DBMain.Password = password;
            db = new DBMain();
        }
        public DataTable login (string user, string password, ref string err)
        {
            SqlCommand cmd = new SqlCommand("select * from dbo.func_getIdEmployee(@user, @password)");
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@user", user);
            cmd.Parameters.AddWithValue("@password", password);
            return db.ExecuteFunction(cmd, ref err);
        }
    }
}
