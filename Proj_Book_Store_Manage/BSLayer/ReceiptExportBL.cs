﻿using System;
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
        public bool addNewReceiptExport(string idBillOutput, DateTime dateOfOutput, string idCus, string idEmployee, ref string err)
        {
            strSQL = "proc_addNewBillOutput";
            parameters = new List<SqlParameter>();

            parameter = new SqlParameter("@idBillOutput", idBillOutput);
            parameters.Add(parameter);

            parameter = new SqlParameter("@dateOfOutput", dateOfOutput);
            parameters.Add(parameter);

            parameter = new SqlParameter("@idCus", idCus);
            parameters.Add(parameter);

            parameter = new SqlParameter("@idEmployee", idEmployee);
            parameters.Add(parameter);

            return db.ExecuteProcedure(strSQL, CommandType.StoredProcedure, parameters, ref err);
        }
        public bool modifyReceiptExport(string idBillOutput, DateTime dateOfBill, string idCus, string idEmployee, ref string err)
        {
            strSQL = "proc_updateBillOutput";
            parameters = new List<SqlParameter>();

            parameter = new SqlParameter("@idBillOutput", idBillOutput);
            parameters.Add(parameter);

            parameter = new SqlParameter("@dateOfBill", dateOfBill);
            parameters.Add(parameter);

            parameter = new SqlParameter("@idCus", idCus);
            parameters.Add(parameter);

            parameter = new SqlParameter("@idEmployee", idEmployee);
            parameters.Add(parameter);

            return db.ExecuteProcedure(strSQL, CommandType.StoredProcedure, parameters, ref err);
        }
        public bool deleteReceiptExport(string idBillOutput, ref string err)
        {
            strSQL = "proc_deleteBillOutput";
            parameters = new List<SqlParameter>();

            parameter = new SqlParameter("@idBillOutput", idBillOutput);
            parameters.Add(parameter);

            return db.ExecuteProcedure(strSQL, CommandType.StoredProcedure, parameters, ref err);
        }
        public bool invoiceBill(int idBillOutput, ref string err)
        {
            strSQL = "proc_invoiceBillOutput";
            parameters = new List<SqlParameter>();

            parameter = new SqlParameter("@idBillOutput", idBillOutput);
            parameters.Add(parameter);

            return db.ExecuteProcedure(strSQL, CommandType.StoredProcedure, parameters, ref err);
        }
    }
}
