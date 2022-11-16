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
        private DataTable dtReceiptExport = null;
        private Utilities utl = null;
        private string err = "";
        private DialogResult result;
        ReceiptExportBL receiptExport = null;

        private CartBL cart = null;
        List<string> param;
        public UControlReceiptExport()
        {
            InitializeComponent();
            this.lblIDEmployee.Text = frmLogin.idEmp;

            createAttributeComBoBox();

            receiptExport = new ReceiptExportBL();

        }
        
        private void btnDetailExportReceipt_Click(object sender, EventArgs e)
        {
            FormDetailReceiptExport frm_DetailReceiptExport = new FormDetailReceiptExport(this.lblID.Text,this.lblIDEmployee.Text,this.lblIdCustomer.Text, this.lblDateBill.Text, this.lblIdVoucher.Text, int.Parse(this.lblTotal.Text.ToString()));
            frm_DetailReceiptExport.ShowDialog();
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            string idBill = utl.createID("HDX");
            receiptExport.addNewReceiptExport(idBill, ref err);
            //cart = new CartBL(idBill);
            
            FormSale frmSale = new FormSale(idBill);
            frmSale.FormClosed += Edit_FormDetailReceiptExportClosed;
            frmSale.Show();
        }
        private void Edit_FormDetailReceiptExportClosed(object sender, FormClosedEventArgs e)
        {
            LoadData();
        }   
        private void LoadData()
        {
            updateBill();
            dtReceiptExport = receiptExport.getDataReceiptExport();
            dgvReceiptExport.DataSource = dtReceiptExport;
            utl = new Utilities(dgvReceiptExport);
            dgvReceiptExport.AutoResizeColumns();
            utl.SetEnableButton(new List<Button>() { btnDetailExportReceipt }, false);
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
                this.lblIdVoucher.Text = dgvReceiptExport.Rows[utl.rowCurrent].Cells[5].Value.ToString();
            }
            catch
            {
                result = MessageBox.Show("Hóa đơn này không có giá trị ! Vui lòng chọn hóa đơn khác", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }      
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string id;
            id= getParameter();
            try
            {
                receiptExport = new ReceiptExportBL();
                dtReceiptExport = receiptExport.searchReceiptExport(id, ref err);
                dgvReceiptExport.DataSource = dtReceiptExport;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        void createAttributeComBoBox()
        {
            param = new List<string>();
            param.Add("Id Bill");
            this.cbAttributeSearch.DataSource = param;
        }

        string getParameter()
        {
            string id;
            if (cbAttributeSearch.Text == "Id Bill")
            {
                id = this.txtSearch.Text.Trim();
            }

            else if (cbAttributeSearch.Text == "Name Customer")
            {
                id = null;
            }
            else
            {
                id = null;
            }
            return (id);
        }
        void updateBill ()
        {
            try
            {

                receiptExport.updateBill(ref err);
                if (err != "")
                {
                    MessageBox.Show(err);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
