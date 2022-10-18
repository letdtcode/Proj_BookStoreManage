using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project_QuanLyCuaHangSach.DB_Layer;
using System.Data;
using System.Data.SqlClient;

namespace Project_QuanLyCuaHangSach.Business_Layer
{
    internal class Customer
    {
        DBMain db;

        SqlParameter parameter;
        string err;
        public Customer()
        {
            db = new DBMain();
        }

        void setParameter()
        {

        }

        public DataSet LayThongTinKhachHang()
        {
            return db.ExecuteQueryDataSet("select * from view_customer_bookOutput", CommandType.Text);
        }


        public bool SuaThognTinKhachHang(int id, string name, string address, string phoneNumber, ref string err)
        {
            List<SqlParameter> parameters = new List<SqlParameter>();

            string strSQL = "UpdateCustomer";

            parameter = new SqlParameter("@id", id);
            parameters.Add(parameter);

            parameter = new SqlParameter("@name", name);
            parameters.Add(parameter);

            parameter = new SqlParameter("@address", address);
            parameters.Add(parameter);

            parameter = new SqlParameter("@phoneNumber", phoneNumber);
            parameters.Add(parameter);


            return db.MyExecuteNonQuery(strSQL, CommandType.StoredProcedure, parameters, ref err);
        }

        public DataSet TimKiemKhacHang(int id)
        {
            string strSQL = "select * from view_customer_bookOutput where idCus = " + id; 
            return db.ExecuteQueryDataSet(strSQL, CommandType.Text);
        }


    }
}
