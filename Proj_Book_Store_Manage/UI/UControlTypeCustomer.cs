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
    public partial class UControlTypeCustomer : UserControl
    {
        private List<Control> controls = null;
        private DataTable dtTypeCustomer = null;
        private Utilities utl = null;
        //private int IDAccount;
        private string err = "";
        private DialogResult result;

        //false là chế độ sửa, true là chế độ thêm
        private bool isAdd = false;
        private bool isEdit = false;
        TypeCustomerBL typecustomer = new TypeCustomerBL();
        public UControlTypeCustomer()
        {
            InitializeComponent();
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
                        if (typecustomer.deleteTypeCustomer(utl.IDCurrent, ref err) == true)
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
                    typecustomer = new TypeCustomerBL();
                    try
                    {
                        typecustomer.addNewTypeCustomer(this.txtTypeCustomer.Text, int.Parse(this.txtPointMark.Text), int.Parse(this.txtValue.Text), ref err);
                        if (err == "")
                        {
                            MessageBox.Show("Thêm thông tin khách hàng thành công !");
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
                    typecustomer.modifyTypeCustomer(utl.IDCurrent, this.txtTypeCustomer.Text, int.Parse(this.txtPointMark.Text), int.Parse(this.txtValue.Text), ref err);
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
            lblID.Text = "None";
            controls = new List<Control> { txtTypeCustomer, txtValue, txtPointMark };
            dtTypeCustomer = typecustomer.getDataTypeCustomer();
            dgvTypeCustomer.DataSource = dtTypeCustomer;
            utl = new Utilities(controls, dgvTypeCustomer);
            dgvTypeCustomer.AutoResizeColumns();
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

        private void UControlTypeCustomer_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void dgvTypeCustomer_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            utl.CellClick(btnCancel, btnDelete);
            lblID.Text = dgvTypeCustomer.Rows[utl.rowCurrent].Cells[0].Value.ToString();
            txtTypeCustomer.Text = dgvTypeCustomer.Rows[utl.rowCurrent].Cells[1].Value.ToString();
            txtPointMark.Text = dgvTypeCustomer.Rows[utl.rowCurrent].Cells[2].Value.ToString();
            txtValue.Text = dgvTypeCustomer.Rows[utl.rowCurrent].Cells[3].Value.ToString();
        }

    }
}
