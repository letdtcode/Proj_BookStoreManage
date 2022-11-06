﻿using System;
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
    public class BookBL
    {
        private DBMain db = null;
        private String nameView = "view_Book";
        SqlParameter parameter;
        List<SqlParameter> parameters;
        string strSQL = "";

        public BookBL()
        {
            db = new DBMain();
        }
        
        public Image ByteArrayToImage(byte[] byteArrayIn)
        {
            using (MemoryStream mStream = new MemoryStream(byteArrayIn))
            {
                return Image.FromStream(mStream);
            }
        }
        public byte[] ImgToByteArray(Image img)
        {
            byte[] imgByte = null;
            if (img != null)
            {
                MemoryStream ms = new MemoryStream();
                img.Save(ms, img.RawFormat);
                imgByte = ms.ToArray();
                ms.Close();
                return imgByte;
            }
            else
                return null;
        }
        public DataTable getDataBook()
        {
            DataTable dtBook = new DataTable();
            dtBook = db.LoadData(nameView, CommandType.Text);
            dtBook.Columns.Add("Hình ảnh", typeof(Image));
            foreach (DataRow row in dtBook.Rows)
            {
                row["Hình ảnh"] = ByteArrayToImage((byte[])row[2]);
            }
            dtBook.Columns.Remove("urlImage");
            return dtBook;
        }

        public bool addNewBook(string idBook, string nameBook, Image img, int amount, int priceImport, int priceExport, string idPublisher, ref string err)
        {
            strSQL = "proc_addNewBook";
            byte[] imgString = ImgToByteArray(img);
            parameters = new List<SqlParameter>();

            parameter = new SqlParameter("@idBook", idBook);
            parameters.Add(parameter);

            parameter = new SqlParameter("@nameBook", nameBook);
            parameters.Add(parameter);

            parameter = new SqlParameter("@urlImage", imgString);
            parameters.Add(parameter);

            parameter = new SqlParameter("@amount", amount);
            parameters.Add(parameter);

            parameter = new SqlParameter("@priceImport", priceImport);
            parameters.Add(parameter);

            parameter = new SqlParameter("@priceExport", priceExport);
            parameters.Add(parameter);

            parameter = new SqlParameter("@idPublisher", idPublisher);
            parameters.Add(parameter);

            return db.ExecuteProcedure(strSQL, CommandType.StoredProcedure, parameters, ref err);
        }
        public bool modifyBook(string idBook, string nameBook, Image img, int amount, int priceImport, int priceExport, string idPublisher, ref string err)
        {
            strSQL = "proc_updateBook";
            byte[] imgString = ImgToByteArray(img);
            parameters = new List<SqlParameter>();

            parameter = new SqlParameter("@idBook", idBook);
            parameters.Add(parameter);

            parameter = new SqlParameter("@nameBook", nameBook);
            parameters.Add(parameter);

            parameter = new SqlParameter("@urlImage", imgString);
            parameters.Add(parameter);

            parameter = new SqlParameter("@amount", amount);
            parameters.Add(parameter);

            parameter = new SqlParameter("@priceImport", priceImport);
            parameters.Add(parameter);

            parameter = new SqlParameter("@priceExport", priceExport);
            parameters.Add(parameter);

            parameter = new SqlParameter("@idPublisher", idPublisher);
            parameters.Add(parameter);

            return db.ExecuteProcedure(strSQL, CommandType.StoredProcedure, parameters, ref err);
        }
        public bool deleteBook(string idBook, ref string err)
        {
            strSQL = "proc_DeleteBook";
            parameters = new List<SqlParameter>();

            parameter = new SqlParameter("@idBook", idBook);
            parameters.Add(parameter);

            return db.ExecuteProcedure(strSQL, CommandType.StoredProcedure, parameters, ref err);
        }
        public DataTable showCategory(string idBook, ref string err)
        {
            SqlCommand cmd = new SqlCommand("Select * from func_getAllCategoryOfBook(@idBook)");
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@idBook", idBook);
            return db.ExecuteFunction(cmd, ref err);
        }
        public DataTable showAuthor(string idBook, ref string err)
        {
            SqlCommand cmd = new SqlCommand("Select * from func_getAllAuthorOfBook(@idBook)");
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@idBook", idBook);
            return db.ExecuteFunction(cmd, ref err);
        }
        public bool addNewBookCategory(string idBook, string nameCategory, ref string err)
        {
            strSQL = "proc_addNewBookCategory";
            parameters = new List<SqlParameter>();

            parameter = new SqlParameter("@idBook", idBook);
            parameters.Add(parameter);

            parameter = new SqlParameter("@nameCategory", nameCategory);
            parameters.Add(parameter);

            return db.ExecuteProcedure(strSQL, CommandType.StoredProcedure, parameters, ref err);
        }
        public bool modifyBookCategory(string idBook, string nameCategory, string nameNewCategory, ref string err)
        {
            strSQL = "proc_updateBookCategory";
            parameters = new List<SqlParameter>();

            parameter = new SqlParameter("@idBook", idBook);
            parameters.Add(parameter);

            parameter = new SqlParameter("@nameCategory", nameCategory);
            parameters.Add(parameter);

            parameter = new SqlParameter("@nameNewCategory", nameNewCategory);
            parameters.Add(parameter);

            return db.ExecuteProcedure(strSQL, CommandType.StoredProcedure, parameters, ref err);
        }
        public bool deleteBookCategory(string idBook, string nameCategory, ref string err)
        {
            strSQL = "proc_deleteBookCategory";
            parameters = new List<SqlParameter>();

            parameter = new SqlParameter("@idBook", idBook);
            parameters.Add(parameter);

            parameter = new SqlParameter("@nameCategory", nameCategory);
            parameters.Add(parameter);

            return db.ExecuteProcedure(strSQL, CommandType.StoredProcedure, parameters, ref err);
        }

        public bool addNewBookAuthor(string idBook, string nameAuthor, ref string err)
        {
            strSQL = "proc_addNewBookAuthor";
            parameters = new List<SqlParameter>();

            parameter = new SqlParameter("@idBook", idBook);
            parameters.Add(parameter);

            parameter = new SqlParameter("@nameAuthor", nameAuthor);
            parameters.Add(parameter);

            return db.ExecuteProcedure(strSQL, CommandType.StoredProcedure, parameters, ref err);
        }
        public bool modifyBookAuthor(string idBook, string nameAuthor, string nameNewAuthor, ref string err)
        {
            strSQL = "proc_updateBookAuthor";
            parameters = new List<SqlParameter>();

            parameter = new SqlParameter("@idBook", idBook);
            parameters.Add(parameter);

            parameter = new SqlParameter("@nameAuthor", nameAuthor);
            parameters.Add(parameter);

            parameter = new SqlParameter("@nameNewAuthor", nameNewAuthor);
            parameters.Add(parameter);

            return db.ExecuteProcedure(strSQL, CommandType.StoredProcedure, parameters, ref err);
        }
        public bool deleteBookAuthor(string idBook, string nameAuthor, ref string err)
        {
            strSQL = "proc_deleteBookAuthor";
            parameters = new List<SqlParameter>();

            parameter = new SqlParameter("@idBook", idBook);
            parameters.Add(parameter);

            parameter = new SqlParameter("@nameAuthor", nameAuthor);
            parameters.Add(parameter);

            return db.ExecuteProcedure(strSQL, CommandType.StoredProcedure, parameters, ref err);
        }
        /*public DataTable addNewCateForBook(int idBook, int nameBook, ref string err)
        {
            strSQL = "proc_addNewBookCategory";
            parameters = new List<SqlParameter>();

            parameter = new SqlParameter("@idBook", idBook);
            parameters.Add(parameter);

            parameter = new SqlParameter("@idCategory", nameBook);
            parameters.Add(parameter);

            parameter = new SqlParameter("@urlImage", imgString);
            parameters.Add(parameter);

            parameter = new SqlParameter("@amount", amount);
            parameters.Add(parameter);

            parameter = new SqlParameter("@priceImport", priceImport);
            parameters.Add(parameter);

            parameter = new SqlParameter("@priceExport", priceExport);
            parameters.Add(parameter);

            parameter = new SqlParameter("@idPublisher", idPublisher);
            parameters.Add(parameter);

            return db.ExecuteProcedure(strSQL, CommandType.StoredProcedure, parameters, ref err);
        }*/
    }
}




