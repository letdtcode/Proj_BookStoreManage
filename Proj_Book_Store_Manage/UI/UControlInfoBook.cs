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
    public partial class UControlInfoBook : UserControl
    {
        DataTable dt;
        Book book;
        string err;
        bool insert, delete, update, search;

        public UControlInfoBook()
        {
            InitializeComponent();
            loadData();
        }

        private void UControlInfoBook_Load(object sender, EventArgs e)
        {

        }

       
        void loadData ()
        {
            try
            {
                dt = new DataTable();

                book = new Book();

                DataSet ds = book.getBook();
                dt = ds.Tables[0];

                dgvBook.DataSource = dt;
                dgvBook.AutoResizeColumns();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void btnEdit_Click(object sender, EventArgs e)
        {
            setText(true);
            this.txtIdBook.Enabled = false;
            setBtn(false);
            this.btnCancel.Enabled = true;
            this.btnSave.Enabled = true;

            setFlag(false);
            this.update = true;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            setText(true);
            this.txtIdBook.Enabled = false;
            setBtn(false);
            this.btnCancel.Enabled = true;
            this.btnSave.Enabled = true;

            setFlag(false);
            this.delete = true;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            setBtn(true);
            this.btnSave.Enabled = false;
            this.btnCancel.Enabled = false;
            setText(true);
            setFlag(false);
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            setBtn(true); 
            this.btnSave.Enabled = false;
            this.btnCancel.Enabled = false;
            setText(true);
            setFlag(false);
            loadData();
        }

        
        private void btnSearch_Click(object sender, EventArgs e)
        {
            setText(true);
            setBtn(false);
            this.btnCancel.Enabled = true;
            this.btnSave.Enabled = true;

            setFlag(false);
            this.search = true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (search)
            {
                try
                {       
                    dt = new DataTable();
                    string nameBook = null, nameAuthor = null, nameCategory = null;
                    book = new Book();
                    int id = Convert.ToInt32(txtIdBook.Text);
                    nameBook = this.txtNameBook.Text.ToString().Trim() ;
                    nameAuthor = this.txtAuthor.Text.ToString().Trim();
                    nameCategory = this.txtCategory.Text.ToString().Trim();
                    DataSet ds = book.searchBook(id, nameBook, nameAuthor, nameCategory);
                    dt = ds.Tables[0];

                    dgvBook.DataSource = dt;
                    dgvBook.AutoResizeColumns();
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
                    book = new Book();
                    int id = Convert.ToInt32(txtIdBook.Text);
                    string name = this.txtNameBook.Text.ToString();
                    int price = Convert.ToInt32(txtPriceExport.Text);

                    book.updatehBook(id, Name, price, ref err);
                    if (err != null)
                    {
                        MessageBox.Show(err);
                    }

                    loadData();
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else if (delete)
            {
                try
                {
                    book = new Book();
                    int id = Convert.ToInt32(txtIdBook.Text);
                    string name = this.txtNameBook.Text.ToString();
                    int price = Convert.ToInt32(txtPriceExport.Text);

                    book.deleteBook(id, ref err);
                    if (err != null)
                    {
                        MessageBox.Show(err);
                    }

                    loadData();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            setBtn(true);
            this.btnSave.Enabled = false;
            this.btnCancel.Enabled = false;
            setText(true);
            this.txtIdBook.Enabled = false;
        }

        private void dgvBook_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = dgvBook.CurrentCell.RowIndex;

            this.txtIdBook.Text = dgvBook.Rows[r].Cells[0].Value.ToString().Trim();
            this.txtNameBook.Text = dgvBook.Rows[r].Cells[1].Value.ToString().Trim();
            this.txtPriceExport.Text = dgvBook.Rows[r].Cells[5].Value.ToString().Trim();
        }

        void setText(bool flag)
        {
            this.txtAuthor.ResetText();
            this.txtCategory.ResetText();
            this.txtNameBook.ResetText();
            this.txtIdBook.ResetText();
            this.txtPriceExport.ResetText();

            this.txtAuthor.Enabled = flag;
            this.txtCategory.Enabled = flag;
            this.txtNameBook.Enabled = flag;
            this.txtIdBook.Enabled = flag;
            this.txtPriceExport.Enabled = flag;
        }

        void setBtn(bool flag)
        {
            this.btnSearch.Enabled = flag;
            this.btnDelete.Enabled = flag;
            this.btnEdit.Enabled = flag;
            this.btnCancel.Enabled = flag;
            this.btnReload.Enabled = flag;
            this.btnSave.Enabled = flag;

        }
        void setFlag(bool flag)
        {
            this.update = flag;
            this.search = flag;
            this.delete = flag;
        }
    }
}
