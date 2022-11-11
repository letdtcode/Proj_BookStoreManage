using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proj_Book_Store_Manage.UI
{
    public partial class FormSelectUsing : Form
    {
        public FormSelectUsing()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormDashBoard frmDashBoard = new FormDashBoard();
            frmDashBoard.FormClosed += Edit_Form;
            frmDashBoard.Show();
            
        }
        private void Edit_Form(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            /*FormSale frmSale = new FormSale();
            frmSale.Show();*/
        }
    }
}
