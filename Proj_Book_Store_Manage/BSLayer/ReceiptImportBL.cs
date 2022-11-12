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
        public bool addNewReceiptImport(string idBillInput, DateTime dateOfInput, string idEmployee, ref string err)
        {
            strSQL = "proc_addNewBillInput";
            parameters = new List<SqlParameter>();

            parameter = new SqlParameter("@idBillInput", idBillInput);
            parameters.Add(parameter);

            parameter = new SqlParameter("@dateOfInput", dateOfInput);
            parameters.Add(parameter);

            parameter = new SqlParameter("@idEmployee", idEmployee);
            parameters.Add(parameter);

            return db.ExecuteProcedure(strSQL, CommandType.StoredProcedure, parameters, ref err);
        }
        public bool modifyReceiptImport(string idBillInput, DateTime dateOfInput, string idEmployee, ref string err)
        {
            strSQL = "proc_updateBillInput";
            parameters = new List<SqlParameter>();

            parameter = new SqlParameter("@idBillInput", idBillInput);
            parameters.Add(parameter);

            parameter = new SqlParameter("@dateOfInput", dateOfInput);
            parameters.Add(parameter);

            parameter = new SqlParameter("@idEmployee", idEmployee);
            parameters.Add(parameter);

            return db.ExecuteProcedure(strSQL, CommandType.StoredProcedure, parameters, ref err);
        }
        public bool deleteReceiptImport(string idBillInput, ref string err)
        {
            strSQL = "proc_deleteBillInput";
            parameters = new List<SqlParameter>();

            parameter = new SqlParameter("@idBillInput", idBillInput);
            parameters.Add(parameter);

            return db.ExecuteProcedure(strSQL, CommandType.StoredProcedure, parameters, ref err);
        }

        public DataTable searchReceiptImport(string id, ref string err)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = $"select * from dbo.func_searchReceiptImport('{id}')";
            cmd.CommandType = CommandType.Text;

            return db.ExecuteFunction(cmd, ref err);
        }
    }
}
