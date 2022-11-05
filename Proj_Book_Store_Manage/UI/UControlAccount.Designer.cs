
namespace Proj_Book_Store_Manage.UI
{
    partial class UControlAccount
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnReload = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.dgvAuthor = new System.Windows.Forms.DataGridView();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblUserName = new System.Windows.Forms.Label();
            this.gbAccount = new System.Windows.Forms.GroupBox();
            this.cbTypeAcc = new System.Windows.Forms.ComboBox();
            this.cbEmployee = new System.Windows.Forms.ComboBox();
            this.lblEmployee = new System.Windows.Forms.Label();
            this.lblTypeAcc = new System.Windows.Forms.Label();
            this.lblIDAcount = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnShowResult = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAuthor)).BeginInit();
            this.gbAccount.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
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
            this.panel2.Location = new System.Drawing.Point(903, 276);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(169, 371);
            this.panel2.TabIndex = 4;
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
            // dgvAuthor
            // 
            this.dgvAuthor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAuthor.Location = new System.Drawing.Point(30, 293);
            this.dgvAuthor.Name = "dgvAuthor";
            this.dgvAuthor.ReadOnly = true;
            this.dgvAuthor.RowHeadersWidth = 51;
            this.dgvAuthor.RowTemplate.Height = 24;
            this.dgvAuthor.Size = new System.Drawing.Size(721, 280);
            this.dgvAuthor.TabIndex = 5;
            this.dgvAuthor.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAuthor_CellClick);
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(188, 175);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(247, 22);
            this.txtPassword.TabIndex = 2;
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(188, 114);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(247, 22);
            this.txtUserName.TabIndex = 2;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.Location = new System.Drawing.Point(21, 174);
            this.lblPassword.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(94, 23);
            this.lblPassword.TabIndex = 1;
            this.lblPassword.Text = "Mật Khẩu";
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserName.Location = new System.Drawing.Point(21, 113);
            this.lblUserName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(160, 23);
            this.lblUserName.TabIndex = 0;
            this.lblUserName.Text = "Tên Đăng Nhập";
            // 
            // gbAccount
            // 
            this.gbAccount.Controls.Add(this.cbTypeAcc);
            this.gbAccount.Controls.Add(this.cbEmployee);
            this.gbAccount.Controls.Add(this.txtPassword);
            this.gbAccount.Controls.Add(this.txtUserName);
            this.gbAccount.Controls.Add(this.lblEmployee);
            this.gbAccount.Controls.Add(this.lblTypeAcc);
            this.gbAccount.Controls.Add(this.lblPassword);
            this.gbAccount.Controls.Add(this.lblIDAcount);
            this.gbAccount.Controls.Add(this.label1);
            this.gbAccount.Controls.Add(this.lblID);
            this.gbAccount.Controls.Add(this.lblUserName);
            this.gbAccount.Location = new System.Drawing.Point(30, 21);
            this.gbAccount.Margin = new System.Windows.Forms.Padding(4);
            this.gbAccount.Name = "gbAccount";
            this.gbAccount.Padding = new System.Windows.Forms.Padding(4);
            this.gbAccount.Size = new System.Drawing.Size(874, 224);
            this.gbAccount.TabIndex = 0;
            this.gbAccount.TabStop = false;
            this.gbAccount.Text = "Thông tin tác giả";
            // 
            // cbTypeAcc
            // 
            this.cbTypeAcc.FormattingEnabled = true;
            this.cbTypeAcc.Items.AddRange(new object[] {
            "Admin",
            "Nhân Viên"});
            this.cbTypeAcc.Location = new System.Drawing.Point(653, 77);
            this.cbTypeAcc.Name = "cbTypeAcc";
            this.cbTypeAcc.Size = new System.Drawing.Size(136, 24);
            this.cbTypeAcc.TabIndex = 4;
            // 
            // cbEmployee
            // 
            this.cbEmployee.FormattingEnabled = true;
            this.cbEmployee.Items.AddRange(new object[] {
            "1"});
            this.cbEmployee.Location = new System.Drawing.Point(653, 123);
            this.cbEmployee.Name = "cbEmployee";
            this.cbEmployee.Size = new System.Drawing.Size(136, 24);
            this.cbEmployee.TabIndex = 3;
            // 
            // lblEmployee
            // 
            this.lblEmployee.AutoSize = true;
            this.lblEmployee.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmployee.Location = new System.Drawing.Point(497, 125);
            this.lblEmployee.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEmployee.Name = "lblEmployee";
            this.lblEmployee.Size = new System.Drawing.Size(112, 23);
            this.lblEmployee.TabIndex = 1;
            this.lblEmployee.Text = "Nhân Viên";
            // 
            // lblTypeAcc
            // 
            this.lblTypeAcc.AutoSize = true;
            this.lblTypeAcc.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTypeAcc.Location = new System.Drawing.Point(497, 79);
            this.lblTypeAcc.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTypeAcc.Name = "lblTypeAcc";
            this.lblTypeAcc.Size = new System.Drawing.Size(139, 23);
            this.lblTypeAcc.TabIndex = 1;
            this.lblTypeAcc.Text = "Loại Tài Khoản";
            // 
            // lblIDAcount
            // 
            this.lblIDAcount.AutoSize = true;
            this.lblIDAcount.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIDAcount.Location = new System.Drawing.Point(184, 54);
            this.lblIDAcount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIDAcount.Name = "lblIDAcount";
            this.lblIDAcount.Size = new System.Drawing.Size(0, 23);
            this.lblIDAcount.TabIndex = 0;
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblID.Location = new System.Drawing.Point(21, 54);
            this.lblID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(121, 23);
            this.lblID.TabIndex = 0;
            this.lblID.Text = "ID Account";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnShowResult);
            this.panel1.Controls.Add(this.btnSearch);
            this.panel1.Controls.Add(this.gbAccount);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1072, 276);
            this.panel1.TabIndex = 3;
            // 
            // btnShowResult
            // 
            this.btnShowResult.Location = new System.Drawing.Point(927, 178);
            this.btnShowResult.Name = "btnShowResult";
            this.btnShowResult.Size = new System.Drawing.Size(84, 40);
            this.btnShowResult.TabIndex = 3;
            this.btnShowResult.Text = "Show";
            this.btnShowResult.UseVisualStyleBackColor = true;
            this.btnShowResult.Click += new System.EventHandler(this.btnShowResult_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(927, 92);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(84, 45);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(184, 54);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID Account";
            // 
            // UControlAccount
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.Silver;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.dgvAuthor);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "UControlAccount";
            this.Size = new System.Drawing.Size(1072, 647);
            this.Load += new System.EventHandler(this.UControlAccount_Load);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAuthor)).EndInit();
            this.gbAccount.ResumeLayout(false);
            this.gbAccount.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnReload;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.GroupBox gbAccount;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cbTypeAcc;
        private System.Windows.Forms.ComboBox cbEmployee;
        private System.Windows.Forms.Label lblEmployee;
        private System.Windows.Forms.Label lblTypeAcc;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Button btnShowResult;
        private System.Windows.Forms.Label lblIDAcount;
        private System.Windows.Forms.DataGridView dgvAuthor;
        private System.Windows.Forms.Label label1;
    }
}
