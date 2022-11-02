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
    public partial class UControlReceiptImport : UserControl
    {
        bool insert, update, search, delete;
        DataTable dt;

        string err;

        BillInput billInput;
        public UControlReceiptImport()
        {
            InitializeComponent();
            loadData();
        }

        private void btnDetailImportReceipt_Click(object sender, EventArgs e)
        {
            if (txtIdBill.Text == "")
            {
                MessageBox.Show("Vui lòng nhập mã hóa đơn");
                txtIdBill.Focus();
            }

            else
            {
                int id = Convert.ToInt32(txtIdBill.Text);
                FormDetailReceiptImport frm_DetailReceiptImport = new FormDetailReceiptImport(id);
                frm_DetailReceiptImport.ShowDialog();
            }
                
        }

        private void dgvReceiptImport_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = dgvReceiptImport.CurrentCell.RowIndex;

            this.txtIdBill.Text = dgvReceiptImport.Rows[r].Cells[0].Value.ToString().Trim();
            this.txtIdEmp.Text = dgvReceiptImport.Rows[r].Cells[3].Value.ToString().Trim();

            this.dtpReceiptImport.Text = dgvReceiptImport.Rows[r].Cells[1].Value.ToString().Trim();

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            setText(true);
            this.txtIdBill.Enabled = false;
            this.dtpReceiptImport.Enabled = false;

            setFlag(false);
            this.insert = true;

            setBtn(false);
            this.btnCancel.Enabled = true;
            this.btnSave.Enabled = true;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            setText(false);
            this.txtIdBill.Enabled = true;

            setBtn(false);
            this.btnCancel.Enabled = true;
            this.btnSave.Enabled = true;

            setFlag(false);
            this.search = true;
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

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (insert)
            {
                try
                {
                    billInput = new BillInput();

                    DateTime date = DateTime.Now.Date;
                    int idEmp = Convert.ToInt32(txtIdEmp.Text);
                    billInput.createBill(date, idEmp, ref err);
                    if (err != null)
                    {
                        MessageBox.Show(err);
                    }    
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                loadData();
                setText(true);
                setBtn(true);
                setFlag(false);
                this.btnSave.Enabled = false;
            }   
            else if (search)
            {
                try
                {
                    billInput = new BillInput();

                    dt = new DataTable();

                    int id = Convert.ToInt32(txtIdBill.Text);
                    DataSet ds = billInput.searchBill(id);
                    dt = ds.Tables[0];

                    dgvReceiptImport.DataSource = dt;
                    dgvReceiptImport.AutoResizeColumns();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

                setText(true);
                setBtn(true);
                setFlag(false);
                this.btnSave.Enabled = false;
                this.btnCancel.Enabled = false;
            }
            
            
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            setText(true);
            setBtn(true);
            setFlag(false);
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            loadData();
            setText(true);
            setFlag(false);
            setBtn(true);
        }

        

        void setText(bool flag)
        {
            this.txtIdEmp.ResetText();
            this.txtIdEmp.ResetText();
            this.dtpReceiptImport.ResetText();


            this.txtIdEmp.Enabled = flag;
            this.txtIdEmp.Enabled = flag;
            this.dtpReceiptImport.Enabled = flag;

        }

        private void dgvReceiptImport_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            int r = dgvReceiptImport.CurrentCell.RowIndex;

            this.txtIdBill.Text = dgvReceiptImport.Rows[r].Cells[0].Value.ToString().Trim();
            this.dtpReceiptImport.Text = dgvReceiptImport.Rows[r].Cells[1].Value.ToString().Trim();
            this.txtIdEmp.Text = dgvReceiptImport.Rows[r].Cells[3].Value.ToString().Trim();
        }

        void setBtn(bool flag)
        {
            this.btnAdd.Enabled = flag;
            this.btnDelete.Enabled = flag;
            this.btnEdit.Enabled = flag;
            this.btnSearch.Enabled = flag;
        }
        void setFlag(bool flag)
        {
            this.insert = flag;
            this.update = flag;
            this.search = flag;
            this.delete = flag;
        }

        void loadData()
        {
            dt = new DataTable();

            billInput = new BillInput();

            DataSet ds = billInput.getBills();
            dt = ds.Tables[0];

            dgvReceiptImport.DataSource = dt;
            dgvReceiptImport.AutoResizeColumns();
        }
    }
}
