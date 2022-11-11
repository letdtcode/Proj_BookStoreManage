
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
            this.lblIDBill = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblStt = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblInfoTotal = new System.Windows.Forms.Label();
            this.lbl10 = new System.Windows.Forms.Label();
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
            this.lbIdEmployee = new System.Windows.Forms.Label();
            this.gbReceiptImport.SuspendLayout();
            this.panel2.SuspendLayout();
            this.gpSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReceiptImport)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbReceiptImport
            // 
            this.gbReceiptImport.Controls.Add(this.lbIdEmployee);
            this.gbReceiptImport.Controls.Add(this.dtpReceiptImport);
            this.gbReceiptImport.Controls.Add(this.lblIDBill);
            this.gbReceiptImport.Controls.Add(this.lblTotal);
            this.gbReceiptImport.Controls.Add(this.lblStt);
            this.gbReceiptImport.Controls.Add(this.label1);
            this.gbReceiptImport.Controls.Add(this.lblInfoTotal);
            this.gbReceiptImport.Controls.Add(this.lbl10);
            this.gbReceiptImport.Controls.Add(this.lblEmployee);
            this.gbReceiptImport.Controls.Add(this.lblDateImport);
            this.gbReceiptImport.Location = new System.Drawing.Point(30, 21);
            this.gbReceiptImport.Margin = new System.Windows.Forms.Padding(4);
            this.gbReceiptImport.Name = "gbReceiptImport";
            this.gbReceiptImport.Padding = new System.Windows.Forms.Padding(4);
            this.gbReceiptImport.Size = new System.Drawing.Size(575, 179);
            this.gbReceiptImport.TabIndex = 0;
            this.gbReceiptImport.TabStop = false;
            this.gbReceiptImport.Text = "Thông tin nhập sách";
            // 
            // dtpReceiptImport
            // 
            this.dtpReceiptImport.Location = new System.Drawing.Point(356, 58);
            this.dtpReceiptImport.Name = "dtpReceiptImport";
            this.dtpReceiptImport.Size = new System.Drawing.Size(200, 20);
            this.dtpReceiptImport.TabIndex = 3;
            // 
            // lblIDBill
            // 
            this.lblIDBill.AutoSize = true;
            this.lblIDBill.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIDBill.Location = new System.Drawing.Point(123, 36);
            this.lblIDBill.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIDBill.Name = "lblIDBill";
            this.lblIDBill.Size = new System.Drawing.Size(19, 21);
            this.lblIDBill.TabIndex = 1;
            this.lblIDBill.Text = "0";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(123, 87);
            this.lblTotal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(19, 21);
            this.lblTotal.TabIndex = 1;
            this.lblTotal.Text = "0";
            // 
            // lblStt
            // 
            this.lblStt.AutoSize = true;
            this.lblStt.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStt.Location = new System.Drawing.Point(123, 140);
            this.lblStt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStt.Name = "lblStt";
            this.lblStt.Size = new System.Drawing.Size(19, 21);
            this.lblStt.TabIndex = 1;
            this.lblStt.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 140);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "Trạng thái";
            // 
            // lblInfoTotal
            // 
            this.lblInfoTotal.AutoSize = true;
            this.lblInfoTotal.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfoTotal.Location = new System.Drawing.Point(8, 88);
            this.lblInfoTotal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblInfoTotal.Name = "lblInfoTotal";
            this.lblInfoTotal.Size = new System.Drawing.Size(81, 21);
            this.lblInfoTotal.TabIndex = 1;
            this.lblInfoTotal.Text = "Tổng tiền";
            // 
            // lbl10
            // 
            this.lbl10.AutoSize = true;
            this.lbl10.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl10.Location = new System.Drawing.Point(8, 37);
            this.lbl10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl10.Name = "lbl10";
            this.lbl10.Size = new System.Drawing.Size(53, 21);
            this.lbl10.TabIndex = 1;
            this.lbl10.Text = "ID Bill:";
            // 
            // lblEmployee
            // 
            this.lblEmployee.AutoSize = true;
            this.lblEmployee.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmployee.Location = new System.Drawing.Point(175, 109);
            this.lblEmployee.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEmployee.Name = "lblEmployee";
            this.lblEmployee.Size = new System.Drawing.Size(121, 21);
            this.lblEmployee.TabIndex = 1;
            this.lblEmployee.Text = "Mã Nhân Viên";
            // 
            // lblDateImport
            // 
            this.lblDateImport.AutoSize = true;
            this.lblDateImport.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateImport.Location = new System.Drawing.Point(175, 58);
            this.lblDateImport.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDateImport.Name = "lblDateImport";
            this.lblDateImport.Size = new System.Drawing.Size(141, 21);
            this.lblDateImport.TabIndex = 0;
            this.lblDateImport.Text = "Ngày Nhập Sách";
            // 
            // btnReload
            // 
            this.btnReload.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReload.Location = new System.Drawing.Point(24, 301);
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
            this.btnAdd.Location = new System.Drawing.Point(24, 16);
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
            this.btnDelete.Location = new System.Drawing.Point(24, 130);
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
            this.btnEdit.Location = new System.Drawing.Point(24, 73);
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
            this.btnSave.Location = new System.Drawing.Point(24, 187);
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
            this.btnCancel.Location = new System.Drawing.Point(24, 244);
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
            this.panel2.Location = new System.Drawing.Point(903, 204);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(169, 364);
            this.panel2.TabIndex = 7;
            // 
            // cbAttributeSearch
            // 
            this.cbAttributeSearch.FormattingEnabled = true;
            this.cbAttributeSearch.Location = new System.Drawing.Point(157, 26);
            this.cbAttributeSearch.Name = "cbAttributeSearch";
            this.cbAttributeSearch.Size = new System.Drawing.Size(121, 21);
            this.cbAttributeSearch.TabIndex = 1;
            // 
            // gpSearch
            // 
            this.gpSearch.Controls.Add(this.txtSearch);
            this.gpSearch.Controls.Add(this.cbAttributeSearch);
            this.gpSearch.Controls.Add(this.lblSearchBy);
            this.gpSearch.Location = new System.Drawing.Point(631, 41);
            this.gpSearch.Name = "gpSearch";
            this.gpSearch.Size = new System.Drawing.Size(301, 130);
            this.gpSearch.TabIndex = 1;
            this.gpSearch.TabStop = false;
            this.gpSearch.Text = "Tìm kiếm";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(54, 67);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(224, 20);
            this.txtSearch.TabIndex = 2;
            // 
            // lblSearchBy
            // 
            this.lblSearchBy.AutoSize = true;
            this.lblSearchBy.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearchBy.Location = new System.Drawing.Point(16, 27);
            this.lblSearchBy.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSearchBy.Name = "lblSearchBy";
            this.lblSearchBy.Size = new System.Drawing.Size(91, 21);
            this.lblSearchBy.TabIndex = 0;
            this.lblSearchBy.Text = "Thuộc tính";
            // 
            // dgvReceiptImport
            // 
            this.dgvReceiptImport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReceiptImport.Location = new System.Drawing.Point(73, 235);
            this.dgvReceiptImport.Name = "dgvReceiptImport";
            this.dgvReceiptImport.ReadOnly = true;
            this.dgvReceiptImport.RowHeadersWidth = 51;
            this.dgvReceiptImport.RowTemplate.Height = 24;
            this.dgvReceiptImport.Size = new System.Drawing.Size(721, 280);
            this.dgvReceiptImport.TabIndex = 8;
            this.dgvReceiptImport.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvReceiptImport_CellClick);
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
            this.panel1.Size = new System.Drawing.Size(1072, 204);
            this.panel1.TabIndex = 6;
            // 
            // btnDetailImportReceipt
            // 
            this.btnDetailImportReceipt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnDetailImportReceipt.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDetailImportReceipt.Location = new System.Drawing.Point(938, 58);
            this.btnDetailImportReceipt.Name = "btnDetailImportReceipt";
            this.btnDetailImportReceipt.Size = new System.Drawing.Size(110, 93);
            this.btnDetailImportReceipt.TabIndex = 9;
            this.btnDetailImportReceipt.Text = "Chi tiết hóa đơn";
            this.btnDetailImportReceipt.UseVisualStyleBackColor = false;
            this.btnDetailImportReceipt.Click += new System.EventHandler(this.btnDetailImportReceipt_Click);
            // 
            // lbIdEmployee
            // 
            this.lbIdEmployee.AutoSize = true;
            this.lbIdEmployee.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbIdEmployee.Location = new System.Drawing.Point(352, 109);
            this.lbIdEmployee.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbIdEmployee.Name = "lbIdEmployee";
            this.lbIdEmployee.Size = new System.Drawing.Size(19, 21);
            this.lbIdEmployee.TabIndex = 4;
            this.lbIdEmployee.Text = "0";
            // 
            // UControlReceiptImport
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.dgvReceiptImport);
            this.Controls.Add(this.panel1);
            this.Name = "UControlReceiptImport";
            this.Size = new System.Drawing.Size(1072, 568);
            this.Load += new System.EventHandler(this.UControlReceiptImport_Load);
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
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblInfoTotal;
        private System.Windows.Forms.Label lblStt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblIDBill;
        private System.Windows.Forms.Label lbl10;
        private System.Windows.Forms.Label lbIdEmployee;
    }
}
