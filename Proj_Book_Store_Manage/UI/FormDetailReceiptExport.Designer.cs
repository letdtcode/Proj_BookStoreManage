
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
            this.lblID = new System.Windows.Forms.Label();
            this.lblAmount = new System.Windows.Forms.Label();
            this.gbDetailReceiptExport = new System.Windows.Forms.GroupBox();
            this.lblCustomer = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblIDReceipt = new System.Windows.Forms.Label();
            this.lblMoney = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblNameCustomer = new System.Windows.Forms.Label();
            this.lblNameEmployee = new System.Windows.Forms.Label();
            this.txtAmountBook = new System.Windows.Forms.TextBox();
            this.lblBook = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.dgvListBook = new System.Windows.Forms.DataGridView();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblAnnounce = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.lViewCart = new System.Windows.Forms.ListView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblNameBook = new System.Windows.Forms.Label();
            this.ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.NameBook = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Price = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnEdit = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnDelete = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.lblIDBook = new System.Windows.Forms.Label();
            this.gbDetailReceiptExport.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListBook)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
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
            this.lblAmount.Location = new System.Drawing.Point(20, 119);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(115, 30);
            this.lblAmount.TabIndex = 5;
            this.lblAmount.Text = "Số Lượng";
            // 
            // gbDetailReceiptExport
            // 
            this.gbDetailReceiptExport.Controls.Add(this.lblID);
            this.gbDetailReceiptExport.Controls.Add(this.lblCustomer);
            this.gbDetailReceiptExport.Controls.Add(this.lblName);
            this.gbDetailReceiptExport.Controls.Add(this.lblIDReceipt);
            this.gbDetailReceiptExport.Controls.Add(this.lblMoney);
            this.gbDetailReceiptExport.Controls.Add(this.lblTotal);
            this.gbDetailReceiptExport.Controls.Add(this.lblNameCustomer);
            this.gbDetailReceiptExport.Controls.Add(this.lblNameEmployee);
            this.gbDetailReceiptExport.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbDetailReceiptExport.Location = new System.Drawing.Point(47, 88);
            this.gbDetailReceiptExport.Name = "gbDetailReceiptExport";
            this.gbDetailReceiptExport.Size = new System.Drawing.Size(723, 167);
            this.gbDetailReceiptExport.TabIndex = 27;
            this.gbDetailReceiptExport.TabStop = false;
            this.gbDetailReceiptExport.Text = "Thông tin đơn hàng";
            // 
            // lblCustomer
            // 
            this.lblCustomer.AutoSize = true;
            this.lblCustomer.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomer.Location = new System.Drawing.Point(277, 115);
            this.lblCustomer.Name = "lblCustomer";
            this.lblCustomer.Size = new System.Drawing.Size(159, 30);
            this.lblCustomer.TabIndex = 5;
            this.lblCustomer.Text = "Khách Hàng";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(277, 37);
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
            // lblMoney
            // 
            this.lblMoney.AutoSize = true;
            this.lblMoney.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMoney.Location = new System.Drawing.Point(6, 116);
            this.lblMoney.Name = "lblMoney";
            this.lblMoney.Size = new System.Drawing.Size(119, 30);
            this.lblMoney.TabIndex = 5;
            this.lblMoney.Text = "Tổng tiền";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(138, 116);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(26, 30);
            this.lblTotal.TabIndex = 5;
            this.lblTotal.Text = "0";
            // 
            // lblNameCustomer
            // 
            this.lblNameCustomer.AutoSize = true;
            this.lblNameCustomer.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNameCustomer.Location = new System.Drawing.Point(449, 115);
            this.lblNameCustomer.Name = "lblNameCustomer";
            this.lblNameCustomer.Size = new System.Drawing.Size(238, 30);
            this.lblNameCustomer.TabIndex = 6;
            this.lblNameCustomer.Text = "Nguyễn Đức Thành";
            // 
            // lblNameEmployee
            // 
            this.lblNameEmployee.AutoSize = true;
            this.lblNameEmployee.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNameEmployee.Location = new System.Drawing.Point(448, 37);
            this.lblNameEmployee.Name = "lblNameEmployee";
            this.lblNameEmployee.Size = new System.Drawing.Size(238, 30);
            this.lblNameEmployee.TabIndex = 6;
            this.lblNameEmployee.Text = "Nguyễn Đức Thành";
            // 
            // txtAmountBook
            // 
            this.txtAmountBook.Location = new System.Drawing.Point(157, 122);
            this.txtAmountBook.Name = "txtAmountBook";
            this.txtAmountBook.Size = new System.Drawing.Size(186, 22);
            this.txtAmountBook.TabIndex = 7;
            // 
            // lblBook
            // 
            this.lblBook.AutoSize = true;
            this.lblBook.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBook.Location = new System.Drawing.Point(20, 66);
            this.lblBook.Name = "lblBook";
            this.lblBook.Size = new System.Drawing.Size(121, 30);
            this.lblBook.TabIndex = 5;
            this.lblBook.Text = "Tên Sách";
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(86, 301);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(121, 53);
            this.btnAdd.TabIndex = 22;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.Location = new System.Drawing.Point(238, 301);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(121, 53);
            this.btnEdit.TabIndex = 23;
            this.btnEdit.Text = "Sửa";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(390, 301);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(121, 53);
            this.btnDelete.TabIndex = 25;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(542, 301);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(121, 53);
            this.btnSave.TabIndex = 26;
            this.btnSave.Text = "Lưu";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // dgvListBook
            // 
            this.dgvListBook.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListBook.Location = new System.Drawing.Point(38, 392);
            this.dgvListBook.Name = "dgvListBook";
            this.dgvListBook.RowHeadersWidth = 51;
            this.dgvListBook.RowTemplate.Height = 24;
            this.dgvListBook.Size = new System.Drawing.Size(729, 304);
            this.dgvListBook.TabIndex = 20;
            this.dgvListBook.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvListBook_CellClick);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Teal;
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(1297, 10);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(10, 711);
            this.panel4.TabIndex = 19;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Teal;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(10, 721);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1297, 10);
            this.panel3.TabIndex = 18;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Teal;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 10);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(10, 721);
            this.panel2.TabIndex = 17;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Teal;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1307, 10);
            this.panel1.TabIndex = 16;
            // 
            // lblAnnounce
            // 
            this.lblAnnounce.AutoSize = true;
            this.lblAnnounce.Font = new System.Drawing.Font("Century Gothic", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnnounce.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.lblAnnounce.Location = new System.Drawing.Point(487, 30);
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
            this.btnExit.Location = new System.Drawing.Point(1229, 10);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(66, 48);
            this.btnExit.TabIndex = 28;
            this.btnExit.Text = "X";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lViewCart
            // 
            this.lViewCart.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ID,
            this.NameBook,
            this.Price,
            this.columnEdit,
            this.columnDelete});
            this.lViewCart.HideSelection = false;
            this.lViewCart.Location = new System.Drawing.Point(787, 392);
            this.lViewCart.Name = "lViewCart";
            this.lViewCart.RightToLeftLayout = true;
            this.lViewCart.Size = new System.Drawing.Size(504, 304);
            this.lViewCart.TabIndex = 29;
            this.lViewCart.UseCompatibleStateImageBehavior = false;
            this.lViewCart.View = System.Windows.Forms.View.Details;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblIDBook);
            this.groupBox1.Controls.Add(this.lblNameBook);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.lblBook);
            this.groupBox1.Controls.Add(this.txtAmountBook);
            this.groupBox1.Controls.Add(this.lblAmount);
            this.groupBox1.Location = new System.Drawing.Point(883, 88);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(379, 167);
            this.groupBox1.TabIndex = 30;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin sản phẩm";
            // 
            // lblNameBook
            // 
            this.lblNameBook.AutoSize = true;
            this.lblNameBook.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNameBook.Location = new System.Drawing.Point(161, 65);
            this.lblNameBook.Name = "lblNameBook";
            this.lblNameBook.Size = new System.Drawing.Size(78, 30);
            this.lblNameBook.TabIndex = 8;
            this.lblNameBook.Text = "None";
            // 
            // ID
            // 
            this.ID.Text = "ID Sách";
            this.ID.Width = 64;
            // 
            // NameBook
            // 
            this.NameBook.Text = "Tên Sách";
            this.NameBook.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.NameBook.Width = 110;
            // 
            // Price
            // 
            this.Price.Text = "Số Lượng";
            this.Price.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Price.Width = 87;
            // 
            // columnEdit
            // 
            this.columnEdit.Text = "Sửa";
            this.columnEdit.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnEdit.Width = 74;
            // 
            // columnDelete
            // 
            this.columnDelete.Text = "Xóa";
            this.columnDelete.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnDelete.Width = 61;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(20, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 30);
            this.label1.TabIndex = 5;
            this.label1.Text = "Mã Sách";
            // 
            // lblIDBook
            // 
            this.lblIDBook.AutoSize = true;
            this.lblIDBook.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIDBook.Location = new System.Drawing.Point(161, 23);
            this.lblIDBook.Name = "lblIDBook";
            this.lblIDBook.Size = new System.Drawing.Size(78, 30);
            this.lblIDBook.TabIndex = 8;
            this.lblIDBook.Text = "None";
            // 
            // FormDetailReceiptExport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1307, 731);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lViewCart);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.gbDetailReceiptExport);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.dgvListBook);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblAnnounce);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormDetailReceiptExport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FormDetailReceiptExport";
            this.Load += new System.EventHandler(this.FormDetailReceiptExport_Load);
            this.gbDetailReceiptExport.ResumeLayout(false);
            this.gbDetailReceiptExport.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListBook)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.GroupBox gbDetailReceiptExport;
        private System.Windows.Forms.TextBox txtAmountBook;
        private System.Windows.Forms.Label lblBook;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblIDReceipt;
        private System.Windows.Forms.Label lblNameEmployee;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.DataGridView dgvListBook;
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
        private System.Windows.Forms.ListView lViewCart;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblNameBook;
        private System.Windows.Forms.ColumnHeader ID;
        private System.Windows.Forms.ColumnHeader NameBook;
        private System.Windows.Forms.ColumnHeader Price;
        private System.Windows.Forms.ColumnHeader columnEdit;
        private System.Windows.Forms.ColumnHeader columnDelete;
        private System.Windows.Forms.Label lblIDBook;
        private System.Windows.Forms.Label label1;
    }
}