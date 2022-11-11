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
    public partial class FormEditItemSale : Form
    {
        CartBL cart = null;
        private string idBook = null;
        private int amount;
        BookBL book = null;
        string err = null;

        public FormEditItemSale(CartBL cart, string idBook, int amount)
        {
            InitializeComponent();
            this.cart = cart;
            this.idBook = idBook;
            this.amount = amount;
            this.book = new BookBL();
        }
        private void FormEditDetailReceiptExport_Load(object sender, EventArgs e)
        {
            this.cbIDBook.Text = idBook;
            this.lblNameBook.Text = book.getNameBook(idBook, ref err).ToString();
            int index = -1;
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
            editValue();
            this.Close();
        }
        private void editValue()
        {
            cart.modifyItemInCart(this.idBook, this.cbIDBook.Text, this.amount, int.Parse(this.txtAmount.Text.ToString()), ref err);
            if (err == "")
            {
                MessageBox.Show("Cập nhật thành công");
            }
            else
            {
                MessageBox.Show(err);
            }
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
