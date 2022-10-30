
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
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.gbVoucher = new System.Windows.Forms.GroupBox();
            this.dtpDateEnd = new System.Windows.Forms.DateTimePicker();
            this.dtpDateStart = new System.Windows.Forms.DateTimePicker();
            this.txtNameVoucher = new System.Windows.Forms.TextBox();
            this.txtValueVoucher = new System.Windows.Forms.TextBox();
            this.lblDateEnd = new System.Windows.Forms.Label();
            this.lblDateStart = new System.Windows.Forms.Label();
            this.lblNameEvent = new System.Windows.Forms.Label();
            this.lblValueVoucher = new System.Windows.Forms.Label();
            this.txtIdVoucher = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.lblAmount = new System.Windows.Forms.Label();
            this.btnReload = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVoucher)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.gbVoucher.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvVoucher
            // 
            this.dgvVoucher.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVoucher.Location = new System.Drawing.Point(30, 293);
            this.dgvVoucher.Name = "dgvVoucher";
            this.dgvVoucher.RowHeadersWidth = 51;
            this.dgvVoucher.RowTemplate.Height = 24;
            this.dgvVoucher.Size = new System.Drawing.Size(721, 188);
            this.dgvVoucher.TabIndex = 11;
            this.dgvVoucher.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvVoucher_CellClick);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.btnSearch);
            this.panel2.Controls.Add(this.btnAdd);
            this.panel2.Controls.Add(this.btnDelete);
            this.panel2.Controls.Add(this.btnEdit);
            this.panel2.Controls.Add(this.btnSave);
            this.panel2.Controls.Add(this.btnCancel);
            this.panel2.Location = new System.Drawing.Point(789, 293);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(267, 188);
            this.panel2.TabIndex = 10;
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(144, 127);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(110, 33);
            this.btnSearch.TabIndex = 1;
            this.btnSearch.Text = "Tìm Kiếm";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(3, 4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(110, 37);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(3, 71);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(110, 32);
            this.btnDelete.TabIndex = 1;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.Location = new System.Drawing.Point(144, 5);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(110, 36);
            this.btnEdit.TabIndex = 1;
            this.btnEdit.Text = "Sửa";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(144, 72);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(110, 31);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "Lưu";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(3, 127);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(110, 31);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "Hủy";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.gbVoucher);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1093, 256);
            this.panel3.TabIndex = 5;
            // 
            // gbVoucher
            // 
            this.gbVoucher.Controls.Add(this.btnReload);
            this.gbVoucher.Controls.Add(this.txtAmount);
            this.gbVoucher.Controls.Add(this.lblAmount);
            this.gbVoucher.Controls.Add(this.dtpDateEnd);
            this.gbVoucher.Controls.Add(this.txtIdVoucher);
            this.gbVoucher.Controls.Add(this.label1);
            this.gbVoucher.Controls.Add(this.dtpDateStart);
            this.gbVoucher.Controls.Add(this.txtNameVoucher);
            this.gbVoucher.Controls.Add(this.txtValueVoucher);
            this.gbVoucher.Controls.Add(this.lblDateStart);
            this.gbVoucher.Controls.Add(this.lblNameEvent);
            this.gbVoucher.Controls.Add(this.lblValueVoucher);
            this.gbVoucher.Controls.Add(this.lblDateEnd);
            this.gbVoucher.Location = new System.Drawing.Point(4, 17);
            this.gbVoucher.Margin = new System.Windows.Forms.Padding(4);
            this.gbVoucher.Name = "gbVoucher";
            this.gbVoucher.Padding = new System.Windows.Forms.Padding(4);
            this.gbVoucher.Size = new System.Drawing.Size(1043, 212);
            this.gbVoucher.TabIndex = 0;
            this.gbVoucher.TabStop = false;
            this.gbVoucher.Text = "Thông tin Voucher";
            // 
            // dtpDateEnd
            // 
            this.dtpDateEnd.Location = new System.Drawing.Point(586, 172);
            this.dtpDateEnd.Name = "dtpDateEnd";
            this.dtpDateEnd.Size = new System.Drawing.Size(200, 20);
            this.dtpDateEnd.TabIndex = 4;
            // 
            // dtpDateStart
            // 
            this.dtpDateStart.Location = new System.Drawing.Point(173, 171);
            this.dtpDateStart.Name = "dtpDateStart";
            this.dtpDateStart.Size = new System.Drawing.Size(200, 20);
            this.dtpDateStart.TabIndex = 4;
            // 
            // txtNameVoucher
            // 
            this.txtNameVoucher.Location = new System.Drawing.Point(173, 122);
            this.txtNameVoucher.Name = "txtNameVoucher";
            this.txtNameVoucher.Size = new System.Drawing.Size(200, 20);
            this.txtNameVoucher.TabIndex = 2;
            // 
            // txtValueVoucher
            // 
            this.txtValueVoucher.Location = new System.Drawing.Point(173, 75);
            this.txtValueVoucher.Name = "txtValueVoucher";
            this.txtValueVoucher.Size = new System.Drawing.Size(200, 20);
            this.txtValueVoucher.TabIndex = 2;
            // 
            // lblDateEnd
            // 
            this.lblDateEnd.AutoSize = true;
            this.lblDateEnd.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateEnd.Location = new System.Drawing.Point(435, 170);
            this.lblDateEnd.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDateEnd.Name = "lblDateEnd";
            this.lblDateEnd.Size = new System.Drawing.Size(123, 21);
            this.lblDateEnd.TabIndex = 1;
            this.lblDateEnd.Text = "Ngày Kết Thúc";
            // 
            // lblDateStart
            // 
            this.lblDateStart.AutoSize = true;
            this.lblDateStart.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateStart.Location = new System.Drawing.Point(8, 171);
            this.lblDateStart.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDateStart.Name = "lblDateStart";
            this.lblDateStart.Size = new System.Drawing.Size(117, 21);
            this.lblDateStart.TabIndex = 1;
            this.lblDateStart.Text = "Ngày Bắt Đầu";
            // 
            // lblNameEvent
            // 
            this.lblNameEvent.AutoSize = true;
            this.lblNameEvent.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNameEvent.Location = new System.Drawing.Point(8, 121);
            this.lblNameEvent.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNameEvent.Name = "lblNameEvent";
            this.lblNameEvent.Size = new System.Drawing.Size(94, 21);
            this.lblNameEvent.TabIndex = 1;
            this.lblNameEvent.Text = "Tên Sự Kiện";
            // 
            // lblValueVoucher
            // 
            this.lblValueVoucher.AutoSize = true;
            this.lblValueVoucher.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValueVoucher.Location = new System.Drawing.Point(8, 72);
            this.lblValueVoucher.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblValueVoucher.Name = "lblValueVoucher";
            this.lblValueVoucher.Size = new System.Drawing.Size(128, 21);
            this.lblValueVoucher.TabIndex = 0;
            this.lblValueVoucher.Text = "Giá Trị Voucher";
            // 
            // txtIdVoucher
            // 
            this.txtIdVoucher.Location = new System.Drawing.Point(173, 38);
            this.txtIdVoucher.Name = "txtIdVoucher";
            this.txtIdVoucher.Size = new System.Drawing.Size(200, 20);
            this.txtIdVoucher.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 35);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 21);
            this.label1.TabIndex = 5;
            this.label1.Text = "Mã Voucher";
            // 
            // txtAmount
            // 
            this.txtAmount.Location = new System.Drawing.Point(598, 36);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(86, 20);
            this.txtAmount.TabIndex = 8;
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAmount.Location = new System.Drawing.Point(481, 35);
            this.lblAmount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(77, 21);
            this.lblAmount.TabIndex = 7;
            this.lblAmount.Text = "Số Lượng";
            // 
            // btnReload
            // 
            this.btnReload.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReload.Location = new System.Drawing.Point(893, 25);
            this.btnReload.Name = "btnReload";
            this.btnReload.Size = new System.Drawing.Size(110, 37);
            this.btnReload.TabIndex = 2;
            this.btnReload.Text = "Làm mới";
            this.btnReload.UseVisualStyleBackColor = true;
            this.btnReload.Click += new System.EventHandler(this.btnReload_Click);
            // 
            // UControlVoucher
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.dgvVoucher);
            this.Controls.Add(this.panel2);
            this.Name = "UControlVoucher";
            this.Size = new System.Drawing.Size(1093, 543);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVoucher)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.gbVoucher.ResumeLayout(false);
            this.gbVoucher.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvVoucher;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.GroupBox gbVoucher;
        private System.Windows.Forms.DateTimePicker dtpDateEnd;
        private System.Windows.Forms.DateTimePicker dtpDateStart;
        private System.Windows.Forms.TextBox txtNameVoucher;
        private System.Windows.Forms.TextBox txtValueVoucher;
        private System.Windows.Forms.Label lblDateEnd;
        private System.Windows.Forms.Label lblDateStart;
        private System.Windows.Forms.Label lblNameEvent;
        private System.Windows.Forms.Label lblValueVoucher;
        private System.Windows.Forms.TextBox txtIdVoucher;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.Button btnReload;
    }
}
