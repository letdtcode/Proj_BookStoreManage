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
    public class VoucherBL
    {
        private DBMain db = null;
        private String nameView = "view_Voucher";
        private string strSQL = "";
        private SqlParameter parameter;
        private List<SqlParameter> parameters;

        public VoucherBL()
        {
            db = new DBMain();
        }
        public DataTable getDataVoucher()
        {
            return db.LoadData(nameView, CommandType.Text);
        }
        public bool addNewVoucher(int valueVoucher, string nameOfEvent, string dateStart, string dateEnd, int amount, ref string err)
        {
            strSQL = "proc_addNewVoucher";
            parameters = new List<SqlParameter>();

            parameter = new SqlParameter("@valueVoucher", valueVoucher);
            parameters.Add(parameter);

            parameter = new SqlParameter("@nameOfEvent", nameOfEvent);
            parameters.Add(parameter);

            parameter = new SqlParameter("@dateStart", dateStart);
            parameters.Add(parameter);

            parameter = new SqlParameter("@dateEnd", dateEnd);
            parameters.Add(parameter);

            parameter = new SqlParameter("@amount", amount);
            parameters.Add(parameter);

            //String sqlString = "exec"+ @nameAccount = '" + nameAccount + "', @password = '" + passWord + "', @typeOfAcc = " + typeOfAcc.ToString() + ", @idEmployee = " + idEmployee.ToString() ;
            return db.ExecuteProcedure(strSQL, CommandType.StoredProcedure, parameters, ref err);
        }
        public bool modifyVoucher(int idVoucher, int valueVoucher, string nameOfEvent, string dateStart, string dateEnd, int amount, ref string err)
        {
            strSQL = "proc_updateVoucher";
            parameters = new List<SqlParameter>();

            parameter = new SqlParameter("@idVoucher", idVoucher);
            parameters.Add(parameter);

            parameter = new SqlParameter("@valueVoucher", valueVoucher);
            parameters.Add(parameter);

            parameter = new SqlParameter("@nameOfEvent", nameOfEvent);
            parameters.Add(parameter);

            parameter = new SqlParameter("@dateStart", dateStart);
            parameters.Add(parameter);

            parameter = new SqlParameter("@dateEnd", dateEnd);
            parameters.Add(parameter);

            parameter = new SqlParameter("@amount", amount);
            parameters.Add(parameter);

            return db.ExecuteProcedure(strSQL, CommandType.StoredProcedure, parameters, ref err);
        }
        public bool deleteVoucher(int idVoucher, ref string err)
        {
            strSQL = "proc_deleteVoucher";
            parameters = new List<SqlParameter>();

            parameter = new SqlParameter("@idVoucher", idVoucher);
            parameters.Add(parameter);

            return db.ExecuteProcedure(strSQL, CommandType.StoredProcedure, parameters, ref err);
        }
    }
}
