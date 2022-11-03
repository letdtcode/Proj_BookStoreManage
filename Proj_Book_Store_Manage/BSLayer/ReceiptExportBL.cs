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

        public ReceiptExportBL()
        {
            db = new DBMain();
        }
        public DataTable getDataReceiptExport()
        {
            return db.LoadData(nameView, CommandType.Text);
        }
        public bool addNewReceiptExport(string dateOfOutput, int idCus, int idEmployee, ref string err)
        {
            strSQL = "proc_addNewBillOutput";
            parameters = new List<SqlParameter>();

            parameter = new SqlParameter("@dateOfOutput", dateOfOutput);
            parameters.Add(parameter);

            parameter = new SqlParameter("@idCus", idCus);
            parameters.Add(parameter);

            parameter = new SqlParameter("@idEmployee", idEmployee);
            parameters.Add(parameter);

            return db.ExecuteProcedure(strSQL, CommandType.StoredProcedure, parameters, ref err);
        }
        public bool modifyReceiptExport(int idBillOutput, string dateOfBill, int total, int idCus, int idEmployee, ref string err)
        {
            strSQL = "proc_updateBillOutput";
            parameters = new List<SqlParameter>();

            parameter = new SqlParameter("@idBillOutput", idBillOutput);
            parameters.Add(parameter);

            parameter = new SqlParameter("@dateOfBill", dateOfBill);
            parameters.Add(parameter);

            parameter = new SqlParameter("@total", total);
            parameters.Add(parameter);

            parameter = new SqlParameter("@idCus", idCus);
            parameters.Add(parameter);

            parameter = new SqlParameter("@idEmployee", idEmployee);
            parameters.Add(parameter);

            return db.ExecuteProcedure(strSQL, CommandType.StoredProcedure, parameters, ref err);
        }
        public bool deleteReceiptExport(int idBillOutput, ref string err)
        {
            strSQL = "proc_deleteBillOutput";
            parameters = new List<SqlParameter>();

            parameter = new SqlParameter("@idBillOutput", idBillOutput);
            parameters.Add(parameter);

            return db.ExecuteProcedure(strSQL, CommandType.StoredProcedure, parameters, ref err);
        }
    }
}
