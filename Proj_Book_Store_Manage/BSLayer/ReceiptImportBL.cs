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
    class ReceiptImportBL
    {
        DBMain db = null;
        String nameView = "view_ReceiptImport";
        string strSQL = "";
        SqlParameter parameter;
        List<SqlParameter> parameters;
        private int totalOfCurrent = 0;

        public int TotalOfCurrent { get => totalOfCurrent; set => totalOfCurrent = value; }

        public ReceiptImportBL()
        {
            db = new DBMain();
        }
        public DataTable getDataReceiptImport()
        {
            return db.LoadData(nameView, CommandType.Text);
        }
        public DataTable getDataDetailReceiptImport(string idBillImport, ref string err)
        {
            SqlCommand cmd = new SqlCommand("Select * from dbo.func_getDataOfBillImport(@idBill)");
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@idBill", idBillImport);
            return db.ExecuteFunction(cmd, ref err);
        }
        public bool addNewReceiptImport(string idBillInput, ref string err)
        {
            strSQL = "proc_addNewBillInput";
            parameters = new List<SqlParameter>();

            parameter = new SqlParameter("@idBillInput", idBillInput);
            parameters.Add(parameter);

            return db.ExecuteProcedure(strSQL, CommandType.StoredProcedure, parameters, ref err);
        }
        public bool confirmReceiptImport(string idBillInput, DateTime dateTimeOfBill, string idEmp, ref string err)
        {
            strSQL = "proc_confirmBillImport ";
            parameters = new List<SqlParameter>();

            parameter = new SqlParameter("@idBillInput", idBillInput);
            parameters.Add(parameter);

            parameter = new SqlParameter("@dateTimeOfBill", dateTimeOfBill);
            parameters.Add(parameter);

            parameter = new SqlParameter("@idEmp", idEmp);
            parameters.Add(parameter);

            return db.ExecuteProcedure(strSQL, CommandType.StoredProcedure, parameters, ref err);
        }

        public bool deleteReceiptImport(string idBill, ref string err)
        {
            strSQL = "proc_cancelBillImport";
            parameters = new List<SqlParameter>();

            parameter = new SqlParameter("@idBill", idBill);
            parameters.Add(parameter);

            return db.ExecuteProcedure(strSQL, CommandType.StoredProcedure, parameters, ref err);
        }
    }
}
