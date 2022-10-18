using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Project_QuanLyCuaHangSach.DB_Layer;
using System.Data.SqlClient;

namespace Project_QuanLyCuaHangSach.Business_Layer
{
    internal class Book
    {
        DBMain db;

        List<SqlParameter> paramets;
        SqlParameter paramet;

        public Book()
        {
            db = new DBMain();
        }

        public DataSet LayThongTinSach ()
        {
            return db.ExecuteQueryDataSet("select * from view_Book_BillOutput", CommandType.);
        }

        public DataSet TimSach (int id)
        {
            return db.ExecuteQueryDataSet("select * from view_Book_BillOutput where = " + id, CommandType.Text);
        }

        public bool SuaThongTinSach(int id, string name, string theLoai, string NXB, ref string err)
         {
            string strSQL = "UpdateBook";
            paramets.Add(paramet);

            paramet = new SqlParameter("@id", id);
            paramets.Add(paramet);

            paramet = new SqlParameter("@name", name);
            paramets.Add(paramet);

            paramet = new SqlParameter("@theLoai", theLoai);
            paramets.Add(paramet);

            paramet = new SqlParameter("@NXB", NXB);
            paramets.Add(paramet);

            return db.MyExecuteNonQuery(strSQL, CommandType.StoredProcedure, paramets, ref err);
        }

        public bool ThemSach (string name, int idNXB, int priceImport, int priceOut, string theLoai, ref string err)
        {
            string strSQL = "InsertBook";
            paramets.Add(paramet);

            paramet = new SqlParameter("@priceOut", priceOut);
            paramets.Add(paramet);

            paramet = new SqlParameter("@name", name);
            paramets.Add(paramet);

            paramet = new SqlParameter("@theLoai", theLoai);
            paramets.Add(paramet);

            paramet = new SqlParameter("@idNXB", idNXB);
            paramets.Add(paramet);

            paramet = new SqlParameter("@priceImport", priceImport);
            paramets.Add(paramet);

            return db.MyExecuteNonQuery(strSQL, CommandType.StoredProcedure, paramets, ref err);
        }

        public bool XoaSach
    }
}
