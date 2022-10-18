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
    public partial class frmCustomerType : Form
    {
        public frmCustomerType()
        {
            InitializeComponent();
        }
        
        private void ResetTxt()
        {
            txtCustomerTypeID.ResetText();
            txtCustomerTyperNAME.ResetText();
            txtCustomerTypeDESCRIBE.ResetText();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
          
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
           
        }



        private void frmCustomerType_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmCustomer frm = new frmCustomer();
            frm.Show();
            this.Hide();
        }

        private void btnSearch_Click_1(object sender, EventArgs e)
        {
           
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
                ResetTxt();
        }
    }
}
