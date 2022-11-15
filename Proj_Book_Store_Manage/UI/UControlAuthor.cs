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

namespace Proj_Book_Store_Manage.UI
{
    public partial class UControlAuthor : UserControl
    {
        private List<Control> controls = null;
        private DataTable dtAuthor = null;
        private Utilities utl = null;
        private int IDAuthor;
        private string err = "";
        private DialogResult result;
        List<string> param;

        //false là chế độ sửa, true là chế độ thêm
        private bool isAdd = false;
        private bool isEdit = false;
        AuthorBL author = new AuthorBL();
        //private bool roleTemp;
        public UControlAuthor()
        {
            InitializeComponent();
            createAttributeComBoBox();
        }
        public void LoadData()
        {
            controls = new List<Control> { txtNameAuthor, txtPhoneNumber };
            dtAuthor = author.getDataAuthor();
            dgvAuthor.DataSource = dtAuthor;
            utl = new Utilities(controls, dgvAuthor);
            dgvAuthor.AutoResizeColumns();
            utl.SetEnableButton(new List<Button>() { btnSave, btnCancel }, false);
            utl.SetEnableButton(new List<Button>() { btnAdd, btnEdit, btnDelete, btnReload }, true);
            utl.setEnableControl(false);
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            isAdd = true;
            lblIDAuthor.Text = utl.createID("TG ");
            utl.SetNullForAllControl();
            utl.setEnableControl(true);
            utl.SetEnableButton(new List<Button> { btnEdit, btnDelete }, false);
            utl.SetEnableButton(new List<Button> { btnSave, btnReload, btnCancel }, true);
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            isEdit = true;
            //utl.SetNullForAllControl();
            utl.setEnableControl(true);
            utl.SetEnableButton(new List<Button> { btnAdd, btnDelete }, false);
            utl.SetEnableButton(new List<Button> { btnSave, btnReload, btnCancel }, true);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (utl.checkAllControlIsFill() == false)
                {
                    result = MessageBox.Show("Vui lòng nhập đầy đủ thông tin !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    isAdd = false;
                    isEdit = false;
                    return;
                }
                if (isAdd)
                {
                    author = new AuthorBL();
                    try
                    {
                        lblIDAuthor.Text = utl.createID("TG");
                        author.addNewAuthor(this.lblIDAuthor.Text, this.txtNameAuthor.Text, this.txtPhoneNumber.Text, ref err);
                        if (err == "")
                        {
                            MessageBox.Show("Thêm tài khoản thành công !");
                        }
                        else
                        {
                            MessageBox.Show(err, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    catch
                    {
                        MessageBox.Show("Thông tin không hợp lệ");
                    }
                }
                else if (isEdit)
                {
                    //account = new AccountBL()
                    author.modifyAuthor(this.lblIDAuthor.Text, this.txtNameAuthor.Text, this.txtPhoneNumber.Text, ref err);
                    //LoadData();
                    if (err == "")
                    {
                        MessageBox.Show("Sửa tài khoản thành công !");
                    }
                    else
                    {
                        MessageBox.Show(err, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch
            {
                MessageBox.Show("Đã có lỗi xảy ra !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                isAdd = false;
                isEdit = false;
                utl.SetNullForAllControl();
                LoadData();
            }
        }

        private void UControlAuthor_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (utl.CheckIDValid is true)
                {
                    result = MessageBox.Show("Bạn có chắc chắn muốn xóa không ?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        if (author.deleteAuthor(utl.IDCurrent, ref err) == true)
                        {
                            MessageBox.Show("Xóa thành công !");
                        }
                        else
                            MessageBox.Show("Xoá thất bại !");

                    }
                }
            }
            catch
            {
                MessageBox.Show("Không thể xóa !");
            }
            finally
            {
                LoadData();
            }
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void dgvAuthor_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            utl.CellClick(btnCancel, btnDelete);
            this.lblIDAuthor.Text = utl.IDCurrent;
            txtNameAuthor.Text = dgvAuthor.Rows[utl.rowCurrent].Cells[1].Value.ToString();
            txtPhoneNumber.Text = dgvAuthor.Rows[utl.rowCurrent].Cells[2].Value.ToString();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string id, nameAuthor;
            (id, nameAuthor) = getParameter();

            try
            {
                author = new AuthorBL();
                dtAuthor = author.searchAuthor(id, nameAuthor, ref err);
                dgvAuthor.DataSource = dtAuthor;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        void createAttributeComBoBox()
        {
            param = new List<string>();
            param.Add("Id Author");
            param.Add("Name Author");
            this.cbAttributeSearch.DataSource = param;
        }
        (string, string) getParameter()
        {
            string id, nameAuthor;
            if (cbAttributeSearch.Text == "Id Author")
            {
                id = this.txtSearch.Text.Trim();
                nameAuthor = null;
            }

            else if (cbAttributeSearch.Text == "Name Author")
            {
                id = null;
                nameAuthor = this.txtSearch.Text.Trim(); ;
            }
            else
            {
                id = null;
                nameAuthor = null;
            }
            return (id, nameAuthor);
        }
    }
}
