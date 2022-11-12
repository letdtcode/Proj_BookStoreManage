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
    public partial class FormDetailReceiptImport : Form
    {
        private DataTable dtDetailReceiptImport = null;
        private ReceiptImportBL receiptImport = null;
        private string err;
        private string idBillImport = null;
        public FormDetailReceiptImport(string idBill, string idEmployee, string dateTimeOfBill, int total)
        {
            InitializeComponent();
            receiptImport = new ReceiptImportBL();
            this.idBillImport = idBill;
            this.lblIDReceipt.Text = idBill;
            this.lblDateBillImport.Text = dateTimeOfBill;
            this.lblIdEmployee.Text = idEmployee;
            this.lblTotal.Text = total.ToString();
        }

        private void FormDetailReceiptImport_Load(object sender, EventArgs e)
        {
            dtDetailReceiptImport = receiptImport.getDataDetailReceiptImport(this.idBillImport, ref err);
            dgvDetailReceiptImport.DataSource = dtDetailReceiptImport;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

        }
    }
}
