using Proj_Book_Store_Manage.BSLayer;
using Proj_Book_Store_Manage.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Proj_Book_Store_Manage.UI
{
    public partial class UControlCategory : UserControl
    {
        public UControlCategory()
        {
            InitializeComponent();
        }
        private string crud;
        BindingSource bdCategory = new BindingSource();
        void AddBidingCategory()
        {
            txtID.DataBindings.Add(new Binding("Text", dgvCategory.DataSource, "IdCategory", true, DataSourceUpdateMode.Never));
            txtNameCategory.DataBindings.Add(new Binding("Text", dgvCategory.DataSource, "NameCategory", true, DataSourceUpdateMode.Never));
            txtDescribe.DataBindings.Add(new Binding("Text", dgvCategory.DataSource, "Description", true, DataSourceUpdateMode.Never));
        }
        string getValue(string text)
        {
            // string a = this.txtTenDanhMuc.Text;
            text = text.Trim();
            Regex trimmer = new Regex(@"\s\s+"); // Xóa khoảng trắng thừa trong chuỗi
            text = trimmer.Replace(text, " ");
            return text;
        }
        void AddCategory()
        {

            try
            {
                CategoryDAO.Instance.InsertCategory(getValue(txtNameCategory.Text),getValue(txtDescribe.Text));
                MessageBox.Show("Thêm thành công");
            }
            catch
            {
                MessageBox.Show("Lỗi khi thêm");
            }


        }
        void DeleteCategory()
        {
            try
            {
                CategoryDAO.Instance.DeleteCategory(int.Parse(txtID.Text));
                MessageBox.Show("Xóa thành công");
            }
            catch
            {
                MessageBox.Show("Lỗi khi xóa");
            }
        }
        void UpdateCategory()
        {
            try
            {
                CategoryDAO.Instance.UpdateCategory(int.Parse(this.txtID.Text), getValue(txtNameCategory.Text),getValue(txtDescribe.Text));
                MessageBox.Show("Sửa thành công");
            }
            catch
            {
                MessageBox.Show("Lỗi khi sửa");
            }
        }
        void ShowCategory()
        {
            bdCategory.DataSource = CategoryDAO.Instance.LoadCategory();
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            txtNameCategory.Text = string.Empty;
            txtDescribe.Text = String.Empty;
            txtID.Text = (CategoryDAO.Instance.getIdmaxCategory() + 1).ToString();
            btnSave.Visible = true;
            btnAdd.Enabled = false;
            btnCancel.Visible = true;
            btnEdit.Visible = false;
            btnDelete.Visible = false;
            btnReload.Visible = false;
            crud = "Add";
        }


        private void UControlCategory_Load(object sender, EventArgs e)
        {
            dgvCategory.DataSource = bdCategory;
            ShowCategory();
            AddBidingCategory();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            ShowCategory();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            btnEdit.Enabled = false;
            btnCancel.Visible = true;
            btnDelete.Visible = false;
            btnAdd.Visible = false;
            btnSave.Visible = true;
            this.crud = "Update";
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            btnDelete.Enabled = false;
            txtID.Enabled = false;
            txtNameCategory.Enabled = false;
            txtDescribe.Enabled = false;
            btnCancel.Visible = true;
            btnEdit.Visible = false;
            btnAdd.Visible = false;
            btnSave.Visible = true;
            this.crud = "Delete";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            switch (this.crud)
            {
                case "Add":
                    AddCategory();
                    break;
                case "Delete":
                    DeleteCategory();
                    break;
                case "Update":
                    UpdateCategory();
                    break;
                default:
                    break;
            }
            btnEdit.Visible = true;
            btnDelete.Visible = true;
            btnCancel.Visible = false;
            btnAdd.Visible = true;
            btnSave.Visible = false;
            btnAdd.Enabled = true;
            txtNameCategory.Enabled = true;
            //txtPhone.Enabled = true;
            btnEdit.Enabled = true;
            btnDelete.Enabled = true;
            ShowCategory();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            btnCancel.Visible = false;
            btnDelete.Visible = true;
            btnAdd.Visible = true;
            btnEdit.Visible = true;
            btnSave.Visible = false;
            btnAdd.Enabled = true;
            txtNameCategory.Enabled = true;
            btnEdit.Enabled = true;
            btnDelete.Enabled = true;
            ShowCategory();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if(cbAttributeSearch.SelectedIndex==0)
            {
                bdCategory.DataSource = CategoryDAO.Instance.LoadCategoryById(int.Parse(txtSearch.Text));
            }    
            if(cbAttributeSearch.SelectedIndex==1)
            {
                bdCategory.DataSource = CategoryDAO.Instance.LoadCategoryByName(txtSearch.Text);
            }    
        }
    }
}
