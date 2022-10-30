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
    public class Voucher
    {
        DBMain dB;
        SqlParameter parameter;
        List<SqlParameter> parameters;

        public Voucher ()
        {
            dB = new DBMain();
        }

        public DataSet getVoucher(DateTime date)
        {
            parameters = new List<SqlParameter>();

            parameter = new SqlParameter("@date", date);
            parameters.Add(parameter);
            string strSQL = "GetVoucher";
            return dB.ExecuteQueryDataSet(strSQL, CommandType.StoredProcedure, parameters);
        }

        public bool insertVoucher (int value, string name, DateTime dateStart, DateTime dateEnd, int amount, ref string err)
        {
            parameters = new List<SqlParameter>();

            parameter = new SqlParameter("@value", value);
            parameters.Add(parameter);

            parameter = new SqlParameter("@name", name);
            parameters.Add(parameter);

            parameter = new SqlParameter("@dateStart", dateStart);
            parameters.Add(parameter);

            parameter = new SqlParameter("@dateEnd", dateEnd);
            parameters.Add(parameter);

            parameter = new SqlParameter("@amount", amount);
            parameters.Add(parameter);

            string strSQL = "InsertVoucher";
            return dB.MyExecuteNonQuery(strSQL, CommandType.StoredProcedure, parameters, ref err);
        }
        public bool deleteVoucher(int id, ref string err)
        {
            parameters = new List<SqlParameter>();

            parameter = new SqlParameter("@id", id);
            parameters.Add(parameter);

            string strSQL = "DeleteVoucher";

            return dB.MyExecuteNonQuery(strSQL, CommandType.StoredProcedure, parameters, ref err);
        }

        public bool updateVoucer(int id, string name, ref string err)
        {
            parameters = new List<SqlParameter>();

            parameter = new SqlParameter("@id", id);
            parameters.Add(parameter);

            parameter = new SqlParameter("@name", name);
            parameters.Add(parameter);

            string strSQL = "UpdateVoucher";

            return dB.MyExecuteNonQuery(strSQL, CommandType.StoredProcedure, parameters, ref err);
        }

        public DataSet searchVoucher(int id, string name)
        {
            parameters = new List<SqlParameter>();

            parameter = new SqlParameter("@id", id);
            parameters.Add(parameter);

            parameter = new SqlParameter("@name", name);
            parameters.Add(parameter);

            string strSQL = "SearchVoucher";

            return dB.ExecuteQueryDataSet(strSQL, CommandType.StoredProcedure, parameters);
        }

    }
}
