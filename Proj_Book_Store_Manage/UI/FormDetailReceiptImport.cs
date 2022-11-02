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
    public partial class FormDetailReceiptImport : Form
    {
        int idBill;
        DataTable dt;
        BillInput billInput;
        string err;

        bool insert, delete, update;
        public FormDetailReceiptImport()
        {
            InitializeComponent();
            MessageBox.Show("Vui lòng nhập mã hóa đơn");
            this.Close();
        }

        public FormDetailReceiptImport(int id)
        {
            InitializeComponent();
            this.idBill = id;
            loadData(id);
            this.lblIDReceipt.Text = id.ToString();
            loadMoney();
        }

        void loadData(int idBill)
        {
            try
            {
                dt = new DataTable();
                billInput = new BillInput();
                DataSet ds = billInput.getBooksInBill(idBill);
                dt = ds.Tables[0];
                dgvDetailReceiptImport.DataSource = dt;
                dgvDetailReceiptImport.AutoResizeColumns();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            loadMoney();
        }

        private void btnExit_MouseEnter(object sender, EventArgs e)
        {
            btnExit.BackColor = Color.WhiteSmoke;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            setText(true);

            setFlag(false);
            this.insert = true;

            setBtn(false);
            this.btnCancel.Enabled = true;
            this.btnSave.Enabled = true;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            setText(false);
            this.txtAmountBook.Enabled = true;
            setBtn(false);
            this.btnCancel.Enabled = true;
            this.btnSave.Enabled = true;

            setFlag(false);
            this.update = true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (insert)
            {
                try
                {
                    billInput = new BillInput();
                    int idBook = Convert.ToInt32(txtIdBook.Text);
                    int amount = Convert.ToInt32(txtAmountBook.Text);
                    billInput.addBookInBill(idBill, idBook, amount, ref err);

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
            else if (update)
            {
                try
                {
                    billInput = new BillInput();
                    int idBook = Convert.ToInt32(txtIdBook.Text);
                    int amount = Convert.ToInt32(txtAmountBook.Text);
                    billInput.updateAmountBook(idBill, idBook, amount, ref err);

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

            else if (delete)
            {
                try
                {
                    billInput = new BillInput();
                    int idBook = Convert.ToInt32(txtIdBook.Text);
                    int amount = Convert.ToInt32(txtAmountBook.Text);
                    billInput.deleBookInBill(idBill, idBook, ref err);

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
            loadData(idBill);
            setText(true);
            setBtn(true);
            setFlag(false);
            this.btnSave.Enabled = false;
            this.btnCancel.Enabled = false;

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            setText(true);
            setBtn(true);
            setFlag(false);
        }

        private void btnReload_Click(object sender, EventArgs e)
        {

        }
        void setText(bool flag)
        {
            this.txtAmountBook.ResetText();
            this.txtIdBook.ResetText();

            this.txtAmountBook.Enabled = flag;
            this.txtIdBook.Enabled = flag;

        }

        private void dgvDetailReceiptImport_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = dgvDetailReceiptImport.CurrentCell.RowIndex;

            this.txtIdBook.Text = dgvDetailReceiptImport.Rows[r].Cells[1].Value.ToString().Trim();
            this.txtAmountBook.Text = dgvDetailReceiptImport.Rows[r].Cells[2].Value.ToString().Trim();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            setText(false);

            setBtn(false);
            this.btnCancel.Enabled = true;
            this.btnSave.Enabled = true;

            setFlag(false);
            this.delete = true;
        }

        void setBtn(bool flag)
        {
            this.btnAdd.Enabled = flag;
            this.btnDelete.Enabled = flag;
            this.btnEdit.Enabled = flag;
        }

        void setFlag(bool flag)
        {
            this.insert = flag;
            this.update = flag;
            this.delete = flag;
        }

        private void btnAddBook_Click(object sender, EventArgs e)
        {
            FormAddBook fmAddBook = new FormAddBook();
            fmAddBook.ShowDialog();
        }

        void loadMoney ()
        {
            try
            {

                billInput = new BillInput();
                DataSet ds = billInput.calcTotalMoney(idBill);

                this.lblTotal.Text = ds.Tables[0].Rows[0][0].ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            updateTotalMoneyInBill(idBill);
        }
        void updateTotalMoneyInBill (int idBill)
        {
            try
            {
                billInput = new BillInput();
                billInput.updateTotalMoneyInBill(idBill, ref err);
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
    }
}
