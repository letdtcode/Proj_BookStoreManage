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
    public class DetailReceiptExport
    {
        DBMain db = null;
        String nameView = "view_GetAllBookForSale";
        string strSQL = "";
        private string idBill = null;
        SqlParameter parameter;
        List<SqlParameter> parameters;

        public string IdBill { get => idBill; set => idBill = value; }

        public DetailReceiptExport(string idBill)
        {
            db = new DBMain();
            this.idBill = idBill;
        }
        public DataTable getDataBook()
        {
            return db.LoadData(nameView, CommandType.Text);
        }
        public DataTable getDataItemOfBill(ref string err)
        {
            SqlCommand cmd = new SqlCommand("Select * from dbo.func_getDataOfBillOutput(@idBill)");
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@idBill", IdBill);
            return db.ExecuteFunction(cmd, ref err);
        }
        public string getNameOfEmployee(ref string err)
        {
            SqlCommand cmd = new SqlCommand("select dbo.func_getNameEmpOfBillOutPut(@idBill)");
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@idBill", IdBill);
            return db.ExecuteFunctionToString(cmd, ref err);
        }
        public string getNameOfCustomer(ref string err)
        {
            SqlCommand cmd = new SqlCommand("select dbo.func_getNameCusOfBillOutPut(@idBill)");
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@idBill", IdBill);
            return db.ExecuteFunctionToString(cmd, ref err);
        }
        public bool addNewDetailReceiptExport(string idBook, int amount, ref string err)
        {
            strSQL = "proc_addNewBookBillOutput";
            parameters = new List<SqlParameter>();

            parameter = new SqlParameter("@idBillOutput", idBill);
            parameters.Add(parameter);

            parameter = new SqlParameter("@idBook", idBook);
            parameters.Add(parameter);

            parameter = new SqlParameter("@amount", amount);
            parameters.Add(parameter);

            return db.ExecuteProcedure(strSQL, CommandType.StoredProcedure, parameters, ref err);
        }
        public bool modifyDetailReceiptExport(string idBillOutput, string idBook, string idnewBook, int amount, ref string err)
        {
            strSQL = "proc_updateBookBillOutput";
            parameters = new List<SqlParameter>();

            parameter = new SqlParameter("@idBillOutput", idBillOutput);
            parameters.Add(parameter);

            parameter = new SqlParameter("@idBook", idBook);
            parameters.Add(parameter);

            parameter = new SqlParameter("@idnewBook", idnewBook);
            parameters.Add(parameter);

            parameter = new SqlParameter("@amount", amount);
            parameters.Add(parameter);

            return db.ExecuteProcedure(strSQL, CommandType.StoredProcedure, parameters, ref err);
        }
        public bool deleteDetailReceiptExport(string idBillOutput, string idBook, ref string err)
        {
            strSQL = "proc_deleteBookBillOutput";
            parameters = new List<SqlParameter>();

            parameter = new SqlParameter("@idBillOutput", idBillOutput);
            parameters.Add(parameter);

            parameter = new SqlParameter("@idBook", idBook);
            parameters.Add(parameter);

            return db.ExecuteProcedure(strSQL, CommandType.StoredProcedure, parameters, ref err);
        }
    }
}
