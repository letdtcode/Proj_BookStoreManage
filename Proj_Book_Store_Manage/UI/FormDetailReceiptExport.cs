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
        private ReceiptExportBL receiptExport = null;
        private DataTable dtDetailReceiptExport = null;
        private string idBill = null;
        private string err;
        public FormDetailReceiptExport(string idBill, string idEmployee, string idCustomer, string dateBill, string idVoucher, int totalBill)
        {
            InitializeComponent();
            receiptExport = new ReceiptExportBL();
            this.idBill = idBill;
            this.lblIDReceipt.Text = idBill;
            this.lblIdEmployee.Text = idEmployee;
            this.lblCustomer.Text = idCustomer;
            this.lblDateBillExport.Text = dateBill;
            this.lblIdVoucher.Text = idVoucher;
            this.lblTotal.Text = totalBill.ToString();
        }

        private void FormDetailReceiptExport_Load(object sender, EventArgs e)
        {
            dtDetailReceiptExport = receiptExport.getDataDetailReceiptExport(this.idBill, ref err);
            dgvDetailReceiptExport.DataSource = dtDetailReceiptExport;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
