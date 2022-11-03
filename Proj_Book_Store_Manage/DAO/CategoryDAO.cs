using Proj_Book_Store_Manage.BSLayer;
using Proj_Book_Store_Manage.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Proj_Book_Store_Manage.DAO
{
    public class CategoryDAO
    {
        private static CategoryDAO instance;
        public static CategoryDAO Instance
        {
            get { if (instance == null) instance = new CategoryDAO(); return instance; }
            private set { instance = value; }
        }
        public List<Category> LoadCategory()
        {
            List<Category> list = new List<Category>();
            string query = "select * from CATEGORY ";
            DataTable table = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow data in table.Rows)
            {
                Category tb = new Category(data);
                list.Add(tb);
            }
            return list;
        }
        public List<Category> LoadCategoryById(int id)
        {
            List<Category> list = new List<Category>();
            //string query = "select * from CATEGORY ";
            DataTable table = DataProvider.Instance.ExecuteQuery("exec sp_SearchCategroyById @id ", new object[] { id });

            foreach (DataRow data in table.Rows)
            {
                Category tb = new Category(data);
                list.Add(tb);
            }
            return list;
        }

        public List<Category> LoadCategoryByName(string name)
        {
            List<Category> list = new List<Category>();
            //string query = "select * from CATEGORY ";
            DataTable table = DataProvider.Instance.ExecuteQuery("exec sp_SearchCategoryByName @nameCategory ", new object[] { name });

            foreach (DataRow data in table.Rows)
            {
                Category tb = new Category(data);
                list.Add(tb);
            }
            return list;
        }
        public void InsertCategory(string name, string description)
        {
            DataProvider.Instance.ExecuteNonQuery("exec sp_InsertCategory @name , @description", new object[] { name , description});
        }
        public void DeleteCategory(int id)
        {
            DataProvider.Instance.ExecuteNonQuery("exec sp_DeleteCategory @id ", new object[] { id });
        }
        public void UpdateCategory(int id, string name, string description)
        {
            DataProvider.Instance.ExecuteNonQuery("exec sp_UpdateCategory @id , @name , @description", new object[] { id, name , description});
        }
        public int getIdmaxCategory()
        {
            return (int)DataProvider.Instance.ExecuteScalar("select MAX(idCategory) from CATEGORY");
        }

        public CategoryDAO() {  }
    }
}
