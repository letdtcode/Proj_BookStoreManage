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
    public partial class UControlReceiptOverview : UserControl
    {
        public UControlReceiptOverview()
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
            panelMainReceipt.Controls.Clear();
            panelMainReceipt.Controls.Add(c);
        }

        private void btnImport_Click(object sender, EventArgs e)
        {
            moveSidePanel(btnImport);
            UControlReceiptImport uc_ReceiptImport = new UControlReceiptImport();
            addUserControl(uc_ReceiptImport);
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            moveSidePanel(btnExport);
            UControlReceiptExport uc_ReceiptExport = new UControlReceiptExport();
            addUserControl(uc_ReceiptExport);
        }

        private void UControlReceiptOverview_Load(object sender, EventArgs e)
        {
            UControlReceiptImport uc_receiptImport = new UControlReceiptImport();
            panelMainReceipt.Controls.Clear();
            panelMainReceipt.Controls.Add(uc_receiptImport);
        }
    }
}
