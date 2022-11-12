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
    public partial class FormSale : Form
    {
        private DataTable dtListBook = null;
        private DataTable dtListIemOfBill = null;
        private string err = "";

        DetailReceiptExport detailReceiptExport = null;
        ReceiptExportBL receiptExport = null;
        CartBL cart = null;
        VoucherBL voucher = null;
        EmployeeBL employee = new EmployeeBL();
        CustomerBL customer = new CustomerBL();
        Utilities utl = null;
        List<Control> controls = null;
        private DialogResult result;

        public FormSale(string idBill)
        {
            InitializeComponent();
            detailReceiptExport = new DetailReceiptExport(idBill);
            receiptExport = new ReceiptExportBL();
            cart = new CartBL(idBill);
            voucher = new VoucherBL();
            controls = new List<Control> { dtpReceiptExport, cbIdCustomer, cbIdVoucher };
            utl = new Utilities(controls, dgvListBook);
            this.lbIdEmployee.Text = frmLogin.idEmp;
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            cart.addNewItemIntoCart(this.lblIDBook.Text, int.Parse(this.txtAmountBook.Text.ToString()), ref err);
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
        private bool checkFill()
        {
            if (this.cbIdCustomer.Text.ToString() == "" || this.cbIdVoucher.Text.ToString() == "")
                return false;
            return true;
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (checkFill())
            {
                receiptExport.confirmReceiptExport(this.lblIDReceipt.Text, this.dtpReceiptExport.Value.Date, this.cbIdCustomer.Text, this.lbIdEmployee.Text, this.cbIdVoucher.Text, ref err);
                this.Close();
            }    
            else
                result = MessageBox.Show("Vui lòng nhập đầy đủ thông tin !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Dữ liệu sẽ không được cập nhật. Bạn có chắc chắn muốn thoát không ?", "Warnning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (result == DialogResult.OK)
            {
                receiptExport.deleteReceiptExport(this.lblIDReceipt.Text, ref err);
                this.Close();
            }
            else
            {
                return;
            }
        }
        private void LoadDataBook()
        {
 
            this.lblIDReceipt.Text = detailReceiptExport.IdBill;
            dtListBook = detailReceiptExport.getDataBook();
            dgvListBook.DataSource = dtListBook;
            dgvListBook.AutoResizeColumns();
        }

        private void FormDetailReceiptExport_Load(object sender, EventArgs e)
        {
            ReloadAllData();
            LoadDataIntoCbVoucher(voucher.getAllIdVoucher());
            LoadDataIntoCbCustomer(customer.getAllIDCustomer());
        }

        private void dgvListBook_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowCurrentIndex = dgvListBook.CurrentCell.RowIndex;
            this.lblIDBook.Text = dgvListBook.Rows[rowCurrentIndex].Cells[0].Value.ToString();
            this.lblNameBook.Text = dgvListBook.Rows[rowCurrentIndex].Cells[1].Value.ToString();
        }
        private void dgvCart_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.ColumnIndex == 3)
            {
                try
                {
                    FormEditItemSale frmEditItemSale = new FormEditItemSale(cart, senderGrid.Rows[e.RowIndex].Cells[0].Value.ToString(),int.Parse(senderGrid.Rows[e.RowIndex].Cells[2].Value.ToString()));
                    frmEditItemSale.FormClosed += Edit_FormClosed;
                    frmEditItemSale.Show();
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
                        cart.deleteItemInCart(senderGrid.Rows[e.RowIndex].Cells[0].Value.ToString(),ref err);
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
            DialogResult result = MessageBox.Show("Dữ liệu sẽ không được cập nhật. Bạn có chắc chắn muốn thoát không ?", "Warnning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (result == DialogResult.OK)
            {
                receiptExport.deleteReceiptExport(this.lblIDReceipt.Text, ref err);
                this.Close();
            }
            else
            {
                return;
            }
        }
        private void LoadDataCartIntoDgv()
        {
            dtListIemOfBill = cart.getDataItemOfBill();
            dgvCart.Columns.Clear();
            dgvCart.DataSource = dtListIemOfBill;
            DataGridViewButtonColumn editColumn = new DataGridViewButtonColumn();
            editColumn.Name = "editColumn";
            editColumn.HeaderText = "Edit";
            dgvCart.Columns.Add(editColumn);

            DataGridViewButtonColumn deleteColumn = new DataGridViewButtonColumn();
            deleteColumn.Name = "deleteColumn";
            deleteColumn.HeaderText = "Delete";
            dgvCart.Columns.Add(deleteColumn);
        }
        private void ReloadAllData()
        {
            LoadDataBook();
            LoadDataCartIntoDgv();
            this.lblTotal.Text = cart.getTotalCurrentOfBill(ref err).ToString();
        }
        private void LoadDataIntoCbVoucher(List<string> idVouchers)
        {
            cbIdVoucher.Items.Clear();
            foreach (string idVoucher in idVouchers)
            {
                cbIdVoucher.Items.Add(idVoucher);
            }
        }
        private void LoadDataIntoCbCustomer(List<string> idCustomers)
        {
            cbIdCustomer.Items.Clear();
            foreach (string idCustomer in idCustomers)
            {
                cbIdCustomer.Items.Add(idCustomer);
            }
        }
    }
}
