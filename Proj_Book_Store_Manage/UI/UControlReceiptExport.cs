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
    public partial class UControlReceiptExport : UserControl
    {
        private List<Control> controls = null;
        private DataTable dtReceiptExport = null;
        private Utilities utl = null;
        private string err = "";
        private DialogResult result;

        //false là chế độ sửa, true là chế độ thêm
        private bool isAdd = false;
        private bool isEdit = false;
        ReceiptExportBL receiptExport = new ReceiptExportBL();

        private CustomerBL cus = new CustomerBL();
        private EmployeeBL employee = new EmployeeBL();

        private CartBL cart = null;
        public UControlReceiptExport()
        {
            InitializeComponent();
        }
        
        private void btnDetailExportReceipt_Click(object sender, EventArgs e)
        {
            FormSale frm_DetailReceiptExport = new FormSale(this.lblID.Text);
            frm_DetailReceiptExport.ShowDialog();
        }

        private void btnVoucher_Click(object sender, EventArgs e)
        {
            FormApplyVoucherForBill frm_VoucherForBill = new FormApplyVoucherForBill();
            frm_VoucherForBill.ShowDialog();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string idBill = utl.createID("BILL");
            cart = new CartBL(idBill);
            receiptExport.addNewReceiptExport(idBill, ref err);
            FormSale frmSale = new FormSale(idBill);
            frmSale.FormClosed += Edit_FormDetailReceiptExportClosed;
            frmSale.Show();
        }
        private void Edit_FormDetailReceiptExportClosed(object sender, FormClosedEventArgs e)
        {
            LoadData();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            /*try
            {
                if (utl.checkAllControlIsFill() == false)
                {
                    result = MessageBox.Show("Vui lòng nhập đầy đủ thông tin !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    isAdd = false;
                    isEdit = false;
                    return;
                }
                if (isAdd)
                {
                    receiptExport = new ReceiptExportBL();
                    try
                    {
                        receiptExport.addNewReceiptExport(this.lblID.Text, this.dtpReceiptExport.Value.Date, this.cbIDCus.Text, this.cbIDEmp.Text, ref err);
                        if (err == "")
                        {
                            MessageBox.Show("Thêm hóa đơn thành công !");
                        }
                        else
                        {
                            MessageBox.Show(err, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    catch
                    {
                        MessageBox.Show("Thông tin không hợp lệ");
                    }
                }
                else if (isEdit)
                {
                    //account = new AccountBL()
                    receiptExport.modifyReceiptExport(this.lblID.Text, this.dtpReceiptExport.Value.Date, this.cbIDCus.Text, this.cbIDEmp.Text, ref err);
                    //LoadData();
                    if (err == "")
                    {
                        MessageBox.Show("Sửa hóa đơn thành công !");
                    }
                    else
                    {
                        MessageBox.Show(err, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch
            {
                MessageBox.Show("Đã có lỗi xảy ra !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                isAdd = false;
                isEdit = false;
                utl.SetNullForAllControl();
                LoadData();
            }*/
        }
        private void LoadData()
        {
            dtReceiptExport = receiptExport.getDataReceiptExport();
            dgvReceiptExport.DataSource = dtReceiptExport;
            utl = new Utilities(dgvReceiptExport);
            dgvReceiptExport.AutoResizeColumns();
            utl.SetEnableButton(new List<Button>() { btnDetailExportReceipt }, false);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {

        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void UControlReceiptExport_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void dgvReceiptExport_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                utl.CellClick(btnDetailExportReceipt);
                this.lblID.Text = dgvReceiptExport.Rows[utl.rowCurrent].Cells[0].Value.ToString();
                string dt = DateTime.Parse(dgvReceiptExport.Rows[utl.rowCurrent].Cells[1].Value.ToString()).ToString("dd/MM/yyyy");
                this.lblDateBill.Text = dt;
                this.lblTotal.Text = dgvReceiptExport.Rows[utl.rowCurrent].Cells[2].Value.ToString();
                this.lblIdCustomer.Text = dgvReceiptExport.Rows[utl.rowCurrent].Cells[3].Value.ToString();
                this.lblIDEmployee.Text = dgvReceiptExport.Rows[utl.rowCurrent].Cells[4].Value.ToString();
            }
            catch
            {
                result = MessageBox.Show("Hóa đơn này không có giá trị ! Vui lòng chọn hóa đơn khác", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
        }
        private void gbReceiptExport_Enter(object sender, EventArgs e)
        {

        }
    }
}
