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
        private Utilities utl = null;
        private int IDBook;
        private string err = "";
        private DialogResult result;

        //false là chế độ sửa, true là chế độ thêm
        private bool isAdd = false;
        private bool isEdit = false;
        BookBL book = new BookBL();
        private byte[] imgBook = null;
        //private bool roleTemp;
        public UControlInfoBook()
        {
            InitializeComponent();
        }

        private void UControlInfoBook_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
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
                        if (book.deleteBook(utl.row, ref err) == true)
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
                        book.addNewBook(this.txtNameBook.Text, this.ptbBook.Image, int.Parse(this.txtAmount.Text), int.Parse(this.txtPriceImport.Text), int.Parse(this.txtPriceExport.Text), int.Parse(this.cbIDPublisher.Text), ref err);
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
                    book.modifyBook(utl.row, this.txtNameBook.Text, this.ptbBook.Image, int.Parse(this.txtAmount.Text), int.Parse(this.txtPriceImport.Text), int.Parse(this.txtPriceExport.Text), int.Parse(this.cbIDPublisher.Text), ref err);
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

        }

        private void btnDeleteCate_Click(object sender, EventArgs e)
        {

        }

        private void btnSaveCate_Click(object sender, EventArgs e)
        {

        }

        private void btnAddAuthor_Click(object sender, EventArgs e)
        {

        }

        private void btnDeleteAuthor_Click(object sender, EventArgs e)
        {

        }

        private void btnSaveAuthor_Click(object sender, EventArgs e)
        {

        }

        private void btnUploadImg_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                ptbBook.Image = Image.FromFile(openFileDialog.FileName);
                this.Text = openFileDialog.FileName;
            }
        }
        

        
        private void LoadData()
        {
            controls = new List<Control> { txtNameBook, txtAmount, cbIDPublisher, txtPriceImport, txtPriceExport, btnUploadImg };
            dtBook = book.getDataBook();
            //DataGridViewImageColumn
            dgvBook.DataSource = dtBook;
            DataGridViewImageColumn imgCol = (DataGridViewImageColumn)dgvBook.Columns["Hình ảnh"];
            imgCol.ImageLayout = DataGridViewImageCellLayout.Stretch;
            //dgvBook.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            utl = new Utilities(controls, dgvBook);
            //dgvBook.AutoResizeColumns();
            utl.SetEnableButton(new List<Button>() { btnSave, btnCancel }, false);
            utl.SetEnableButton(new List<Button>() { btnAdd, btnEdit, btnDelete, btnReload }, true);
            utl.setEnableControl(false);
        }

        private void dgvBook_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            utl.CellClick(btnCancel, btnDelete);
            if (dgvBook.Rows[utl.rowCurrent].Cells[6].Value.ToString() == "")
                ptbBook.Image = null;
            else
                ptbBook.Image = (Image)dgvBook.Rows[utl.rowCurrent].Cells[6].Value;
            txtNameBook.Text = dgvBook.Rows[utl.rowCurrent].Cells[1].Value.ToString();
            txtAmount.Text = dgvBook.Rows[utl.rowCurrent].Cells[2].Value.ToString();
            txtPriceImport.Text = dgvBook.Rows[utl.rowCurrent].Cells[3].Value.ToString();
            txtPriceExport.Text = dgvBook.Rows[utl.rowCurrent].Cells[4].Value.ToString();
            cbIDPublisher.Text = dgvBook.Rows[utl.rowCurrent].Cells[5].Value.ToString();
        }
    }
}
