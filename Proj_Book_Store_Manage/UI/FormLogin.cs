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
    }
}
