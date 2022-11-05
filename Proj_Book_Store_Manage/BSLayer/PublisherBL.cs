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
    class PublisherBL
    {
        DBMain db = null;
        String nameView = "view_Publisher";
        string strSQL = "";
        SqlParameter parameter;
        List<SqlParameter> parameters;

        public PublisherBL()
        {
            db = new DBMain();
        }
        public DataTable getDataPublisher()
        {
            return db.LoadData(nameView, CommandType.Text);
        }
        public bool addNewPublisher(string idPublisher, string namePublisher, string addPublisher, string phoneNumber, ref string err)
        {
            strSQL = "proc_addNewPublisher";
            parameters = new List<SqlParameter>();

            parameter = new SqlParameter("@idPublisher", idPublisher);
            parameters.Add(parameter);

            parameter = new SqlParameter("@namePublisher", namePublisher);
            parameters.Add(parameter);

            parameter = new SqlParameter("@addPublisher", addPublisher);
            parameters.Add(parameter);

            parameter = new SqlParameter("@phoneNumber", phoneNumber);
            parameters.Add(parameter);

            return db.ExecuteProcedure(strSQL, CommandType.StoredProcedure, parameters, ref err);
        }
        public bool modifyPublisher(string idPublisher, string namePublisher, string addPublisher, string phoneNumber, ref string err)
        {
            strSQL = "proc_updatePublisher";
            parameters = new List<SqlParameter>();

            parameter = new SqlParameter("@idPublisher", idPublisher);
            parameters.Add(parameter);

            parameter = new SqlParameter("@namePublisher", namePublisher);
            parameters.Add(parameter);

            parameter = new SqlParameter("@addPublisher", addPublisher);
            parameters.Add(parameter);

            parameter = new SqlParameter("@phoneNumber", phoneNumber);
            parameters.Add(parameter);

            return db.ExecuteProcedure(strSQL, CommandType.StoredProcedure, parameters, ref err);
        }
        public bool deletePublisher(string idPublisher, ref string err)
        {
            strSQL = "proc_deletePublisher";
            parameters = new List<SqlParameter>();

            parameter = new SqlParameter("@idPublisher", idPublisher);
            parameters.Add(parameter);

            //String sqlString = "exec proc_updateAccount @idAccount = " + idAccount + ", @nameAccount = '" + nameAccount + "', @password = '" + password + "', @typeOfAcc = " + typeOfAcc + ", @idEmployee = " + idEmployee;
            return db.ExecuteProcedure(strSQL, CommandType.StoredProcedure, parameters, ref err);
        }
        public List<string> getAllIDPublisher()
        {
            List<string> dataIDPub = new List<string>();
            DataTable dtPublisher = new DataTable();
            dtPublisher = db.LoadData(nameView, CommandType.Text);
            foreach (DataRow row in dtPublisher.Rows)
            {
                dataIDPub.Add(row[0].ToString());
            }
            return dataIDPub;
        }
    }
}
