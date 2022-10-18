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

namespace Project_QuanLyCuaHangSach
{
    public partial class frmBook : Form
    {
        bool add = false;
        public frmBook()
        {
            InitializeComponent();
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

        }
     

        private void btnThem_Click(object sender, EventArgs e)
        {
            add = true;
            //xóa trống các đối tượng trong panel
            Reset(true);


            // Cho thao tác trên các nút Lưu / Hủy / Panel
            this.btnLuu.Enabled = true;
            this.btnHuy.Enabled = true;

            // Không cho thao tác trên các nút Thêm / Xóa / Thoát
            this.btnThem.Enabled = false;
            this.btnSua.Enabled = false;
            this.btnXoa.Enabled = false;
            this.btnThoat.Enabled = false;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            add = false;
            //xóa trống các đối tượng trong panel
            Reset(true);


            // Cho thao tác trên các nút Lưu / Hủy / Panel
            this.btnLuu.Enabled = true;
            this.btnHuy.Enabled = true;

            // Không cho thao tác trên các nút Thêm / Xóa / Thoát
            this.btnThem.Enabled = false;
            this.btnSua.Enabled = false;
            this.btnXoa.Enabled = false;
            this.btnThoat.Enabled = false;

            int r = dgvAllBook.CurrentCell.RowIndex;
            // Chuyển thông tin lên panel
            if (r >=0)
            {
                MemoryStream ms = new MemoryStream((byte[])dgvAllBook.Rows[r].Cells[1].Value);
                this.pictureBoxImageB.Image = Image.FromStream(ms);
                this.txtBookID.Text =
                dgvAllBook.Rows[r].Cells[2].Value.ToString();
                this.txtBookNAME.Text =
                dgvAllBook.Rows[r].Cells[3].Value.ToString();
                this.cbCategoryNAME.Text =
                dgvAllBook.Rows[r].Cells[4].Value.ToString();
                this.cbAuthorNAME.Text =
                dgvAllBook.Rows[r].Cells[5].Value.ToString();
                this.cbPublisherNAME.Text =
                dgvAllBook.Rows[r].Cells[6].Value.ToString();
                this.txtBookPRICE.Text =
                dgvAllBook.Rows[r].Cells[7].Value.ToString();
                this.txtBookAMOUNT.Text =
                dgvAllBook.Rows[r].Cells[8].Value.ToString();
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (add)
            {
                if (txtBookID.Text.Length > 10)
                {
                    MessageBox.Show("Mã sách quá dài!");
                }
                else
                {
                    try
                    {
                       MessageBox.Show("Sách này chưa có bìa sách");
                    }
                    catch
                    {
                        MessageBox.Show("Thông tin mã sách này đã tồn tại");
                        txtBookID.Focus();
                    }
                }
            }
            else
            {
                try
                {
                   
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
            this.btnThem.Enabled = true;
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
            if(openFileDialog.ShowDialog() == DialogResult.OK)
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

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                
                    MessageBox.Show("Không tìm thấy mã sách này!");
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void frmBook_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmMain frm = new frmMain();
            frm.Show();
            this.Hide();
        }
    }
}
