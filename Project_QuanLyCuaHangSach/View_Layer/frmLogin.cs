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
    public partial class frmLogin : Form
    {
        static public string roles { get; set; }
        public frmLogin()
        {
            InitializeComponent();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtID.Text == "admin" && txtPassword.Text == "admin")
            {
                MessageBox.Show("Đăng nhập thành công!!!!", "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                frmMain frm = new frmMain();
                frm.Show();
                this.Hide();
            }
        }

        private void lblDangKi_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmSignUp frm = new frmSignUp();
            frm.Show();
            this.Hide();
        }

        private void frmLogin_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
