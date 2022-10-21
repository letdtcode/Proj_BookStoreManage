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
    public partial class frmUpdatePublisher : Form
    {
        bool insert, update, delete, search;
        public frmUpdatePublisher()
        {
            InitializeComponent();
        }
      

        private void ResetTxt()
        {
            txtPublisherID.ResetText();
            txtPublisherNAME.ResetText();
            txtPublisherADDRESS.ResetText();
            txtPHONENUM.ResetText();

            this.insert = false;
            this.update = false;
            this.delete = false;
            this.search = false;

        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
           
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            this.insert = true;
            this.btnFinish.Enabled = true;
            this.txtPublisherID.Enabled = false;
            
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
        }

        private void frmUpdatePublisher_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmBook frm = new frmBook();
            frm.Show();
            this.Hide();
        }

        private void frmUpdatePublisher_Load(object sender, EventArgs e)
        {

        }
    }
}
