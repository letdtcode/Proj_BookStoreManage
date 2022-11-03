
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
            this.cbEmployee = new System.Windows.Forms.ComboBox();
            this.dtpReceiptImport = new System.Windows.Forms.DateTimePicker();
            this.lblEmployee = new System.Windows.Forms.Label();
            this.lblDateImport = new System.Windows.Forms.Label();
            this.btnReload = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cbAttributeSearch = new System.Windows.Forms.ComboBox();
            this.gpSearch = new System.Windows.Forms.GroupBox();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.lblSearchBy = new System.Windows.Forms.Label();
            this.dgvReceiptImport = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnDetailImportReceipt = new System.Windows.Forms.Button();
            this.gbReceiptImport.SuspendLayout();
            this.panel2.SuspendLayout();
            this.gpSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReceiptImport)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbReceiptImport
            // 
            this.gbReceiptImport.Controls.Add(this.cbEmployee);
            this.gbReceiptImport.Controls.Add(this.dtpReceiptImport);
            this.gbReceiptImport.Controls.Add(this.lblEmployee);
            this.gbReceiptImport.Controls.Add(this.lblDateImport);
            this.gbReceiptImport.Location = new System.Drawing.Point(30, 21);
            this.gbReceiptImport.Margin = new System.Windows.Forms.Padding(4);
            this.gbReceiptImport.Name = "gbReceiptImport";
            this.gbReceiptImport.Padding = new System.Windows.Forms.Padding(4);
            this.gbReceiptImport.Size = new System.Drawing.Size(476, 130);
            this.gbReceiptImport.TabIndex = 0;
            this.gbReceiptImport.TabStop = false;
            this.gbReceiptImport.Text = "Thông tin nhập sách";
            // 
            // cbEmployee
            // 
            this.cbEmployee.FormattingEnabled = true;
            this.cbEmployee.Location = new System.Drawing.Point(203, 79);
            this.cbEmployee.Name = "cbEmployee";
            this.cbEmployee.Size = new System.Drawing.Size(200, 24);
            this.cbEmployee.TabIndex = 4;
            // 
            // dtpReceiptImport
            // 
            this.dtpReceiptImport.Location = new System.Drawing.Point(203, 37);
            this.dtpReceiptImport.Name = "dtpReceiptImport";
            this.dtpReceiptImport.Size = new System.Drawing.Size(200, 22);
            this.dtpReceiptImport.TabIndex = 3;
            // 
            // lblEmployee
            // 
            this.lblEmployee.AutoSize = true;
            this.lblEmployee.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmployee.Location = new System.Drawing.Point(8, 80);
            this.lblEmployee.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEmployee.Name = "lblEmployee";
            this.lblEmployee.Size = new System.Drawing.Size(151, 23);
            this.lblEmployee.TabIndex = 1;
            this.lblEmployee.Text = "Tên Nhân Viên";
            // 
            // lblDateImport
            // 
            this.lblDateImport.AutoSize = true;
            this.lblDateImport.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateImport.Location = new System.Drawing.Point(8, 37);
            this.lblDateImport.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDateImport.Name = "lblDateImport";
            this.lblDateImport.Size = new System.Drawing.Size(174, 23);
            this.lblDateImport.TabIndex = 0;
            this.lblDateImport.Text = "Ngày Nhập Sách";
            // 
            // btnReload
            // 
            this.btnReload.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReload.Location = new System.Drawing.Point(35, 310);
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
            this.btnAdd.Location = new System.Drawing.Point(35, 25);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(110, 43);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(35, 139);
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
            this.btnEdit.Location = new System.Drawing.Point(35, 82);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(110, 43);
            this.btnEdit.TabIndex = 1;
            this.btnEdit.Text = "Sửa";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(35, 196);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(110, 43);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "Lưu";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(35, 253);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(110, 43);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "Hủy";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
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
            this.panel2.Location = new System.Drawing.Point(903, 168);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(169, 400);
            this.panel2.TabIndex = 7;
            // 
            // cbAttributeSearch
            // 
            this.cbAttributeSearch.FormattingEnabled = true;
            this.cbAttributeSearch.Location = new System.Drawing.Point(157, 26);
            this.cbAttributeSearch.Name = "cbAttributeSearch";
            this.cbAttributeSearch.Size = new System.Drawing.Size(121, 24);
            this.cbAttributeSearch.TabIndex = 1;
            // 
            // gpSearch
            // 
            this.gpSearch.Controls.Add(this.txtSearch);
            this.gpSearch.Controls.Add(this.cbAttributeSearch);
            this.gpSearch.Controls.Add(this.lblSearchBy);
            this.gpSearch.Location = new System.Drawing.Point(532, 21);
            this.gpSearch.Name = "gpSearch";
            this.gpSearch.Size = new System.Drawing.Size(320, 130);
            this.gpSearch.TabIndex = 1;
            this.gpSearch.TabStop = false;
            this.gpSearch.Text = "Tìm kiếm";
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
            // dgvReceiptImport
            // 
            this.dgvReceiptImport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReceiptImport.Location = new System.Drawing.Point(42, 222);
            this.dgvReceiptImport.Name = "dgvReceiptImport";
            this.dgvReceiptImport.RowHeadersWidth = 51;
            this.dgvReceiptImport.RowTemplate.Height = 24;
            this.dgvReceiptImport.Size = new System.Drawing.Size(721, 280);
            this.dgvReceiptImport.TabIndex = 8;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnDetailImportReceipt);
            this.panel1.Controls.Add(this.gpSearch);
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
            this.btnDetailImportReceipt.Location = new System.Drawing.Point(912, 47);
            this.btnDetailImportReceipt.Name = "btnDetailImportReceipt";
            this.btnDetailImportReceipt.Size = new System.Drawing.Size(110, 93);
            this.btnDetailImportReceipt.TabIndex = 9;
            this.btnDetailImportReceipt.Text = "Chi tiết hóa đơn";
            this.btnDetailImportReceipt.UseVisualStyleBackColor = false;
            this.btnDetailImportReceipt.Click += new System.EventHandler(this.btnDetailImportReceipt_Click);
            // 
            // UControlReceiptImport
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.dgvReceiptImport);
            this.Controls.Add(this.panel1);
            this.Name = "UControlReceiptImport";
            this.Size = new System.Drawing.Size(1072, 568);
            this.gbReceiptImport.ResumeLayout(false);
            this.gbReceiptImport.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.gpSearch.ResumeLayout(false);
            this.gpSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReceiptImport)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbReceiptImport;
        private System.Windows.Forms.ComboBox cbEmployee;
        private System.Windows.Forms.DateTimePicker dtpReceiptImport;
        private System.Windows.Forms.Label lblEmployee;
        private System.Windows.Forms.Label lblDateImport;
        private System.Windows.Forms.Button btnReload;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox cbAttributeSearch;
        private System.Windows.Forms.GroupBox gpSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label lblSearchBy;
        private System.Windows.Forms.DataGridView dgvReceiptImport;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnDetailImportReceipt;
    }
}
