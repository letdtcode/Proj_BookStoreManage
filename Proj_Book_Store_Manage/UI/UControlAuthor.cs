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
using System.Data.SqlClient;
using System.Data;

namespace Proj_Book_Store_Manage.UI
{
    public partial class UControlAuthor : UserControl
    {
        DataTable dtAuthor = null;

        //false là chế độ sửa, true là chế độ thêm
        bool tempAdd = false;
        AuthorBL author = new AuthorBL();
        private string err = "";
        public UControlAuthor()
        {
            InitializeComponent();
        }
        public void LoadData()
        {
            try
            {
                dtAuthor = new DataTable();
                dtAuthor = author.getDataAuthor();
                //Đưa dữ liệu lên datagridview
                dgvAuthor.DataSource = dtAuthor;
                dgvAuthor.AutoResizeColumns();

                //Reset lại textbox
                this.txtNameAuthor.ResetText();
                this.txtPhoneNumber.ResetText();
                this.txtSearch.ResetText();

                //Khóa button save và cancel
                this.btnSave.Enabled = false;
                this.btnCancel.Enabled = false;
                this.txtNameAuthor.Enabled = false;
                this.txtPhoneNumber.Enabled = false;

                //Mở button add, edit, delete
                this.btnAdd.Enabled = true;
                this.btnEdit.Enabled = true;
                this.btnDelete.Enabled = true;

            }
            catch (SqlException)
            {
                MessageBox.Show("Không lấy được dữ liệu ! Vui lòng kiểm tra lại");
            }
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            //Kích hoạt biến Thêm
            tempAdd = true;

            //Xóa trống các đối tượng trong panel
            this.txtNameAuthor.ResetText();
            this.txtPhoneNumber.ResetText();
            this.txtSearch.ResetText();

            //Cho phép thao tác trên các nút Save/Cancel
            this.btnSave.Enabled = true;
            this.btnCancel.Enabled = true;

            //Mở cho người dùng nhập các text field
            this.txtNameAuthor.Enabled = true;
            this.txtPhoneNumber.Enabled = true;

            //Đưa con trỏ đến vị trí bắt đầu
            this.txtNameAuthor.Focus();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (tempAdd)
            {
                try
                {
                    //author = new AuthorBL();
                    author.addNewAuthor(this.txtNameAuthor.Text, this.txtPhoneNumber.Text,ref err);
                    LoadData();
                    MessageBox.Show("Thêm Tác Giả thành công !");
                }
                catch
                {
                    MessageBox.Show("Đã có lỗi xảy ra !");
                }
            }
        }

        private void UControlAuthor_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }

        private void btnReload_Click(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {

        }
    }
}
