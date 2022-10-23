using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Drawing.Imaging;

using Project_QuanLyCuaHangSach.Business_Layer;

namespace Project_QuanLyCuaHangSach
{
    public partial class frmBook : Form
    {
        bool update = false, delete = false, search = false;
        string err;

        DataTable dt;
        Book book;
        public frmBook()
        {
            InitializeComponent();
            loadData();
        }

        void loadData()
        {
            dt = new DataTable();
            dt.Clear();

            this.book = new Book();
            DataSet ds = book.getBook();
            dt = ds.Tables[0];

            dgvAllBook.DataSource = dt;
            dgvAllBook.AutoResizeColumns();
        }
        public void Reset(bool c)
        {
            this.txtBookID.ResetText();
            this.txtBookNAME.ResetText();
            this.cbAuthorNAME.ResetText();
            this.txtBookAMOUNT.ResetText();
            this.txtBookPRICE.ResetText();
            this.cbCategoryNAME.ResetText();
            this.cbPublisherNAME.ResetText();
            this.pictureBoxImageB.Image = null;


            this.txtBookNAME.Enabled = c;
            this.cbAuthorNAME.Enabled = c;
            this.txtBookAMOUNT.Enabled = c;
            this.txtBookPRICE.Enabled = c;
            this.cbCategoryNAME.Enabled = c;
            this.cbPublisherNAME.Enabled = c;

            this.update = false;
            this.delete = false;
            this.search = false;

        }


        private void btnThem_Click(object sender, EventArgs e)
        {
            //xóa trống các đối tượng trong panel
            Reset(true);


            // Cho thao tác trên các nút Lưu / Hủy / Panel
            this.btnLuu.Enabled = true;
            this.btnHuy.Enabled = true;

            // Không cho thao tác trên các nút Thêm / Xóa / Thoát
            this.btnSua.Enabled = false;
            this.btnXoa.Enabled = false;
            this.btnThoat.Enabled = false;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            //xóa trống các đối tượng trong panel
            Reset(true);
            update = true;


            // Cho thao tác trên các nút Lưu / Hủy / Panel
            this.btnLuu.Enabled = true;
            this.btnHuy.Enabled = true;

            // Không cho thao tác trên các nút Thêm / Xóa / Thoát
            this.btnSua.Enabled = false;
            this.btnXoa.Enabled = false;
            this.btnThoat.Enabled = false;

            int r = dgvAllBook.CurrentCell.RowIndex;
            // Chuyển thông tin lên panel
            if (r >= 0)
            {
                //MemoryStream ms = new MemoryStream((byte[])dgvAllBook.Rows[r].Cells[1].Value);
                //this.pictureBoxImageB.Image = Image.FromStream(ms);
                this.txtBookID.Text =
                dgvAllBook.Rows[r].Cells[0].Value.ToString();
                this.txtBookNAME.Text =
                dgvAllBook.Rows[r].Cells[1].Value.ToString();
                this.cbCategoryNAME.Text =
                dgvAllBook.Rows[r].Cells[2].Value.ToString();
                this.cbAuthorNAME.Text =
                dgvAllBook.Rows[r].Cells[3].Value.ToString();
                this.cbPublisherNAME.Text =
                dgvAllBook.Rows[r].Cells[4].Value.ToString();
                this.txtBookPRICE.Text =
                dgvAllBook.Rows[r].Cells[5].Value.ToString();
                this.txtBookAMOUNT.Text =
                dgvAllBook.Rows[r].Cells[6].Value.ToString();
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (update)
            {
                try
                {
                    int id = Convert.ToInt32(txtBookID.Text);
                    string name = txtBookNAME.Text.Trim().ToString();
                    int price = Convert.ToInt32(txtBookPRICE.Text);

                    book = new Book();
                    book.updatehBook(id, name, price, ref err);

                    if (err != null)
                    {
                        MessageBox.Show(err);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

                Reset(true);
                loadData();
            }
            else if (delete)
            {
                try
                {
                    int id = Convert.ToInt32(txtBookID.Text);

                    book = new Book();
                    book.deleteBook(id, ref err);
                    if (err != null)
                    {
                        MessageBox.Show(err);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);

                }
                Reset(true);
                loadData();
            }

            else if (search)
            {
                try
                {
                    int id = Convert.ToInt32(txtBookID.Text);
                    string name = txtBookNAME.Text.Trim().ToString();


                    dt = new DataTable();
                    dt.Clear();

                    book = new Book();
                    DataSet ds = book.searchBook(id, name);
                    dt = ds.Tables[0];

                    dgvAllBook.DataSource = dt;
                    dgvAllBook.AutoResizeColumns();

                    
                    if (err != null)
                    {
                        MessageBox.Show(err);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }


        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            //xóa trống các đối tượng trong panel
            Reset(false);


            // Cho thao tác trên các nút Lưu / Hủy / Panel
            this.btnLuu.Enabled = false;
            this.btnHuy.Enabled = false;

            // Không cho thao tác trên các nút Thêm / Xóa / Thoát
            this.btnSua.Enabled = true;
            this.btnXoa.Enabled = true;
            this.btnThoat.Enabled = true;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            frmMain frm = new frmMain();
            frm.Show();
            this.Hide();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string bkID;
            if (txtBookID.Text != string.Empty)
                bkID = txtBookID.Text;
            else
                bkID = dgvAllBook.Rows[dgvAllBook.CurrentCell.RowIndex].Cells[2].Value.ToString();

            this.delete = true;
        }

        private void btnSuaCategory_Click(object sender, EventArgs e)
        {
            frmUpdateCategory frm = new frmUpdateCategory();
            frm.ShowDialog();
            this.Hide();
        }

        private void btnSuaAuthor_Click(object sender, EventArgs e)
        {
            frmUpdateAuthor frm = new frmUpdateAuthor();
            frm.ShowDialog();
            this.Hide();
        }

        private void btnSuaPublisher_Click(object sender, EventArgs e)
        {
            frmUpdatePublisher frm = new frmUpdatePublisher();
            frm.ShowDialog();
            this.Hide();
        }

        private void btnLoadBia_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                pictureBoxImageB.Image = Image.FromFile(openFileDialog.FileName);
                this.Text = openFileDialog.FileName;
            }
        }
        // Chuyển ảnh sang byte array
        byte[] ImageToByteArray(Image image)
        {
            if (pictureBoxImageB.Image != null)
            {
                MemoryStream ms = new MemoryStream();
                image.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                return ms.ToArray();
            }
            else
                return null;
        }

        private void dgvAllBook_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = dgvAllBook.CurrentCell.RowIndex;
            this.txtBookID.Text =
                dgvAllBook.Rows[r].Cells[0].Value.ToString();
            this.txtBookNAME.Text =
            dgvAllBook.Rows[r].Cells[1].Value.ToString();
            this.cbCategoryNAME.Text =
            dgvAllBook.Rows[r].Cells[2].Value.ToString();
            this.cbAuthorNAME.Text =
            dgvAllBook.Rows[r].Cells[3].Value.ToString();
            this.cbPublisherNAME.Text =
            dgvAllBook.Rows[r].Cells[4].Value.ToString();
            this.txtBookPRICE.Text =
            dgvAllBook.Rows[r].Cells[5].Value.ToString();
            this.txtBookAMOUNT.Text =
            dgvAllBook.Rows[r].Cells[6].Value.ToString();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            this.search = true;
            this.btnLuu.Enabled = true;
        }

        private void frmBook_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmMain frm = new frmMain();
            frm.Show();
            this.Hide();
        }
    }
}
