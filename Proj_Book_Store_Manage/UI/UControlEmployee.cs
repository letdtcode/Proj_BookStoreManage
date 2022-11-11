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
    public partial class UControlEmployee : UserControl
    {
        private List<Control> controls = null;
        private DataTable dtEmployee = null;
        private Utilities utl = null;

        private string err = "";
        private DialogResult result;

        //false là chế độ sửa, true là chế độ thêm
        private bool isAdd = false;
        private bool isEdit = false;
        EmployeeBL employee = new EmployeeBL();
        public UControlEmployee()
        {
            InitializeComponent();
            dtpBirth.Format = DateTimePickerFormat.Custom;
            dtpBirth.CustomFormat = "dd-MM-yyyy";
            LoadData();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            this.lblIDEmployee.Text = utl.createID("NV");
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
                        if (employee.deleteEmployee(utl.IDCurrent, ref err) == true)
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
                    employee = new EmployeeBL();
                    try
                    {
                        lblIDEmployee.Text = utl.createID("NV");
                        employee.addNewEmployee(this.lblIDEmployee.Text, this.txtFirstName.Text, this.txtMiddleName.Text, this.txtLastName.Text, this.cbSex.Text.ToString(), this.txtAddress.Text, this.txtPhoneNumber.Text, this.txtEmail.Text,  this.dtpBirth.Value.Date, ref err);
                        if (err == "")
                        {
                            MessageBox.Show("Thêm thông tin nhân viên thành công !");
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
                    employee.modifyEmployee(this.lblIDEmployee.Text, this.txtFirstName.Text, this.txtMiddleName.Text, this.txtLastName.Text, this.cbSex.Text.ToString(), this.txtAddress.Text, this.txtPhoneNumber.Text, this.txtEmail.Text, this.dtpBirth.Value.Date, ref err);
                    //LoadData();
                    if (err == "")
                    {
                        MessageBox.Show("Sửa thông tin loại khách hàng thành công !");
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
        private void LoadData()
        {
            lblIDEmployee.Text = "None";
            controls = new List<Control> { txtFirstName, txtMiddleName, txtLastName, cbSex, txtAddress, txtPhoneNumber, txtEmail, dtpBirth };
            dtEmployee = employee.getDataEmployee();
            dgvEmployee.DataSource = dtEmployee;
            utl = new Utilities(controls, dgvEmployee);
            dgvEmployee.AutoResizeColumns();
            utl.SetEnableButton(new List<Button>() { btnSave, btnCancel }, false);
            utl.SetEnableButton(new List<Button>() { btnAdd, btnEdit, btnDelete, btnReload }, true);
            utl.setEnableControl(false);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {

        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void dgvEmployee_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            utl.CellClick(btnCancel, btnDelete);
            lblIDEmployee.Text = utl.IDCurrent;
            txtFirstName.Text = dgvEmployee.Rows[utl.rowCurrent].Cells[1].Value.ToString();
            txtMiddleName.Text = dgvEmployee.Rows[utl.rowCurrent].Cells[2].Value.ToString();
            txtLastName.Text = dgvEmployee.Rows[utl.rowCurrent].Cells[3].Value.ToString();
            cbSex.SelectedItem = dgvEmployee.Rows[utl.rowCurrent].Cells[4].Value;
            txtAddress.Text = dgvEmployee.Rows[utl.rowCurrent].Cells[5].Value.ToString();
            txtPhoneNumber.Text = dgvEmployee.Rows[utl.rowCurrent].Cells[6].Value.ToString();
            txtEmail.Text = dgvEmployee.Rows[utl.rowCurrent].Cells[7].Value.ToString();
            dtpBirth.Text = dgvEmployee.Rows[utl.rowCurrent].Cells[8].Value.ToString();
        }

        private void UControlEmployee_Load(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}
