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
    public class CartBL
    {
        private List<string> idBooks = null;
        private List<string> nameBooks = null;
        private List<int> amountBooks = null;
        private int totalBill = 0;
        private BookBL book = null;
        private string err = null;
        public CartBL()
        {
            
            IdBooks = new List<string>();
            NameBooks = new List<string>();
            AmountBooks = new List<int>();
            book = new BookBL();
        }

        public List<string> IdBooks { get => idBooks; set => idBooks = value; }
        public List<string> NameBooks { get => nameBooks; set => nameBooks = value; }
        public List<int> AmountBooks { get => amountBooks; set => amountBooks = value; }
        public int TotalBill { get => totalBill; set => totalBill = value; }

        public void addNewItemIntoCart(string idBook, string nameBook, int amountBook)
        {
            IdBooks.Add(idBook);
            NameBooks.Add(nameBook);
            AmountBooks.Add(amountBook);
            totalInCart();

        }
        public void editItemInCart(string idOldBook, string idNewBook, int amount)
        {
            int index = -1;
            string nameNewBook = book.getNameBook(idNewBook, ref err);
            foreach(string id in idBooks)
            {
                if (id == idOldBook)
                {
                    index = idBooks.IndexOf(id);
                    id.Replace(idOldBook, idNewBook);
                }
            }
            amountBooks[index] = amount;
            nameBooks[index] = nameNewBook;
            totalInCart();
        }
        public void deleteItemInCart(string idBook)
        {
            int index = -1;
            foreach (string id in idBooks)
            {
                if (id == idBook)
                {
                    index = idBooks.IndexOf(id);
                }
            }
            idBooks.Remove(idBook);
            nameBooks.RemoveAt(index);
            amountBooks.RemoveAt(index);
            totalInCart();
        }
        public void totalInCart()
        {
            totalBill = 0; 
            int index = -1;
            if (!idBooks.Any())
            {
                return;
            }
            foreach(string idBook in idBooks)
            {
                index = idBook.IndexOf(idBook);
                totalBill += (book.getPriceExportOfBook(idBook, ref err) * amountBooks[index]);
            }
        }
    }
}
