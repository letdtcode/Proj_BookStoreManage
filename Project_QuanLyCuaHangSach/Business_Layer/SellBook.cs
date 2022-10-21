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

        public SellBook()
        {
            dB = new DBMain();
        }

        public DataSet getBooks()
        {
            return dB.ExecuteQueryDataSet("select * from view_book_publisher", CommandType.Text);
        }

        public bool insertBook()
        {
            return false;
        }
    }
}
