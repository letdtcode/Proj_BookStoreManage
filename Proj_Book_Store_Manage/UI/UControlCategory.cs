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
    public partial class UControlCategory : UserControl
    {
        private List<Control> controls = null;
        private DataTable dtCategory = null;
        private Utilities utl = null;
        private string err = "";
        private DialogResult result;

        private bool isAdd = false;
        private bool isEdit = false;
        CategoryBL category = new CategoryBL();
        List<string> param;
        public UControlCategory()
        {
            InitializeComponent();
            createAttributeComBoBox();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            this.lblIDCategory.Text = utl.createID("TL");
            isAdd = true;
            utl.SetNullForAllControl();
            utl.setEnableControl(true);
            utl.SetEnableButton(new List<Button> { btnEdit, btnDelete }, false);
            utl.SetEnableButton(new List<Button> { btnSave, btnReload }, true);
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            isEdit = true;
            utl.setEnableControl(true);
            utl.SetEnableButton(new List<Button> { btnAdd, btnDelete }, false);
            utl.SetEnableButton(new List<Button> { btnSave, btnReload }, true);
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
                        if (category.deleteCategory(utl.IDCurrent, ref err) == true)
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
                    category = new CategoryBL();
                    try
                    {
                        lblIDCategory.Text = utl.createID("TL");
                        category.addNewCategory(this.lblIDCategory.Text, this.txtNameCategory.Text, this.txtDescribe.Text, ref err);
                        if (err == "")
                        {
                            MessageBox.Show("Thêm thể loại thành công !");
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
                    category.modifyCategory(this.lblIDCategory.Text, this.txtNameCategory.Text, this.txtDescribe.Text, ref err);
                    //LoadData();
                    if (err == "")
                    {
                        MessageBox.Show("Sửa thể loại thành công !");
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

        private void btnCancel_Click(object sender, EventArgs e)
        {

        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            LoadData();
        }
        private void LoadData()
        {
            controls = new List<Control> { txtNameCategory, txtDescribe };
            dtCategory = category.getDataCategory();
            dgvCategory.DataSource = dtCategory;
            utl = new Utilities(controls, dgvCategory);
            dgvCategory.AutoResizeColumns();
            utl.SetEnableButton(new List<Button>() { btnSave, btnCancel }, false);
            utl.SetEnableButton(new List<Button>() { btnAdd, btnEdit, btnDelete, btnReload }, true);
            utl.setEnableControl(false);
        }
        private void dgvCategory_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            utl.CellClick(btnCancel, btnDelete);
            lblIDCategory.Text = utl.IDCurrent;
            txtNameCategory.Text = dgvCategory.Rows[utl.rowCurrent].Cells[1].Value.ToString();
            txtDescribe.Text = dgvCategory.Rows[utl.rowCurrent].Cells[2].Value.ToString();
        }

        private void UControlCategory_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string id, nameCate;
            (id, nameCate) = getParameter();

            try
            {
                category = new CategoryBL();
                dtCategory = category.searchCategory(id, nameCate, ref err);
                dgvCategory.DataSource = dtCategory;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        void createAttributeComBoBox()
        {
            param = new List<string>();
            param.Add("Id Category");
            param.Add("Name Category");
            this.cbAttributeSearch.DataSource = param;
        }

        (string, string) getParameter()
        {
            string id, username;
            if (cbAttributeSearch.Text == "Id Category")
            {
                id = this.txtSearch.Text.Trim();
                username = null;
            }

            else if (cbAttributeSearch.Text == "Name Category")
            {
                id = null;
                username = this.txtSearch.Text.Trim(); ;
            }
            else
            {
                id = null;
                username = null;
            }
            return (id, username);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
