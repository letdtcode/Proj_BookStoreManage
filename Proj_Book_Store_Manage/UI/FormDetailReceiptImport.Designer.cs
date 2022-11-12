
namespace Proj_Book_Store_Manage.UI
{
    partial class FormDetailReceiptImport
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblAnnounce = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label14 = new System.Windows.Forms.Label();
            this.lblIDReceipt = new System.Windows.Forms.Label();
            this.dgvDetailReceiptImport = new System.Windows.Forms.DataGridView();
            this.lblName = new System.Windows.Forms.Label();
            this.lblNameEmployee = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.gbDetailReceiptImport = new System.Windows.Forms.GroupBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblMoney = new System.Windows.Forms.Label();
            this.txtAmountBook = new System.Windows.Forms.TextBox();
            this.lblID = new System.Windows.Forms.Label();
            this.lblAmount = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnReload = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cbbIdBook = new System.Windows.Forms.ComboBox();
            this.lblNameBook = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetailReceiptImport)).BeginInit();
            this.gbDetailReceiptImport.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblAnnounce
            // 
            this.lblAnnounce.AutoSize = true;
            this.lblAnnounce.Font = new System.Drawing.Font("Century Gothic", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnnounce.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.lblAnnounce.Location = new System.Drawing.Point(304, 30);
            this.lblAnnounce.Name = "lblAnnounce";
            this.lblAnnounce.Size = new System.Drawing.Size(372, 39);
            this.lblAnnounce.TabIndex = 0;
            this.lblAnnounce.Text = "Chi Tiết Hóa Đơn Nhập";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Teal;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(960, 10);
            this.panel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Teal;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 10);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(11, 692);
            this.panel2.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Teal;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(11, 692);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(949, 10);
            this.panel3.TabIndex = 3;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Teal;
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(949, 10);
            this.panel4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(11, 682);
            this.panel4.TabIndex = 4;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(466, 92);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(121, 30);
            this.label14.TabIndex = 5;
            this.label14.Text = "Tên Sách";
            // 
            // lblIDReceipt
            // 
            this.lblIDReceipt.AutoSize = true;
            this.lblIDReceipt.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIDReceipt.Location = new System.Drawing.Point(177, 39);
            this.lblIDReceipt.Name = "lblIDReceipt";
            this.lblIDReceipt.Size = new System.Drawing.Size(26, 30);
            this.lblIDReceipt.TabIndex = 6;
            this.lblIDReceipt.Text = "0";
            // 
            // dgvDetailReceiptImport
            // 
            this.dgvDetailReceiptImport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetailReceiptImport.Location = new System.Drawing.Point(111, 353);
            this.dgvDetailReceiptImport.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvDetailReceiptImport.Name = "dgvDetailReceiptImport";
            this.dgvDetailReceiptImport.RowHeadersWidth = 51;
            this.dgvDetailReceiptImport.RowTemplate.Height = 24;
            this.dgvDetailReceiptImport.Size = new System.Drawing.Size(717, 304);
            this.dgvDetailReceiptImport.TabIndex = 7;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(5, 92);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(138, 30);
            this.lblName.TabIndex = 5;
            this.lblName.Text = "Nhân Viên";
            // 
            // lblNameEmployee
            // 
            this.lblNameEmployee.AutoSize = true;
            this.lblNameEmployee.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNameEmployee.Location = new System.Drawing.Point(177, 92);
            this.lblNameEmployee.Name = "lblNameEmployee";
            this.lblNameEmployee.Size = new System.Drawing.Size(78, 30);
            this.lblNameEmployee.TabIndex = 6;
            this.lblNameEmployee.Text = "None";
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(37, 278);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(121, 53);
            this.btnAdd.TabIndex = 9;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // btnEdit
            // 
            this.btnEdit.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.Location = new System.Drawing.Point(189, 278);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(121, 53);
            this.btnEdit.TabIndex = 10;
            this.btnEdit.Text = "Sửa";
            this.btnEdit.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(341, 278);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(121, 53);
            this.btnDelete.TabIndex = 12;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(493, 278);
            this.btnSave.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(121, 53);
            this.btnSave.TabIndex = 13;
            this.btnSave.Text = "Lưu";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // gbDetailReceiptImport
            // 
            this.gbDetailReceiptImport.Controls.Add(this.lblNameBook);
            this.gbDetailReceiptImport.Controls.Add(this.cbbIdBook);
            this.gbDetailReceiptImport.Controls.Add(this.label1);
            this.gbDetailReceiptImport.Controls.Add(this.lblTotal);
            this.gbDetailReceiptImport.Controls.Add(this.lblMoney);
            this.gbDetailReceiptImport.Controls.Add(this.txtAmountBook);
            this.gbDetailReceiptImport.Controls.Add(this.lblID);
            this.gbDetailReceiptImport.Controls.Add(this.label14);
            this.gbDetailReceiptImport.Controls.Add(this.lblAmount);
            this.gbDetailReceiptImport.Controls.Add(this.lblName);
            this.gbDetailReceiptImport.Controls.Add(this.lblIDReceipt);
            this.gbDetailReceiptImport.Controls.Add(this.lblNameEmployee);
            this.gbDetailReceiptImport.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbDetailReceiptImport.Location = new System.Drawing.Point(63, 84);
            this.gbDetailReceiptImport.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbDetailReceiptImport.Name = "gbDetailReceiptImport";
            this.gbDetailReceiptImport.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbDetailReceiptImport.Size = new System.Drawing.Size(835, 188);
            this.gbDetailReceiptImport.TabIndex = 14;
            this.gbDetailReceiptImport.TabStop = false;
            this.gbDetailReceiptImport.Text = "Thông tin hóa đơn nhập";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(144, 147);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(26, 30);
            this.lblTotal.TabIndex = 15;
            this.lblTotal.Text = "0";
            // 
            // lblMoney
            // 
            this.lblMoney.AutoSize = true;
            this.lblMoney.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMoney.Location = new System.Drawing.Point(5, 146);
            this.lblMoney.Name = "lblMoney";
            this.lblMoney.Size = new System.Drawing.Size(119, 30);
            this.lblMoney.TabIndex = 16;
            this.lblMoney.Text = "Tổng tiền";
            // 
            // txtAmountBook
            // 
            this.txtAmountBook.Location = new System.Drawing.Point(603, 148);
            this.txtAmountBook.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtAmountBook.Name = "txtAmountBook";
            this.txtAmountBook.Size = new System.Drawing.Size(185, 28);
            this.txtAmountBook.TabIndex = 7;
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblID.Location = new System.Drawing.Point(5, 39);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(158, 30);
            this.lblID.TabIndex = 5;
            this.lblID.Text = "Mã hóa đơn";
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAmount.Location = new System.Drawing.Point(466, 145);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(115, 30);
            this.lblAmount.TabIndex = 5;
            this.lblAmount.Text = "Số Lượng";
            // 
            // btnExit
            // 
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Century Gothic", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.Teal;
            this.btnExit.Location = new System.Drawing.Point(877, 16);
            this.btnExit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(67, 48);
            this.btnExit.TabIndex = 15;
            this.btnExit.Text = "X";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            this.btnExit.MouseEnter += new System.EventHandler(this.btnExit_MouseEnter);
            // 
            // btnReload
            // 
            this.btnReload.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReload.Location = new System.Drawing.Point(797, 278);
            this.btnReload.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnReload.Name = "btnReload";
            this.btnReload.Size = new System.Drawing.Size(121, 53);
            this.btnReload.TabIndex = 8;
            this.btnReload.Text = "Tải lại";
            this.btnReload.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(645, 278);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(121, 53);
            this.btnCancel.TabIndex = 11;
            this.btnCancel.Text = "Hủy";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(471, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 21);
            this.label1.TabIndex = 17;
            this.label1.Text = "Mã sách";
            // 
            // cbbIdBook
            // 
            this.cbbIdBook.FormattingEnabled = true;
            this.cbbIdBook.Location = new System.Drawing.Point(603, 39);
            this.cbbIdBook.Name = "cbbIdBook";
            this.cbbIdBook.Size = new System.Drawing.Size(121, 29);
            this.cbbIdBook.TabIndex = 18;
            // 
            // lblNameBook
            // 
            this.lblNameBook.AutoSize = true;
            this.lblNameBook.Location = new System.Drawing.Point(603, 104);
            this.lblNameBook.Name = "lblNameBook";
            this.lblNameBook.Size = new System.Drawing.Size(55, 21);
            this.lblNameBook.TabIndex = 19;
            this.lblNameBook.Text = "None";
            // 
            // FormDetailReceiptImport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(960, 702);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.gbDetailReceiptImport);
            this.Controls.Add(this.btnReload);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.dgvDetailReceiptImport);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblAnnounce);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormDetailReceiptImport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FormDetailReceiptImport";
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetailReceiptImport)).EndInit();
            this.gbDetailReceiptImport.ResumeLayout(false);
            this.gbDetailReceiptImport.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAnnounce;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label lblIDReceipt;
        private System.Windows.Forms.DataGridView dgvDetailReceiptImport;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblNameEmployee;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.GroupBox gbDetailReceiptImport;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.TextBox txtAmountBook;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblMoney;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnReload;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.ComboBox cbbIdBook;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblNameBook;
    }
}