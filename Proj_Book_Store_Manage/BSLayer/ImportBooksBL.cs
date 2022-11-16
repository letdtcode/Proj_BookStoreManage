using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Proj_Book_Store_Manage.DBLayer;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
namespace Proj_Book_Store_Manage.BSLayer
{
    public class ImportBooksBL
    {
        private DBMain db = null;
        SqlParameter parameter;
        List<SqlParameter> parameters;
        string strSQL = "";
        private string idBill = null;
        private string err = "";
        public ImportBooksBL(string idBill)
        {
            this.idBill = idBill;
            db = new DBMain();
        }

        public string IdBill { get => idBill; set => idBill = value; }
        public DataTable getDataBook()
        {
            return db.LoadData("view_GetAllBookForSale", CommandType.Text);
        }
        public DataTable getDataItemOfBill()
        {
            SqlCommand cmd = new SqlCommand("select * from dbo.func_getDataOfBillImport(@idBill)");
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@idBill", IdBill);
            return db.ExecuteFunction(cmd, ref err);
        }
        public bool addNewItemIntoWarehouse(string idBook, int amount, ref string err)
        {
            strSQL = "proc_addNewBookBillInput";
            parameters = new List<SqlParameter>();

            parameter = new SqlParameter("@idBillInput", idBill);
            parameters.Add(parameter);

            parameter = new SqlParameter("@idBook", idBook);
            parameters.Add(parameter);

            parameter = new SqlParameter("@amountInput", amount);
            parameters.Add(parameter);

            return db.ExecuteProcedure(strSQL, CommandType.StoredProcedure, parameters, ref err);
        }
        public int getTotalCurrentOfBill(ref string err)
        {
            SqlCommand cmd = new SqlCommand("Select dbo.func_returnToTalOfBillInput(@idBill)");
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@idBill", idBill);
            return db.ExecuteFunctionToInt(cmd, ref err);
        }
        public bool deleteItemInCart(string @idBook, ref string err)
        {
            strSQL = "proc_deleteBookBillInput";
            parameters = new List<SqlParameter>();

            parameter = new SqlParameter("@idBillInput", idBill);
            parameters.Add(parameter);

            parameter = new SqlParameter("@idBook", idBook);
            parameters.Add(parameter);

            return db.ExecuteProcedure(strSQL, CommandType.StoredProcedure, parameters, ref err);
        }
        public bool modifyItemInCart(string idBook, int amountBook, int amountNewBook, ref string err)
        {
            strSQL = "proc_updateBookBillInput";
            parameters = new List<SqlParameter>();

            parameter = new SqlParameter("@idBillImport", idBill);
            parameters.Add(parameter);

            parameter = new SqlParameter("@idBook", idBook);
            parameters.Add(parameter);

            parameter = new SqlParameter("@amountBook", amountBook);
            parameters.Add(parameter);

            parameter = new SqlParameter("@amountNewBook", amountNewBook);
            parameters.Add(parameter);

            return db.ExecuteProcedure(strSQL, CommandType.StoredProcedure, parameters, ref err);
        }
    }
}
