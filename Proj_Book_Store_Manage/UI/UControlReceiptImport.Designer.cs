
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
            this.lbIIdEmployee = new System.Windows.Forms.Label();
            this.lblIDBill = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lbl14 = new System.Windows.Forms.Label();
            this.lbl10 = new System.Windows.Forms.Label();
            this.lbl16 = new System.Windows.Forms.Label();
            this.lbl11 = new System.Windows.Forms.Label();
            this.btnReload = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cbAttributeSearch = new System.Windows.Forms.ComboBox();
            this.gpSearch = new System.Windows.Forms.GroupBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.lblSearchBy = new System.Windows.Forms.Label();
            this.dgvReceiptImport = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnDetailImportReceipt = new System.Windows.Forms.Button();
            this.lblDateBill = new System.Windows.Forms.Label();
            this.gbReceiptImport.SuspendLayout();
            this.panel2.SuspendLayout();
            this.gpSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReceiptImport)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbReceiptImport
            // 
            this.gbReceiptImport.Controls.Add(this.lblDateBill);
            this.gbReceiptImport.Controls.Add(this.lbIIdEmployee);
            this.gbReceiptImport.Controls.Add(this.lblIDBill);
            this.gbReceiptImport.Controls.Add(this.lblTotal);
            this.gbReceiptImport.Controls.Add(this.lbl14);
            this.gbReceiptImport.Controls.Add(this.lbl10);
            this.gbReceiptImport.Controls.Add(this.lbl16);
            this.gbReceiptImport.Controls.Add(this.lbl11);
            this.gbReceiptImport.Location = new System.Drawing.Point(30, 21);
            this.gbReceiptImport.Margin = new System.Windows.Forms.Padding(4);
            this.gbReceiptImport.Name = "gbReceiptImport";
            this.gbReceiptImport.Padding = new System.Windows.Forms.Padding(4);
            this.gbReceiptImport.Size = new System.Drawing.Size(575, 179);
            this.gbReceiptImport.TabIndex = 0;
            this.gbReceiptImport.TabStop = false;
            this.gbReceiptImport.Text = "Thông tin nhập sách";
            // 
            // lbIIdEmployee
            // 
            this.lbIIdEmployee.AutoSize = true;
            this.lbIIdEmployee.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbIIdEmployee.Location = new System.Drawing.Point(372, 88);
            this.lbIIdEmployee.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbIIdEmployee.Name = "lbIIdEmployee";
            this.lbIIdEmployee.Size = new System.Drawing.Size(21, 23);
            this.lbIIdEmployee.TabIndex = 4;
            this.lbIIdEmployee.Text = "0";
            // 
            // lblIDBill
            // 
            this.lblIDBill.AutoSize = true;
            this.lblIDBill.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIDBill.Location = new System.Drawing.Point(123, 36);
            this.lblIDBill.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIDBill.Name = "lblIDBill";
            this.lblIDBill.Size = new System.Drawing.Size(21, 23);
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
            this.lblTotal.Size = new System.Drawing.Size(21, 23);
            this.lblTotal.TabIndex = 1;
            this.lblTotal.Text = "0";
            // 
            // lbl14
            // 
            this.lbl14.AutoSize = true;
            this.lbl14.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl14.Location = new System.Drawing.Point(8, 88);
            this.lbl14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl14.Name = "lbl14";
            this.lbl14.Size = new System.Drawing.Size(89, 23);
            this.lbl14.TabIndex = 1;
            this.lbl14.Text = "Tổng tiền";
            // 
            // lbl10
            // 
            this.lbl10.AutoSize = true;
            this.lbl10.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl10.Location = new System.Drawing.Point(8, 37);
            this.lbl10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl10.Name = "lbl10";
            this.lbl10.Size = new System.Drawing.Size(65, 23);
            this.lbl10.TabIndex = 1;
            this.lbl10.Text = "ID Bill:";
            // 
            // lbl16
            // 
            this.lbl16.AutoSize = true;
            this.lbl16.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl16.Location = new System.Drawing.Point(186, 87);
            this.lbl16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl16.Name = "lbl16";
            this.lbl16.Size = new System.Drawing.Size(149, 23);
            this.lbl16.TabIndex = 1;
            this.lbl16.Text = "Mã Nhân Viên";
            // 
            // lbl11
            // 
            this.lbl11.AutoSize = true;
            this.lbl11.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl11.Location = new System.Drawing.Point(186, 36);
            this.lbl11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl11.Name = "lbl11";
            this.lbl11.Size = new System.Drawing.Size(174, 23);
            this.lbl11.TabIndex = 0;
            this.lbl11.Text = "Ngày Nhập Sách";
            // 
            // btnReload
            // 
            this.btnReload.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReload.Location = new System.Drawing.Point(24, 86);
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
            // panel2
            // 
            this.panel2.Controls.Add(this.btnReload);
            this.panel2.Controls.Add(this.btnAdd);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(903, 204);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(169, 364);
            this.panel2.TabIndex = 7;
            // 
            // cbAttributeSearch
            // 
            this.cbAttributeSearch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbAttributeSearch.FormattingEnabled = true;
            this.cbAttributeSearch.Location = new System.Drawing.Point(157, 26);
            this.cbAttributeSearch.Name = "cbAttributeSearch";
            this.cbAttributeSearch.Size = new System.Drawing.Size(121, 24);
            this.cbAttributeSearch.TabIndex = 1;
            // 
            // gpSearch
            // 
            this.gpSearch.Controls.Add(this.btnSearch);
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
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(185, 82);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(110, 43);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "Tìm Kiếm";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(54, 56);
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
            // lblDateBill
            // 
            this.lblDateBill.AutoSize = true;
            this.lblDateBill.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateBill.Location = new System.Drawing.Point(372, 36);
            this.lblDateBill.Name = "lblDateBill";
            this.lblDateBill.Size = new System.Drawing.Size(116, 23);
            this.lblDateBill.TabIndex = 5;
            this.lblDateBill.Text = "14/11/2022";
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
        private System.Windows.Forms.Label lbl16;
        private System.Windows.Forms.Label lbl11;
        private System.Windows.Forms.Button btnReload;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox cbAttributeSearch;
        private System.Windows.Forms.GroupBox gpSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label lblSearchBy;
        private System.Windows.Forms.DataGridView dgvReceiptImport;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnDetailImportReceipt;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lbl14;
        private System.Windows.Forms.Label lblIDBill;
        private System.Windows.Forms.Label lbl10;
        private System.Windows.Forms.Label lbIIdEmployee;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label lblDateBill;
    }
}