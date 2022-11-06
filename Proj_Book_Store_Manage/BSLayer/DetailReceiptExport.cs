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
    public class DetailReceiptExport
    {
        DBMain db = null;
        String nameView = "view_DetailReceiptExport";
        string strSQL = "";
        SqlParameter parameter;
        List<SqlParameter> parameters;
        private int totalOfCurrent = 0;

        public DetailReceiptExport()
        {
            db = new DBMain();
        }
        public DataTable getDataDetailReceiptExport()
        {
            return db.LoadData(nameView, CommandType.Text);
        }
    }
}
