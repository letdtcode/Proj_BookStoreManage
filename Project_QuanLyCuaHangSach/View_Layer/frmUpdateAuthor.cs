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
    public partial class frmUpdateAuthor : Form
    {
        public frmUpdateAuthor()
        {
            InitializeComponent();
        }
       
        private void ResetTxt()
        {
            txtAuthorNAME.ResetText();
            txtAuthorID.ResetText();
            txtAuthorPHONENUM.ResetText();
        }
        private void frmUpdateAuthor_Load(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
           
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
           
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
           
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
        }

        private void frmUpdateAuthor_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmBook frm = new frmBook();
            frm.Show();
            this.Hide();
        }
    }
}
