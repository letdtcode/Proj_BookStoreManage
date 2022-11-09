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
    public partial class FormDetailReceiptExport : Form
    {
        private DataTable dtListBook = null;
        //private DataTable dtListIemOfBill = null;
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

        public FormDetailReceiptExport(string idBill)
        {
            InitializeComponent();
            detailReceiptExport = new DetailReceiptExport(idBill);
            receiptExport = new ReceiptExportBL();
            cart = new CartBL();
            voucher = new VoucherBL();
            controls = new List<Control> { dtpReceiptExport, cbIdEmployee, cbIdCustomer, cbIdVoucher };
            utl = new Utilities(controls, dgvListBook);
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            int index = -1;
            bool isExist = false;
            try
            {
                if (cart.IdBooks.Count == 0)
                {
                    cart.addNewItemIntoCart(this.lblIDBook.Text, this.lblNameBook.Text, int.Parse(this.txtAmountBook.Text.ToString()));
                    LoadDataCartIntoDgv();
                    return;
                }
                foreach (string idBook in cart.IdBooks)
                {
                    if (idBook == this.lblIDBook.Text.ToString())
                    {
                        isExist = true;
                        index = cart.IdBooks.IndexOf(idBook);
                        break;
                    }
                }
                if (isExist == true)
                {
                    cart.editItemInCart(this.lblIDBook.Text, this.lblIDBook.Text, int.Parse(this.txtAmountBook.Text.ToString()) + cart.AmountBooks[index]);
                }
                else
                {
                    cart.addNewItemIntoCart(this.lblIDBook.Text, this.lblNameBook.Text, int.Parse(this.txtAmountBook.Text.ToString()));
                }
                LoadDataCartIntoDgv();
            }
            catch
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (utl.checkAllControlIsFill() == false)
                {
                    result = MessageBox.Show("Vui lòng nhập đầy đủ thông tin !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                //Tạo hóa đơn
                receiptExport.addNewReceiptExport(this.lblIDReceipt.Text, this.dtpReceiptExport.Value.Date, int.Parse(this.lblTotal.Text.ToString()), this.cbIdCustomer.Text.ToString(), this.cbIdEmployee.Text.ToString(), this.cbIdVoucher.Text.ToString(), ref err);
                //Thêm dữ liệu item xuống db
                int indexOfIdBook = -1;
                foreach(string idBook in cart.IdBooks)
                {
                    indexOfIdBook = cart.IdBooks.IndexOf(idBook);
                    detailReceiptExport.addNewDetailReceiptExport(idBook, cart.AmountBooks[indexOfIdBook], ref err);
                }
                if (err == "")
                {
                    MessageBox.Show("Đơn hàng đã được tạo !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show(err, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch
            {
                MessageBox.Show("Đã có lỗi xảy ra !");
            }
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
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
            LoadDataBook();
            LoadDataIntoCbVoucher(voucher.getAllIdVoucher());
            LoadDataIntoCbCustomer(customer.getAllIDCustomer());
            LoadDataIntoCbEmployee(employee.getAllIDEmployee());
        }

        private void dgvListBook_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowCurrentIndex = dgvListBook.CurrentCell.RowIndex;
            this.lblIDBook.Text = dgvListBook.Rows[rowCurrentIndex].Cells[0].Value.ToString();
            this.lblNameBook.Text = dgvListBook.Rows[rowCurrentIndex].Cells[1].Value.ToString();
        }
        private void addItemIntoBill(string idBook, string nameBook, int amount)
        {
            cart.addNewItemIntoCart(idBook, nameBook, amount);
            LoadDataCartIntoDgv();
        }
        private void dgvCart_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;
           
            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.ColumnIndex == 3)
            {
                try
                {
                    FormEditDetailReceiptExport frmEditDetailReceiptExport = new FormEditDetailReceiptExport(cart, senderGrid.Rows[e.RowIndex].Cells[0].Value.ToString());
                    frmEditDetailReceiptExport.FormClosed += Edit_FormClosed;
                    frmEditDetailReceiptExport.Show();
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
                        cart.deleteItemInCart(senderGrid.Rows[e.RowIndex].Cells[0].Value.ToString());
                        LoadDataCartIntoDgv();
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
            LoadDataCartIntoDgv();
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Dữ liệu sẽ không được cập nhật. Bạn có chắc chắn muốn thoát không ?", "Warnning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (result == DialogResult.OK)
            {
                this.Close();
            }
            else
            {
                return;
            }
        }
        private void LoadDataCartIntoDgv()
        {
            
            int index = -1;
            dgvCart.Rows.Clear();
            foreach (string idBook in cart.IdBooks)
            {
                DataGridViewRow dgvRow = (DataGridViewRow)dgvCart.Rows[0].Clone();
                index = cart.IdBooks.IndexOf(idBook);
                
                int indexLastRow = dgvCart.Rows.GetLastRow(DataGridViewElementStates.None);
                if (indexLastRow == -1)
                    indexLastRow = 0;
                dgvRow.Cells[0].Value = idBook.ToString();
                dgvRow.Cells[1].Value = cart.NameBooks[index].ToString();
                dgvRow.Cells[2].Value = cart.AmountBooks[index].ToString();
                dgvCart.Rows.Add(dgvRow);
            }
            this.lblTotal.Text = cart.TotalBill.ToString();
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
        private void LoadDataIntoCbEmployee(List<string> idEmployees)
        {
            cbIdEmployee.Items.Clear();
            foreach (string idEmployee in idEmployees)
            {
                cbIdEmployee.Items.Add(idEmployee);
            }
        }
    }
}
