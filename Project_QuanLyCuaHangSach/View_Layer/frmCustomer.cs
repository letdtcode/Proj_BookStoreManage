using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Project_QuanLyCuaHangSach.Business_Layer;

namespace Project_QuanLyCuaHangSach
{
    public partial class frmCustomer : Form
    {
        string err;
        DataTable dtCustomer;
        Customer cus = new Customer();

        bool add = false;
        public frmCustomer()
        {
            InitializeComponent();
            LoadData();
        }
      

        void LoadData ()
        {
            try
            {
                dtCustomer = new DataTable();
                dtCustomer.Clear();

                DataSet ds = cus.LayThongTinKhachHang();
                dtCustomer = ds.Tables[0];

                dgvKhachHang.DataSource = dtCustomer;
                dgvKhachHang.AutoResizeColumns();

                txtCustomerADDRESS.ResetText();
                txtCustomerID.ResetText();
                txtCustomerNAME.ResetText();
                txtCustomerPHONENUM.ResetText();

                btnHuy.Enabled = true;
                btnLuu.Enabled = true;
                btnSearch.Enabled = true;
            }
            catch 
            {
                
            }
        }
        public void Reset(bool c)
        {
            txtCustomerID.ResetText();
            txtCustomerNAME.ResetText();
            txtCustomerADDRESS.ResetText();
            txtCustomerPHONENUM.ResetText();
            this.cbCustomerTypeID.ResetText();

            this.txtCustomerNAME.Enabled = c;
            this.txtCustomerADDRESS.Enabled = c;
            this.txtCustomerPHONENUM.Enabled = c;
            this.cbCustomerTypeID.Enabled = c;

            this.btnSearch.Enabled = true;
            this.btnXoa.Enabled = true;
            this.btnSua.Enabled = true;


        }
       

        private void btnThem_Click(object sender, EventArgs e)
        {
            add = true;
            //xóa trống các đối tượng trong 
            Reset(true);

            // Cho thao tác trên các nút Lưu / Hủy
            this.btnLuu.Enabled = true;
            this.btnHuy.Enabled = true;

            // Không cho thao tác trên các nút Thêm / Xóa / Thoát
            this.btnThem.Enabled = false;
            this.btnSua.Enabled = false;
            this.btnXoa.Enabled = false;
            this.btnThoat.Enabled = false;

        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if(txtCustomerID.Text == string.Empty || txtCustomerADDRESS.Text == string.Empty || txtCustomerNAME.Text == string.Empty||
                txtCustomerPHONENUM.Text==string.Empty || cbCustomerTypeID.Text == string.Empty)
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
            }  
            else if (add)
            {
                try
                {
                    
                    MessageBox.Show("Thêm thành công");
                    Reset(true);
                }
                catch
                {
                    MessageBox.Show("Mã sách này đã tồn tại");
                    txtCustomerID.Focus();
                }
            }
            else
            {
                try
                {
                    cus.SuaThognTinKhachHang(Convert.ToInt32(txtCustomerID.Text.ToString()), txtCustomerNAME.Text.ToString(), txtCustomerADDRESS.Text.ToString(), txtCustomerPHONENUM.Text.ToString(), ref err);
                    if (err == null)
                        MessageBox.Show("Update thành công");
                    else
                        MessageBox.Show(err);
                    
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            LoadData();
            Reset(true);

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            frmMain frm = new frmMain();
            frm.Show();
            this.Hide();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            add = false;
            Reset(true);

            // Cho thao tác trên các nút Lưu / Hủy
            this.btnLuu.Enabled = true;
            this.btnHuy.Enabled = true;

            // Không cho thao tác trên các nút Thêm / Xóa / Thoát
            this.btnThem.Enabled = false;
            this.btnSua.Enabled = false;
            this.btnXoa.Enabled = false;
            this.btnThoat.Enabled = false;

            //Không cho phép thay đổi các trường thông tin
            this.txtCustomerID.Enabled = false;
            this.cbCustomerTypeID.Enabled = false;

            int r = dgvKhachHang.CurrentCell.RowIndex;
            // Chuyển thông tin lên panel
            this.txtCustomerID.Text = dgvKhachHang.Rows[r].Cells[0].Value.ToString().Trim();
            this.txtCustomerNAME.Text = dgvKhachHang.Rows[r].Cells[1].Value.ToString().Trim(); 
            this.txtCustomerADDRESS.Text = dgvKhachHang.Rows[r].Cells[2].Value.ToString().Trim();
            this.txtCustomerPHONENUM.Text =dgvKhachHang.Rows[r].Cells[3].Value.ToString().Trim();
            this.cbCustomerTypeID.Text =  dgvKhachHang.Rows[r].Cells[5].Value.ToString().Trim();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                dtCustomer = new DataTable();
                dtCustomer.Clear();

                DataSet ds = cus.TimKiemKhacHang (Convert.ToInt32(txtCustomerID.Text.Trim().ToString()));
                dtCustomer = ds.Tables[0];

                dgvKhachHang.DataSource = dtCustomer;
                dgvKhachHang.AutoResizeColumns();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            Reset(true);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string cusID;

        }

        private void btnUpdateCustomerType_Click(object sender, EventArgs e)
        {
            frmCustomerType frm = new frmCustomerType();
            frm.ShowDialog();
            this.Hide();
        }

        private void frmCustomer_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmMain frm = new frmMain();
            frm.Show();
            this.Hide();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            Reset(false);

            // Cho thao tác trên các nút Lưu / Hủy 
            this.btnLuu.Enabled = false;
            this.btnHuy.Enabled = false;

            // Không cho thao tác trên các nút Thêm / Xóa / Thoát
            this.btnThem.Enabled = true;
            this.btnSua.Enabled = true;
            this.btnXoa.Enabled = true;
            this.btnThoat.Enabled = true;
        }

        private void dgvKhachHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = dgvKhachHang.CurrentCell.RowIndex;
            // Chuyển thông tin lên panel
            this.txtCustomerID.Text = dgvKhachHang.Rows[r].Cells[0].Value.ToString().Trim();
            this.txtCustomerNAME.Text = dgvKhachHang.Rows[r].Cells[1].Value.ToString().Trim();
            this.txtCustomerADDRESS.Text = dgvKhachHang.Rows[r].Cells[2].Value.ToString().Trim();
            this.txtCustomerPHONENUM.Text = dgvKhachHang.Rows[r].Cells[3].Value.ToString().Trim();
            this.cbCustomerTypeID.Text = dgvKhachHang.Rows[r].Cells[5].Value.ToString().Trim();
        }
    }
}
