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
    public partial class FormDetailReceiptExport : Form
    {
        int idBill;
        SellBook sellBook;
        string err;

        DataTable dt;
        bool insert, update, delete, search;

        public FormDetailReceiptExport()
        {
            InitializeComponent();
            

        }
        public FormDetailReceiptExport(int idBill)
        {
            InitializeComponent();
            this.idBill = idBill;
            loadDataCart(idBill);
            this.lblIDReceipt.Text = idBill.ToString();

        }

        private void dgvCart_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = dgvCart.CurrentCell.RowIndex;

            this.txtIdBook.Text = dgvCart.Rows[r].Cells[1].Value.ToString().Trim();
            this.txtAmountBook.Text = dgvCart.Rows[r].Cells[4].Value.ToString().Trim();
        }

        private void btnAddCart_Click(object sender, EventArgs e)
        {
            setText(true);

            setFlag(false);
            this.insert = true;

            setBtn(false);
            this.btnCancel.Enabled = true;
            this.btnSave.Enabled = true;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            setText(false);
            this.txtAmountBook.Enabled = true;
            setBtn(false);
            this.btnCancel.Enabled = true;
            this.btnSave.Enabled = true;

            setFlag(false);
            this.update = true;
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

        private void btnExit_Click(object sender, EventArgs e)
        {
            loadMoneyCurrent();
            this.Dispose();
        }

        void loadDataCart (int idBill)
        {
            try
            {
                dt = new DataTable();

                sellBook = new SellBook();

                DataSet ds = sellBook.getCart(idBill);

                dt = ds.Tables[0];
                dgvCart.DataSource = dt;
                dgvCart.AutoResizeColumns();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            loadMoney();
        }

        void loadMoney ()
        {
            try
            {
                
                sellBook = new SellBook();
                DataSet ds = sellBook.calcTotalMoney(idBill);

                this.lblTotal.Text = ds.Tables[0].Rows[0][0].ToString();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (insert)
            {
                try
                {
                    sellBook = new SellBook();
                    int idBook = Convert.ToInt32(txtIdBook.Text);
                    int amount = Convert.ToInt32(txtAmountBook.Text);
                    sellBook.addBookToCart(idBill, idBook, amount, ref err);

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
                    sellBook = new SellBook();
                    int idBook = Convert.ToInt32(txtIdBook.Text);
                    int amount = Convert.ToInt32(txtAmountBook.Text);
                    sellBook.updateAmountBookInCart(idBill, idBook, amount, ref err);

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
                    sellBook = new SellBook();
                    int idBook = Convert.ToInt32(txtIdBook.Text);
                    int amount = Convert.ToInt32(txtAmountBook.Text);
                    sellBook.deleteBookFromCart(idBill, idBook, ref err);

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
            loadDataCart(idBill);
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

        private void FormDetailReceiptExport_Load(object sender, EventArgs e)
        {
           
        }

        void setText(bool flag)
        {
            this.txtAmountBook.ResetText();
            this.txtIdBook.ResetText();
            this.txtAmountBook.Enabled = flag;
            this.txtIdBook.Enabled = flag;

        }

        void setBtn(bool flag)
        {
            this.btnAddCart.Enabled = flag;
            this.btnDelete.Enabled = flag;
            this.btnUpdate.Enabled = flag;
        }
        void setFlag(bool flag)
        {
            this.insert = flag;
            this.update = flag;
            this.search = flag;
            this.delete = flag;
        }
        void loadMoneyCurrent()
        {
            try
            {
                sellBook = new SellBook();
                sellBook.updateBillMoney(idBill, ref err);
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
