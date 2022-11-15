
namespace Proj_Book_Store_Manage.UI
{
    partial class UControlVoucher
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
            this.dgvVoucher = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnReload = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.gbVoucher = new System.Windows.Forms.GroupBox();
            this.dtpDateEnd = new System.Windows.Forms.DateTimePicker();
            this.dtpDateStart = new System.Windows.Forms.DateTimePicker();
            this.txtEvent = new System.Windows.Forms.TextBox();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.txtValueVoucher = new System.Windows.Forms.TextBox();
            this.lblDateEnd = new System.Windows.Forms.Label();
            this.lblDateStart = new System.Windows.Forms.Label();
            this.lblNameEvent = new System.Windows.Forms.Label();
            this.lblAmount = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblValueVoucher = new System.Windows.Forms.Label();
            this.gpSearch = new System.Windows.Forms.GroupBox();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.cbAttributeSearch = new System.Windows.Forms.ComboBox();
            this.lblSearchBy = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVoucher)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.gbVoucher.SuspendLayout();
            this.gpSearch.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvVoucher
            // 
            this.dgvVoucher.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVoucher.Location = new System.Drawing.Point(30, 293);
            this.dgvVoucher.Name = "dgvVoucher";
            this.dgvVoucher.ReadOnly = true;
            this.dgvVoucher.RowHeadersWidth = 51;
            this.dgvVoucher.RowTemplate.Height = 24;
            this.dgvVoucher.Size = new System.Drawing.Size(721, 280);
            this.dgvVoucher.TabIndex = 11;
            this.dgvVoucher.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvVoucher_CellClick);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.btnReload);
            this.panel2.Controls.Add(this.btnAdd);
            this.panel2.Controls.Add(this.btnDelete);
            this.panel2.Controls.Add(this.btnEdit);
            this.panel2.Controls.Add(this.btnSave);
            this.panel2.Controls.Add(this.btnCancel);
            this.panel2.Location = new System.Drawing.Point(849, 252);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(169, 383);
            this.panel2.TabIndex = 10;
            // 
            // btnReload
            // 
            this.btnReload.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReload.Location = new System.Drawing.Point(35, 310);
            this.btnReload.Name = "btnReload";
            this.btnReload.Size = new System.Drawing.Size(110, 37);
            this.btnReload.TabIndex = 1;
            this.btnReload.Text = "Tải lại";
            this.btnReload.UseVisualStyleBackColor = true;
            this.btnReload.Click += new System.EventHandler(this.btnReload_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(35, 25);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(110, 37);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(35, 139);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(110, 37);
            this.btnDelete.TabIndex = 1;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.Location = new System.Drawing.Point(35, 82);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(110, 37);
            this.btnEdit.TabIndex = 1;
            this.btnEdit.Text = "Sửa";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(35, 196);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(110, 37);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "Lưu";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(35, 253);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(110, 37);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "Hủy";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.gbVoucher);
            this.panel3.Controls.Add(this.gpSearch);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1018, 256);
            this.panel3.TabIndex = 5;
            // 
            // gbVoucher
            // 
            this.gbVoucher.Controls.Add(this.dtpDateEnd);
            this.gbVoucher.Controls.Add(this.dtpDateStart);
            this.gbVoucher.Controls.Add(this.txtEvent);
            this.gbVoucher.Controls.Add(this.txtAmount);
            this.gbVoucher.Controls.Add(this.txtValueVoucher);
            this.gbVoucher.Controls.Add(this.lblDateEnd);
            this.gbVoucher.Controls.Add(this.lblDateStart);
            this.gbVoucher.Controls.Add(this.lblNameEvent);
            this.gbVoucher.Controls.Add(this.lblAmount);
            this.gbVoucher.Controls.Add(this.lblID);
            this.gbVoucher.Controls.Add(this.label1);
            this.gbVoucher.Controls.Add(this.lblValueVoucher);
            this.gbVoucher.Location = new System.Drawing.Point(13, 13);
            this.gbVoucher.Margin = new System.Windows.Forms.Padding(4);
            this.gbVoucher.Name = "gbVoucher";
            this.gbVoucher.Padding = new System.Windows.Forms.Padding(4);
            this.gbVoucher.Size = new System.Drawing.Size(689, 212);
            this.gbVoucher.TabIndex = 0;
            this.gbVoucher.TabStop = false;
            this.gbVoucher.Text = "Thông tin Voucher";
            // 
            // dtpDateEnd
            // 
            this.dtpDateEnd.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDateEnd.Location = new System.Drawing.Point(510, 91);
            this.dtpDateEnd.Name = "dtpDateEnd";
            this.dtpDateEnd.Size = new System.Drawing.Size(161, 20);
            this.dtpDateEnd.TabIndex = 4;
            // 
            // dtpDateStart
            // 
            this.dtpDateStart.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDateStart.Location = new System.Drawing.Point(507, 45);
            this.dtpDateStart.Name = "dtpDateStart";
            this.dtpDateStart.Size = new System.Drawing.Size(161, 20);
            this.dtpDateStart.TabIndex = 4;
            // 
            // txtEvent
            // 
            this.txtEvent.Location = new System.Drawing.Point(173, 164);
            this.txtEvent.Name = "txtEvent";
            this.txtEvent.Size = new System.Drawing.Size(145, 20);
            this.txtEvent.TabIndex = 2;
            // 
            // txtAmount
            // 
            this.txtAmount.Location = new System.Drawing.Point(510, 161);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(86, 20);
            this.txtAmount.TabIndex = 2;
            // 
            // txtValueVoucher
            // 
            this.txtValueVoucher.Location = new System.Drawing.Point(173, 118);
            this.txtValueVoucher.Name = "txtValueVoucher";
            this.txtValueVoucher.Size = new System.Drawing.Size(145, 20);
            this.txtValueVoucher.TabIndex = 2;
            // 
            // lblDateEnd
            // 
            this.lblDateEnd.AutoSize = true;
            this.lblDateEnd.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateEnd.Location = new System.Drawing.Point(345, 91);
            this.lblDateEnd.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDateEnd.Name = "lblDateEnd";
            this.lblDateEnd.Size = new System.Drawing.Size(122, 20);
            this.lblDateEnd.TabIndex = 1;
            this.lblDateEnd.Text = "Ngày Kết Thúc";
            // 
            // lblDateStart
            // 
            this.lblDateStart.AutoSize = true;
            this.lblDateStart.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateStart.Location = new System.Drawing.Point(345, 45);
            this.lblDateStart.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDateStart.Name = "lblDateStart";
            this.lblDateStart.Size = new System.Drawing.Size(115, 20);
            this.lblDateStart.TabIndex = 1;
            this.lblDateStart.Text = "Ngày Bắt Đầu";
            // 
            // lblNameEvent
            // 
            this.lblNameEvent.AutoSize = true;
            this.lblNameEvent.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNameEvent.Location = new System.Drawing.Point(8, 161);
            this.lblNameEvent.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNameEvent.Name = "lblNameEvent";
            this.lblNameEvent.Size = new System.Drawing.Size(101, 20);
            this.lblNameEvent.TabIndex = 1;
            this.lblNameEvent.Text = "Tên Sự Kiện";
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAmount.Location = new System.Drawing.Point(345, 161);
            this.lblAmount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(80, 20);
            this.lblAmount.TabIndex = 0;
            this.lblAmount.Text = "Số Lượng";
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblID.Location = new System.Drawing.Point(174, 66);
            this.lblID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(19, 21);
            this.lblID.TabIndex = 0;
            this.lblID.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 66);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID Voucher:";
            // 
            // lblValueVoucher
            // 
            this.lblValueVoucher.AutoSize = true;
            this.lblValueVoucher.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValueVoucher.Location = new System.Drawing.Point(8, 118);
            this.lblValueVoucher.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblValueVoucher.Name = "lblValueVoucher";
            this.lblValueVoucher.Size = new System.Drawing.Size(126, 20);
            this.lblValueVoucher.TabIndex = 0;
            this.lblValueVoucher.Text = "Giá Trị Voucher";
            // 
            // gpSearch
            // 
            this.gpSearch.Controls.Add(this.btnSearch);
            this.gpSearch.Controls.Add(this.txtSearch);
            this.gpSearch.Controls.Add(this.cbAttributeSearch);
            this.gpSearch.Controls.Add(this.lblSearchBy);
            this.gpSearch.Location = new System.Drawing.Point(735, 13);
            this.gpSearch.Name = "gpSearch";
            this.gpSearch.Size = new System.Drawing.Size(280, 212);
            this.gpSearch.TabIndex = 1;
            this.gpSearch.TabStop = false;
            this.gpSearch.Text = "Tìm kiếm";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(11, 120);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(263, 20);
            this.txtSearch.TabIndex = 2;
            // 
            // cbAttributeSearch
            // 
            this.cbAttributeSearch.FormattingEnabled = true;
            this.cbAttributeSearch.Location = new System.Drawing.Point(11, 65);
            this.cbAttributeSearch.Name = "cbAttributeSearch";
            this.cbAttributeSearch.Size = new System.Drawing.Size(263, 21);
            this.cbAttributeSearch.TabIndex = 1;
            // 
            // lblSearchBy
            // 
            this.lblSearchBy.AutoSize = true;
            this.lblSearchBy.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearchBy.Location = new System.Drawing.Point(7, 33);
            this.lblSearchBy.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSearchBy.Name = "lblSearchBy";
            this.lblSearchBy.Size = new System.Drawing.Size(91, 21);
            this.lblSearchBy.TabIndex = 0;
            this.lblSearchBy.Text = "Thuộc tính";
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(164, 169);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(110, 37);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "Tìm Kiếm";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // UControlVoucher
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.dgvVoucher);
            this.Controls.Add(this.panel2);
            this.Name = "UControlVoucher";
            this.Size = new System.Drawing.Size(1018, 635);
            this.Load += new System.EventHandler(this.UControlVoucher_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVoucher)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.gbVoucher.ResumeLayout(false);
            this.gbVoucher.PerformLayout();
            this.gpSearch.ResumeLayout(false);
            this.gpSearch.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvVoucher;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnReload;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.GroupBox gbVoucher;
        private System.Windows.Forms.DateTimePicker dtpDateEnd;
        private System.Windows.Forms.DateTimePicker dtpDateStart;
        private System.Windows.Forms.TextBox txtEvent;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.TextBox txtValueVoucher;
        private System.Windows.Forms.Label lblDateEnd;
        private System.Windows.Forms.Label lblDateStart;
        private System.Windows.Forms.Label lblNameEvent;
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.Label lblValueVoucher;
        private System.Windows.Forms.GroupBox gpSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.ComboBox cbAttributeSearch;
        private System.Windows.Forms.Label lblSearchBy;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSearch;
    }
}
