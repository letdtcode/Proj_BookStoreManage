
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
            this.btnCancel = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnReload = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.lblDateExport = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnVoucher = new System.Windows.Forms.Button();
            this.gbReceiptExport = new System.Windows.Forms.GroupBox();
            this.txtIdCus = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtIdBill = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtIdEmp = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNameCus = new System.Windows.Forms.TextBox();
            this.txtNameEmp = new System.Windows.Forms.TextBox();
            this.lblCustomer = new System.Windows.Forms.Label();
            this.lblEmployee = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvReceiptExport = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvCus = new System.Windows.Forms.DataGridView();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.gbReceiptExport.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReceiptExport)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCus)).BeginInit();
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
            this.dtpReceiptImport.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpReceiptImport.Location = new System.Drawing.Point(640, 124);
            this.dtpReceiptImport.Name = "dtpReceiptImport";
            this.dtpReceiptImport.Size = new System.Drawing.Size(200, 20);
            this.dtpReceiptImport.TabIndex = 3;
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(629, 15);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(110, 31);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "Hủy";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnSearch);
            this.panel2.Controls.Add(this.btnReload);
            this.panel2.Controls.Add(this.btnAdd);
            this.panel2.Controls.Add(this.btnDelete);
            this.panel2.Controls.Add(this.btnSave);
            this.panel2.Controls.Add(this.btnCancel);
            this.panel2.Location = new System.Drawing.Point(30, 199);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(858, 56);
            this.panel2.TabIndex = 10;
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(238, 15);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(110, 31);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "Tìm Kiếm";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnReload
            // 
            this.btnReload.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReload.Location = new System.Drawing.Point(745, 15);
            this.btnReload.Name = "btnReload";
            this.btnReload.Size = new System.Drawing.Size(110, 31);
            this.btnReload.TabIndex = 1;
            this.btnReload.Text = "Tải lại";
            this.btnReload.UseVisualStyleBackColor = true;
            this.btnReload.Click += new System.EventHandler(this.btnReload_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(6, 15);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(110, 31);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(122, 15);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(110, 31);
            this.btnDelete.TabIndex = 1;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(513, 15);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(110, 31);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "Lưu";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lblDateExport
            // 
            this.lblDateExport.AutoSize = true;
            this.lblDateExport.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateExport.Location = new System.Drawing.Point(472, 124);
            this.lblDateExport.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDateExport.Name = "lblDateExport";
            this.lblDateExport.Size = new System.Drawing.Size(129, 21);
            this.lblDateExport.TabIndex = 0;
            this.lblDateExport.Text = "Ngày Bán Sách";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnVoucher);
            this.panel1.Controls.Add(this.btnDetailExportReceipt);
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
            this.gbReceiptExport.Controls.Add(this.txtIdCus);
            this.gbReceiptExport.Controls.Add(this.label3);
            this.gbReceiptExport.Controls.Add(this.txtIdBill);
            this.gbReceiptExport.Controls.Add(this.label2);
            this.gbReceiptExport.Controls.Add(this.txtIdEmp);
            this.gbReceiptExport.Controls.Add(this.label1);
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
            this.gbReceiptExport.Size = new System.Drawing.Size(847, 171);
            this.gbReceiptExport.TabIndex = 0;
            this.gbReceiptExport.TabStop = false;
            this.gbReceiptExport.Text = "Thông tin bán sách";
            // 
            // txtIdCus
            // 
            this.txtIdCus.Location = new System.Drawing.Point(640, 80);
            this.txtIdCus.Name = "txtIdCus";
            this.txtIdCus.Size = new System.Drawing.Size(200, 20);
            this.txtIdCus.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(464, 79);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 21);
            this.label3.TabIndex = 10;
            this.label3.Text = "Mã Khách Hàng";
            // 
            // txtIdBill
            // 
            this.txtIdBill.Location = new System.Drawing.Point(203, 36);
            this.txtIdBill.Name = "txtIdBill";
            this.txtIdBill.Size = new System.Drawing.Size(200, 20);
            this.txtIdBill.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(18, 33);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 21);
            this.label2.TabIndex = 8;
            this.label2.Text = "Mã Hóa Đơn";
            // 
            // txtIdEmp
            // 
            this.txtIdEmp.Location = new System.Drawing.Point(640, 36);
            this.txtIdEmp.Name = "txtIdEmp";
            this.txtIdEmp.Size = new System.Drawing.Size(200, 20);
            this.txtIdEmp.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(472, 36);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 21);
            this.label1.TabIndex = 6;
            this.label1.Text = "Mã Nhân Viên";
            // 
            // txtNameCus
            // 
            this.txtNameCus.Location = new System.Drawing.Point(203, 127);
            this.txtNameCus.Name = "txtNameCus";
            this.txtNameCus.Size = new System.Drawing.Size(200, 20);
            this.txtNameCus.TabIndex = 5;
            // 
            // txtNameEmp
            // 
            this.txtNameEmp.Location = new System.Drawing.Point(203, 80);
            this.txtNameEmp.Name = "txtNameEmp";
            this.txtNameEmp.Size = new System.Drawing.Size(200, 20);
            this.txtNameEmp.TabIndex = 4;
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
            this.lblEmployee.Location = new System.Drawing.Point(18, 80);
            this.lblEmployee.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEmployee.Name = "lblEmployee";
            this.lblEmployee.Size = new System.Drawing.Size(123, 21);
            this.lblEmployee.TabIndex = 1;
            this.lblEmployee.Text = "Tên Nhân Viên";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvReceiptExport);
            this.groupBox1.Location = new System.Drawing.Point(30, 261);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(609, 274);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Bảng Hóa Đơn";
            // 
            // dgvReceiptExport
            // 
            this.dgvReceiptExport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReceiptExport.Location = new System.Drawing.Point(6, 32);
            this.dgvReceiptExport.Name = "dgvReceiptExport";
            this.dgvReceiptExport.RowHeadersWidth = 51;
            this.dgvReceiptExport.RowTemplate.Height = 24;
            this.dgvReceiptExport.Size = new System.Drawing.Size(583, 197);
            this.dgvReceiptExport.TabIndex = 13;
            this.dgvReceiptExport.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvReceiptExport_CellClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvCus);
            this.groupBox2.Location = new System.Drawing.Point(670, 261);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(362, 274);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Bảng Khách hàng";
            // 
            // dgvCus
            // 
            this.dgvCus.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCus.Location = new System.Drawing.Point(0, 32);
            this.dgvCus.Name = "dgvCus";
            this.dgvCus.Size = new System.Drawing.Size(350, 197);
            this.dgvCus.TabIndex = 0;
            this.dgvCus.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCus_CellClick);
            // 
            // UControlReceiptExport
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "UControlReceiptExport";
            this.Size = new System.Drawing.Size(1072, 558);
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.gbReceiptExport.ResumeLayout(false);
            this.gbReceiptExport.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvReceiptExport)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCus)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnDetailExportReceipt;
        private System.Windows.Forms.DateTimePicker dtpReceiptImport;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnReload;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblDateExport;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox gbReceiptExport;
        private System.Windows.Forms.Label lblCustomer;
        private System.Windows.Forms.Label lblEmployee;
        private System.Windows.Forms.Button btnVoucher;
        private System.Windows.Forms.TextBox txtNameCus;
        private System.Windows.Forms.TextBox txtNameEmp;
        private System.Windows.Forms.TextBox txtIdBill;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtIdEmp;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvReceiptExport;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtIdCus;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgvCus;
        private System.Windows.Forms.Button btnSearch;
    }
}
