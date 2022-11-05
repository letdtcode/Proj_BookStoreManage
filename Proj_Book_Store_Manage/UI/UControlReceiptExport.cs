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
        public UControlReceiptExport()
        {
            InitializeComponent();
            dtpReceiptExport.Format = DateTimePickerFormat.Custom;
            dtpReceiptExport.CustomFormat = "dd-MM-yyyy";
        }
        
        private void btnDetailExportReceipt_Click(object sender, EventArgs e)
        {
            FormDetailReceiptExport frm_DetailReceiptExport = new FormDetailReceiptExport();
            frm_DetailReceiptExport.ShowDialog();
        }

        private void btnVoucher_Click(object sender, EventArgs e)
        {
            FormApplyVoucherForBill frm_VoucherForBill = new FormApplyVoucherForBill();
            frm_VoucherForBill.ShowDialog();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(dtpReceiptExport.Value.ToShortDateString());
            this.lblID.Text = utl.createID("HDX");
            isAdd = true;
            utl.SetNullForAllControl();
            utl.setEnableControl(true);
            utl.SetEnableButton(new List<Button> { btnEdit, btnDelete }, false);
            utl.SetEnableButton(new List<Button> { btnSave, btnReload }, true);
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            isEdit = true;
            //utl.SetNullForAllControl();
            utl.setEnableControl(true);
            utl.SetEnableButton(new List<Button> { btnAdd, btnDelete }, false);
            utl.SetEnableButton(new List<Button> { btnSave, btnReload }, true);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (utl.CheckIDValid is true)
                {
                    result = MessageBox.Show("Bạn có chắc chắn muốn xóa không ?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        if (receiptExport.deleteReceiptExport(utl.IDCurrent, ref err) == true)
                        {
                            MessageBox.Show("Xóa thành công !");
                        }
                        else
                            MessageBox.Show("Xoá thất bại !");

                    }
                }
            }
            catch
            {
                MessageBox.Show("Không thể xóa !");
            }
            finally
            {
                LoadData();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
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
            }
        }
        private void LoadData()
        {
            LoadDataIntoCbCus(cus.getAllIDCustomer());
            LoadDataIntoCbEmployee(employee.getAllIDEmployee());
            controls = new List<Control> { dtpReceiptExport, cbIDEmp, cbIDCus };
            dtReceiptExport = receiptExport.getDataReceiptExport();
            dgvReceiptExport.DataSource = dtReceiptExport;
            utl = new Utilities(controls, dgvReceiptExport);
            dgvReceiptExport.AutoResizeColumns();
            utl.SetEnableButton(new List<Button>() { btnSave, btnCancel }, false);
            utl.SetEnableButton(new List<Button>() { btnAdd, btnEdit, btnDelete, btnReload }, true);
            utl.setEnableControl(false);
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
            utl.CellClick(btnCancel, btnDelete);
            lblID.Text = utl.IDCurrent;
            dtpReceiptExport.Text = dgvReceiptExport.Rows[utl.rowCurrent].Cells[1].Value.ToString();
            lblTotal.Text = dgvReceiptExport.Rows[utl.rowCurrent].Cells[2].Value.ToString();
            cbIDCus.Text = dgvReceiptExport.Rows[utl.rowCurrent].Cells[3].Value.ToString();
            cbIDEmp.Text = dgvReceiptExport.Rows[utl.rowCurrent].Cells[4].Value.ToString();
            lblStt.Text = dgvReceiptExport.Rows[utl.rowCurrent].Cells[5].Value.ToString();
        }

        /*private void btnInvoice_Click(object sender, EventArgs e)
        {
            receiptExport.invoiceBill(utl.IDCurrent, ref err);
        }*/
        private void LoadDataIntoCbCus(List<string> idCustomers)
        {
            cbIDCus.Items.Clear();
            foreach(string idCus in idCustomers)
            {
                cbIDCus.Items.Add(idCus);
            }
        }
        private void LoadDataIntoCbEmployee(List<string> idEmployee)
        {
            cbIDEmp.Items.Clear();
            foreach (string idEmp in idEmployee)
            {
                cbIDEmp.Items.Add(idEmp);
            }
        }
    }
}
