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
    public partial class UControlReceiptImport : UserControl
    {
        private List<Control> controls = null;
        private DataTable dtReceiptImport = null;
        private Utilities utl = null;
        //private int IDAccount;
        private string err = "";
        private DialogResult result;

        //false là chế độ sửa, true là chế độ thêm
        private bool isAdd = false;
        private bool isEdit = false;
        ReceiptImportBL receiptImport = new ReceiptImportBL();
        private EmployeeBL emp = new EmployeeBL();
        
        public UControlReceiptImport()
        {
            InitializeComponent();
            dtpReceiptImport.Format = DateTimePickerFormat.Custom;
            dtpReceiptImport.CustomFormat = "dd-MM-yyyy";
            this.lbIdEmployee.Text = frmLogin.idEmp;
        }

        private void btnDetailImportReceipt_Click(object sender, EventArgs e)
        {
            FormDetailReceiptImport frm_DetailReceiptImport = new FormDetailReceiptImport();
            frm_DetailReceiptImport.ShowDialog();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            this.lblIDBill.Text = utl.createID("HDN");
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
                        receiptImport.deleteReceiptImport(this.lblIDBill.Text, ref err);
                        if (err == "")
                        {
                            MessageBox.Show("Xóa thành công !");
                        }
                        else
                            MessageBox.Show(err);

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
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
                    receiptImport = new ReceiptImportBL();
                    try
                    {
                        receiptImport.addNewReceiptImport(this.lblIDBill.Text, this.dtpReceiptImport.Value.Date, this.lbIdEmployee.Text, ref err); ;;
                        if (err == "")
                        {
                            MessageBox.Show("Thêm hóa đơn nhập thành công !");
                        }
                        else
                        {
                            MessageBox.Show(err, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                else if (isEdit)
                {
                    //account = new AccountBL()
                    receiptImport.modifyReceiptImport(this.lblIDBill.Text, this.dtpReceiptImport.Value.Date, this.lbIdEmployee.Text, ref err);
                    //LoadData();
                    if (err == "")
                    {
                        MessageBox.Show("Sửa thông tin đơn nhập thành công !");
                    }
                    else
                    {
                        MessageBox.Show(err, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                isAdd = false;
                isEdit = false;
                utl.SetNullForAllControl();
                LoadData();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {

        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void dgvReceiptImport_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            utl.CellClick(btnCancel, btnDelete);
            lblIDBill.Text = dgvReceiptImport.Rows[utl.rowCurrent].Cells[0].Value.ToString();
            dtpReceiptImport.Text = dgvReceiptImport.Rows[utl.rowCurrent].Cells[1].Value.ToString();
            lblTotal.Text = dgvReceiptImport.Rows[utl.rowCurrent].Cells[2].Value.ToString();
            lblStt.Text = dgvReceiptImport.Rows[utl.rowCurrent].Cells[4].Value.ToString();
        }

        private void UControlReceiptImport_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        private void LoadData()
        {
            lblIDBill.Text = "None";
            controls = new List<Control> { dtpReceiptImport };
            dtReceiptImport = receiptImport.getDataReceiptImport();
            dgvReceiptImport.DataSource = dtReceiptImport;
            utl = new Utilities(controls, dgvReceiptImport);
            dgvReceiptImport.AutoResizeColumns();
            utl.SetEnableButton(new List<Button>() { btnSave, btnCancel }, false);
            utl.SetEnableButton(new List<Button>() { btnAdd, btnEdit, btnDelete, btnReload }, true);
            utl.setEnableControl(false);
        }
    }
}
