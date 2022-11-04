
namespace Proj_Book_Store_Manage.UI
{
    partial class UControlTypeCustomer
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
            this.txtValue = new System.Windows.Forms.TextBox();
            this.lblValueType = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnReload = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.dgvTypeCustomer = new System.Windows.Forms.DataGridView();
            this.txtTypeCustomer = new System.Windows.Forms.TextBox();
            this.lblPointMark = new System.Windows.Forms.Label();
            this.txtPointMark = new System.Windows.Forms.TextBox();
            this.gbTypeCustomer = new System.Windows.Forms.GroupBox();
            this.lblNameTypeCus = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.cbAttributeSearch = new System.Windows.Forms.ComboBox();
            this.lblSearchBy = new System.Windows.Forms.Label();
            this.gpSearch = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTypeCustomer)).BeginInit();
            this.gbTypeCustomer.SuspendLayout();
            this.gpSearch.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtValue
            // 
            this.txtValue.Location = new System.Drawing.Point(523, 94);
            this.txtValue.Name = "txtValue";
            this.txtValue.Size = new System.Drawing.Size(162, 22);
            this.txtValue.TabIndex = 2;
            // 
            // lblValueType
            // 
            this.lblValueType.AutoSize = true;
            this.lblValueType.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValueType.Location = new System.Drawing.Point(353, 92);
            this.lblValueType.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblValueType.Name = "lblValueType";
            this.lblValueType.Size = new System.Drawing.Size(166, 23);
            this.lblValueType.TabIndex = 1;
            this.lblValueType.Text = "Giá trị chiết khấu";
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
            this.panel2.Location = new System.Drawing.Point(866, 193);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(206, 375);
            this.panel2.TabIndex = 10;
            // 
            // btnReload
            // 
            this.btnReload.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReload.Location = new System.Drawing.Point(54, 302);
            this.btnReload.Name = "btnReload";
            this.btnReload.Size = new System.Drawing.Size(121, 53);
            this.btnReload.TabIndex = 1;
            this.btnReload.Text = "Tải lại";
            this.btnReload.UseVisualStyleBackColor = true;
            this.btnReload.Click += new System.EventHandler(this.btnReload_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(54, 7);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(121, 53);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.Location = new System.Drawing.Point(54, 66);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(121, 53);
            this.btnEdit.TabIndex = 1;
            this.btnEdit.Text = "Sửa";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(54, 243);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(121, 53);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "Hủy";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(54, 125);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(121, 53);
            this.btnDelete.TabIndex = 1;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(54, 184);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(121, 53);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "Lưu";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // dgvTypeCustomer
            // 
            this.dgvTypeCustomer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTypeCustomer.Location = new System.Drawing.Point(29, 241);
            this.dgvTypeCustomer.Name = "dgvTypeCustomer";
            this.dgvTypeCustomer.ReadOnly = true;
            this.dgvTypeCustomer.RowHeadersWidth = 51;
            this.dgvTypeCustomer.RowTemplate.Height = 24;
            this.dgvTypeCustomer.Size = new System.Drawing.Size(721, 280);
            this.dgvTypeCustomer.TabIndex = 11;
            this.dgvTypeCustomer.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTypeCustomer_CellClick);
            // 
            // txtTypeCustomer
            // 
            this.txtTypeCustomer.Location = new System.Drawing.Point(139, 98);
            this.txtTypeCustomer.Name = "txtTypeCustomer";
            this.txtTypeCustomer.Size = new System.Drawing.Size(146, 22);
            this.txtTypeCustomer.TabIndex = 2;
            // 
            // lblPointMark
            // 
            this.lblPointMark.AutoSize = true;
            this.lblPointMark.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPointMark.Location = new System.Drawing.Point(353, 57);
            this.lblPointMark.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPointMark.Name = "lblPointMark";
            this.lblPointMark.Size = new System.Drawing.Size(102, 23);
            this.lblPointMark.TabIndex = 1;
            this.lblPointMark.Text = "Điểm Mốc";
            // 
            // txtPointMark
            // 
            this.txtPointMark.Location = new System.Drawing.Point(523, 58);
            this.txtPointMark.Name = "txtPointMark";
            this.txtPointMark.Size = new System.Drawing.Size(162, 22);
            this.txtPointMark.TabIndex = 2;
            // 
            // gbTypeCustomer
            // 
            this.gbTypeCustomer.Controls.Add(this.txtValue);
            this.gbTypeCustomer.Controls.Add(this.txtPointMark);
            this.gbTypeCustomer.Controls.Add(this.txtTypeCustomer);
            this.gbTypeCustomer.Controls.Add(this.lblValueType);
            this.gbTypeCustomer.Controls.Add(this.lblPointMark);
            this.gbTypeCustomer.Controls.Add(this.lblID);
            this.gbTypeCustomer.Controls.Add(this.label1);
            this.gbTypeCustomer.Controls.Add(this.lblNameTypeCus);
            this.gbTypeCustomer.Location = new System.Drawing.Point(17, 21);
            this.gbTypeCustomer.Margin = new System.Windows.Forms.Padding(4);
            this.gbTypeCustomer.Name = "gbTypeCustomer";
            this.gbTypeCustomer.Padding = new System.Windows.Forms.Padding(4);
            this.gbTypeCustomer.Size = new System.Drawing.Size(717, 147);
            this.gbTypeCustomer.TabIndex = 0;
            this.gbTypeCustomer.TabStop = false;
            this.gbTypeCustomer.Text = "Thông tin loại khách hàng";
            // 
            // lblNameTypeCus
            // 
            this.lblNameTypeCus.AutoSize = true;
            this.lblNameTypeCus.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNameTypeCus.Location = new System.Drawing.Point(8, 98);
            this.lblNameTypeCus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNameTypeCus.Name = "lblNameTypeCus";
            this.lblNameTypeCus.Size = new System.Drawing.Size(115, 23);
            this.lblNameTypeCus.TabIndex = 0;
            this.lblNameTypeCus.Text = "Tên Loại KH";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(47, 83);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(224, 22);
            this.txtSearch.TabIndex = 2;
            // 
            // cbAttributeSearch
            // 
            this.cbAttributeSearch.FormattingEnabled = true;
            this.cbAttributeSearch.Location = new System.Drawing.Point(138, 27);
            this.cbAttributeSearch.Name = "cbAttributeSearch";
            this.cbAttributeSearch.Size = new System.Drawing.Size(121, 24);
            this.cbAttributeSearch.TabIndex = 1;
            // 
            // lblSearchBy
            // 
            this.lblSearchBy.AutoSize = true;
            this.lblSearchBy.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearchBy.Location = new System.Drawing.Point(7, 30);
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
            this.gpSearch.Location = new System.Drawing.Point(762, 33);
            this.gpSearch.Name = "gpSearch";
            this.gpSearch.Size = new System.Drawing.Size(293, 125);
            this.gpSearch.TabIndex = 1;
            this.gpSearch.TabStop = false;
            this.gpSearch.Text = "Tìm kiếm";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.gpSearch);
            this.panel1.Controls.Add(this.gbTypeCustomer);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1072, 193);
            this.panel1.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 57);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID Loại KH:";
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblID.Location = new System.Drawing.Point(135, 59);
            this.lblID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(21, 23);
            this.lblID.TabIndex = 0;
            this.lblID.Text = "0";
            // 
            // UControlTypeCustomer
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.dgvTypeCustomer);
            this.Controls.Add(this.panel1);
            this.Name = "UControlTypeCustomer";
            this.Size = new System.Drawing.Size(1072, 568);
            this.Load += new System.EventHandler(this.UControlTypeCustomer_Load);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTypeCustomer)).EndInit();
            this.gbTypeCustomer.ResumeLayout(false);
            this.gbTypeCustomer.PerformLayout();
            this.gpSearch.ResumeLayout(false);
            this.gpSearch.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtValue;
        private System.Windows.Forms.Label lblValueType;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnReload;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.DataGridView dgvTypeCustomer;
        private System.Windows.Forms.TextBox txtTypeCustomer;
        private System.Windows.Forms.Label lblPointMark;
        private System.Windows.Forms.TextBox txtPointMark;
        private System.Windows.Forms.GroupBox gbTypeCustomer;
        private System.Windows.Forms.Label lblNameTypeCus;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.ComboBox cbAttributeSearch;
        private System.Windows.Forms.Label lblSearchBy;
        private System.Windows.Forms.GroupBox gpSearch;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label label1;
    }
}
