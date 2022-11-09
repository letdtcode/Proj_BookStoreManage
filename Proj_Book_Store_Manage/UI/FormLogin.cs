using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Proj_Book_Store_Manage.UI;
using Proj_Book_Store_Manage.DBLayer;
namespace Proj_Book_Store_Manage
{
    public partial class frmLogin : Form
    {
        
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

            try
            {

                DBMain.UserName = this.txtUserName.Text.ToString().Trim();
                DBMain.Password = this.txtPassword.Text.ToString().Trim();
                DBMain dBMain = new DBMain();
                using (FormDashBoard frmDashBoard = new FormDashBoard())
                {
                    frmDashBoard.ShowDialog();
                }

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
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
            this.txtPassword.PasswordChar = '✽';
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
    }
}
