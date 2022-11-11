using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Proj_Book_Store_Manage.BSLayer;
using System.Drawing.Imaging;

namespace Proj_Book_Store_Manage.UI
{
    public partial class UControlInfoBook : UserControl
    {
        private List<Control> controls = null;
        private DataTable dtBook = null;
        private DataTable dtCateOfBook = null;
        private DataTable dtAuthorOfBook = null;
        private Utilities utl = null;
        private string err = "";
        private DialogResult result;

        //false là chế độ sửa, true là chế độ thêm
        private bool isAdd = false;
        private bool isEdit = false;
        BookBL book = new BookBL();
        PublisherBL publisher = new PublisherBL();
        AuthorBL author = new AuthorBL();
        CategoryBL category = new CategoryBL();

        //Category Of Book
        private bool isAddCateOfBook = false;
        private bool isEditCateOfBook = false;
        private string nameCateCellClick = null;
        

        //Author Of Book
        private bool isAddAuthorOfBook = false;
        private bool isEditAuthorOfBook = false;
        private string nameAuthorCellClick = null;
        public UControlInfoBook()
        {
            InitializeComponent();
        }

        private void UControlInfoBook_Load(object sender, EventArgs e)
        {
            LoadDataIntoCbPublisher(publisher.getAllIDPublisher());
            LoadDataIntoCbCategory(category.getAllNameCategory());
            LoadDataIntoCbAuthor(author.getAllNameAuthor());
            LoadData();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            this.lblIDBook.Text = utl.createID("BK");
            isAdd = true;
            utl.SetNullForAllControl();
            utl.setEnableControl(true);
            utl.SetEnableButton(new List<Button> { btnEdit, btnDelete }, false);
            utl.SetEnableButton(new List<Button> { btnSave, btnReload }, true);
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            isEdit = true;
            //utl.SetNullForAllControl();
            utl.setEnableControl(true);
            utl.SetEnableButton(new List<Button> { btnAdd, btnDelete }, false);
            utl.SetEnableButton(new List<Button> { btnSave, btnReload, btnUploadImg }, true);
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
                        if (book.deleteBook(utl.IDCurrent, ref err) == true)
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
                    book = new BookBL();
                    try
                    {
                        //imgBook = ImgToByteArray(ptbBook.Image);
                        book.addNewBook(this.lblIDBook.Text, this.txtNameBook.Text, this.ptbBook.Image, int.Parse(this.txtAmount.Text), int.Parse(this.txtPriceImport.Text), int.Parse(this.txtPriceExport.Text), this.cbIDPublisher.Text, ref err);
                        if (err == "")
                        {
                            MessageBox.Show("Thêm sách thành công !");
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
                    book.modifyBook(this.lblIDBook.Text, this.txtNameBook.Text, this.ptbBook.Image, int.Parse(this.txtAmount.Text), int.Parse(this.txtPriceImport.Text), int.Parse(this.txtPriceExport.Text), this.cbIDPublisher.Text, ref err);
                    LoadData();
                    if (err == "")
                    {
                        MessageBox.Show("Sửa sách thành công !");
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

        private void btnAddCate_Click(object sender, EventArgs e)
        {
            isAddCateOfBook = true;
            isEditCateOfBook = false;
            cbaddCategory.Enabled = true;
            btnSaveCate.Enabled = true; 
        }

        private void btnDeleteCate_Click(object sender, EventArgs e)
        {
            try
            {
                result = MessageBox.Show("Bạn có chắc chắn muốn xóa không ?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    if (book.deleteBookCategory(this.lblIDBook.Text, this.cbaddCategory.Text, ref err))
                    {
                        MessageBox.Show("Xóa thành công !");
                    }
                    else
                    {
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
                LoadDataCategory(this.lblIDBook.Text, ref err);
            }
        }
        private void btnEditCate_Click(object sender, EventArgs e)
        {
            isAddCateOfBook = false;
            isEditCateOfBook = true;
            cbaddCategory.Enabled = true;
            btnSaveCate.Enabled = true;
        }

        private void btnSaveCate_Click(object sender, EventArgs e)
        {
            try
            {
                if (isAddCateOfBook)
                {
                    try
                    {
                        //imgBook = ImgToByteArray(ptbBook.Image);
                        book.addNewBookCategory(this.lblIDBook.Text, this.cbaddCategory.Text, ref err);
                        if (err == "")
                        {
                            MessageBox.Show("Thêm thể loại cho sách có mã "+utl.IDCurrent+" thành công !");
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
                else if (isEditCateOfBook)
                {
                    //account = new AccountBL()
                    book.modifyBookCategory(this.lblIDBook.Text, this.nameCateCellClick, this.cbaddCategory.Text, ref err);
                    LoadData();
                    if (err == "")
                    {
                        MessageBox.Show("Sửa thể loại cho sách có mã " + this.lblIDBook.Text + " thành công !");
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
                isAddCateOfBook = false;
                isEditCateOfBook = false;
                cbaddCategory.Enabled = false;
                LoadDataCategory(lblIDBook.Text, ref err);
            }
        }

        private void btnAddAuthor_Click(object sender, EventArgs e)
        {
            isAddAuthorOfBook = true;
            isEditAuthorOfBook = false;
            cbaddAuthor.Enabled = true;
            btnSaveAuthor.Enabled = true;
        }

        private void btnDeleteAuthor_Click(object sender, EventArgs e)
        {
            try
            {
                result = MessageBox.Show("Bạn có chắc chắn muốn xóa không ?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    if (book.deleteBookAuthor(this.lblIDBook.Text, this.cbaddAuthor.Text, ref err))
                    {
                        MessageBox.Show("Xóa thành công !");
                    }
                    else
                    {
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
                LoadDataAuthor(this.lblIDBook.Text, ref err);
            }
        }
        private void btnEditAuthor_Click(object sender, EventArgs e)
        {
            isAddAuthorOfBook = false;
            isEditAuthorOfBook = true;
            cbaddAuthor.Enabled = true;
            btnSaveAuthor.Enabled = true;
        }
        private void btnSaveAuthor_Click(object sender, EventArgs e)
        {
            try
            {
                if (isAddAuthorOfBook)
                {
                    try
                    {
                        //imgBook = ImgToByteArray(ptbBook.Image);
                        book.addNewBookAuthor(this.lblIDBook.Text, this.cbaddAuthor.Text, ref err);
                        if (err == "")
                        {
                            MessageBox.Show("Thêm tác giả cho sách có mã " + utl.IDCurrent + " thành công !");
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
                else if (isEditAuthorOfBook)
                {
                    //account = new AccountBL()
                    book.modifyBookAuthor(this.lblIDBook.Text, this.nameAuthorCellClick, this.cbaddAuthor.Text, ref err);
                    LoadData();
                    if (err == "")
                    {
                        MessageBox.Show("Sửa tác giả cho sách có mã " + this.lblIDBook.Text + " thành công !");
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
                isAddAuthorOfBook = false;
                isEditAuthorOfBook = false;
                cbaddAuthor.Enabled = false;
                LoadDataAuthor(lblIDBook.Text, ref err);
            }
        }

        private void btnUploadImg_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog openFileDialog = new OpenFileDialog();
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    ptbBook.Image = Image.FromFile(openFileDialog.FileName);
                    this.Text = openFileDialog.FileName;
                }
            }
            catch
            {
                MessageBox.Show("Không đúng định dạng ảnh !");
            }
        }

        private void LoadDataCategory(string idBook, ref string err)
        {
            cbaddCategory.Enabled = false;
            dtCateOfBook = book.showCategory(idBook,ref err);
            dgvCategory.DataSource = dtCateOfBook;
            dgvCategory.AutoResizeColumns();
        }
        private void LoadDataAuthor(string idBook, ref string err)
        {
            cbaddAuthor.Enabled = false;
            dtAuthorOfBook = book.showAuthor(idBook, ref err);
            dgvAuthor.DataSource = dtAuthorOfBook;
            dgvAuthor.AutoResizeColumns();
        }
        private void LoadData()
        {

            controls = new List<Control> { txtNameBook, txtAmount, cbIDPublisher, txtPriceImport, txtPriceExport, btnUploadImg };
            dtBook = book.getDataBook();
            //DataGridViewImageColumn
            dgvBook.DataSource = dtBook;
            utl = new Utilities(controls, dgvBook);
            dgvBook.AutoResizeColumns();
            utl.SetEnableButton(new List<Button>() { btnSave, btnCancel }, false);
            utl.SetEnableButton(new List<Button>() { btnAdd, btnEdit, btnDelete, btnReload }, true);
            utl.setEnableControl(false);
        }

        private void dgvBook_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            err = "";
            utl.CellClick(btnCancel, btnDelete);

            //dgvCategory.DataSource = book.sh(utl.IDCurrent,ref err);
            lblIDBook.Text = utl.IDCurrent;
            //dgvAuthor.DataSource = book.showAuthor(utl.IDCurrent, ref err);
            if (dgvBook.Rows[utl.rowCurrent].Cells[6].Value.ToString() == "")
                ptbBook.Image = null;
            else
                ptbBook.Image = (Image)dgvBook.Rows[utl.rowCurrent].Cells[6].Value;
            txtNameBook.Text = dgvBook.Rows[utl.rowCurrent].Cells[1].Value.ToString();
            txtAmount.Text = dgvBook.Rows[utl.rowCurrent].Cells[2].Value.ToString();
            txtPriceImport.Text = dgvBook.Rows[utl.rowCurrent].Cells[3].Value.ToString();
            txtPriceExport.Text = dgvBook.Rows[utl.rowCurrent].Cells[4].Value.ToString();
            cbIDPublisher.Text = dgvBook.Rows[utl.rowCurrent].Cells[5].Value.ToString();
            LoadDataCategory(lblIDBook.Text.ToString(),ref err);
            LoadDataAuthor(lblIDBook.Text.ToString(), ref err);
        }
        private void LoadDataIntoCbPublisher(List<string> idPublishers)
        {
            cbIDPublisher.Items.Clear();
            foreach (string idPublisher in idPublishers)
            {
                cbIDPublisher.Items.Add(idPublisher);
            }
        }
        private void LoadDataIntoCbCategory(List<string> nameCategorys)
        {
            cbaddCategory.Items.Clear();
            foreach (string nameCategory in nameCategorys)
            {
                cbaddCategory.Items.Add(nameCategory);
            }
        }
        private void LoadDataIntoCbAuthor(List<string> nameAuthors)
        {
            cbaddAuthor.Items.Clear();
            foreach (string nameAuthor in nameAuthors)
            {
                cbaddAuthor.Items.Add(nameAuthor);
            }
        }
        private void dgvCategory_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowCateIndex = dgvCategory.CurrentCell.RowIndex;
            this.nameCateCellClick = dgvCategory.Rows[rowCateIndex].Cells[0].Value.ToString();
            this.cbaddCategory.Text = this.nameCateCellClick;
        }

        private void dgvAuthor_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowAuthorIndex = dgvAuthor.CurrentCell.RowIndex;
            this.nameAuthorCellClick = dgvAuthor.Rows[rowAuthorIndex].Cells[0].Value.ToString();
            this.cbaddAuthor.Text = this.nameAuthorCellClick;
        }
    }
}
