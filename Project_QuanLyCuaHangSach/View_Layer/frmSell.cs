using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_QuanLyCuaHangSach
{
    public partial class frmSell : Form
    {
        public frmSell()
        {
            InitializeComponent();
        }

        void loadDataBook()
        {

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

            }
            catch
            {
                MessageBox.Show("Vui lòng nhập số lượng sách hợp lệ");
                txtAmount.Focus();
            }
        }
        private void btnCreateBill_Click(object sender, EventArgs e)
        {
            

        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
           
        }

        private void dgvAllBook_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow row = new DataGridViewRow();
                row = dgvAllBook.Rows[e.RowIndex];
                txtBookID.Text = Convert.ToString(row.Cells[2].Value);
                txtAmount.Text = "";
                txtAmount.Focus();
            }
        }

        private void dgvBillDetail_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow row = new DataGridViewRow();
                row = dgvBillDetail.Rows[e.RowIndex];
                txtBookID.Text = Convert.ToString(row.Cells[2].Value);
                txtBillID.Text = Convert.ToString(row.Cells[3].Value);
                txtAmount.Text = Convert.ToString(row.Cells[5].Value);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
          
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

            btnLuu.Enabled = true;
            btnHuy.Enabled = true;

            txtAmount.Focus();
        }


        private void btnCus_Click(object sender, EventArgs e)
        {
            frmCustomer frm = new frmCustomer();
            frm.ShowDialog();
            this.Hide();
        }
        private void btnLuu_Click(object sender, EventArgs e)
        {
           
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

        private void dgvBill_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
