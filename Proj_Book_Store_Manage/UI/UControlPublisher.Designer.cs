
namespace Proj_Book_Store_Manage.UI
{
    partial class UControlPublisher
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
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.lblSearchBy = new System.Windows.Forms.Label();
            this.gpSearch = new System.Windows.Forms.GroupBox();
            this.cbAttributeSearch = new System.Windows.Forms.ComboBox();
            this.dgvPublisher = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnReload = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtPhoneNumber = new System.Windows.Forms.TextBox();
            this.txtNamePublisher = new System.Windows.Forms.TextBox();
            this.lblPhoneNumber = new System.Windows.Forms.Label();
            this.lblNamePublisher = new System.Windows.Forms.Label();
            this.gbPublisher = new System.Windows.Forms.GroupBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblIDPublisher = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.gpSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPublisher)).BeginInit();
            this.panel2.SuspendLayout();
            this.gbPublisher.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(91, 131);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(224, 22);
            this.txtSearch.TabIndex = 2;
            // 
            // lblSearchBy
            // 
            this.lblSearchBy.AutoSize = true;
            this.lblSearchBy.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearchBy.Location = new System.Drawing.Point(24, 57);
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
            this.gpSearch.Location = new System.Drawing.Point(668, 21);
            this.gpSearch.Name = "gpSearch";
            this.gpSearch.Size = new System.Drawing.Size(384, 180);
            this.gpSearch.TabIndex = 1;
            this.gpSearch.TabStop = false;
            this.gpSearch.Text = "Tìm kiếm";
            // 
            // cbAttributeSearch
            // 
            this.cbAttributeSearch.FormattingEnabled = true;
            this.cbAttributeSearch.Location = new System.Drawing.Point(173, 51);
            this.cbAttributeSearch.Name = "cbAttributeSearch";
            this.cbAttributeSearch.Size = new System.Drawing.Size(121, 24);
            this.cbAttributeSearch.TabIndex = 1;
            // 
            // dgvPublisher
            // 
            this.dgvPublisher.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPublisher.Location = new System.Drawing.Point(30, 259);
            this.dgvPublisher.Name = "dgvPublisher";
            this.dgvPublisher.ReadOnly = true;
            this.dgvPublisher.RowHeadersWidth = 51;
            this.dgvPublisher.RowTemplate.Height = 24;
            this.dgvPublisher.Size = new System.Drawing.Size(721, 280);
            this.dgvPublisher.TabIndex = 5;
            this.dgvPublisher.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPublisher_CellClick);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnReload);
            this.panel2.Controls.Add(this.btnAdd);
            this.panel2.Controls.Add(this.btnEdit);
            this.panel2.Controls.Add(this.btnCancel);
            this.panel2.Controls.Add(this.btnDelete);
            this.panel2.Controls.Add(this.btnSave);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(849, 208);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(206, 355);
            this.panel2.TabIndex = 4;
            // 
            // btnReload
            // 
            this.btnReload.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReload.Location = new System.Drawing.Point(52, 312);
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
            this.btnAdd.Location = new System.Drawing.Point(52, 17);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(110, 43);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.Location = new System.Drawing.Point(52, 76);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(110, 43);
            this.btnEdit.TabIndex = 1;
            this.btnEdit.Text = "Sửa";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(52, 253);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(110, 43);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "Hủy";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(52, 135);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(110, 43);
            this.btnDelete.TabIndex = 1;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(52, 194);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(110, 43);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "Lưu";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.Location = new System.Drawing.Point(422, 111);
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.Size = new System.Drawing.Size(175, 22);
            this.txtPhoneNumber.TabIndex = 2;
            // 
            // txtNamePublisher
            // 
            this.txtNamePublisher.Location = new System.Drawing.Point(107, 115);
            this.txtNamePublisher.Name = "txtNamePublisher";
            this.txtNamePublisher.Size = new System.Drawing.Size(91, 22);
            this.txtNamePublisher.TabIndex = 2;
            // 
            // lblPhoneNumber
            // 
            this.lblPhoneNumber.AutoSize = true;
            this.lblPhoneNumber.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhoneNumber.Location = new System.Drawing.Point(313, 112);
            this.lblPhoneNumber.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPhoneNumber.Name = "lblPhoneNumber";
            this.lblPhoneNumber.Size = new System.Drawing.Size(44, 23);
            this.lblPhoneNumber.TabIndex = 1;
            this.lblPhoneNumber.Text = "SĐT";
            // 
            // lblNamePublisher
            // 
            this.lblNamePublisher.AutoSize = true;
            this.lblNamePublisher.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNamePublisher.Location = new System.Drawing.Point(8, 112);
            this.lblNamePublisher.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNamePublisher.Name = "lblNamePublisher";
            this.lblNamePublisher.Size = new System.Drawing.Size(87, 23);
            this.lblNamePublisher.TabIndex = 0;
            this.lblNamePublisher.Text = "Tên NXB";
            // 
            // gbPublisher
            // 
            this.gbPublisher.Controls.Add(this.txtAddress);
            this.gbPublisher.Controls.Add(this.txtPhoneNumber);
            this.gbPublisher.Controls.Add(this.txtNamePublisher);
            this.gbPublisher.Controls.Add(this.lblPhoneNumber);
            this.gbPublisher.Controls.Add(this.lblAddress);
            this.gbPublisher.Controls.Add(this.lblIDPublisher);
            this.gbPublisher.Controls.Add(this.label1);
            this.gbPublisher.Controls.Add(this.lblNamePublisher);
            this.gbPublisher.Location = new System.Drawing.Point(30, 21);
            this.gbPublisher.Margin = new System.Windows.Forms.Padding(4);
            this.gbPublisher.Name = "gbPublisher";
            this.gbPublisher.Padding = new System.Windows.Forms.Padding(4);
            this.gbPublisher.Size = new System.Drawing.Size(620, 180);
            this.gbPublisher.TabIndex = 0;
            this.gbPublisher.TabStop = false;
            this.gbPublisher.Text = "Thông tin nhà xuất bản";
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(422, 51);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(175, 22);
            this.txtAddress.TabIndex = 2;
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddress.Location = new System.Drawing.Point(313, 52);
            this.lblAddress.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(79, 23);
            this.lblAddress.TabIndex = 0;
            this.lblAddress.Text = "Địa chỉ";
            // 
            // lblIDPublisher
            // 
            this.lblIDPublisher.AutoSize = true;
            this.lblIDPublisher.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIDPublisher.Location = new System.Drawing.Point(103, 48);
            this.lblIDPublisher.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIDPublisher.Name = "lblIDPublisher";
            this.lblIDPublisher.Size = new System.Drawing.Size(21, 23);
            this.lblIDPublisher.TabIndex = 0;
            this.lblIDPublisher.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 48);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã NXB";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.gpSearch);
            this.panel1.Controls.Add(this.gbPublisher);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1055, 208);
            this.panel1.TabIndex = 3;
            // 
            // UControlPublisher
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.dgvPublisher);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "UControlPublisher";
            this.Size = new System.Drawing.Size(1055, 563);
            this.Load += new System.EventHandler(this.UControlPublisher_Load);
            this.gpSearch.ResumeLayout(false);
            this.gpSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPublisher)).EndInit();
            this.panel2.ResumeLayout(false);
            this.gbPublisher.ResumeLayout(false);
            this.gbPublisher.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label lblSearchBy;
        private System.Windows.Forms.GroupBox gpSearch;
        private System.Windows.Forms.ComboBox cbAttributeSearch;
        private System.Windows.Forms.DataGridView dgvPublisher;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnReload;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtPhoneNumber;
        private System.Windows.Forms.TextBox txtNamePublisher;
        private System.Windows.Forms.Label lblPhoneNumber;
        private System.Windows.Forms.Label lblNamePublisher;
        private System.Windows.Forms.GroupBox gbPublisher;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label lblIDPublisher;
        private System.Windows.Forms.Label label1;
    }
}
