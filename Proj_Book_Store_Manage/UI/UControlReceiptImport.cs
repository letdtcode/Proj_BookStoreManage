using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proj_Book_Store_Manage.UI
{
    public partial class UControlReceiptImport : UserControl
    {
        public UControlReceiptImport()
        {
            InitializeComponent();
        }

        private void btnDetailImportReceipt_Click(object sender, EventArgs e)
        {
            FormDetailReceiptImport frm_DetailReceiptImport = new FormDetailReceiptImport();
            frm_DetailReceiptImport.ShowDialog();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {

        }

        private void btnReload_Click(object sender, EventArgs e)
        {

        }
    }
}
