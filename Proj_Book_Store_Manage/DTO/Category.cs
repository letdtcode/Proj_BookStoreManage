using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proj_Book_Store_Manage.DTO
{
    public class Category
    {

        private int idCategory;
        private string nameCategory;
        private string description;

        public int IdCategory { get => idCategory; set => idCategory = value; }
        public string NameCategory { get => nameCategory; set => nameCategory = value; }
        public string Description { get => description; set => description = value; }
        public Category()
        {

        }

        public Category(DataRow data)
        {
            this.IdCategory = (int)data["idCategory"];
            this.NameCategory = (string)data["nameCategory"];
            this.Description = (string)data["description"];

        }
    }
}
