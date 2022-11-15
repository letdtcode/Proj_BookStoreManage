namespace Proj_Book_Store_Manage.UI
{
    partial class UControlReceiptExport
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnDetailExportReceipt = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.lblSearchBy = new System.Windows.Forms.Label();
            this.gpSearch = new System.Windows.Forms.GroupBox();
            this.cbAttributeSearch = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnReload = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.dgvReceiptExport = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.gbReceiptExport = new System.Windows.Forms.GroupBox();
            this.lblDateBill = new System.Windows.Forms.Label();
            this.lblIdCustomer = new System.Windows.Forms.Label();
            this.lblIDEmployee = new System.Windows.Forms.Label();
            this.lblCustomer = new System.Windows.Forms.Label();
            this.lblEmployee = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblIdVoucher = new System.Windows.Forms.Label();
            this.gpSearch.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReceiptExport)).BeginInit();
            this.panel1.SuspendLayout();
            this.gbReceiptExport.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnDetailExportReceipt
            // 
            this.btnDetailExportReceipt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnDetailExportReceipt.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDetailExportReceipt.Location = new System.Drawing.Point(938, 54);
            this.btnDetailExportReceipt.Name = "btnDetailExportReceipt";
            this.btnDetailExportReceipt.Size = new System.Drawing.Size(110, 93);
            this.btnDetailExportReceipt.TabIndex = 9;
            this.btnDetailExportReceipt.Text = "Chi tiết hóa đơn";
            this.btnDetailExportReceipt.UseVisualStyleBackColor = false;
            this.btnDetailExportReceipt.Click += new System.EventHandler(this.btnDetailExportReceipt_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(54, 67);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(224, 22);
            this.txtSearch.TabIndex = 2;
            // 
            // lblSearchBy
            // 
            this.lblSearchBy.AutoSize = true;
            this.lblSearchBy.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearchBy.Location = new System.Drawing.Point(16, 27);
            this.lblSearchBy.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSearchBy.Name = "lblSearchBy";
            this.lblSearchBy.Size = new System.Drawing.Size(106, 23);
            this.lblSearchBy.TabIndex = 0;
            this.lblSearchBy.Text = "Thuộc tính";
            // 
            // gpSearch
            // 
            this.gpSearch.Controls.Add(this.txtSearch);
            this.gpSearch.Controls.Add(this.cbAttributeSearch);
            this.gpSearch.Controls.Add(this.lblSearchBy);
            this.gpSearch.Location = new System.Drawing.Point(605, 33);
            this.gpSearch.Name = "gpSearch";
            this.gpSearch.Size = new System.Drawing.Size(298, 130);
            this.gpSearch.TabIndex = 1;
            this.gpSearch.TabStop = false;
            this.gpSearch.Text = "Tìm kiếm";
            // 
            // cbAttributeSearch
            // 
            this.cbAttributeSearch.FormattingEnabled = true;
            this.cbAttributeSearch.Location = new System.Drawing.Point(157, 26);
            this.cbAttributeSearch.Name = "cbAttributeSearch";
            this.cbAttributeSearch.Size = new System.Drawing.Size(121, 24);
            this.cbAttributeSearch.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnReload);
            this.panel2.Controls.Add(this.btnAdd);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(903, 198);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(169, 370);
            this.panel2.TabIndex = 10;
            // 
            // btnReload
            // 
            this.btnReload.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReload.Location = new System.Drawing.Point(35, 101);
            this.btnReload.Name = "btnReload";
            this.btnReload.Size = new System.Drawing.Size(110, 43);
            this.btnReload.TabIndex = 1;
            this.btnReload.Text = "Tải lại";
            this.btnReload.UseVisualStyleBackColor = true;
            this.btnReload.Click += new System.EventHandler(this.btnReload_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(35, 16);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(110, 43);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(236, 32);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(161, 23);
            this.label10.TabIndex = 0;
            this.label10.Text = "Ngày Bán Sách";
            // 
            // dgvReceiptExport
            // 
            this.dgvReceiptExport.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgvReceiptExport.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgvReceiptExport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReceiptExport.Location = new System.Drawing.Point(42, 240);
            this.dgvReceiptExport.Name = "dgvReceiptExport";
            this.dgvReceiptExport.ReadOnly = true;
            this.dgvReceiptExport.RowHeadersWidth = 51;
            this.dgvReceiptExport.RowTemplate.Height = 24;
            this.dgvReceiptExport.Size = new System.Drawing.Size(721, 280);
            this.dgvReceiptExport.TabIndex = 11;
            this.dgvReceiptExport.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvReceiptExport_CellClick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnDetailExportReceipt);
            this.panel1.Controls.Add(this.gpSearch);
            this.panel1.Controls.Add(this.gbReceiptExport);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1072, 198);
            this.panel1.TabIndex = 9;
            // 
            // gbReceiptExport
            // 
            this.gbReceiptExport.Controls.Add(this.lblIdVoucher);
            this.gbReceiptExport.Controls.Add(this.label2);
            this.gbReceiptExport.Controls.Add(this.lblDateBill);
            this.gbReceiptExport.Controls.Add(this.lblIdCustomer);
            this.gbReceiptExport.Controls.Add(this.lblIDEmployee);
            this.gbReceiptExport.Controls.Add(this.lblCustomer);
            this.gbReceiptExport.Controls.Add(this.lblEmployee);
            this.gbReceiptExport.Controls.Add(this.lblID);
            this.gbReceiptExport.Controls.Add(this.lblTotal);
            this.gbReceiptExport.Controls.Add(this.label1);
            this.gbReceiptExport.Controls.Add(this.lbl1);
            this.gbReceiptExport.Controls.Add(this.label10);
            this.gbReceiptExport.Location = new System.Drawing.Point(16, 16);
            this.gbReceiptExport.Margin = new System.Windows.Forms.Padding(4);
            this.gbReceiptExport.Name = "gbReceiptExport";
            this.gbReceiptExport.Padding = new System.Windows.Forms.Padding(4);
            this.gbReceiptExport.Size = new System.Drawing.Size(582, 171);
            this.gbReceiptExport.TabIndex = 0;
            this.gbReceiptExport.TabStop = false;
            this.gbReceiptExport.Text = "Thông tin bán sách";
            // 
            // lblDateBill
            // 
            this.lblDateBill.AutoSize = true;
            this.lblDateBill.Location = new System.Drawing.Point(425, 38);
            this.lblDateBill.Name = "lblDateBill";
            this.lblDateBill.Size = new System.Drawing.Size(46, 17);
            this.lblDateBill.TabIndex = 6;
            this.lblDateBill.Text = "label2";
            // 
            // lblIdCustomer
            // 
            this.lblIdCustomer.AutoSize = true;
            this.lblIdCustomer.Location = new System.Drawing.Point(415, 89);
            this.lblIdCustomer.Name = "lblIdCustomer";
            this.lblIdCustomer.Size = new System.Drawing.Size(42, 17);
            this.lblIdCustomer.TabIndex = 5;
            this.lblIdCustomer.Text = "None";
            // 
            // lblIDEmployee
            // 
            this.lblIDEmployee.AutoSize = true;
            this.lblIDEmployee.Location = new System.Drawing.Point(164, 83);
            this.lblIDEmployee.Name = "lblIDEmployee";
            this.lblIDEmployee.Size = new System.Drawing.Size(42, 17);
            this.lblIDEmployee.TabIndex = 4;
            this.lblIDEmployee.Text = "None";
            // 
            // lblCustomer
            // 
            this.lblCustomer.AutoSize = true;
            this.lblCustomer.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomer.Location = new System.Drawing.Point(236, 83);
            this.lblCustomer.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCustomer.Name = "lblCustomer";
            this.lblCustomer.Size = new System.Drawing.Size(169, 23);
            this.lblCustomer.TabIndex = 1;
            this.lblCustomer.Text = "Mã Khách Hàng";
            // 
            // lblEmployee
            // 
            this.lblEmployee.AutoSize = true;
            this.lblEmployee.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmployee.Location = new System.Drawing.Point(8, 83);
            this.lblEmployee.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEmployee.Name = "lblEmployee";
            this.lblEmployee.Size = new System.Drawing.Size(149, 23);
            this.lblEmployee.TabIndex = 1;
            this.lblEmployee.Text = "Mã Nhân Viên";
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblID.Location = new System.Drawing.Point(92, 32);
            this.lblID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(21, 23);
            this.lblID.TabIndex = 0;
            this.lblID.Text = "0";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(344, 135);
            this.lblTotal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(21, 23);
            this.lblTotal.TabIndex = 0;
            this.lblTotal.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(236, 135);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tổng tiền: ";
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1.Location = new System.Drawing.Point(8, 32);
            this.lbl1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(65, 23);
            this.lbl1.TabIndex = 0;
            this.lbl1.Text = "ID Bill:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Voucher";
            // 
            // lblIdVoucher
            // 
            this.lblIdVoucher.AutoSize = true;
            this.lblIdVoucher.Location = new System.Drawing.Point(96, 135);
            this.lblIdVoucher.Name = "lblIdVoucher";
            this.lblIdVoucher.Size = new System.Drawing.Size(42, 17);
            this.lblIdVoucher.TabIndex = 8;
            this.lblIdVoucher.Text = "None";
            // 
            // UControlReceiptExport
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.dgvReceiptExport);
            this.Controls.Add(this.panel1);
            this.Name = "UControlReceiptExport";
            this.Size = new System.Drawing.Size(1072, 568);
            this.Load += new System.EventHandler(this.UControlReceiptExport_Load);
            this.gpSearch.ResumeLayout(false);
            this.gpSearch.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvReceiptExport)).EndInit();
            this.panel1.ResumeLayout(false);
            this.gbReceiptExport.ResumeLayout(false);
            this.gbReceiptExport.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnDetailExportReceipt;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label lblSearchBy;
        private System.Windows.Forms.GroupBox gpSearch;
        private System.Windows.Forms.ComboBox cbAttributeSearch;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnReload;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridView dgvReceiptExport;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox gbReceiptExport;
        private System.Windows.Forms.Label lblCustomer;
        private System.Windows.Forms.Label lblEmployee;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label lblIdCustomer;
        private System.Windows.Forms.Label lblIDEmployee;
        private System.Windows.Forms.Label lblDateBill;
        private System.Windows.Forms.Label lblIdVoucher;
        private System.Windows.Forms.Label label2;
    }
}
