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
using System.Data.SqlClient;

using Proj_Book_Store_Manage.BSLayer;

namespace Proj_Book_Store_Manage.UI
{
    public partial class FormApplyVoucherForBill : Form
    {
        SellBook sellBook;
        Voucher voucher;

        DataTable dt;
        int idBill;
        string err;

        public FormApplyVoucherForBill()
        {
            InitializeComponent();
        }


        public FormApplyVoucherForBill(int idBill)
        {
            InitializeComponent();
            this.idBill = idBill;
            loadData();
            this.lbIdBill.Text = idBill.ToString();
        }

        void loadData()
        {
            try
            {
                dt = new DataTable();
                voucher = new Voucher();
                DataSet ds = voucher.getVoucher(DateTime.Now.Date);
                dt = ds.Tables[0];
                dgvVoucher.DataSource = dt;
                dgvVoucher.AutoResizeColumns();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            try
            {
                sellBook = new SellBook();
                int idVoucher = Convert.ToInt32(lbIdVoucher.Text);
                sellBook.addVoucher(idBill, idVoucher, ref err);
                if (err != null)
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
                sellBook = new SellBook();
                int idVoucher = Convert.ToInt32(lbIdVoucher.Text);
                sellBook.deleteVoucher(idBill, ref err);
                if (err != null)
                {
                    MessageBox.Show(err);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgvVoucher_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = dgvVoucher.CurrentCell.RowIndex;

            this.lbIdVoucher.Text = dgvVoucher.Rows[r].Cells[0].Value.ToString().Trim();
            this.lbNameVoucher.Text = dgvVoucher.Rows[r].Cells[2].Value.ToString().Trim();
        }
    }
}
