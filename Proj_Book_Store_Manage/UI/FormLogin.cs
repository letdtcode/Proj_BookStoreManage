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
    public partial class frmLogin : Form
    {
        public static string idEmp { get; set; }
        public static string nameEmp { get; set; }
        public static string idRole { get; set; }
        LoginBL login;

        string err;
        public frmLogin()
        {
            InitializeComponent();
            this.txtUserName.Text = "Username";
            this.txtPassword.Text = "Password";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            using (FormSelectUsing frmSelectUsing = new FormSelectUsing())
            {
                try
                {
                    string user = txtUserName.Text.ToString().Trim();
                    string password = txtPassword.Text.ToString().Trim();
                    //Tạo kết nối với DB
                    login = new LoginBL(user, password);
                    //Lấy dữ liệu của nhân viên đổ vào DataTable
                    DataTable dt = login.login(user, password, ref err);
                    //Lấy thông tin từ dt
                    setInformationEmployee(dt);
                    frmSelectUsing.ShowDialog();
                    //using (FormDashBoard frmDashBoard = new FormDashBoard())
                    //{
                    //    frmDashBoard.ShowDialog();
                    //}
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        void setInformationEmployee (DataTable dt)
        {
            idEmp = dt.Rows[0][0].ToString();
            nameEmp = dt.Rows[0][1].ToString();
            if (dt.Rows[0][2].ToString() == "False")
                idRole = "Nhân Viên";
            else
                idRole = "Quản Lý";
        }    

        private void ptbPassInvisible_Click(object sender, EventArgs e)
        {
            if (this.ptbPassInvisible.Visible == false)
            {
                this.ptbPassVisible.Visible = false;
                this.ptbPassInvisible.Visible = true;
                this.txtPassword.PasswordChar = '\0';
            }
            else
            {
                this.ptbPassVisible.Visible = true;
                this.ptbPassInvisible.Visible = false;
                this.txtPassword.PasswordChar = '✽';
            }
        }

        private void ptbPassVisible_Click(object sender, EventArgs e)
        {
            
            if (this.ptbPassVisible.Visible == true)
            {
                this.ptbPassVisible.Visible = false;
                this.ptbPassInvisible.Visible = true;
                this.txtPassword.PasswordChar = '\0';
            }
            else
            {
                this.ptbPassVisible.Visible = true;
                this.ptbPassInvisible.Visible = false;
                this.txtPassword.PasswordChar = '✽';
            }
        }

        private void txtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            //this.txtPassword.PasswordChar = '✽';
            ptbPassVisible_Click(sender, e);
            ptbPassInvisible_Click(sender, e);
        }

        private void txtUserName_Click(object sender, EventArgs e)
        {

            if (txtUserName.Text == "Username")
                this.txtUserName.ResetText();
        }

        private void txtPassword_Click(object sender, EventArgs e)
        {
            if (txtPassword.Text == "Password")
                this.txtPassword.ResetText();
        }

        private void txtUserName_Enter(object sender, EventArgs e)
        {
            if (txtUserName.Text == "Username")
                this.txtUserName.ResetText();
        }

        private void txtPassword_Enter(object sender, EventArgs e)
        {
            if (txtPassword.Text == "Password")
                this.txtPassword.ResetText();
        }

        private void txtPassword_Leave(object sender, EventArgs e)
        {
            if (txtPassword.Text == "")
                this.txtPassword.Text = "Password";
        }

        private void txtUserName_Leave(object sender, EventArgs e)
        {
            if (txtUserName.Text == "")
            {
                this.txtUserName.Text = "Username";
            }
        }

        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnLogin_Click (sender, e);
            }    
        }
    }
}
