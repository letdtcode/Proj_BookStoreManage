﻿
namespace Proj_Book_Store_Manage.UI
{
    partial class FormDetailReceiptExport
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblID = new System.Windows.Forms.Label();
            this.lblAmount = new System.Windows.Forms.Label();
            this.gbDetailReceiptExport = new System.Windows.Forms.GroupBox();
            this.lblCustomer = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblIDReceipt = new System.Windows.Forms.Label();
            this.lblMoney = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblNameCustomer = new System.Windows.Forms.Label();
            this.lblNameEmployee = new System.Windows.Forms.Label();
            this.txtAmountBook = new System.Windows.Forms.TextBox();
            this.lblBook = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.dgvListBook = new System.Windows.Forms.DataGridView();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnExit = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblIDBook = new System.Windows.Forms.Label();
            this.lblNameBook = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvCart = new System.Windows.Forms.DataGridView();
            this.idBook = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameBook = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amountColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.editColumn = new System.Windows.Forms.DataGridViewButtonColumn();
            this.deleteColumn = new System.Windows.Forms.DataGridViewButtonColumn();
            this.lblAnnounce = new System.Windows.Forms.Label();
            this.gbDetailReceiptExport.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListBook)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCart)).BeginInit();
            this.SuspendLayout();
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblID.Location = new System.Drawing.Point(4, 30);
            this.lblID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(121, 22);
            this.lblID.TabIndex = 5;
            this.lblID.Text = "Mã hóa đơn";
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAmount.Location = new System.Drawing.Point(15, 97);
            this.lblAmount.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(85, 22);
            this.lblAmount.TabIndex = 5;
            this.lblAmount.Text = "Số Lượng";
            // 
            // gbDetailReceiptExport
            // 
            this.gbDetailReceiptExport.Controls.Add(this.lblID);
            this.gbDetailReceiptExport.Controls.Add(this.lblCustomer);
            this.gbDetailReceiptExport.Controls.Add(this.lblName);
            this.gbDetailReceiptExport.Controls.Add(this.lblIDReceipt);
            this.gbDetailReceiptExport.Controls.Add(this.lblMoney);
            this.gbDetailReceiptExport.Controls.Add(this.lblTotal);
            this.gbDetailReceiptExport.Controls.Add(this.lblNameCustomer);
            this.gbDetailReceiptExport.Controls.Add(this.lblNameEmployee);
            this.gbDetailReceiptExport.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbDetailReceiptExport.Location = new System.Drawing.Point(35, 72);
            this.gbDetailReceiptExport.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gbDetailReceiptExport.Name = "gbDetailReceiptExport";
            this.gbDetailReceiptExport.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gbDetailReceiptExport.Size = new System.Drawing.Size(542, 136);
            this.gbDetailReceiptExport.TabIndex = 27;
            this.gbDetailReceiptExport.TabStop = false;
            this.gbDetailReceiptExport.Text = "Thông tin đơn hàng";
            // 
            // lblCustomer
            // 
            this.lblCustomer.AutoSize = true;
            this.lblCustomer.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomer.Location = new System.Drawing.Point(208, 93);
            this.lblCustomer.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCustomer.Name = "lblCustomer";
            this.lblCustomer.Size = new System.Drawing.Size(126, 22);
            this.lblCustomer.TabIndex = 5;
            this.lblCustomer.Text = "Khách Hàng";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(208, 30);
            this.lblName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(108, 22);
            this.lblName.TabIndex = 5;
            this.lblName.Text = "Nhân Viên";
            // 
            // lblIDReceipt
            // 
            this.lblIDReceipt.AutoSize = true;
            this.lblIDReceipt.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIDReceipt.Location = new System.Drawing.Point(133, 30);
            this.lblIDReceipt.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblIDReceipt.Name = "lblIDReceipt";
            this.lblIDReceipt.Size = new System.Drawing.Size(21, 22);
            this.lblIDReceipt.TabIndex = 6;
            this.lblIDReceipt.Text = "0";
            // 
            // lblMoney
            // 
            this.lblMoney.AutoSize = true;
            this.lblMoney.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMoney.Location = new System.Drawing.Point(4, 94);
            this.lblMoney.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMoney.Name = "lblMoney";
            this.lblMoney.Size = new System.Drawing.Size(88, 22);
            this.lblMoney.TabIndex = 5;
            this.lblMoney.Text = "Tổng tiền";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(104, 94);
            this.lblTotal.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(21, 22);
            this.lblTotal.TabIndex = 5;
            this.lblTotal.Text = "0";
            // 
            // lblNameCustomer
            // 
            this.lblNameCustomer.AutoSize = true;
            this.lblNameCustomer.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNameCustomer.Location = new System.Drawing.Point(337, 93);
            this.lblNameCustomer.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNameCustomer.Name = "lblNameCustomer";
            this.lblNameCustomer.Size = new System.Drawing.Size(184, 22);
            this.lblNameCustomer.TabIndex = 6;
            this.lblNameCustomer.Text = "Nguyễn Đức Thành";
            // 
            // lblNameEmployee
            // 
            this.lblNameEmployee.AutoSize = true;
            this.lblNameEmployee.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNameEmployee.Location = new System.Drawing.Point(336, 30);
            this.lblNameEmployee.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNameEmployee.Name = "lblNameEmployee";
            this.lblNameEmployee.Size = new System.Drawing.Size(184, 22);
            this.lblNameEmployee.TabIndex = 6;
            this.lblNameEmployee.Text = "Nguyễn Đức Thành";
            // 
            // txtAmountBook
            // 
            this.txtAmountBook.Location = new System.Drawing.Point(118, 99);
            this.txtAmountBook.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtAmountBook.Name = "txtAmountBook";
            this.txtAmountBook.Size = new System.Drawing.Size(140, 20);
            this.txtAmountBook.TabIndex = 7;
            // 
            // lblBook
            // 
            this.lblBook.AutoSize = true;
            this.lblBook.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBook.Location = new System.Drawing.Point(15, 54);
            this.lblBook.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBook.Name = "lblBook";
            this.lblBook.Size = new System.Drawing.Size(93, 22);
            this.lblBook.TabIndex = 5;
            this.lblBook.Text = "Tên Sách";
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(64, 245);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(91, 43);
            this.btnAdd.TabIndex = 22;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(187, 245);
            this.btnSave.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(112, 43);
            this.btnSave.TabIndex = 26;
            this.btnSave.Text = "Cập nhật";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // dgvListBook
            // 
            this.dgvListBook.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListBook.Location = new System.Drawing.Point(28, 318);
            this.dgvListBook.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvListBook.Name = "dgvListBook";
            this.dgvListBook.RowHeadersWidth = 51;
            this.dgvListBook.RowTemplate.Height = 24;
            this.dgvListBook.Size = new System.Drawing.Size(547, 247);
            this.dgvListBook.TabIndex = 20;
            this.dgvListBook.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvListBook_CellClick);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Teal;
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(972, 8);
            this.panel4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(8, 578);
            this.panel4.TabIndex = 19;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Teal;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(8, 586);
            this.panel3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(972, 8);
            this.panel3.TabIndex = 18;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Teal;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 8);
            this.panel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(8, 586);
            this.panel2.TabIndex = 17;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Teal;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(980, 8);
            this.panel1.TabIndex = 16;
            // 
            // btnExit
            // 
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Century Gothic", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.Teal;
            this.btnExit.Location = new System.Drawing.Point(922, 8);
            this.btnExit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(50, 39);
            this.btnExit.TabIndex = 28;
            this.btnExit.Text = "X";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblIDBook);
            this.groupBox1.Controls.Add(this.lblNameBook);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.lblBook);
            this.groupBox1.Controls.Add(this.txtAmountBook);
            this.groupBox1.Controls.Add(this.lblAmount);
            this.groupBox1.Location = new System.Drawing.Point(662, 72);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(284, 136);
            this.groupBox1.TabIndex = 30;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin sản phẩm";
            // 
            // lblIDBook
            // 
            this.lblIDBook.AutoSize = true;
            this.lblIDBook.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIDBook.Location = new System.Drawing.Point(121, 19);
            this.lblIDBook.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblIDBook.Name = "lblIDBook";
            this.lblIDBook.Size = new System.Drawing.Size(60, 22);
            this.lblIDBook.TabIndex = 8;
            this.lblIDBook.Text = "None";
            // 
            // lblNameBook
            // 
            this.lblNameBook.AutoSize = true;
            this.lblNameBook.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNameBook.Location = new System.Drawing.Point(121, 53);
            this.lblNameBook.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNameBook.Name = "lblNameBook";
            this.lblNameBook.Size = new System.Drawing.Size(60, 22);
            this.lblNameBook.TabIndex = 8;
            this.lblNameBook.Text = "None";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 19);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 22);
            this.label1.TabIndex = 5;
            this.label1.Text = "Mã Sách";
            // 
            // dgvCart
            // 
            this.dgvCart.AllowUserToAddRows = false;
            this.dgvCart.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCart.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idBook,
            this.nameBook,
            this.amountColumn,
            this.editColumn,
            this.deleteColumn});
            this.dgvCart.Location = new System.Drawing.Point(618, 318);
            this.dgvCart.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvCart.Name = "dgvCart";
            this.dgvCart.RowHeadersWidth = 51;
            this.dgvCart.RowTemplate.Height = 24;
            this.dgvCart.Size = new System.Drawing.Size(337, 247);
            this.dgvCart.TabIndex = 31;
            this.dgvCart.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCart_CellContentClick);
            // 
            // idBook
            // 
            this.idBook.HeaderText = "ID";
            this.idBook.MinimumWidth = 6;
            this.idBook.Name = "idBook";
            this.idBook.Width = 125;
            // 
            // nameBook
            // 
            this.nameBook.HeaderText = "Tên Sách";
            this.nameBook.MinimumWidth = 6;
            this.nameBook.Name = "nameBook";
            this.nameBook.Width = 125;
            // 
            // amountColumn
            // 
            this.amountColumn.HeaderText = "Số Lượng";
            this.amountColumn.MinimumWidth = 6;
            this.amountColumn.Name = "amountColumn";
            this.amountColumn.Width = 125;
            // 
            // editColumn
            // 
            this.editColumn.HeaderText = "Edit";
            this.editColumn.MinimumWidth = 6;
            this.editColumn.Name = "editColumn";
            this.editColumn.Width = 125;
            // 
            // deleteColumn
            // 
            this.deleteColumn.HeaderText = "Delete";
            this.deleteColumn.MinimumWidth = 6;
            this.deleteColumn.Name = "deleteColumn";
            this.deleteColumn.Width = 125;
            // 
            // lblAnnounce
            // 
            this.lblAnnounce.AutoSize = true;
            this.lblAnnounce.Font = new System.Drawing.Font("Century Gothic", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnnounce.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.lblAnnounce.Location = new System.Drawing.Point(365, 24);
            this.lblAnnounce.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAnnounce.Name = "lblAnnounce";
            this.lblAnnounce.Size = new System.Drawing.Size(293, 32);
            this.lblAnnounce.TabIndex = 15;
            this.lblAnnounce.Text = "Chi Tiết Hóa Đơn Xuất";
            // 
            // FormDetailReceiptExport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(980, 594);
            this.Controls.Add(this.dgvCart);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.gbDetailReceiptExport);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.dgvListBook);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblAnnounce);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FormDetailReceiptExport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FormDetailReceiptExport";
            this.Load += new System.EventHandler(this.FormDetailReceiptExport_Load);
            this.gbDetailReceiptExport.ResumeLayout(false);
            this.gbDetailReceiptExport.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListBook)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.GroupBox gbDetailReceiptExport;
        private System.Windows.Forms.TextBox txtAmountBook;
        private System.Windows.Forms.Label lblBook;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblIDReceipt;
        private System.Windows.Forms.Label lblNameEmployee;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.DataGridView dgvListBook;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblCustomer;
        private System.Windows.Forms.Label lblNameCustomer;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblMoney;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblNameBook;
        private System.Windows.Forms.Label lblIDBook;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvCart;
        private System.Windows.Forms.DataGridViewTextBoxColumn idBook;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameBook;
        private System.Windows.Forms.DataGridViewTextBoxColumn amountColumn;
        private System.Windows.Forms.DataGridViewButtonColumn editColumn;
        private System.Windows.Forms.DataGridViewButtonColumn deleteColumn;
        private System.Windows.Forms.Label lblAnnounce;
    }
}