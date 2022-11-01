
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
            this.dtpReceiptImport = new System.Windows.Forms.DateTimePicker();
            this.lblSearchBy = new System.Windows.Forms.Label();
            this.gpSearch = new System.Windows.Forms.GroupBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnReload = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.lblDateExport = new System.Windows.Forms.Label();
            this.dgvReceiptExport = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnVoucher = new System.Windows.Forms.Button();
            this.gbReceiptExport = new System.Windows.Forms.GroupBox();
            this.lblCustomer = new System.Windows.Forms.Label();
            this.lblEmployee = new System.Windows.Forms.Label();
            this.txtNameEmp = new System.Windows.Forms.TextBox();
            this.txtNameCus = new System.Windows.Forms.TextBox();
            this.txtIdBill = new System.Windows.Forms.TextBox();
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
            this.btnDetailExportReceipt.Location = new System.Drawing.Point(917, 18);
            this.btnDetailExportReceipt.Name = "btnDetailExportReceipt";
            this.btnDetailExportReceipt.Size = new System.Drawing.Size(110, 93);
            this.btnDetailExportReceipt.TabIndex = 9;
            this.btnDetailExportReceipt.Text = "Chi tiết hóa đơn";
            this.btnDetailExportReceipt.UseVisualStyleBackColor = false;
            this.btnDetailExportReceipt.Click += new System.EventHandler(this.btnDetailExportReceipt_Click);
            // 
            // dtpReceiptImport
            // 
            this.dtpReceiptImport.Location = new System.Drawing.Point(203, 37);
            this.dtpReceiptImport.Name = "dtpReceiptImport";
            this.dtpReceiptImport.Size = new System.Drawing.Size(200, 20);
            this.dtpReceiptImport.TabIndex = 3;
            // 
            // lblSearchBy
            // 
            this.lblSearchBy.AutoSize = true;
            this.lblSearchBy.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearchBy.Location = new System.Drawing.Point(16, 27);
            this.lblSearchBy.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSearchBy.Name = "lblSearchBy";
            this.lblSearchBy.Size = new System.Drawing.Size(108, 21);
            this.lblSearchBy.TabIndex = 0;
            this.lblSearchBy.Text = "Mã Hóa Đơn";
            // 
            // gpSearch
            // 
            this.gpSearch.Controls.Add(this.txtIdBill);
            this.gpSearch.Controls.Add(this.lblSearchBy);
            this.gpSearch.Location = new System.Drawing.Point(532, 21);
            this.gpSearch.Name = "gpSearch";
            this.gpSearch.Size = new System.Drawing.Size(354, 171);
            this.gpSearch.TabIndex = 1;
            this.gpSearch.TabStop = false;
            this.gpSearch.Text = "Tìm kiếm";
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(35, 244);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(110, 43);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "Hủy";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnReload);
            this.panel2.Controls.Add(this.btnAdd);
            this.panel2.Controls.Add(this.btnDelete);
            this.panel2.Controls.Add(this.btnEdit);
            this.panel2.Controls.Add(this.btnSave);
            this.panel2.Controls.Add(this.btnCancel);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(917, 198);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(155, 360);
            this.panel2.TabIndex = 10;
            // 
            // btnReload
            // 
            this.btnReload.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReload.Location = new System.Drawing.Point(35, 301);
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
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(35, 130);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(110, 43);
            this.btnDelete.TabIndex = 1;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.Location = new System.Drawing.Point(35, 73);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(110, 43);
            this.btnEdit.TabIndex = 1;
            this.btnEdit.Text = "Sửa";
            this.btnEdit.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(35, 187);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(110, 43);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "Lưu";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // lblDateExport
            // 
            this.lblDateExport.AutoSize = true;
            this.lblDateExport.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateExport.Location = new System.Drawing.Point(8, 37);
            this.lblDateExport.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDateExport.Name = "lblDateExport";
            this.lblDateExport.Size = new System.Drawing.Size(129, 21);
            this.lblDateExport.TabIndex = 0;
            this.lblDateExport.Text = "Ngày Bán Sách";
            // 
            // dgvReceiptExport
            // 
            this.dgvReceiptExport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReceiptExport.Location = new System.Drawing.Point(42, 240);
            this.dgvReceiptExport.Name = "dgvReceiptExport";
            this.dgvReceiptExport.RowHeadersWidth = 51;
            this.dgvReceiptExport.RowTemplate.Height = 24;
            this.dgvReceiptExport.Size = new System.Drawing.Size(721, 280);
            this.dgvReceiptExport.TabIndex = 11;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnVoucher);
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
            // btnVoucher
            // 
            this.btnVoucher.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnVoucher.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoucher.Location = new System.Drawing.Point(917, 117);
            this.btnVoucher.Name = "btnVoucher";
            this.btnVoucher.Size = new System.Drawing.Size(110, 70);
            this.btnVoucher.TabIndex = 9;
            this.btnVoucher.Text = "Voucher";
            this.btnVoucher.UseVisualStyleBackColor = false;
            this.btnVoucher.Click += new System.EventHandler(this.btnVoucher_Click);
            // 
            // gbReceiptExport
            // 
            this.gbReceiptExport.Controls.Add(this.txtNameCus);
            this.gbReceiptExport.Controls.Add(this.txtNameEmp);
            this.gbReceiptExport.Controls.Add(this.dtpReceiptImport);
            this.gbReceiptExport.Controls.Add(this.lblCustomer);
            this.gbReceiptExport.Controls.Add(this.lblEmployee);
            this.gbReceiptExport.Controls.Add(this.lblDateExport);
            this.gbReceiptExport.Location = new System.Drawing.Point(30, 21);
            this.gbReceiptExport.Margin = new System.Windows.Forms.Padding(4);
            this.gbReceiptExport.Name = "gbReceiptExport";
            this.gbReceiptExport.Padding = new System.Windows.Forms.Padding(4);
            this.gbReceiptExport.Size = new System.Drawing.Size(476, 171);
            this.gbReceiptExport.TabIndex = 0;
            this.gbReceiptExport.TabStop = false;
            this.gbReceiptExport.Text = "Thông tin bán sách";
            // 
            // lblCustomer
            // 
            this.lblCustomer.AutoSize = true;
            this.lblCustomer.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomer.Location = new System.Drawing.Point(8, 124);
            this.lblCustomer.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCustomer.Name = "lblCustomer";
            this.lblCustomer.Size = new System.Drawing.Size(139, 21);
            this.lblCustomer.TabIndex = 1;
            this.lblCustomer.Text = "Tên Khách Hàng";
            // 
            // lblEmployee
            // 
            this.lblEmployee.AutoSize = true;
            this.lblEmployee.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmployee.Location = new System.Drawing.Point(8, 80);
            this.lblEmployee.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEmployee.Name = "lblEmployee";
            this.lblEmployee.Size = new System.Drawing.Size(123, 21);
            this.lblEmployee.TabIndex = 1;
            this.lblEmployee.Text = "Tên Nhân Viên";
            // 
            // txtNameEmp
            // 
            this.txtNameEmp.Location = new System.Drawing.Point(203, 80);
            this.txtNameEmp.Name = "txtNameEmp";
            this.txtNameEmp.Size = new System.Drawing.Size(200, 20);
            this.txtNameEmp.TabIndex = 4;
            // 
            // txtNameCus
            // 
            this.txtNameCus.Location = new System.Drawing.Point(203, 127);
            this.txtNameCus.Name = "txtNameCus";
            this.txtNameCus.Size = new System.Drawing.Size(200, 20);
            this.txtNameCus.TabIndex = 5;
            // 
            // txtIdBill
            // 
            this.txtIdBill.Location = new System.Drawing.Point(148, 28);
            this.txtIdBill.Name = "txtIdBill";
            this.txtIdBill.Size = new System.Drawing.Size(200, 20);
            this.txtIdBill.TabIndex = 6;
            // 
            // UControlReceiptExport
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.dgvReceiptExport);
            this.Controls.Add(this.panel1);
            this.Name = "UControlReceiptExport";
            this.Size = new System.Drawing.Size(1072, 558);
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
        private System.Windows.Forms.DateTimePicker dtpReceiptImport;
        private System.Windows.Forms.Label lblSearchBy;
        private System.Windows.Forms.GroupBox gpSearch;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnReload;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblDateExport;
        private System.Windows.Forms.DataGridView dgvReceiptExport;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox gbReceiptExport;
        private System.Windows.Forms.Label lblCustomer;
        private System.Windows.Forms.Label lblEmployee;
        private System.Windows.Forms.Button btnVoucher;
        private System.Windows.Forms.TextBox txtIdBill;
        private System.Windows.Forms.TextBox txtNameCus;
        private System.Windows.Forms.TextBox txtNameEmp;
    }
}
