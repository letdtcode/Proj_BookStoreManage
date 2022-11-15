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
    public partial class FormSelectUsing : Form
    {
        private string err = null;
        public FormSelectUsing()
        {
            InitializeComponent();
        }

        private void btnManage_Click(object sender, EventArgs e)
        {
            FormDashBoard frmDashBoard = new FormDashBoard();
            frmDashBoard.FormClosed += Edit_Form;
            frmDashBoard.Show();
            
        }
        private void Edit_Form(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }
        

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnSale_Click(object sender, EventArgs e)
        {
            //Kết nối để lấy ID tự động
            ReceiptExportBL receiptExport = new ReceiptExportBL();
            DataTable dt = receiptExport.getDataReceiptExport();
            Utilities utl = new Utilities(dt);
            string idBill = utl.createIDBill("HDX");
            //Tạo mới hóa đơn
            receiptExport.addNewReceiptExport(idBill, ref err);
            FormSale frmSale = new FormSale(idBill);
            frmSale.FormClosed += Edit_Form;
            frmSale.Show();
        }

        private void btnImport_Click(object sender, EventArgs e)
        {
            //Kết nối để lấy ID tự động
            ReceiptImportBL receiptImport = new ReceiptImportBL();
            DataTable dt = receiptImport.getDataReceiptImport();
            Utilities utl = new Utilities(dt);
            string idBill = utl.createIDBill("HDN");
            //Tạo mới hóa đơn
            receiptImport.addNewReceiptImport(idBill, ref err);
            FormImportBook frmImportBook = new FormImportBook(idBill);
            frmImportBook.FormClosed += Edit_Form;
            frmImportBook.Show();
        }

        private void btnRevenue_Click(object sender, EventArgs e)
        {
            FormRevenue revenue = new FormRevenue();
            revenue.ShowDialog();
        }
    }
}
