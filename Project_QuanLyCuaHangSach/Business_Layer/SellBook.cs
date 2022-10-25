using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

using Project_QuanLyCuaHangSach.DB_Layer;

namespace Project_QuanLyCuaHangSach.Business_Layer
{
    internal class SellBook
    {
        DBMain dB;

        SqlParameter parameter;
        List<SqlParameter> parameters;

        public SellBook()
        {
            dB = new DBMain();
        }

        
        public bool createBill(int idCus, int idEmp, DateTime date, ref string err)
        {
            string strSql = "CreateBillOutPut";


            parameters = new List<SqlParameter>();

            parameter = new SqlParameter("@idCus", idCus);
            parameters.Add(parameter);

            parameter = new SqlParameter("@idCus", idCus);
            parameters.Add(parameter);

            return dB.MyExecuteNonQuery(strSql, CommandType.StoredProcedure, parameters, ref err);
        }

        public DataSet getBill()
        {
            return dB.ExecuteQueryDataSet("GetAllBill", CommandType.StoredProcedure);
        }

        public DataSet getBill(int idBill)
        {
            parameters = new List<SqlParameter>();

            parameter = new SqlParameter("@idBill", idBill);
            parameters.Add(parameter);

            return dB.ExecuteQueryDataSet("GetBill", CommandType.StoredProcedure, parameters);
        }

        public DataSet getCart(int id)
        {
            parameters = new List<SqlParameter>();

            parameter = new SqlParameter("@idBill", id);
            parameters.Add(parameter);

            return dB.ExecuteQueryDataSet("GetCart", CommandType.StoredProcedure, parameters);
        }


        public bool addBookToCart (int idBill, int idBook, int amount, ref string err)
        {
            parameters = new List<SqlParameter>();

            parameter = new SqlParameter("@idBill", idBill);
            parameters.Add(parameter);

            parameter = new SqlParameter("@idBook", idBook);
            parameters.Add(parameter);

            parameter = new SqlParameter("@amount", amount);
            parameters.Add(parameter);

            string strSql = "AddBookToCart";
            return dB.MyExecuteNonQuery(strSql, CommandType.StoredProcedure, parameters, ref err);
        }

        public bool deleteBookFromCart (int idBill, int idBook, ref string err)
        {
            parameters = new List<SqlParameter>();

            parameter = new SqlParameter("@idBill", idBill);
            parameters.Add(parameter);

            parameter = new SqlParameter("@idBook", idBook);
            parameters.Add(parameter);

            string strSql = "DeleteBookFromCart";
            return dB.MyExecuteNonQuery(strSql, CommandType.StoredProcedure, parameters, ref err);
        }

        public bool updateAmountBookInCart(int idBill, int idBook, int amount, ref string err)
        {
            parameters = new List<SqlParameter>();

            parameter = new SqlParameter("@idBill", idBill);
            parameters.Add(parameter);

            parameter = new SqlParameter("@idBook", idBook);
            parameters.Add(parameter);

            parameter = new SqlParameter("@amount", amount);
            parameters.Add(parameter);

            string strSql = "UpdateAmountBookInCart";
            return dB.MyExecuteNonQuery(strSql, CommandType.StoredProcedure, parameters, ref err);
        }


        public bool addVoucher(int idBill, int idVoucher, ref string err)
        {
            parameters = new List<SqlParameter>();

            parameter = new SqlParameter("@idBill", idBill);
            parameters.Add(parameter);

            parameter = new SqlParameter("@idVoucher", idVoucher);
            parameters.Add(parameter);

            string strSql = "AddVoucher";
            return dB.MyExecuteNonQuery(strSql, CommandType.StoredProcedure, parameters, ref err);

        }

        public bool deleteVoucher(int idBill, ref string err)
        {
            parameters = new List<SqlParameter>();

            parameter = new SqlParameter("@idBill", idBill);
            parameters.Add(parameter);

            string strSql = "RemoveVoucher";
            return dB.MyExecuteNonQuery(strSql, CommandType.StoredProcedure, parameters, ref err);
        }

        public DataSet getVoucher (DateTime date)
        {
            parameters = new List<SqlParameter>();

            parameter = new SqlParameter("@date", date);
            parameters.Add(parameter);

            string strSql = "GetVoucher";
            return dB.ExecuteQueryDataSet(strSql, CommandType.StoredProcedure, parameters);
        }


    }
}
