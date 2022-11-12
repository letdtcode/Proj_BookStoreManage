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
    public class ReceiptExportBL
    {
        DBMain db = null;
        String nameView = "view_ReceiptExport";
        string strSQL = "";
        SqlParameter parameter;
        List<SqlParameter> parameters;
        private int totalOfCurrent = 0;

        public int TotalOfCurrent { get => totalOfCurrent; set => totalOfCurrent = value; }

        public ReceiptExportBL()
        {
            db = new DBMain();
        }
        public DataTable getDataReceiptExport()
        {
            return db.LoadData(nameView, CommandType.Text);
        }
        public DataTable getDataDetailReceiptExport(string idBillOutput, ref string err)
        {
            SqlCommand cmd = new SqlCommand("Select * from dbo.func_getDataOfBillExport(@idBill)");
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@idBill", idBillOutput);
            return db.ExecuteFunction(cmd, ref err);
        }
        public bool addNewReceiptExport(string idBillOutput, ref string err)
        {
            strSQL = "proc_addNewBillOutput ";
            parameters = new List<SqlParameter>();

            parameter = new SqlParameter("@idBillOutput", idBillOutput);
            parameters.Add(parameter);

            return db.ExecuteProcedure(strSQL, CommandType.StoredProcedure, parameters, ref err);
        }
        public bool confirmReceiptExport(string idBillOutput, DateTime dateOfOutput, string idCus, string idEmployee, string idVoucher, ref string err)
        {
            strSQL = "proc_confirmBillExport ";
            parameters = new List<SqlParameter>();

            parameter = new SqlParameter("@idBillOutput", idBillOutput);
            parameters.Add(parameter);

            parameter = new SqlParameter("@dateTimeOfBill", dateOfOutput);
            parameters.Add(parameter);

            parameter = new SqlParameter("@idCus", idCus);
            parameters.Add(parameter);

            parameter = new SqlParameter("@idEmp", idEmployee);
            parameters.Add(parameter);

            parameter = new SqlParameter("@idVoucher", idVoucher);
            parameters.Add(parameter);

            return db.ExecuteProcedure(strSQL, CommandType.StoredProcedure, parameters, ref err);
        }
        
        public bool deleteReceiptExport(string idBillOutput, ref string err)
        {
            strSQL = "proc_cancelBillExport";
            parameters = new List<SqlParameter>();

            parameter = new SqlParameter("@idBill", idBillOutput);
            parameters.Add(parameter);

            return db.ExecuteProcedure(strSQL, CommandType.StoredProcedure, parameters, ref err);
        }
    }
}
