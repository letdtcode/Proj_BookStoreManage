namespace Project_QuanLyCuaHangSach
{
    partial class frmSell
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvAllBook = new System.Windows.Forms.DataGridView();
            this.labelTongTien = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.cbAuthorNAME = new System.Windows.Forms.ComboBox();
            this.cbPublisherNAME = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.btnfilter = new System.Windows.Forms.Button();
            this.btnCreateBill = new System.Windows.Forms.Button();
            this.dgvBill = new System.Windows.Forms.DataGridView();
            this.btnUnFilter = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnFinish = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblEmployeeNAME = new System.Windows.Forms.Label();
            this.lblCustomerNAME = new System.Windows.Forms.Label();
            this.txtBookID = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.txtBillID = new System.Windows.Forms.TextBox();
            this.btnFindBil = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllBook)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBill)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvAllBook
            // 
            this.dgvAllBook.AllowUserToDeleteRows = false;
            this.dgvAllBook.AllowUserToResizeColumns = false;
            this.dgvAllBook.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.MistyRose;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.ForestGreen;
            this.dgvAllBook.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvAllBook.BackgroundColor = System.Drawing.Color.LemonChiffon;
            this.dgvAllBook.ColumnHeadersHeight = 30;
            this.dgvAllBook.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvAllBook.Location = new System.Drawing.Point(25, 349);
            this.dgvAllBook.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.dgvAllBook.MultiSelect = false;
            this.dgvAllBook.Name = "dgvAllBook";
            this.dgvAllBook.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.MenuText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.MistyRose;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.MistyRose;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAllBook.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvAllBook.RowHeadersVisible = false;
            this.dgvAllBook.RowHeadersWidth = 50;
            this.dgvAllBook.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvAllBook.RowTemplate.Height = 100;
            this.dgvAllBook.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvAllBook.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAllBook.Size = new System.Drawing.Size(653, 370);
            this.dgvAllBook.TabIndex = 48;
            this.dgvAllBook.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAllBook_CellClick);
            // 
            // labelTongTien
            // 
            this.labelTongTien.AutoSize = true;
            this.labelTongTien.Location = new System.Drawing.Point(1042, 657);
            this.labelTongTien.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTongTien.Name = "labelTongTien";
            this.labelTongTien.Size = new System.Drawing.Size(15, 15);
            this.labelTongTien.TabIndex = 61;
            this.labelTongTien.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(923, 653);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 19);
            this.label6.TabIndex = 62;
            this.label6.Text = "Tổng Tiền:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(26, 323);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 19);
            this.label7.TabIndex = 1;
            this.label7.Text = "Kho Sách:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(730, 653);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(130, 19);
            this.label8.TabIndex = 1;
            this.label8.Text = "Chi Tiết Giỏ Hàng:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(53, 295);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(47, 15);
            this.label11.TabIndex = 65;
            this.label11.Text = "Bộ lọc";
            // 
            // cbAuthorNAME
            // 
            this.cbAuthorNAME.FormattingEnabled = true;
            this.cbAuthorNAME.Location = new System.Drawing.Point(757, 383);
            this.cbAuthorNAME.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cbAuthorNAME.Name = "cbAuthorNAME";
            this.cbAuthorNAME.Size = new System.Drawing.Size(153, 23);
            this.cbAuthorNAME.TabIndex = 66;
            // 
            // cbPublisherNAME
            // 
            this.cbPublisherNAME.FormattingEnabled = true;
            this.cbPublisherNAME.Location = new System.Drawing.Point(757, 467);
            this.cbPublisherNAME.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cbPublisherNAME.Name = "cbPublisherNAME";
            this.cbPublisherNAME.Size = new System.Drawing.Size(153, 23);
            this.cbPublisherNAME.TabIndex = 66;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(156, 295);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(59, 15);
            this.label12.TabIndex = 65;
            this.label12.Text = "Thể loại";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(790, 349);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(54, 15);
            this.label13.TabIndex = 65;
            this.label13.Text = "Tác giả";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(785, 443);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(35, 15);
            this.label14.TabIndex = 65;
            this.label14.Text = "NXB";
            // 
            // btnfilter
            // 
            this.btnfilter.BackColor = System.Drawing.Color.PapayaWhip;
            this.btnfilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnfilter.Location = new System.Drawing.Point(992, 553);
            this.btnfilter.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnfilter.Name = "btnfilter";
            this.btnfilter.Size = new System.Drawing.Size(94, 32);
            this.btnfilter.TabIndex = 67;
            this.btnfilter.Text = "Lọc";
            this.btnfilter.UseVisualStyleBackColor = false;
            // 
            // btnCreateBill
            // 
            this.btnCreateBill.BackColor = System.Drawing.Color.PapayaWhip;
            this.btnCreateBill.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCreateBill.Location = new System.Drawing.Point(1077, 653);
            this.btnCreateBill.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnCreateBill.Name = "btnCreateBill";
            this.btnCreateBill.Size = new System.Drawing.Size(159, 35);
            this.btnCreateBill.TabIndex = 57;
            this.btnCreateBill.Text = "Xuất Hóa Đơn";
            this.btnCreateBill.UseVisualStyleBackColor = false;
            this.btnCreateBill.Click += new System.EventHandler(this.btnCreateBill_Click);
            // 
            // dgvBill
            // 
            this.dgvBill.AllowUserToDeleteRows = false;
            this.dgvBill.AllowUserToResizeColumns = false;
            this.dgvBill.AllowUserToResizeRows = false;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.MistyRose;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.ForestGreen;
            this.dgvBill.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvBill.BackgroundColor = System.Drawing.Color.LemonChiffon;
            this.dgvBill.ColumnHeadersHeight = 30;
            this.dgvBill.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvBill.Location = new System.Drawing.Point(692, 36);
            this.dgvBill.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.dgvBill.MultiSelect = false;
            this.dgvBill.Name = "dgvBill";
            this.dgvBill.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.MenuText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.MistyRose;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.MistyRose;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvBill.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvBill.RowHeadersVisible = false;
            this.dgvBill.RowHeadersWidth = 50;
            this.dgvBill.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvBill.RowTemplate.Height = 20;
            this.dgvBill.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvBill.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBill.Size = new System.Drawing.Size(558, 230);
            this.dgvBill.TabIndex = 68;
            this.dgvBill.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBillDetail_CellClick);
            // 
            // btnUnFilter
            // 
            this.btnUnFilter.BackColor = System.Drawing.Color.PapayaWhip;
            this.btnUnFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUnFilter.Location = new System.Drawing.Point(811, 553);
            this.btnUnFilter.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnUnFilter.Name = "btnUnFilter";
            this.btnUnFilter.Size = new System.Drawing.Size(85, 32);
            this.btnUnFilter.TabIndex = 69;
            this.btnUnFilter.Text = "Bỏ lọc";
            this.btnUnFilter.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::Project_QuanLyCuaHangSach.Properties.Resources.hinh_anh_cuon_sach_dep_28;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.btnFinish);
            this.panel1.Controls.Add(this.btnCancel);
            this.panel1.Controls.Add(this.lblEmployeeNAME);
            this.panel1.Controls.Add(this.lblCustomerNAME);
            this.panel1.Controls.Add(this.txtBookID);
            this.panel1.Controls.Add(this.btnAdd);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtAmount);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.btnSua);
            this.panel1.Controls.Add(this.btnXoa);
            this.panel1.Controls.Add(this.txtBillID);
            this.panel1.Controls.Add(this.btnFindBil);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(11, 37);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(642, 229);
            this.panel1.TabIndex = 64;
            // 
            // btnFinish
            // 
            this.btnFinish.BackColor = System.Drawing.Color.PapayaWhip;
            this.btnFinish.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFinish.Location = new System.Drawing.Point(421, 144);
            this.btnFinish.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnFinish.Name = "btnFinish";
            this.btnFinish.Size = new System.Drawing.Size(76, 29);
            this.btnFinish.TabIndex = 68;
            this.btnFinish.Text = "Lưu";
            this.btnFinish.UseVisualStyleBackColor = false;
            this.btnFinish.Click += new System.EventHandler(this.btnFinish_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.PapayaWhip;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(540, 144);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(76, 29);
            this.btnCancel.TabIndex = 67;
            this.btnCancel.Text = "Hủy";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_click);
            // 
            // lblEmployeeNAME
            // 
            this.lblEmployeeNAME.AutoSize = true;
            this.lblEmployeeNAME.Location = new System.Drawing.Point(295, 122);
            this.lblEmployeeNAME.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEmployeeNAME.Name = "lblEmployeeNAME";
            this.lblEmployeeNAME.Size = new System.Drawing.Size(0, 15);
            this.lblEmployeeNAME.TabIndex = 65;
            // 
            // lblCustomerNAME
            // 
            this.lblCustomerNAME.AutoSize = true;
            this.lblCustomerNAME.Location = new System.Drawing.Point(295, 158);
            this.lblCustomerNAME.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCustomerNAME.Name = "lblCustomerNAME";
            this.lblCustomerNAME.Size = new System.Drawing.Size(0, 15);
            this.lblCustomerNAME.TabIndex = 65;
            // 
            // txtBookID
            // 
            this.txtBookID.Location = new System.Drawing.Point(148, 41);
            this.txtBookID.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtBookID.Name = "txtBookID";
            this.txtBookID.Size = new System.Drawing.Size(123, 21);
            this.txtBookID.TabIndex = 0;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.PapayaWhip;
            this.btnAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(311, 6);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(148, 58);
            this.btnAdd.TabIndex = 56;
            this.btnAdd.Text = "Thêm giỏ hàng";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI Black", 11F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(7, 41);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mã sách";
            // 
            // txtAmount
            // 
            this.txtAmount.Location = new System.Drawing.Point(146, 81);
            this.txtAmount.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(123, 21);
            this.txtAmount.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI Black", 11F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(4, 78);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Số lượng";
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.Color.PapayaWhip;
            this.btnSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.Location = new System.Drawing.Point(540, 6);
            this.btnSua.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(79, 33);
            this.btnSua.TabIndex = 60;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.PapayaWhip;
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.Location = new System.Drawing.Point(540, 81);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(79, 33);
            this.btnXoa.TabIndex = 59;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // txtBillID
            // 
            this.txtBillID.Enabled = false;
            this.txtBillID.Location = new System.Drawing.Point(146, 3);
            this.txtBillID.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtBillID.Name = "txtBillID";
            this.txtBillID.Size = new System.Drawing.Size(123, 21);
            this.txtBillID.TabIndex = 49;
            // 
            // btnFindBil
            // 
            this.btnFindBil.BackColor = System.Drawing.Color.PapayaWhip;
            this.btnFindBil.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFindBil.Location = new System.Drawing.Point(56, 144);
            this.btnFindBil.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnFindBil.Name = "btnFindBil";
            this.btnFindBil.Size = new System.Drawing.Size(115, 29);
            this.btnFindBil.TabIndex = 63;
            this.btnFindBil.Text = "Lấy mã hóa đơn";
            this.btnFindBil.UseVisualStyleBackColor = false;
            this.btnFindBil.Click += new System.EventHandler(this.btnFindID_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Enabled = false;
            this.label3.Font = new System.Drawing.Font("Segoe UI Black", 11F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(8, 4);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 20);
            this.label3.TabIndex = 50;
            this.label3.Text = "Mã HĐ";
            // 
            // frmSell
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Khaki;
            this.ClientSize = new System.Drawing.Size(1264, 732);
            this.Controls.Add(this.btnUnFilter);
            this.Controls.Add(this.dgvBill);
            this.Controls.Add(this.btnfilter);
            this.Controls.Add(this.cbPublisherNAME);
            this.Controls.Add(this.cbAuthorNAME);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnCreateBill);
            this.Controls.Add(this.dgvAllBook);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.labelTongTien);
            this.Controls.Add(this.label6);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MinimizeBox = false;
            this.Name = "frmSell";
            this.Text = "Bán Sách";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmSell_FormClosed);
            this.Load += new System.EventHandler(this.frmSell_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllBook)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBill)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvAllBook;
        private System.Windows.Forms.Button btnCreateBill;
        private System.Windows.Forms.Label labelTongTien;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cbAuthorNAME;
        private System.Windows.Forms.ComboBox cbPublisherNAME;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button btnfilter;
        private System.Windows.Forms.DataGridView dgvBill;
        private System.Windows.Forms.Button btnUnFilter;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnFindBil;
        private System.Windows.Forms.TextBox txtBillID;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtBookID;
        private System.Windows.Forms.Label lblCustomerNAME;
        private System.Windows.Forms.Label lblEmployeeNAME;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnFinish;
    }
}