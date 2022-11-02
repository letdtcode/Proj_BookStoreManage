
namespace Proj_Book_Store_Manage.UI
{
    partial class UControlReceiptImport
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
            this.gbReceiptImport = new System.Windows.Forms.GroupBox();
            this.dtpReceiptImport = new System.Windows.Forms.DateTimePicker();
            this.lblDateImport = new System.Windows.Forms.Label();
            this.btnReload = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnDetailImportReceipt = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtIdEmp = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtIdBill = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvReceiptImport = new System.Windows.Forms.DataGridView();
            this.gbReceiptImport.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReceiptImport)).BeginInit();
            this.SuspendLayout();
            // 
            // gbReceiptImport
            // 
            this.gbReceiptImport.Controls.Add(this.txtIdBill);
            this.gbReceiptImport.Controls.Add(this.label2);
            this.gbReceiptImport.Controls.Add(this.txtIdEmp);
            this.gbReceiptImport.Controls.Add(this.label1);
            this.gbReceiptImport.Controls.Add(this.dtpReceiptImport);
            this.gbReceiptImport.Controls.Add(this.lblDateImport);
            this.gbReceiptImport.Location = new System.Drawing.Point(30, 21);
            this.gbReceiptImport.Margin = new System.Windows.Forms.Padding(4);
            this.gbReceiptImport.Name = "gbReceiptImport";
            this.gbReceiptImport.Padding = new System.Windows.Forms.Padding(4);
            this.gbReceiptImport.Size = new System.Drawing.Size(895, 130);
            this.gbReceiptImport.TabIndex = 0;
            this.gbReceiptImport.TabStop = false;
            this.gbReceiptImport.Text = "Thông tin nhập sách";
            // 
            // dtpReceiptImport
            // 
            this.dtpReceiptImport.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpReceiptImport.Location = new System.Drawing.Point(688, 27);
            this.dtpReceiptImport.Name = "dtpReceiptImport";
            this.dtpReceiptImport.Size = new System.Drawing.Size(200, 20);
            this.dtpReceiptImport.TabIndex = 3;
            // 
            // lblDateImport
            // 
            this.lblDateImport.AutoSize = true;
            this.lblDateImport.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateImport.Location = new System.Drawing.Point(493, 27);
            this.lblDateImport.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDateImport.Name = "lblDateImport";
            this.lblDateImport.Size = new System.Drawing.Size(141, 21);
            this.lblDateImport.TabIndex = 0;
            this.lblDateImport.Text = "Ngày Nhập Sách";
            // 
            // btnReload
            // 
            this.btnReload.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReload.Location = new System.Drawing.Point(98, 154);
            this.btnReload.Name = "btnReload";
            this.btnReload.Size = new System.Drawing.Size(110, 34);
            this.btnReload.TabIndex = 1;
            this.btnReload.Text = "Tải lại";
            this.btnReload.UseVisualStyleBackColor = true;
            this.btnReload.Click += new System.EventHandler(this.btnReload_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(30, 7);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(110, 34);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(164, 58);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(110, 34);
            this.btnDelete.TabIndex = 1;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.Location = new System.Drawing.Point(164, 7);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(110, 34);
            this.btnEdit.TabIndex = 1;
            this.btnEdit.Text = "Sửa";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(30, 111);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(110, 34);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "Lưu";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(164, 111);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(110, 34);
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
            this.panel2.Controls.Add(this.btnEdit);
            this.panel2.Controls.Add(this.btnSave);
            this.panel2.Controls.Add(this.btnCancel);
            this.panel2.Location = new System.Drawing.Point(783, 175);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(286, 375);
            this.panel2.TabIndex = 7;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnDetailImportReceipt);
            this.panel1.Controls.Add(this.gbReceiptImport);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1072, 168);
            this.panel1.TabIndex = 6;
            // 
            // btnDetailImportReceipt
            // 
            this.btnDetailImportReceipt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnDetailImportReceipt.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDetailImportReceipt.Location = new System.Drawing.Point(939, 58);
            this.btnDetailImportReceipt.Name = "btnDetailImportReceipt";
            this.btnDetailImportReceipt.Size = new System.Drawing.Size(110, 93);
            this.btnDetailImportReceipt.TabIndex = 9;
            this.btnDetailImportReceipt.Text = "Chi tiết hóa đơn";
            this.btnDetailImportReceipt.UseVisualStyleBackColor = false;
            this.btnDetailImportReceipt.Click += new System.EventHandler(this.btnDetailImportReceipt_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(30, 58);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(110, 34);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "Tìm Kiếm";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtIdEmp
            // 
            this.txtIdEmp.Location = new System.Drawing.Point(201, 87);
            this.txtIdEmp.Name = "txtIdEmp";
            this.txtIdEmp.Size = new System.Drawing.Size(224, 20);
            this.txtIdEmp.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 87);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 21);
            this.label1.TabIndex = 4;
            this.label1.Text = "Mã Nhân Viên";
            // 
            // txtIdBill
            // 
            this.txtIdBill.Location = new System.Drawing.Point(201, 30);
            this.txtIdBill.Name = "txtIdBill";
            this.txtIdBill.Size = new System.Drawing.Size(224, 20);
            this.txtIdBill.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 30);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 21);
            this.label2.TabIndex = 6;
            this.label2.Text = "Mã Hóa Đơn";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvReceiptImport);
            this.groupBox1.Location = new System.Drawing.Point(30, 175);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(730, 375);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Bảng Hóa Đơn";
            // 
            // dgvReceiptImport
            // 
            this.dgvReceiptImport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReceiptImport.Location = new System.Drawing.Point(0, 25);
            this.dgvReceiptImport.Name = "dgvReceiptImport";
            this.dgvReceiptImport.RowHeadersWidth = 51;
            this.dgvReceiptImport.RowTemplate.Height = 24;
            this.dgvReceiptImport.Size = new System.Drawing.Size(721, 214);
            this.dgvReceiptImport.TabIndex = 9;
            this.dgvReceiptImport.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvReceiptImport_CellClick_1);
            // 
            // UControlReceiptImport
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "UControlReceiptImport";
            this.Size = new System.Drawing.Size(1072, 568);
            this.gbReceiptImport.ResumeLayout(false);
            this.gbReceiptImport.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvReceiptImport)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbReceiptImport;
        private System.Windows.Forms.DateTimePicker dtpReceiptImport;
        private System.Windows.Forms.Label lblDateImport;
        private System.Windows.Forms.Button btnReload;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnDetailImportReceipt;
        private System.Windows.Forms.TextBox txtIdEmp;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtIdBill;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvReceiptImport;
    }
}
