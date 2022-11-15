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
    public partial class UControlCustomerOverview : UserControl
    {
        public UControlCustomerOverview()
        {
            InitializeComponent();
        }
        private void moveSidePanel(Button btn)
        {
            panelSide.Top = btn.Bottom;
            panelSide.Left = btn.Left;
        }
        private void ChangeColorEnter(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            btn.BackColor = Color.Silver;
        }

        private void ChangeColorLeave(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            btn.BackColor = Color.Black;
        }
        private void addUserControl(Control c)
        {
            panelMainCustomer.Controls.Clear();
            panelMainCustomer.Controls.Add(c);
        }

        private void btnInfoCus_Click(object sender, EventArgs e)
        {
            moveSidePanel(btnInfoCus);
            UControlInfoCustomer uc_InfoCustomer = new UControlInfoCustomer();
            addUserControl(uc_InfoCustomer);
        }

        private void btnTypeCus_Click(object sender, EventArgs e)
        {
            moveSidePanel(btnTypeCus);
            UControlTypeCustomer uc_TypeCustomer = new UControlTypeCustomer();
            addUserControl(uc_TypeCustomer);
        }

        private void UControlCustomerOverview_Load(object sender, EventArgs e)
        {
            UControlInfoCustomer uc_infoCustomer = new UControlInfoCustomer();
            panelMainCustomer.Controls.Clear();
            panelMainCustomer.Controls.Add(uc_infoCustomer);
        }
    }
}
