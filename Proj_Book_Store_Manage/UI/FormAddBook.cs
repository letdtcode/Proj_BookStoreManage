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
    public partial class FormAddBook : Form
    {
        Book book;
        AuthorBL author;
        public FormAddBook()
        {
            InitializeComponent();
        }

        private void dgvBook_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

        }

        void setText(bool flag)
        {
            this.txtBookName.ResetText();
            this.txtIdPub.ResetText();
            this.txtPriceEx.ResetText();
            this.txtPriceIm.ResetText();

            this.txtBookName.Enabled = flag;
            this.txtIdPub.Enabled = flag;
            this.txtPriceEx.Enabled = flag;
            this.txtPriceIm.Enabled = flag;
        }

        void setBtn(bool flag)
        {
            this.btnAddBook.Enabled = flag;
            this.btnAddAuthor.Enabled = !flag;
            this.btnAddCate.Enabled = flag;
            this.btnCancel.Enabled = flag;
            this.btnDelAuthor.Enabled = flag;
            this.btnEdit.Enabled = flag;
            this.btnPushPath.Enabled = flag;
            this.btnReload.Enabled = flag;
            this.btnSave.Enabled = flag;
            this.btnSearch.Enabled = flag;
        }

        private void dgvAthor_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvCategory_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
