using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Project_QuanLyCuaHangSach.Business_Layer;

namespace Project_QuanLyCuaHangSach
{
    public partial class frmSell : Form
    {
        public static int idBill;
        Book book;
        SellBook sellBook;

        DataTable dt;

        string err;
        bool update, delete;

        public frmSell()
        {
            InitializeComponent();
            loadDataBook();
            loadDataBillOutPut();
        }

        public frmSell(int h)
        {
            idBill = h;
            InitializeComponent();
            loadDataBook();
            loadDataBillOutPut();
            this.txtBillID.Text = idBill.ToString();
        }

        void loadDataBook()
        {
            dt = new DataTable();
            book = new Book();
            DataSet ds = book.getBook();
            dt = ds.Tables[0];

            dgvAllBook.DataSource = dt;

        }

        void loadDataBillOutPut()
        {
            if (idBill != 0)
            {
                dt = new DataTable();
                sellBook = new SellBook();
                DataSet ds = sellBook.getCart(idBill);
                dt = ds.Tables[0];

                dgvBill.DataSource = dt;
            }    
        }

        private void frmSell_Load(object sender, EventArgs e)
        {

        }
        private void ShowFilter()
        {
           
        }

        private void ShowBill()
        {
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                sellBook = new SellBook();
                int idBook = Convert.ToInt32(txtBookID.Text);
                int amount = Convert.ToInt32(txtAmount.Text);

                sellBook.addBookToCart(idBill, idBook, amount, ref err);
                if (err != null)
                {
                    MessageBox.Show(err);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                txtAmount.Focus();
            }

            loadDataBillOutPut();
        }
        private void btnCreateBill_Click(object sender, EventArgs e)
        {
            frmPayBill fmPaBill = new frmPayBill();

            fmPaBill.idBill = idBill;

            fmPaBill.Show();
            this.Close();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
           
        }

        private void dgvAllBook_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = dgvAllBook.CurrentCell.RowIndex;

            this.txtBookID.Text = dgvAllBook.Rows[r].Cells[0].Value.ToString().Trim();
        }

        private void dgvBillDetail_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = dgvBill.CurrentCell.RowIndex;

            this.txtBookID.Text = dgvBill.Rows[r].Cells[1].ToString().Trim();
            this.txtAmount.Text = dgvBill.Rows[r].Cells[2].ToString().Trim();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            this.delete = true;
        }

        public void SumBill()
        {
            
        }
        private void btnSua_Click(object sender, EventArgs e)
        {
            btnAdd.Enabled = false;
            btnCreateBill.Enabled = false;
            btnXoa.Enabled = false;
            btnSua.Enabled = false;
            txtBillID.Enabled = false;
            txtBookID.Enabled = false;
          
            txtAmount.Focus();

            this.update = true;

           
        }


        private void btnLuu_Click(object sender, EventArgs e)
        {
           if (update)
            {
                try
                {
                    sellBook = new SellBook();
                    int idBook = Convert.ToInt32(txtBookID.Text);
                    //int idBill = Convert.ToInt32(txtBillID.Text);
                    int amount = Convert.ToInt32(txtAmount.Text);

                    sellBook.addBookToCart(idBill, idBook, amount, ref err);
                    if (err != null)
                    {
                        MessageBox.Show(err);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    txtAmount.Focus();
                }
                this.update = false;
            }
            
           else if (delete)
            {
                try
                {
                    sellBook = new SellBook();
                    int idBook = Convert.ToInt32(txtBookID.Text);
                    //int idBill = Convert.ToInt32(txtBillID.Text);


                    sellBook.deleteBookFromCart(idBill, idBook, ref err);
                    if (err != null)
                    {
                        MessageBox.Show(err);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    txtAmount.Focus();
                }
                this.delete = false;
            }
            loadDataBillOutPut();
            loadDataBook();
        }

        private void frmSell_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmMain frm = new frmMain();
            frm.Show();
            this.Hide();
        }

        private void cbCustomerID_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbEmployeeNAME_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

      

      
        private void dgvBillDetail_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvAllBook_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnFindID_Click(object sender, EventArgs e)
        {
            frmBill fmBill = new frmBill();
            fmBill.Show();
            this.Hide();
            
        }
        

        private void dgvBill_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
