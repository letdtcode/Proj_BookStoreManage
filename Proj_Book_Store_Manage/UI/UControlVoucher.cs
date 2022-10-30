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
    public partial class UControlVoucher : UserControl
    {
        DataTable dt;
        Voucher voucher;
        string err;
        bool insert, delete, update, search;
        public UControlVoucher()
        {
            InitializeComponent();
            loadData();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            setText(true);
            this.txtIdVoucher.Enabled = false;

            setFlag(false);
            this.insert = true;

            setBtn(false);
            this.btnCancel.Enabled = true;
            this.btnSave.Enabled = true;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            setText(false);
            this.txtNameVoucher.Enabled = true;

            setBtn(false);
            this.btnCancel.Enabled = true;
            this.btnSave.Enabled = true;

            setFlag(false);
            this.update = true;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            setText(false);
            this.txtIdVoucher.Enabled = true;

            setBtn(false);
            this.btnCancel.Enabled = true;
            this.btnSave.Enabled = true;

            setFlag(false);
            this.delete = true;
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
            this.txtIdVoucher.Enabled = true;
            this.txtNameVoucher.Enabled = true;

            setBtn(false);
            this.btnCancel.Enabled = true;
            this.btnSave.Enabled = true;

            setFlag(false);
            this.search = true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (insert)
            {
                try
                {
                    dt = new DataTable();

                    voucher = new Voucher();
                    int value = Convert.ToInt32(txtValueVoucher.Text);
                    int amount = Convert.ToInt32(txtAmount.Text);

                    voucher.insertVoucher(value,
                        txtNameVoucher.Text,
                        dtpDateStart.Value,
                        dtpDateEnd.Value,
                        amount,
                        ref err);
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
                this.btnCancel.Enabled = false;
            }
            else if (delete)
            {
                try
                {
                    dt = new DataTable();

                    voucher = new Voucher();
                    int id = Convert.ToInt32(txtIdVoucher.Text);

                    voucher.deleteVoucher(id,
                        ref err);
                    if (err != null)
                    {
                        MessageBox.Show(err);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                loadData();
                setText(true);
                setBtn(true);
                setFlag(false);
                this.btnSave.Enabled = false;
                this.btnCancel.Enabled = false;
            }
            else if (update)
            {
                try
                {
                    dt = new DataTable();

                    voucher = new Voucher();
                    int id = Convert.ToInt32(txtIdVoucher.Text);

                    voucher.updateVoucer(id,
                        txtNameVoucher.Text,
                        ref err);
                    if (err != null)
                    {
                        MessageBox.Show(err);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                loadData();
                setText(true);
                setBtn(true);
                setFlag(false);
                this.btnSave.Enabled = false;
                this.btnCancel.Enabled = false;
            }
            else if (search)
            {
                try
                {
                    dt = new DataTable();

                    voucher = new Voucher();
                    int id = Convert.ToInt32(txtIdVoucher.Text);
                    DataSet ds = voucher.searchVoucher(id, txtNameVoucher.Text);
                    dt = ds.Tables[0];

                    dgvVoucher.DataSource = dt;
                    dgvVoucher.AutoResizeColumns();

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

        void loadData ()
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

        private void dgvVoucher_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = dgvVoucher.CurrentCell.RowIndex;

            this.txtIdVoucher.Text = dgvVoucher.Rows[r].Cells[0].Value.ToString().Trim();
            this.txtValueVoucher.Text = dgvVoucher.Rows[r].Cells[1].Value.ToString().Trim();
            this.txtNameVoucher.Text = dgvVoucher.Rows[r].Cells[2].Value.ToString().Trim();
            this.dtpDateStart.Value = Convert.ToDateTime(dgvVoucher.Rows[r].Cells[3].Value);
            this.dtpDateStart.Value = Convert.ToDateTime(dgvVoucher.Rows[r].Cells[4].Value);
            this.txtAmount.Text = dgvVoucher.Rows[r].Cells[5].Value.ToString().Trim();

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
            this.txtAmount.ResetText();
            this.txtIdVoucher.ResetText();
            this.txtNameVoucher.ResetText();
            this.txtValueVoucher.ResetText();

            this.dtpDateEnd.ResetText();
            this.dtpDateStart.ResetText();

            this.txtAmount.Enabled = flag;
            this.txtIdVoucher.Enabled = flag;
            this.txtNameVoucher.Enabled = flag;
            this.txtValueVoucher.Enabled = flag;

            this.dtpDateEnd.Enabled = flag;
            this.dtpDateStart.Enabled = flag;

        }
        
        void setBtn(bool flag)
        {
            this.btnAdd.Enabled = flag;
            this.btnDelete.Enabled = flag;
            this.btnEdit.Enabled = flag;
            this.btnSearch.Enabled = flag;

            
        }
        void setFlag (bool flag)
        {
            this.insert = flag;
            this.update = flag;
            this.search = flag;
            this.delete = flag;
        }
    }
}
