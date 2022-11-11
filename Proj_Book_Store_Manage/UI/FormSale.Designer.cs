
namespace Proj_Book_Store_Manage.UI
{
    partial class FormSale
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
            this.cbIdEmployee = new System.Windows.Forms.ComboBox();
            this.cbIdCustomer = new System.Windows.Forms.ComboBox();
            this.dtpReceiptExport = new System.Windows.Forms.DateTimePicker();
            this.lblDateExport = new System.Windows.Forms.Label();
            this.lblVoucher = new System.Windows.Forms.Label();
            this.cbIdVoucher = new System.Windows.Forms.ComboBox();
            this.lblCustomer = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblIDReceipt = new System.Windows.Forms.Label();
            this.lblMoney = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.txtAmountBook = new System.Windows.Forms.TextBox();
            this.lblBook = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.dgvListBook = new System.Windows.Forms.DataGridView();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnExit = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblIDBook = new System.Windows.Forms.Label();
            this.lblNameBook = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvCart = new System.Windows.Forms.DataGridView();
            this.lblAnnounce = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.gbDetailReceiptExport.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListBook)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCart)).BeginInit();
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
            this.gbDetailReceiptExport.Controls.Add(this.cbIdEmployee);
            this.gbDetailReceiptExport.Controls.Add(this.cbIdCustomer);
            this.gbDetailReceiptExport.Controls.Add(this.dtpReceiptExport);
            this.gbDetailReceiptExport.Controls.Add(this.lblDateExport);
            this.gbDetailReceiptExport.Controls.Add(this.lblVoucher);
            this.gbDetailReceiptExport.Controls.Add(this.cbIdVoucher);
            this.gbDetailReceiptExport.Controls.Add(this.lblID);
            this.gbDetailReceiptExport.Controls.Add(this.lblCustomer);
            this.gbDetailReceiptExport.Controls.Add(this.lblName);
            this.gbDetailReceiptExport.Controls.Add(this.lblIDReceipt);
            this.gbDetailReceiptExport.Controls.Add(this.lblMoney);
            this.gbDetailReceiptExport.Controls.Add(this.lblTotal);
            this.gbDetailReceiptExport.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbDetailReceiptExport.Location = new System.Drawing.Point(47, 88);
            this.gbDetailReceiptExport.Name = "gbDetailReceiptExport";
            this.gbDetailReceiptExport.Size = new System.Drawing.Size(756, 230);
            this.gbDetailReceiptExport.TabIndex = 27;
            this.gbDetailReceiptExport.TabStop = false;
            this.gbDetailReceiptExport.Text = "Thông tin đơn hàng";
            // 
            // cbIdEmployee
            // 
            this.cbIdEmployee.FormattingEnabled = true;
            this.cbIdEmployee.Location = new System.Drawing.Point(564, 40);
            this.cbIdEmployee.Name = "cbIdEmployee";
            this.cbIdEmployee.Size = new System.Drawing.Size(121, 29);
            this.cbIdEmployee.TabIndex = 37;
            // 
            // cbIdCustomer
            // 
            this.cbIdCustomer.FormattingEnabled = true;
            this.cbIdCustomer.Location = new System.Drawing.Point(553, 85);
            this.cbIdCustomer.Name = "cbIdCustomer";
            this.cbIdCustomer.Size = new System.Drawing.Size(121, 29);
            this.cbIdCustomer.TabIndex = 36;
            // 
            // dtpReceiptExport
            // 
            this.dtpReceiptExport.Location = new System.Drawing.Point(198, 124);
            this.dtpReceiptExport.Name = "dtpReceiptExport";
            this.dtpReceiptExport.Size = new System.Drawing.Size(176, 28);
            this.dtpReceiptExport.TabIndex = 35;
            // 
            // lblDateExport
            // 
            this.lblDateExport.AutoSize = true;
            this.lblDateExport.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateExport.Location = new System.Drawing.Point(16, 123);
            this.lblDateExport.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDateExport.Name = "lblDateExport";
            this.lblDateExport.Size = new System.Drawing.Size(161, 23);
            this.lblDateExport.TabIndex = 34;
            this.lblDateExport.Text = "Ngày Bán Sách";
            // 
            // lblVoucher
            // 
            this.lblVoucher.AutoSize = true;
            this.lblVoucher.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVoucher.Location = new System.Drawing.Point(379, 182);
            this.lblVoucher.Name = "lblVoucher";
            this.lblVoucher.Size = new System.Drawing.Size(115, 30);
            this.lblVoucher.TabIndex = 33;
            this.lblVoucher.Text = "Voucher";
            // 
            // cbIdVoucher
            // 
            this.cbIdVoucher.FormattingEnabled = true;
            this.cbIdVoucher.Items.AddRange(new object[] {
            "Không áp dụng"});
            this.cbIdVoucher.Location = new System.Drawing.Point(553, 185);
            this.cbIdVoucher.Name = "cbIdVoucher";
            this.cbIdVoucher.Size = new System.Drawing.Size(163, 29);
            this.cbIdVoucher.TabIndex = 32;
            // 
            // lblCustomer
            // 
            this.lblCustomer.AutoSize = true;
            this.lblCustomer.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomer.Location = new System.Drawing.Point(379, 85);
            this.lblCustomer.Name = "lblCustomer";
            this.lblCustomer.Size = new System.Drawing.Size(159, 30);
            this.lblCustomer.TabIndex = 5;
            this.lblCustomer.Text = "Khách Hàng";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(379, 37);
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
            this.lblMoney.Location = new System.Drawing.Point(15, 182);
            this.lblMoney.Name = "lblMoney";
            this.lblMoney.Size = new System.Drawing.Size(119, 30);
            this.lblMoney.TabIndex = 5;
            this.lblMoney.Text = "Tổng tiền";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(147, 182);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(26, 30);
            this.lblTotal.TabIndex = 5;
            this.lblTotal.Text = "0";
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
            this.btnAdd.Location = new System.Drawing.Point(708, 324);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(121, 53);
            this.btnAdd.TabIndex = 22;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(883, 324);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(182, 53);
            this.btnSave.TabIndex = 26;
            this.btnSave.Text = "Xuất hóa đơn";
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
            // dgvCart
            // 
            this.dgvCart.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCart.Location = new System.Drawing.Point(817, 392);
            this.dgvCart.Name = "dgvCart";
            this.dgvCart.RowHeadersWidth = 51;
            this.dgvCart.RowTemplate.Height = 24;
            this.dgvCart.Size = new System.Drawing.Size(456, 304);
            this.dgvCart.TabIndex = 31;
            this.dgvCart.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCart_CellContentClick);
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
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(1123, 324);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(128, 53);
            this.btnCancel.TabIndex = 26;
            this.btnCancel.Text = "Hủy";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // FormSale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1307, 731);
            this.Controls.Add(this.dgvCart);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.gbDetailReceiptExport);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.dgvListBook);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblAnnounce);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormSale";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FormSale";
            this.Load += new System.EventHandler(this.FormDetailReceiptExport_Load);
            this.gbDetailReceiptExport.ResumeLayout(false);
            this.gbDetailReceiptExport.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListBook)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCart)).EndInit();
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
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.DataGridView dgvListBook;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblCustomer;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblMoney;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblNameBook;
        private System.Windows.Forms.Label lblIDBook;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvCart;
        private System.Windows.Forms.Label lblAnnounce;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblVoucher;
        private System.Windows.Forms.ComboBox cbIdVoucher;
        private System.Windows.Forms.DateTimePicker dtpReceiptExport;
        private System.Windows.Forms.Label lblDateExport;
        private System.Windows.Forms.ComboBox cbIdEmployee;
        private System.Windows.Forms.ComboBox cbIdCustomer;
    }
}