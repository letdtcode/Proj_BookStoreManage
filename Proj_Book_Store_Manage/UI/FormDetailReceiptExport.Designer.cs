
namespace Proj_Book_Store_Manage.UI
{
    partial class FormDetailReceiptExport
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
            this.cbNameBook = new System.Windows.Forms.ComboBox();
            this.lblID = new System.Windows.Forms.Label();
            this.lblAmount = new System.Windows.Forms.Label();
            this.gbDetailReceiptExport = new System.Windows.Forms.GroupBox();
            this.txtAmountBook = new System.Windows.Forms.TextBox();
            this.lblNameBook = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblMoney = new System.Windows.Forms.Label();
            this.lblCustomer = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblIDReceipt = new System.Windows.Forms.Label();
            this.lblNameCustomer = new System.Windows.Forms.Label();
            this.lblNameEmployee = new System.Windows.Forms.Label();
            this.btnReload = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.dgvDetailReceiptImport = new System.Windows.Forms.DataGridView();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblAnnounce = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.gbDetailReceiptExport.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetailReceiptImport)).BeginInit();
            this.SuspendLayout();
            // 
            // cbNameBook
            // 
            this.cbNameBook.FormattingEnabled = true;
            this.cbNameBook.Location = new System.Drawing.Point(600, 34);
            this.cbNameBook.Name = "cbNameBook";
            this.cbNameBook.Size = new System.Drawing.Size(186, 29);
            this.cbNameBook.TabIndex = 8;
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblID.Location = new System.Drawing.Point(6, 37);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(158, 30);
            this.lblID.TabIndex = 5;
            this.lblID.Text = "Mã hóa đơn";
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAmount.Location = new System.Drawing.Point(463, 86);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(115, 30);
            this.lblAmount.TabIndex = 5;
            this.lblAmount.Text = "Số Lượng";
            // 
            // gbDetailReceiptExport
            // 
            this.gbDetailReceiptExport.Controls.Add(this.cbNameBook);
            this.gbDetailReceiptExport.Controls.Add(this.txtAmountBook);
            this.gbDetailReceiptExport.Controls.Add(this.lblID);
            this.gbDetailReceiptExport.Controls.Add(this.lblNameBook);
            this.gbDetailReceiptExport.Controls.Add(this.lblTotal);
            this.gbDetailReceiptExport.Controls.Add(this.lblMoney);
            this.gbDetailReceiptExport.Controls.Add(this.lblAmount);
            this.gbDetailReceiptExport.Controls.Add(this.lblCustomer);
            this.gbDetailReceiptExport.Controls.Add(this.lblName);
            this.gbDetailReceiptExport.Controls.Add(this.lblIDReceipt);
            this.gbDetailReceiptExport.Controls.Add(this.lblNameCustomer);
            this.gbDetailReceiptExport.Controls.Add(this.lblNameEmployee);
            this.gbDetailReceiptExport.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbDetailReceiptExport.Location = new System.Drawing.Point(68, 91);
            this.gbDetailReceiptExport.Name = "gbDetailReceiptExport";
            this.gbDetailReceiptExport.Size = new System.Drawing.Size(835, 188);
            this.gbDetailReceiptExport.TabIndex = 27;
            this.gbDetailReceiptExport.TabStop = false;
            this.gbDetailReceiptExport.Text = "Thông tin hóa đơn xuất";
            // 
            // txtAmountBook
            // 
            this.txtAmountBook.Location = new System.Drawing.Point(600, 89);
            this.txtAmountBook.Name = "txtAmountBook";
            this.txtAmountBook.Size = new System.Drawing.Size(186, 28);
            this.txtAmountBook.TabIndex = 7;
            // 
            // lblNameBook
            // 
            this.lblNameBook.AutoSize = true;
            this.lblNameBook.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNameBook.Location = new System.Drawing.Point(463, 33);
            this.lblNameBook.Name = "lblNameBook";
            this.lblNameBook.Size = new System.Drawing.Size(121, 30);
            this.lblNameBook.TabIndex = 5;
            this.lblNameBook.Text = "Tên Sách";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(595, 135);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(26, 30);
            this.lblTotal.TabIndex = 5;
            this.lblTotal.Text = "0";
            // 
            // lblMoney
            // 
            this.lblMoney.AutoSize = true;
            this.lblMoney.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMoney.Location = new System.Drawing.Point(463, 135);
            this.lblMoney.Name = "lblMoney";
            this.lblMoney.Size = new System.Drawing.Size(119, 30);
            this.lblMoney.TabIndex = 5;
            this.lblMoney.Text = "Tổng tiền";
            // 
            // lblCustomer
            // 
            this.lblCustomer.AutoSize = true;
            this.lblCustomer.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomer.Location = new System.Drawing.Point(5, 135);
            this.lblCustomer.Name = "lblCustomer";
            this.lblCustomer.Size = new System.Drawing.Size(159, 30);
            this.lblCustomer.TabIndex = 5;
            this.lblCustomer.Text = "Khách Hàng";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(6, 86);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(138, 30);
            this.lblName.TabIndex = 5;
            this.lblName.Text = "Nhân Viên";
            // 
            // lblIDReceipt
            // 
            this.lblIDReceipt.AutoSize = true;
            this.lblIDReceipt.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIDReceipt.Location = new System.Drawing.Point(177, 37);
            this.lblIDReceipt.Name = "lblIDReceipt";
            this.lblIDReceipt.Size = new System.Drawing.Size(26, 30);
            this.lblIDReceipt.TabIndex = 6;
            this.lblIDReceipt.Text = "0";
            // 
            // lblNameCustomer
            // 
            this.lblNameCustomer.AutoSize = true;
            this.lblNameCustomer.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNameCustomer.Location = new System.Drawing.Point(177, 135);
            this.lblNameCustomer.Name = "lblNameCustomer";
            this.lblNameCustomer.Size = new System.Drawing.Size(238, 30);
            this.lblNameCustomer.TabIndex = 6;
            this.lblNameCustomer.Text = "Nguyễn Đức Thành";
            // 
            // lblNameEmployee
            // 
            this.lblNameEmployee.AutoSize = true;
            this.lblNameEmployee.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNameEmployee.Location = new System.Drawing.Point(177, 86);
            this.lblNameEmployee.Name = "lblNameEmployee";
            this.lblNameEmployee.Size = new System.Drawing.Size(238, 30);
            this.lblNameEmployee.TabIndex = 6;
            this.lblNameEmployee.Text = "Nguyễn Đức Thành";
            // 
            // btnReload
            // 
            this.btnReload.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReload.Location = new System.Drawing.Point(798, 294);
            this.btnReload.Name = "btnReload";
            this.btnReload.Size = new System.Drawing.Size(121, 53);
            this.btnReload.TabIndex = 21;
            this.btnReload.Text = "Tải lại";
            this.btnReload.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(38, 294);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(121, 53);
            this.btnAdd.TabIndex = 22;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // btnEdit
            // 
            this.btnEdit.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.Location = new System.Drawing.Point(190, 294);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(121, 53);
            this.btnEdit.TabIndex = 23;
            this.btnEdit.Text = "Sửa";
            this.btnEdit.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(646, 294);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(121, 53);
            this.btnCancel.TabIndex = 24;
            this.btnCancel.Text = "Hủy";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(342, 294);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(121, 53);
            this.btnDelete.TabIndex = 25;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(494, 294);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(121, 53);
            this.btnSave.TabIndex = 26;
            this.btnSave.Text = "Lưu";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // dgvDetailReceiptImport
            // 
            this.dgvDetailReceiptImport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetailReceiptImport.Location = new System.Drawing.Point(121, 362);
            this.dgvDetailReceiptImport.Name = "dgvDetailReceiptImport";
            this.dgvDetailReceiptImport.RowHeadersWidth = 51;
            this.dgvDetailReceiptImport.RowTemplate.Height = 24;
            this.dgvDetailReceiptImport.Size = new System.Drawing.Size(718, 304);
            this.dgvDetailReceiptImport.TabIndex = 20;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Teal;
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(950, 10);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(10, 681);
            this.panel4.TabIndex = 19;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Teal;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(10, 691);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(950, 10);
            this.panel3.TabIndex = 18;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Teal;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 10);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(10, 691);
            this.panel2.TabIndex = 17;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Teal;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(960, 10);
            this.panel1.TabIndex = 16;
            // 
            // lblAnnounce
            // 
            this.lblAnnounce.AutoSize = true;
            this.lblAnnounce.Font = new System.Drawing.Font("Century Gothic", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnnounce.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.lblAnnounce.Location = new System.Drawing.Point(314, 34);
            this.lblAnnounce.Name = "lblAnnounce";
            this.lblAnnounce.Size = new System.Drawing.Size(358, 39);
            this.lblAnnounce.TabIndex = 15;
            this.lblAnnounce.Text = "Chi Tiết Hóa Đơn Xuất";
            // 
            // btnExit
            // 
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Century Gothic", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.Teal;
            this.btnExit.Location = new System.Drawing.Point(878, 16);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(66, 48);
            this.btnExit.TabIndex = 28;
            this.btnExit.Text = "X";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // FormDetailReceiptExport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(960, 701);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.gbDetailReceiptExport);
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
            this.Name = "FormDetailReceiptExport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FormDetailReceiptExport";
            this.gbDetailReceiptExport.ResumeLayout(false);
            this.gbDetailReceiptExport.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetailReceiptImport)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbNameBook;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.GroupBox gbDetailReceiptExport;
        private System.Windows.Forms.TextBox txtAmountBook;
        private System.Windows.Forms.Label lblNameBook;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblIDReceipt;
        private System.Windows.Forms.Label lblNameEmployee;
        private System.Windows.Forms.Button btnReload;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.DataGridView dgvDetailReceiptImport;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblAnnounce;
        private System.Windows.Forms.Label lblCustomer;
        private System.Windows.Forms.Label lblNameCustomer;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblMoney;
        private System.Windows.Forms.Button btnExit;
    }
}