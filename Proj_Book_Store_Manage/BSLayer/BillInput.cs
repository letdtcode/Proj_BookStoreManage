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
    internal class BillInput
    {
        List<SqlParameter> parameters;
        SqlParameter parameter;

        DBMain dB;

        public BillInput ()
        {
            dB = new DBMain ();
        }

        public DataSet getBills()
        {
            return dB.ExecuteQueryDataSet("GetBillsInput", CommandType.StoredProcedure);
        }

        public bool createBill(DateTime date, int idEmp, ref string err)
        {
            parameters = new List<SqlParameter>();

            parameter = new SqlParameter("@date", date);
            parameters.Add(parameter);
            
            parameter = new SqlParameter("@idEmployee", idEmp);
            parameters.Add(parameter);

            string strSQL = "CreateBillInput";
            return dB.MyExecuteNonQuery(strSQL, CommandType.StoredProcedure, parameters, ref err);
        }

       
        public DataSet searchBill (int id)
        {
            parameters = new List<SqlParameter>();

            parameter = new SqlParameter("@idBill", id);
            parameters.Add(parameter);

            string strSQL = "SearchBillInput";
            return dB.ExecuteQueryDataSet(strSQL, CommandType.StoredProcedure);
        }

        public DataSet getBooksInBill (int idBill)
        {
            parameters = new List<SqlParameter>();

            parameter = new SqlParameter("@idBill", idBill);
            parameters.Add(parameter);

            string strSQl = "GetBooksInBill";
            return dB.ExecuteQueryDataSet(strSQl, CommandType.StoredProcedure, parameters);
        }

        public bool deleBookInBill (int idBill, int idBook, ref string err)
        {
            parameters = new List<SqlParameter>();

            parameter = new SqlParameter("@idBill", idBill);
            parameters.Add(parameter);

            parameter = new SqlParameter("@idBook", idBook);
            parameters.Add(parameter);

            string strSQl = "DeleteBookInBillInput";
            return dB.MyExecuteNonQuery(strSQl, CommandType.StoredProcedure, parameters, ref err);
        }

        public bool addBookInBill(int idBill, int idBook, int amount, ref string err)
        {
            parameters = new List<SqlParameter>();

            parameter = new SqlParameter("@idBill", idBill);
            parameters.Add(parameter);

            parameter = new SqlParameter("@idBook", idBook);
            parameters.Add(parameter);

            parameter = new SqlParameter("@amount", amount);
            parameters.Add(parameter);

            string strSQl = "CreateBookBillInput";
            return dB.MyExecuteNonQuery(strSQl, CommandType.StoredProcedure, parameters, ref err);
        }

        public bool updateAmountBook(int idBill, int idBook, int amount, ref string err)
        {
            parameters = new List<SqlParameter>();

            parameter = new SqlParameter("@idBill", idBill);
            parameters.Add(parameter);

            parameter = new SqlParameter("@idBook", idBook);
            parameters.Add(parameter);

            parameter = new SqlParameter("@amount", amount);
            parameters.Add(parameter);

            string strSQl = "UpdateAmoutBookInBillInput";
            return dB.MyExecuteNonQuery(strSQl, CommandType.StoredProcedure, parameters, ref err);
        }

        public DataSet calcTotalMoney(int idbill)
        {
            return dB.ExecuteQueryDataSet("select dbo.returnPriceInput(" + idbill + ")", CommandType.Text);
        }

        public bool updateTotalMoneyInBill (int idBill, ref string err)
        {
            parameters = new List<SqlParameter>();

            parameter = new SqlParameter("@idBill", idBill);
            parameters.Add(parameter);

            string strSQL = "UpdateTotalPriceBooksInBillInput";
            return dB.MyExecuteNonQuery(strSQL, CommandType.StoredProcedure, parameters, ref err);
        }
    }
}
