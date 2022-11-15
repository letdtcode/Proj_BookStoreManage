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
        DialogResult result;

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
            this.lblIdBook.Text = idBook;
            this.lblNameBook.Text = book.getNameBook(idBook, ref err).ToString();
            this.lblInfoAmount.Text = "Số lượng sách còn trong kho: " + book.getAmountBook(idBook, ref err).ToString();
            this.nnrAmount.Value = this.amount;
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            editValue();
            this.Close();
        }
        private void editValue()
        {
            if (this.nnrAmount.Value == 0)
            {
                result = MessageBox.Show("Xác nhận xóa khỏi đơn hàng ?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);
                if (result == DialogResult.OK)
                {
                    cart.deleteItemInCart(this.idBook, ref err);
                }
                return;
            }
            cart.modifyItemInCart(this.idBook,this.amount, int.Parse(this.nnrAmount.Text.ToString()), ref err);
            if (err == "")
            {
                result = MessageBox.Show("Cập nhật thành công");
            }
            else
            {
                result = MessageBox.Show(err);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /*private void cbIDBook_SelectedValueChanged(object sender, EventArgs e)
        {
            ComboBox cbb = sender as ComboBox;
            this.lblNameBook.Text = book.getNameBook(cbb.SelectedItem.ToString(), ref err).ToString();
            this.lblInfoAmount.Text = "Số lượng sách còn trong kho: " + book.getAmountBook(cbb.SelectedItem.ToString(), ref err).ToString();
        }*/
    }
}
