using Proj_Book_Store_Manage.DBLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proj_Book_Store_Manage.BSLayer
{
    public class Revenue
    {

        DBMain db = null;
        String nameView = "view_top5StockMin";
        string strSQL = "";
        SqlParameter parameter;
        List<SqlParameter> parameters;
        SqlCommand sqlCommand;


        public Revenue()
        {
            db = new DBMain();
        }

        public DataTable getRevenue(DateTime begin, DateTime end, ref string err)
        {
            strSQL = "sp_ShowRevenue";
            parameters = new List<SqlParameter>();

            parameter = new SqlParameter("@begin ", begin);
            parameters.Add(parameter);

            parameter = new SqlParameter("@end ", end);
            parameters.Add(parameter);

            return db.Procedure(strSQL, CommandType.StoredProcedure, parameters, ref  err);
        }

        public DataTable getTop5Book(DateTime begin, DateTime end, ref string err)
        {
            strSQL = "sp_ShowTop5Book";
            parameters = new List<SqlParameter>();

            parameter = new SqlParameter("@begin ", begin);
            parameters.Add(parameter);

            parameter = new SqlParameter("@end ", end);
            parameters.Add(parameter);

            return db.Procedure(strSQL, CommandType.StoredProcedure, parameters, ref err);
        }

        public DataTable getTop5MinStock()
        {
            return db.LoadData(nameView, CommandType.Text);
        }

        public DataTable getOverView_Revenue(DateTime begin, DateTime end, ref string err)
        {
            strSQL = "sp_Overview_Revenue";
            parameters = new List<SqlParameter>();

            parameter = new SqlParameter("@begin ", begin);
            parameters.Add(parameter);

            parameter = new SqlParameter("@end ", end);
            parameters.Add(parameter);

            return db.Procedure(strSQL, CommandType.StoredProcedure, parameters, ref err);
        }
        public DataTable get_Overview_AmountBillOutput(DateTime begin, DateTime end, ref string err)
        {
            strSQL = "sp_Overview_AmountBillOutput";
            parameters = new List<SqlParameter>();

            parameter = new SqlParameter("@begin ", begin);
            parameters.Add(parameter);

            parameter = new SqlParameter("@end ", end);
            parameters.Add(parameter);

            return db.Procedure(strSQL, CommandType.StoredProcedure, parameters, ref err);
        }

        public DataTable get_Overview_AmountBookBillOutput(DateTime begin, DateTime end, ref string err)
        {
            strSQL = "sp_Overview_AmountBookBillOutput";
            parameters = new List<SqlParameter>();

            parameter = new SqlParameter("@begin ", begin);
            parameters.Add(parameter);

            parameter = new SqlParameter("@end ", end);
            parameters.Add(parameter);

            return db.Procedure(strSQL, CommandType.StoredProcedure, parameters, ref err);
        }



    }
}
