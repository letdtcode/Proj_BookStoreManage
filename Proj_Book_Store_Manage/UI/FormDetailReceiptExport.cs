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
    public partial class FormDetailReceiptExport : Form
    {
        //private List<Control> controls = null;
        private DataTable dtListItem = null;
        //private Utilities utl = null;
        //private int IDAccount;
        private string err = "";
        //private DialogResult result;

        //false là chế độ sửa, true là chế độ thêm
        /*private bool isAdd = false;
        private bool isEdit = false;*/
        DetailReceiptExport detailReceiptExport = new DetailReceiptExport();
       // private bool roleTemp;
        public FormDetailReceiptExport()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                addProductToList(this.lblIDBook.Text, this.lblNameBook.Text, int.Parse(this.txtAmountBook.Text));
            }
            catch
            {
                MessageBox.Show("Vui lòng chọn sản phẩm cần thêm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }   
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

        private void LoadData()
        {
            dtListItem = detailReceiptExport.getDataDetailReceiptExport();
            dgvListBook.DataSource = dtListItem;
            //utl = new Utilities(controls, dgvAuthor);
            dgvListBook.AutoResizeColumns();
            /*utl.SetEnableButton(new List<Button>() { btnSave, btnCancel }, false);
            utl.SetEnableButton(new List<Button>() { btnAdd, btnEdit, btnDelete, btnReload }, true);
            utl.setEnableControl(false);*/
        }

        private void FormDetailReceiptExport_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void dgvListBook_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowCurrentIndex = dgvListBook.CurrentCell.RowIndex;
            this.lblIDBook.Text = dgvListBook.Rows[rowCurrentIndex].Cells[0].Value.ToString();
            this.lblNameBook.Text=dgvListBook.Rows[rowCurrentIndex].Cells[1].Value.ToString();
        }

        private void addProductToList(string idBook, string nameBook, int amount)
        {
            ListViewItem bookItem = new ListViewItem();
            bookItem.Text = lblIDBook.Text;
            bookItem.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = nameBook });
            bookItem.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = amount.ToString() });

            lViewCart.Items.Add(bookItem);

        }
    }
}
