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
    public partial class frmBill : Form
    {
        SellBook sellBook;

        DataTable dt;

        string err;

        //public int idBill { get; set; }

        public frmBill()
        {
            InitializeComponent();
            loadData();
        }

        void loadData ()
        {
            dt = new DataTable();

            sellBook = new SellBook();

            DataSet ds = sellBook.getBill();
            dt = ds.Tables[0];

            dgvBillOutput.DataSource = dt;
        }

        private void btnFinish_Click(object sender, EventArgs e)
        {
            sellBook = new SellBook();

            int idCus = Convert.ToInt32(txtIdCus.Text);
            int idEm = Convert.ToInt32(txtIdEm.Text);
            DateTime date = DateTime.Now.Date;

            try
            {
                sellBook.createBill(idCus, idEm, date, ref err);
                if (err != null)
                {
                    MessageBox.Show(err);
                }    
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.txtIdCus.ResetText();
            this.txtIdEm.ResetText();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            frmSell frmSell = new frmSell(Convert.ToInt32(txtIdBill.Text));
            frmSell.idBill = Convert.ToInt32(txtIdBill.Text);
            frmSell.Show();
            this.Close();

        }

        private void dgvBillOutput_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = dgvBillOutput.CurrentCell.RowIndex;

            this.txtIdBill.Text = dgvBillOutput.Rows[r].Cells[0].Value.ToString().Trim();
            this.txtIdCus.Text = dgvBillOutput.Rows[r].Cells[1].Value.ToString().Trim();
            this.txtIdEm.Text = dgvBillOutput.Rows[r].Cells[2].Value.ToString().Trim();

            //idBill = Convert.ToInt32(txtIdBill.Text);
        }
    }
}
