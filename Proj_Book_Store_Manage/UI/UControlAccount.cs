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
    public partial class UControlAccount : UserControl
    {
        private List<Control> controls = null;
        private DataTable dtAccount = null;
        private Utilities utl = null;
        //private int IDAccount;
        private string err="";
        private DialogResult result;

        //false là chế độ sửa, true là chế độ thêm
        private bool isAdd = false;
        private bool isEdit = false;
        AccountBL account = new AccountBL();
        private bool roleTemp;
        public UControlAccount()
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
                if(utl.CheckIDValid is true)
                {
                    result = MessageBox.Show("Bạn có chắc chắn muốn xóa không ?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        if (account.deleteAccount(utl.IDCurrent, ref err) == true)
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
                if (cbTypeAcc.Text == "Admin")
                    roleTemp = true;
                else
                    roleTemp = false;
                if (utl.checkAllControlIsFill() == false)
                {
                    result = MessageBox.Show("Vui lòng nhập đầy đủ thông tin !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    isAdd = false;
                    isEdit = false;
                    return;
                }
                if (isAdd)
                {
                    account = new AccountBL();
                    try
                    {
                        account.addNewAccount(this.txtUserName.Text, this.txtPassword.Text, roleTemp, int.Parse(this.cbEmployee.SelectedItem.ToString()), ref err);
                        if (err == "")
                        {
                            MessageBox.Show("Thêm tài khoản thành công !");
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
                    account.modifyAccount(utl.IDCurrent, this.txtUserName.Text, this.txtPassword.Text, roleTemp, int.Parse(this.cbEmployee.SelectedItem.ToString()), ref err);
                    //LoadData();
                    if (err == "")
                    {
                        MessageBox.Show("Sửa tài khoản thành công !");
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
        private void btnReload_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {

        }
        private void LoadData()
        {
            controls = new List<Control> { txtUserName, txtPassword, cbTypeAcc, cbEmployee };
            dtAccount = account.getDataAccount();
            dgvAuthor.DataSource = dtAccount;
            utl = new Utilities(controls, dgvAuthor);
            dgvAuthor.AutoResizeColumns();
            utl.SetEnableButton(new List<Button>() { btnSave,btnCancel },false);
            utl.SetEnableButton(new List<Button>() { btnAdd, btnEdit, btnDelete, btnReload }, true);
            utl.setEnableControl(false);
        }

        private void UControlAccount_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void dgvAuthor_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            utl.CellClick(btnCancel,btnDelete);
            txtUserName.Text = dgvAuthor.Rows[utl.rowCurrent].Cells[1].Value.ToString();
            txtPassword.Text = dgvAuthor.Rows[utl.rowCurrent].Cells[2].Value.ToString();
            cbTypeAcc.Text = dgvAuthor.Rows[utl.rowCurrent].Cells[3].Value.ToString();
            cbEmployee.Text = dgvAuthor.Rows[utl.rowCurrent].Cells[4].Value.ToString();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

        }

        private void btnShowResult_Click(object sender, EventArgs e)
        {
            /*if (cbTypeAcc.Text == "Admin")
                roleTemp = true;
            else
                roleTemp = false;
            dgvAuthor.DataSource = account.searchAccount(int.Parse(txtIDAccount.Text), txtUserName.Text.ToString(), txtPassword.Text.ToString(), roleTemp, int.Parse(cbEmployee.Text), ref err);
            dgvAuthor.Show();*/
        }
    }
}
