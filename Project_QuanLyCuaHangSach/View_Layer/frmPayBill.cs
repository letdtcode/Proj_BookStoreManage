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
    public partial class frmPayBill : Form
    {
        int idBill, idVoucher = 0;

        string err;
        DataTable dt;
        SellBook sellBook;

        public frmPayBill()
        {
            InitializeComponent();
        }

        public frmPayBill(int id)
        {
            this.idBill = id;
            InitializeComponent();
            loadDataDetailItem();
            loadDataVoucher();
            loadDataBill();
            loadText();
            reset();
        }

        void loadText ()
        {
            this.lbIdBill.Text = idBill.ToString();
            this.lbIdVoucher.Text = dgvBill.Rows[0].Cells[5].Value.ToString().Trim();
            this.lbNamCus.Text = dgvBill.Rows[0].Cells[3].Value.ToString().Trim();
            this.lbNotVoucher.Text = "0";
            this.lbPayMust.Text = dgvBill.Rows[0].Cells[2].Value.ToString().Trim();
        }

        void reset ()
        {
            this.btnAddVoucher.Enabled = true;
            this.btnDeleVoucher.Enabled = true;
        }

        void loadDataBill()
        {
            dt = new DataTable();

            sellBook = new SellBook();
            DataSet ds = sellBook.getBill(idBill);
            dt = ds.Tables[0];
            dgvBill.DataSource = dt;
        }

        void loadDataDetailItem ()
        {
            dt = new DataTable();

            sellBook = new SellBook();
            DataSet ds = sellBook.getCart(idBill);
            dt = ds.Tables[0];

            dgvBill.DataSource = dt;
        }

        void loadDataVoucher ()
        {
            dt = new DataTable();

            sellBook = new SellBook();
            DataSet ds = sellBook.getVoucher(DateTime.Now.Date);
            dt = ds.Tables[0];
            dgvVoucher.DataSource = dt;
        }

        private void btnAddVoucher_Click(object sender, EventArgs e)
        {
            this.btnDeleVoucher.Enabled = false;
            if (idVoucher != 0)
            {
                try
                {
                    sellBook = new SellBook();
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


        }

        private void btnDeleVoucher_Click(object sender, EventArgs e)
        {
            try
            {
                sellBook = new SellBook();
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

        private void btnFinish_Click(object sender, EventArgs e)
        {
            try
            {
                sellBook = new SellBook();
                sellBook.export(idBill, ref err);
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

            this.idVoucher = Convert.ToInt32(dgvVoucher.Rows[r].Cells[0].Value.ToString());
        }
    }
}
