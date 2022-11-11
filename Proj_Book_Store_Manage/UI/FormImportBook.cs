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
    public partial class FormImportBook : Form
    {
        public FormImportBook()
        {
            InitializeComponent();
            this.lbIdEmployee.Text = frmLogin.idEmp;
        }

        private void btnAddItem_Click(object sender, EventArgs e)
        {

        }
    }
}
