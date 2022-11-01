using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proj_Book_Store_Manage.UI
{
    public partial class UControlReceiptExport : UserControl
    {
        public UControlReceiptExport()
        {
            InitializeComponent();
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

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }

        private void btnReload_Click(object sender, EventArgs e)
        {

        }
    }
}
