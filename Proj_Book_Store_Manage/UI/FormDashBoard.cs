﻿using System;
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
    public partial class FormDashBoard : Form
    {
        public FormDashBoard()
        {
            InitializeComponent();
        }

        private void FormDashBoard_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void moveSidePanel(Control btn)
        {
            panelSide.Top = btn.Top;
            panelSide.Height = btn.Height;
        }

        private void btnBook_Click(object sender, EventArgs e)
        {
            moveSidePanel(btnBook);
            UControlBookOverview uc_BookOverView = new UControlBookOverview();
            uc_BookOverView.Dock = DockStyle.Fill;
            panelMain.Controls.Clear();
            panelMain.Controls.Add(uc_BookOverView);
        }

        private void btnAccount_Click(object sender, EventArgs e)
        {
            moveSidePanel(btnAccount);
            UControlAccount uc_Account = new UControlAccount();
            panelMain.Controls.Clear();
            panelMain.Controls.Add(uc_Account);
        }

        private void btnReceipt_Click(object sender, EventArgs e)
        {
            moveSidePanel(btnReceipt);
            UControlReceiptOverview uc_ReceiptOverview = new UControlReceiptOverview();
            panelMain.Controls.Clear();
            panelMain.Controls.Add(uc_ReceiptOverview);
        }

        private void btnCustomer_Click(object sender, EventArgs e)
        {
            moveSidePanel(btnCustomer);
            UControlCustomerOverview uc_CustomerOverview = new UControlCustomerOverview();
            panelMain.Controls.Clear();
            panelMain.Controls.Add(uc_CustomerOverview);
        }

        private void btnEmployee_Click(object sender, EventArgs e)
        {
            moveSidePanel(btnEmployee);
            UControlEmployee uc_Employee = new UControlEmployee();
            panelMain.Controls.Clear();
            panelMain.Controls.Add(uc_Employee);
        }

        private void btnVoucher_Click(object sender, EventArgs e)
        {
            moveSidePanel(btnVoucher);
            UControlVoucher uc_Voucher = new UControlVoucher();
            panelMain.Controls.Clear();
            panelMain.Controls.Add(uc_Voucher);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void ChangeEnterColor(object sender, EventArgs e)
        {
            Button tempButton = sender as Button;
            tempButton.BackColor = Color.White;
        }

        private void ChangeLeaveColor(object sender, EventArgs e)
        {
            Button tempButton = sender as Button;
            tempButton.BackColor = Color.SkyBlue;
        }
    }
}