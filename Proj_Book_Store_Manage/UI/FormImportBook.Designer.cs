
namespace Proj_Book_Store_Manage.UI
{
    partial class FormImportBook
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbIdEmployee = new System.Windows.Forms.Label();
            this.lblIdBill = new System.Windows.Forms.Label();
            this.lblTotalBill = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpDateImport = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvListItemImport = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblNameBook = new System.Windows.Forms.Label();
            this.txtAmountBook = new System.Windows.Forms.TextBox();
            this.cbIdBook = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnAddItem = new System.Windows.Forms.Button();
            this.btnInvoiceBill = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblAnnounce = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListItemImport)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbIdEmployee);
            this.groupBox1.Controls.Add(this.lblIdBill);
            this.groupBox1.Controls.Add(this.lblTotalBill);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.dtpDateImport);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(34, 69);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(670, 203);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin hóa đơn nhập";
            // 
            // lbIdEmployee
            // 
            this.lbIdEmployee.AutoSize = true;
            this.lbIdEmployee.Location = new System.Drawing.Point(498, 68);
            this.lbIdEmployee.Name = "lbIdEmployee";
            this.lbIdEmployee.Size = new System.Drawing.Size(42, 17);
            this.lbIdEmployee.TabIndex = 9;
            this.lbIdEmployee.Text = "None";
            // 
            // lblIdBill
            // 
            this.lblIdBill.AutoSize = true;
            this.lblIdBill.Location = new System.Drawing.Point(145, 59);
            this.lblIdBill.Name = "lblIdBill";
            this.lblIdBill.Size = new System.Drawing.Size(46, 17);
            this.lblIdBill.TabIndex = 8;
            this.lblIdBill.Text = "label6";
            // 
            // lblTotalBill
            // 
            this.lblTotalBill.AutoSize = true;
            this.lblTotalBill.Location = new System.Drawing.Point(520, 128);
            this.lblTotalBill.Name = "lblTotalBill";
            this.lblTotalBill.Size = new System.Drawing.Size(16, 17);
            this.lblTotalBill.TabIndex = 7;
            this.lblTotalBill.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(385, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "Mã nhân viên";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(406, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Tổng tiền ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ngày nhập sách";
            // 
            // dtpDateImport
            // 
            this.dtpDateImport.Location = new System.Drawing.Point(145, 128);
            this.dtpDateImport.Name = "dtpDateImport";
            this.dtpDateImport.Size = new System.Drawing.Size(200, 22);
            this.dtpDateImport.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã hóa đơn";
            // 
            // dgvListItemImport
            // 
            this.dgvListItemImport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListItemImport.Location = new System.Drawing.Point(204, 338);
            this.dgvListItemImport.Name = "dgvListItemImport";
            this.dgvListItemImport.RowHeadersWidth = 51;
            this.dgvListItemImport.RowTemplate.Height = 24;
            this.dgvListItemImport.Size = new System.Drawing.Size(617, 197);
            this.dgvListItemImport.TabIndex = 1;
            this.dgvListItemImport.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvListItemImport_CellContentClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblNameBook);
            this.groupBox2.Controls.Add(this.txtAmountBook);
            this.groupBox2.Controls.Add(this.cbIdBook);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(737, 72);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(258, 168);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách ";
            // 
            // lblNameBook
            // 
            this.lblNameBook.AutoSize = true;
            this.lblNameBook.Location = new System.Drawing.Point(105, 91);
            this.lblNameBook.Name = "lblNameBook";
            this.lblNameBook.Size = new System.Drawing.Size(42, 17);
            this.lblNameBook.TabIndex = 3;
            this.lblNameBook.Text = "None";
            // 
            // txtAmountBook
            // 
            this.txtAmountBook.Location = new System.Drawing.Point(105, 131);
            this.txtAmountBook.Name = "txtAmountBook";
            this.txtAmountBook.Size = new System.Drawing.Size(100, 22);
            this.txtAmountBook.TabIndex = 2;
            // 
            // cbIdBook
            // 
            this.cbIdBook.FormattingEnabled = true;
            this.cbIdBook.Location = new System.Drawing.Point(108, 43);
            this.cbIdBook.Name = "cbIdBook";
            this.cbIdBook.Size = new System.Drawing.Size(121, 24);
            this.cbIdBook.TabIndex = 1;
            this.cbIdBook.SelectedIndexChanged += new System.EventHandler(this.cbIdBook_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 137);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 17);
            this.label7.TabIndex = 0;
            this.label7.Text = "Số lượng";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 93);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 17);
            this.label6.TabIndex = 0;
            this.label6.Text = "Tên sách";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 46);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 17);
            this.label5.TabIndex = 0;
            this.label5.Text = "Mã sách";
            // 
            // btnAddItem
            // 
            this.btnAddItem.Location = new System.Drawing.Point(577, 278);
            this.btnAddItem.Name = "btnAddItem";
            this.btnAddItem.Size = new System.Drawing.Size(109, 40);
            this.btnAddItem.TabIndex = 3;
            this.btnAddItem.Text = "Thêm";
            this.btnAddItem.UseVisualStyleBackColor = true;
            this.btnAddItem.Click += new System.EventHandler(this.btnAddItem_Click);
            // 
            // btnInvoiceBill
            // 
            this.btnInvoiceBill.Location = new System.Drawing.Point(734, 278);
            this.btnInvoiceBill.Name = "btnInvoiceBill";
            this.btnInvoiceBill.Size = new System.Drawing.Size(109, 40);
            this.btnInvoiceBill.TabIndex = 4;
            this.btnInvoiceBill.Text = "Xuất hóa đơn";
            this.btnInvoiceBill.UseVisualStyleBackColor = true;
            this.btnInvoiceBill.Click += new System.EventHandler(this.btnInvoiceBill_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(886, 278);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(109, 40);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "Hủy";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Teal;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1049, 10);
            this.panel1.TabIndex = 17;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Teal;
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(1038, 10);
            this.panel4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(11, 576);
            this.panel4.TabIndex = 20;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Teal;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 576);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1038, 10);
            this.panel3.TabIndex = 21;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Teal;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 10);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(11, 566);
            this.panel2.TabIndex = 22;
            // 
            // lblAnnounce
            // 
            this.lblAnnounce.AutoSize = true;
            this.lblAnnounce.Font = new System.Drawing.Font("Century Gothic", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnnounce.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.lblAnnounce.Location = new System.Drawing.Point(366, 10);
            this.lblAnnounce.Name = "lblAnnounce";
            this.lblAnnounce.Size = new System.Drawing.Size(358, 39);
            this.lblAnnounce.TabIndex = 23;
            this.lblAnnounce.Text = "Chi Tiết Hóa Đơn Xuất";
            // 
            // btnExit
            // 
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Century Gothic", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.Teal;
            this.btnExit.Location = new System.Drawing.Point(965, 19);
            this.btnExit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(67, 48);
            this.btnExit.TabIndex = 29;
            this.btnExit.Text = "X";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // FormImportBook
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1049, 586);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.lblAnnounce);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnInvoiceBill);
            this.Controls.Add(this.btnAddItem);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.dgvListItemImport);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormImportBook";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormImportBook";
            this.Load += new System.EventHandler(this.FormImportBook_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListItemImport)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblIdBill;
        private System.Windows.Forms.Label lblTotalBill;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpDateImport;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvListItemImport;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cbIdBook;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblNameBook;
        private System.Windows.Forms.TextBox txtAmountBook;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnAddItem;
        private System.Windows.Forms.Button btnInvoiceBill;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lbIdEmployee;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblAnnounce;
        private System.Windows.Forms.Button btnExit;
    }
}