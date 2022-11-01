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
    public partial class UControlReceiptExport : UserControl
    {
        DataTable dt;
        SellBook sellBook;
        string err;
        bool insert, delete, update, search;

        public UControlReceiptExport()
        {
            InitializeComponent();
            loadDataBill();
        }

        private void btnDetailExportReceipt_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtIdBill.Text);
            FormDetailReceiptExport frm_DetailReceiptExport = new FormDetailReceiptExport(id);
            frm_DetailReceiptExport.ShowDialog();
        }

        private void btnVoucher_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtIdBill.Text);
            FormApplyVoucherForBill frm_VoucherForBill = new FormApplyVoucherForBill(id);
            frm_VoucherForBill.ShowDialog();
        }

        
        private void dgvCus_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvReceiptExport_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = dgvReceiptExport.CurrentCell.RowIndex;

            this.txtIdBill.Text = dgvReceiptExport.Rows[r].Cells[0].Value.ToString().Trim();
            this.txtNameCus.Text = dgvReceiptExport.Rows[r].Cells[1].Value.ToString().Trim();
            this.txtIdEmp.Text = dgvReceiptExport.Rows[r].Cells[2].Value.ToString().Trim();
            this.dtpReceiptImport.Text = dgvReceiptExport.Rows[r].Cells[3].Value.ToString();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            setText(false);
            this.txtIdBill.Enabled = true;

            setBtn(false);
            this.btnCancel.Enabled = true;
            this.btnSave.Enabled = true;

            setFlag(false);
            this.delete = true;
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            loadDataBill();
            setText(true);
            setFlag(false);
            setBtn(true);
        }

      
        private void btnAdd_Click(object sender, EventArgs e)
        {
            setText(true);
            this.txtIdBill.Enabled = false;

            setFlag(false);
            this.insert = true;

            setBtn(false);
            this.btnCancel.Enabled = true;
            this.btnSave.Enabled = true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (insert)
            {
                try
                {
                    sellBook = new SellBook();
                    int idCus = Convert.ToInt32(txtIdCus.Text);
                    int idEmp = Convert.ToInt32(txtIdEmp.Text);
                    DateTime date = dtpReceiptImport.Value;
                    sellBook.createBill(idCus, idEmp, date, ref err);

                    if (err != null)
                    {
                        MessageBox.Show(err);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                loadDataBill();
                setText(true);
                setBtn(true);
                setFlag(false);
                this.btnSave.Enabled = false;
            }

            else if (delete)
            {
            }

            else if (search)
            {
                try
                {
                    dt = new DataTable();

                    sellBook = new SellBook();
                    int id = Convert.ToInt32(txtIdBill.Text);
                    DataSet ds = sellBook.searchBill(id);
                    dt = ds.Tables[0];
                    this.dgvReceiptExport.DataSource = dt;
                    this.dgvReceiptExport.AutoResizeColumns();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }    
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            setText(true);
            setBtn(true);
            setFlag(false);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            setText(false);
            this.txtIdBill.Enabled = true;
            this.txtIdCus.Enabled = true;

            setBtn(false);
            this.btnCancel.Enabled = true;
            this.btnSave.Enabled = true;

            setFlag(false);
            this.search = true;
        }

        void setText(bool flag)
        {
            this.txtIdBill.ResetText();
            this.txtIdCus.ResetText();
            this.txtNameEmp.ResetText();
            this.txtNameCus.ResetText();
            this.txtIdEmp.ResetText();

            this.dtpReceiptImport.ResetText();

            this.txtIdBill.Enabled = flag;
            this.txtIdCus.Enabled = flag;
            this.txtNameEmp.Enabled = flag;
            this.txtNameCus.Enabled = flag;
            this.txtIdEmp.Enabled = flag;

            this.dtpReceiptImport.Enabled = flag;

        }

        void setBtn(bool flag)
        {
            this.btnAdd.Enabled = flag;
            this.btnDelete.Enabled = flag;
            this.txtIdEmp.Enabled = flag;


        }
        void setFlag(bool flag)
        {
            this.insert = flag;
            this.update = flag;
            this.search = flag;
            this.delete = flag;
        }

        void loadDataBill ()
        {
            try
            {
                dt = new DataTable();

                sellBook = new SellBook();
                DataSet ds = sellBook.getBill();
                dt = ds.Tables[0];
                this.dgvReceiptExport.DataSource = dt;
                this.dgvReceiptExport.AutoResizeColumns();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }
      
    }
}
