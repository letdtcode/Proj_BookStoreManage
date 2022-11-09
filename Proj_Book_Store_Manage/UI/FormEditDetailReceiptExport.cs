using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Proj_Book_Store_Manage.BSLayer;

namespace Proj_Book_Store_Manage.UI
{
    public partial class FormEditDetailReceiptExport : Form
    {
        CartBL cart = null;
        string idBook;
        BookBL book = null;
        string err = null;

        public FormEditDetailReceiptExport(CartBL cart, string idBook)
        {
            InitializeComponent();
            this.cart = cart;
            this.idBook = idBook;
            this.book = new BookBL();
        }
        private void FormEditDetailReceiptExport_Load(object sender, EventArgs e)
        {
            //this.lblAnnounce.Text = IdBill;
            /*this.cbIDBook.Text = dgv.Rows[rowIndex].Cells[0].Value.ToString();
            this.lblNameBook.Text = dgv.Rows[rowIndex].Cells[1].Value.ToString();
            this.txtAmount.Text = dgv.Rows[rowIndex].Cells[2].Value.ToString();*/
            int index = -1;
            foreach(string idBook in cart.IdBooks)
            {
                if (this.idBook == idBook)
                {
                    index = cart.IdBooks.IndexOf(idBook);
                    break;
                }
            }
            this.cbIDBook.Text = idBook;
            this.lblNameBook.Text = cart.NameBooks[index].ToString();
            this.lblInfoAmount.Text = "Số lượng sách còn trong kho: " + book.getAmountBook(idBook, ref err).ToString();
            loadDataIDBook();
        }
        private void loadDataIDBook()
        {
            cbIDBook.Items.Clear();
            foreach(string idBook in book.getAllIdBook())
            {
                cbIDBook.Items.Add(idBook);
            }
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            /*this.IdBook = this.cbIDBook.Text;
            this.NameBook = this.lblNameBook.Text;
            this.AmountBook = int.Parse(this.txtAmount.Text.ToString());*/
            editValue();
            this.Close();
        }
        private void editValue()
        {
            cart.editItemInCart(this.cbIDBook.Text, this.cbIDBook.Text, int.Parse(this.txtAmount.Text.ToString()));
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cbIDBook_SelectedValueChanged(object sender, EventArgs e)
        {
            ComboBox cbb = sender as ComboBox;
            this.lblNameBook.Text = book.getNameBook(cbb.SelectedItem.ToString(), ref err).ToString();
            this.lblInfoAmount.Text = "Số lượng sách còn trong kho: " + book.getAmountBook(cbb.SelectedItem.ToString(), ref err).ToString();
        }
    }
}
