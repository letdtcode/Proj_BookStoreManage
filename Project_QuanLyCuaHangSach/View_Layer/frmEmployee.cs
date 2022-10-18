using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_QuanLyCuaHangSach
{
    public partial class frmEmployee : Form
    {
        bool add = false;
        public frmEmployee()
        {
            InitializeComponent();
        }
       
        public void Reset()
        {
            txtEmployeeID.ResetText();
            txtEmployeeNAME.ResetText();
            txtEmployeeADDRESS.ResetText();
            txtEmployeePHONENUM.ResetText();

        }
     

        private void btnThem_Click(object sender, EventArgs e)
        {
            add = true;
            //xóa trống các đối tượng trong panel
            Reset();

            //mở enabled
            this.txtEmployeeID.Enabled = true;
            this.txtEmployeeNAME.Enabled = true;
            this.txtEmployeeADDRESS.Enabled = true;
            this.txtEmployeePHONENUM.Enabled = true;

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
            this.txtEmployeeID.ResetText();
            this.txtEmployeeNAME.ResetText();
            this.txtEmployeeADDRESS.ResetText();
            this.txtEmployeePHONENUM.ResetText();

            //mở enabled
            this.txtEmployeeID.Enabled = true;
            this.txtEmployeeNAME.Enabled = true;
            this.txtEmployeeADDRESS.Enabled = true;
            this.txtEmployeePHONENUM.Enabled = true;

            // Cho thao tác trên các nút Lưu / Hủy / Panel
            this.btnLuu.Enabled = true;
            this.btnHuy.Enabled = true;

            // Không cho thao tác trên các nút Thêm / Xóa / Thoát
            this.btnThem.Enabled = false;
            this.btnSua.Enabled = false;
            this.btnXoa.Enabled = false;
            this.btnThoat.Enabled = false;


            int r = dgvEmployee.CurrentCell.RowIndex;
            // Chuyển thông tin lên panel
            this.txtEmployeeID.Text =
            dgvEmployee.Rows[r].Cells[1].Value.ToString();
            this.txtEmployeeNAME.Text =
            dgvEmployee.Rows[r].Cells[2].Value.ToString();
            this.txtEmployeeADDRESS.Text =
            dgvEmployee.Rows[r].Cells[3].Value.ToString();
            this.txtEmployeePHONENUM.Text =
            dgvEmployee.Rows[r].Cells[4].Value.ToString();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (txtEmployeeID.Text == string.Empty || txtEmployeeADDRESS.Text == string.Empty ||
                txtEmployeeNAME.Text == string.Empty || txtEmployeePHONENUM.Text == string.Empty)
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
            }
            else if (add)
            {
                try
                {
                }
                catch
                {
                    MessageBox.Show("Mã sách này đã tồn tại");
                    txtEmployeeID.Focus();
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
            Reset();

            //đóng enabled
            this.txtEmployeeNAME.Enabled = false;
            this.txtEmployeeADDRESS.Enabled = false;
            this.txtEmployeePHONENUM.Enabled = false;


            // Cho thao tác trên các nút Lưu / Hủy / Panel
            this.btnLuu.Enabled = false;
            this.btnHuy.Enabled = false;

            // Không cho thao tác trên các nút Thêm / Xóa / Thoát
            this.btnThem.Enabled = true;
            this.btnSua.Enabled = true;
            this.btnXoa.Enabled = true;
            this.btnThoat.Enabled = true;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            frmMain frm = new frmMain();
            frm.Show();
            this.Hide();
        }

        private void frmEmployee_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmMain frm = new frmMain();
            frm.Show();
            this.Hide();
        }
    }
}
