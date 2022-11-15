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

        List<string> param;

        //false là chế độ sửa, true là chế độ thêm
        private bool isAdd = false;
        private bool isEdit = false;
        AccountBL account = new AccountBL();
        EmployeeBL employee = new EmployeeBL();
        private int roleTemp;
        public UControlAccount()
        {
            InitializeComponent();
            lblIDAcount.Enabled = false;
            LoadData();
            createAttributeComBoBox();


        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            this.lblID.Text = utl.createID("ACC");
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
                        int idAuthor = Convert.ToInt32(this.lblID.Text);
                        account.deleteAccount(idAuthor, ref err);
                        if (err == "")
                        {
                            MessageBox.Show("Xóa thành công !");
                        }
                        else
                            MessageBox.Show(err);
                        
                    }
                }             
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
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
                    roleTemp = 1;
                else
                    roleTemp = 0;
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
                        int idAuthor = Convert.ToInt32(this.lblID.Text);
                        int idEmp = Convert.ToInt32(this.cbEmployee.Text);

                        account.addNewAccount(idAuthor, this.txtUserName.Text, this.txtPassword.Text, roleTemp, idEmp, ref err);
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
                    int idAuthor = Convert.ToInt32(this.lblID.Text);
                    int idEmp = Convert.ToInt32(this.cbEmployee.Text);
                    account.modifyAccount(idAuthor, this.txtUserName.Text, this.txtPassword.Text, roleTemp, idEmp, ref err);
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
            LoadDataIntoCbEmp(employee.getAllIDEmployee());
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
            this.lblID.Text = utl.IDCurrent;
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
        private void LoadDataIntoCbEmp(List<string> idEmp)
        {
            cbEmployee.Items.Clear();
            foreach (string idCus in idEmp)
            {
                cbEmployee.Items.Add(idCus);
            }
        }

        private void btnSearch_Click_1(object sender, EventArgs e)
        {
            int id;
            string username;
            (id, username) = getParameter();

            try
            {
                account = new AccountBL();
                dtAccount= account.searchAccount(id, username, ref err);
                dgvAuthor.DataSource = dtAccount;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        void createAttributeComBoBox ()
        {
            param = new List<string>();
            param.Add("Id Account");
            param.Add("Name Account");
            this.cbAttribute.DataSource = param;
        }

        (int, string) getParameter ()
        {
            int id;
            string username;
            if (cbAttribute.Text == "Id Account")
            {
                id = Convert.ToInt32(this.txtInput.Text);
                username = null;
            }    

            else if (cbAttribute.Text == "Name Account")
            {
                id = 0;
                username = this.txtInput.Text.Trim(); ;
            }
            else
            {
                id = 0;
                username = null;
            }
            return (id, username);
        }
    }
}
