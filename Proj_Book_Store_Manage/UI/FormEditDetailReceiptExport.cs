using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Proj_Book_Store_Manage.BSLayer;

namespace Proj_Book_Store_Manage.UI
{
    public partial class FormEditDetailReceiptExport : Form
    {
        DataGridView dgv = null;
        int rowIndex;

        public FormEditDetailReceiptExport(DataGridView dgv, int rowIndex)
        {
            InitializeComponent();
            this.dgv = dgv;
            this.rowIndex = rowIndex;
        }

        private void FormEditDetailReceiptExport_Load(object sender, EventArgs e)
        {
            //this.lblAnnounce.Text = IdBill;
            this.cbIDBook.Text = dgv.Rows[rowIndex].Cells[0].Value.ToString();
            this.lblNameBook.Text = dgv.Rows[rowIndex].Cells[1].Value.ToString();
            this.txtAmount.Text = dgv.Rows[rowIndex].Cells[2].Value.ToString();

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            /*this.IdBook = this.cbIDBook.Text;
            this.NameBook = this.lblNameBook.Text;
            this.AmountBook = int.Parse(this.txtAmount.Text.ToString());*/
            editValue();
            this.Close();
        }
        private void editValue()
        {
            dgv.Rows[rowIndex].Cells[0].Value = this.cbIDBook.Text;
            dgv.Rows[rowIndex].Cells[1].Value = this.lblNameBook.Text;
            dgv.Rows[rowIndex].Cells[2].Value = this.txtAmount.Text;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
