using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using Proj_Book_Store_Manage.BSLayer;

namespace Proj_Book_Store_Manage.UI
{
    public partial class FormApplyVoucherForBill : Form
    {
        string idBill, err;
        VoucherBL voucher;
        ReceiptExportBL sellBook;
        DataTable dt;

        public FormApplyVoucherForBill()
        {
            InitializeComponent();
        }

        public FormApplyVoucherForBill(string idBill)
        {
            InitializeComponent();
            this.idBill = idBill;
            this.lbIdBill.Text = idBill.ToString();
            loadData();
        }


        void loadData ()
        {
            try
            {
                voucher = new VoucherBL();
                dt = new DataTable();
                dt = voucher.getDataVoucher();
                dgvVoucher.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgvVoucher_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int r = dgvVoucher.CurrentCell.RowIndex;
                this.lbIdVoucher.Text = dgvVoucher.Rows[r].Cells[0].Value.ToString().Trim();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnUse_Click(object sender, EventArgs e)
        {
            try
            {
                sellBook = new ReceiptExportBL();
                string idVoucher = lbIdVoucher.Text.ToString();
                sellBook.addVoucher(idBill, idVoucher, ref err);
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


        private void btnCancel_Click(object sender, EventArgs e)
        {
            try
            {
                sellBook = new ReceiptExportBL();
                string idVoucher = lbIdVoucher.Text.ToString();
                sellBook.deleteVoucher(idBill, ref err);
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
