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
    public partial class FormImportBook : Form
    {
        private ImportBooksBL importBook = null;
        private string err = null;
        private DataTable dtListIemOfBill = null;
        private ReceiptImportBL receiptImport = null;
        private DialogResult result;
        private BookBL book = null;
        public FormImportBook(string idBillImport)
        {
            InitializeComponent();
            this.lbIdEmployee.Text = frmLogin.idEmp;
            this.lblIdBill.Text = idBillImport;
            importBook = new ImportBooksBL(idBillImport);
            receiptImport = new ReceiptImportBL();
            book = new BookBL();
            LoadDataIntoCbIdBook(book.getAllIdBook());
        }

        private void btnAddItem_Click(object sender, EventArgs e)
        {
            importBook.addNewItemIntoWarehouse(this.cbIdBook.Text, int.Parse(this.txtAmountBook.Text.ToString()), ref err);
            if (err == "")
            {
                MessageBox.Show("Thành công");
            }
            else
            {
                MessageBox.Show(err);
            }
            ReloadAllData();
        }
        private void ReloadAllData()
        {
            dtListIemOfBill = importBook.getDataItemOfBill();
            dgvListItemImport.Columns.Clear();
            dgvListItemImport.DataSource = dtListIemOfBill;
            DataGridViewButtonColumn editColumn = new DataGridViewButtonColumn();
            editColumn.Name = "editColumn";
            editColumn.HeaderText = "Edit";
            dgvListItemImport.Columns.Add(editColumn);

            DataGridViewButtonColumn deleteColumn = new DataGridViewButtonColumn();
            deleteColumn.Name = "deleteColumn";
            deleteColumn.HeaderText = "Delete";
            dgvListItemImport.Columns.Add(deleteColumn);

            this.lblTotalBill.Text = importBook.getTotalCurrentOfBill(ref err).ToString();
        }
        private void btnInvoiceBill_Click(object sender, EventArgs e)
        {
            receiptImport.confirmReceiptImport(this.lblIdBill.Text, this.dtpDateImport.Value.Date, this.lbIdEmployee.Text, ref err);
            this.Close();
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            result = MessageBox.Show("Dữ liệu sẽ không được cập nhật. Bạn có chắc chắn muốn thoát không ?", "Warnning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (result == DialogResult.OK)
            {
                receiptImport.deleteReceiptImport(this.lblIdBill.Text, ref err);
                this.Close();
            }
            else
            {
                return;
            }
        }

        private void dgvListItemImport_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.ColumnIndex == 3)
            {
                try
                {
                    FormEditItemImportBooks frmEditItemImportBooks = new FormEditItemImportBooks(importBook, senderGrid.Rows[e.RowIndex].Cells[0].Value.ToString(), int.Parse(senderGrid.Rows[e.RowIndex].Cells[2].Value.ToString()));
                    frmEditItemImportBooks.FormClosed += Edit_FormClosed;
                    frmEditItemImportBooks.Show();
                }
                catch
                {
                    MessageBox.Show("Dữ liệu không tồn tại");
                }

            }
            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.ColumnIndex == 4)
            {
                try
                {
                    DialogResult result = MessageBox.Show("Xác nhận xóa khỏi đơn hàng", "Xác nhận", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                    if (result == DialogResult.OK)
                    {
                        importBook.deleteItemInCart(senderGrid.Rows[e.RowIndex].Cells[0].Value.ToString(), ref err);
                        ReloadAllData();
                    }
                }
                catch
                {
                    MessageBox.Show("Dữ liệu không tồn tại");
                }

            }
        }

        private void Edit_FormClosed(object sender, FormClosedEventArgs e)
        {
            ReloadAllData();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            result = MessageBox.Show("Dữ liệu sẽ không được cập nhật. Bạn có chắc chắn muốn thoát không ?", "Warnning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (result == DialogResult.OK)
            {
                receiptImport.deleteReceiptImport(this.lblIdBill.Text, ref err);
                this.Close();
            }
            else
            {
                return;
            }
        }
        private void LoadDataIntoCbIdBook(List<string> idBooks)
        {
            cbIdBook.Items.Clear();
            foreach (string idBook in idBooks)
            {
                cbIdBook.Items.Add(idBook);
            }
        }

        private void FormImportBook_Load(object sender, EventArgs e)
        {
            ReloadAllData();
        }

        private void cbIdBook_SelectedIndexChanged(object sender, EventArgs e)
        {
            string idBook = cbIdBook.Text.ToString();
            this.lblNameBook.Text = book.getNameBook(idBook, ref err);
        }
    }
}
