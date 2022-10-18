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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvAllBook = new System.Windows.Forms.DataGridView();
            this.stt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BookIMAGE = new System.Windows.Forms.DataGridViewImageColumn();
            this.BookID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BookName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CategoryName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AuthorName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PublisherNAME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BookPRICE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BookAMOUNT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvBillDetail = new System.Windows.Forms.DataGridView();
            this.labelTongTien = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.cbCategoryNAME = new System.Windows.Forms.ComboBox();
            this.cbAuthorNAME = new System.Windows.Forms.ComboBox();
            this.cbPublisherNAME = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.btnfilter = new System.Windows.Forms.Button();
            this.btnCreateBill = new System.Windows.Forms.Button();
            this.dgvBill = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BillID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SumBill1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BuyDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustomerID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmpID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnUnFilter = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnLuu = new System.Windows.Forms.Button();
            this.lblEmployeeNAME = new System.Windows.Forms.Label();
            this.lblCustomerNAME = new System.Windows.Forms.Label();
            this.txtBookID = new System.Windows.Forms.TextBox();
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtBillID = new System.Windows.Forms.TextBox();
            this.cbEmployeeID = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnCus = new System.Windows.Forms.Button();
            this.cbCustomerID = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TongTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllBook)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBillDetail)).BeginInit();
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
            this.dgvAllBook.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.stt,
            this.BookIMAGE,
            this.BookID,
            this.BookName,
            this.CategoryName,
            this.AuthorName,
            this.PublisherNAME,
            this.BookPRICE,
            this.BookAMOUNT});
            this.dgvAllBook.Location = new System.Drawing.Point(16, 335);
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
            this.dgvAllBook.Size = new System.Drawing.Size(1522, 262);
            this.dgvAllBook.TabIndex = 48;
            this.dgvAllBook.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAllBook_CellClick);
            this.dgvAllBook.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAllBook_CellContentClick);
            // 
            // stt
            // 
            this.stt.FillWeight = 38.51598F;
            this.stt.HeaderText = "STT";
            this.stt.MinimumWidth = 6;
            this.stt.Name = "stt";
            this.stt.ReadOnly = true;
            this.stt.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.stt.Width = 50;
            // 
            // BookIMAGE
            // 
            this.BookIMAGE.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.BookIMAGE.HeaderText = "Bìa sách";
            this.BookIMAGE.MinimumWidth = 6;
            this.BookIMAGE.Name = "BookIMAGE";
            this.BookIMAGE.ReadOnly = true;
            this.BookIMAGE.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.BookIMAGE.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // BookID
            // 
            this.BookID.FillWeight = 71.58199F;
            this.BookID.HeaderText = "Mã sách";
            this.BookID.MinimumWidth = 6;
            this.BookID.Name = "BookID";
            this.BookID.ReadOnly = true;
            this.BookID.Width = 93;
            // 
            // BookName
            // 
            this.BookName.FillWeight = 164.5794F;
            this.BookName.HeaderText = "Tên sách";
            this.BookName.MinimumWidth = 6;
            this.BookName.Name = "BookName";
            this.BookName.ReadOnly = true;
            this.BookName.Width = 213;
            // 
            // CategoryName
            // 
            this.CategoryName.FillWeight = 175.4011F;
            this.CategoryName.HeaderText = "Thể loại";
            this.CategoryName.MinimumWidth = 30;
            this.CategoryName.Name = "CategoryName";
            this.CategoryName.ReadOnly = true;
            this.CategoryName.Width = 227;
            // 
            // AuthorName
            // 
            this.AuthorName.FillWeight = 95.56902F;
            this.AuthorName.HeaderText = "Tác giả";
            this.AuthorName.MinimumWidth = 6;
            this.AuthorName.Name = "AuthorName";
            this.AuthorName.ReadOnly = true;
            this.AuthorName.Width = 124;
            // 
            // PublisherNAME
            // 
            this.PublisherNAME.FillWeight = 101.5049F;
            this.PublisherNAME.HeaderText = "NXB";
            this.PublisherNAME.MinimumWidth = 6;
            this.PublisherNAME.Name = "PublisherNAME";
            this.PublisherNAME.ReadOnly = true;
            this.PublisherNAME.Width = 131;
            // 
            // BookPRICE
            // 
            this.BookPRICE.FillWeight = 90.46624F;
            this.BookPRICE.HeaderText = "Giá";
            this.BookPRICE.MinimumWidth = 6;
            this.BookPRICE.Name = "BookPRICE";
            this.BookPRICE.ReadOnly = true;
            this.BookPRICE.Width = 117;
            // 
            // BookAMOUNT
            // 
            this.BookAMOUNT.FillWeight = 82.3814F;
            this.BookAMOUNT.HeaderText = "Số lượng";
            this.BookAMOUNT.MinimumWidth = 6;
            this.BookAMOUNT.Name = "BookAMOUNT";
            this.BookAMOUNT.ReadOnly = true;
            this.BookAMOUNT.Width = 107;
            // 
            // dgvBillDetail
            // 
            this.dgvBillDetail.AllowUserToDeleteRows = false;
            this.dgvBillDetail.AllowUserToResizeColumns = false;
            this.dgvBillDetail.AllowUserToResizeRows = false;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.MistyRose;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.ForestGreen;
            this.dgvBillDetail.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvBillDetail.BackgroundColor = System.Drawing.Color.LemonChiffon;
            this.dgvBillDetail.ColumnHeadersHeight = 30;
            this.dgvBillDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvBillDetail.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewImageColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.TongTien});
            this.dgvBillDetail.Location = new System.Drawing.Point(16, 645);
            this.dgvBillDetail.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.dgvBillDetail.MultiSelect = false;
            this.dgvBillDetail.Name = "dgvBillDetail";
            this.dgvBillDetail.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.MenuText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.MistyRose;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.MistyRose;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvBillDetail.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvBillDetail.RowHeadersVisible = false;
            this.dgvBillDetail.RowHeadersWidth = 50;
            this.dgvBillDetail.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvBillDetail.RowTemplate.Height = 100;
            this.dgvBillDetail.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvBillDetail.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBillDetail.Size = new System.Drawing.Size(1522, 360);
            this.dgvBillDetail.TabIndex = 53;
            this.dgvBillDetail.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBillDetail_CellClick);
            this.dgvBillDetail.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBillDetail_CellContentClick);
            // 
            // labelTongTien
            // 
            this.labelTongTien.AutoSize = true;
            this.labelTongTien.Location = new System.Drawing.Point(526, 617);
            this.labelTongTien.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTongTien.Name = "labelTongTien";
            this.labelTongTien.Size = new System.Drawing.Size(17, 18);
            this.labelTongTien.TabIndex = 61;
            this.labelTongTien.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(414, 614);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 23);
            this.label6.TabIndex = 62;
            this.label6.Text = "Tổng Tiền:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(15, 302);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(88, 23);
            this.label7.TabIndex = 1;
            this.label7.Text = "Kho Sách:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(20, 614);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(157, 23);
            this.label8.TabIndex = 1;
            this.label8.Text = "Chi Tiết Giỏ Hàng:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(194, 274);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(57, 18);
            this.label11.TabIndex = 65;
            this.label11.Text = "Bộ lọc";
            // 
            // cbCategoryNAME
            // 
            this.cbCategoryNAME.FormattingEnabled = true;
            this.cbCategoryNAME.Location = new System.Drawing.Point(289, 300);
            this.cbCategoryNAME.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cbCategoryNAME.Name = "cbCategoryNAME";
            this.cbCategoryNAME.Size = new System.Drawing.Size(153, 26);
            this.cbCategoryNAME.TabIndex = 66;
            // 
            // cbAuthorNAME
            // 
            this.cbAuthorNAME.FormattingEnabled = true;
            this.cbAuthorNAME.Location = new System.Drawing.Point(540, 300);
            this.cbAuthorNAME.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cbAuthorNAME.Name = "cbAuthorNAME";
            this.cbAuthorNAME.Size = new System.Drawing.Size(153, 26);
            this.cbAuthorNAME.TabIndex = 66;
            // 
            // cbPublisherNAME
            // 
            this.cbPublisherNAME.FormattingEnabled = true;
            this.cbPublisherNAME.Location = new System.Drawing.Point(794, 302);
            this.cbPublisherNAME.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cbPublisherNAME.Name = "cbPublisherNAME";
            this.cbPublisherNAME.Size = new System.Drawing.Size(153, 26);
            this.cbPublisherNAME.TabIndex = 66;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(285, 274);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(68, 18);
            this.label12.TabIndex = 65;
            this.label12.Text = "Thể loại";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(536, 274);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(63, 18);
            this.label13.TabIndex = 65;
            this.label13.Text = "Tác giả";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(790, 279);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(42, 18);
            this.label14.TabIndex = 65;
            this.label14.Text = "NXB";
            // 
            // btnfilter
            // 
            this.btnfilter.BackColor = System.Drawing.Color.PapayaWhip;
            this.btnfilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnfilter.Location = new System.Drawing.Point(979, 300);
            this.btnfilter.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnfilter.Name = "btnfilter";
            this.btnfilter.Size = new System.Drawing.Size(94, 32);
            this.btnfilter.TabIndex = 67;
            this.btnfilter.Text = "Lọc";
            this.btnfilter.UseVisualStyleBackColor = false;
            //this.btnfilter.Click += new System.EventHandler(this.btnfilter_Click);
            // 
            // btnCreateBill
            // 
            this.btnCreateBill.BackColor = System.Drawing.Color.PapayaWhip;
            this.btnCreateBill.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCreateBill.Enabled = false;
            this.btnCreateBill.Location = new System.Drawing.Point(718, 605);
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
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.MistyRose;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.ForestGreen;
            this.dgvBill.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvBill.BackgroundColor = System.Drawing.Color.LemonChiffon;
            this.dgvBill.ColumnHeadersHeight = 30;
            this.dgvBill.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvBill.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn4,
            this.BillID,
            this.SumBill1,
            this.BuyDate,
            this.CustomerID,
            this.EmpID});
            this.dgvBill.Location = new System.Drawing.Point(678, 37);
            this.dgvBill.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.dgvBill.MultiSelect = false;
            this.dgvBill.Name = "dgvBill";
            this.dgvBill.ReadOnly = true;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.MenuText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.MistyRose;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.MistyRose;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvBill.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvBill.RowHeadersVisible = false;
            this.dgvBill.RowHeadersWidth = 50;
            this.dgvBill.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvBill.RowTemplate.Height = 20;
            this.dgvBill.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvBill.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBill.Size = new System.Drawing.Size(872, 230);
            this.dgvBill.TabIndex = 68;
            this.dgvBill.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBill_CellContentClick);
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.FillWeight = 38.51598F;
            this.dataGridViewTextBoxColumn4.HeaderText = "STT";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewTextBoxColumn4.Width = 50;
            // 
            // BillID
            // 
            this.BillID.HeaderText = "Mã HĐ";
            this.BillID.MinimumWidth = 6;
            this.BillID.Name = "BillID";
            this.BillID.ReadOnly = true;
            this.BillID.Width = 125;
            // 
            // SumBill1
            // 
            this.SumBill1.HeaderText = "Tổng tiền";
            this.SumBill1.MinimumWidth = 6;
            this.SumBill1.Name = "SumBill1";
            this.SumBill1.ReadOnly = true;
            this.SumBill1.Width = 125;
            // 
            // BuyDate
            // 
            this.BuyDate.HeaderText = "Ngày mua";
            this.BuyDate.MinimumWidth = 6;
            this.BuyDate.Name = "BuyDate";
            this.BuyDate.ReadOnly = true;
            this.BuyDate.Width = 190;
            // 
            // CustomerID
            // 
            this.CustomerID.HeaderText = "Mã KH";
            this.CustomerID.MinimumWidth = 6;
            this.CustomerID.Name = "CustomerID";
            this.CustomerID.ReadOnly = true;
            this.CustomerID.Width = 125;
            // 
            // EmpID
            // 
            this.EmpID.HeaderText = "Mã NV";
            this.EmpID.MinimumWidth = 6;
            this.EmpID.Name = "EmpID";
            this.EmpID.ReadOnly = true;
            this.EmpID.Width = 125;
            // 
            // btnUnFilter
            // 
            this.btnUnFilter.BackColor = System.Drawing.Color.PapayaWhip;
            this.btnUnFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUnFilter.Location = new System.Drawing.Point(1093, 300);
            this.btnUnFilter.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnUnFilter.Name = "btnUnFilter";
            this.btnUnFilter.Size = new System.Drawing.Size(85, 32);
            this.btnUnFilter.TabIndex = 69;
            this.btnUnFilter.Text = "Bỏ lọc";
            this.btnUnFilter.UseVisualStyleBackColor = false;
            //this.btnUnFilter.Click += new System.EventHandler(this.btnUnFilter_Click);
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::Project_QuanLyCuaHangSach.Properties.Resources.hinh_anh_cuon_sach_dep_28;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.btnLuu);
            this.panel1.Controls.Add(this.lblEmployeeNAME);
            this.panel1.Controls.Add(this.lblCustomerNAME);
            this.panel1.Controls.Add(this.txtBookID);
            this.panel1.Controls.Add(this.btnHuy);
            this.panel1.Controls.Add(this.btnAdd);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtAmount);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.btnSua);
            this.panel1.Controls.Add(this.btnXoa);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txtBillID);
            this.panel1.Controls.Add(this.cbEmployeeID);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.btnCus);
            this.panel1.Controls.Add(this.cbCustomerID);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(11, 37);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(642, 229);
            this.panel1.TabIndex = 64;
            // 
            // btnLuu
            // 
            this.btnLuu.BackColor = System.Drawing.Color.PapayaWhip;
            this.btnLuu.Enabled = false;
            this.btnLuu.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuu.Location = new System.Drawing.Point(445, 19);
            this.btnLuu.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(76, 33);
            this.btnLuu.TabIndex = 66;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = false;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // lblEmployeeNAME
            // 
            this.lblEmployeeNAME.AutoSize = true;
            this.lblEmployeeNAME.Location = new System.Drawing.Point(295, 122);
            this.lblEmployeeNAME.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEmployeeNAME.Name = "lblEmployeeNAME";
            this.lblEmployeeNAME.Size = new System.Drawing.Size(0, 18);
            this.lblEmployeeNAME.TabIndex = 65;
            // 
            // lblCustomerNAME
            // 
            this.lblCustomerNAME.AutoSize = true;
            this.lblCustomerNAME.Location = new System.Drawing.Point(295, 158);
            this.lblCustomerNAME.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCustomerNAME.Name = "lblCustomerNAME";
            this.lblCustomerNAME.Size = new System.Drawing.Size(0, 18);
            this.lblCustomerNAME.TabIndex = 65;
            // 
            // txtBookID
            // 
            this.txtBookID.Location = new System.Drawing.Point(146, 12);
            this.txtBookID.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtBookID.Name = "txtBookID";
            this.txtBookID.Size = new System.Drawing.Size(123, 24);
            this.txtBookID.TabIndex = 0;
            // 
            // btnHuy
            // 
            this.btnHuy.BackColor = System.Drawing.Color.PapayaWhip;
            this.btnHuy.Enabled = false;
            this.btnHuy.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuy.Location = new System.Drawing.Point(445, 58);
            this.btnHuy.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(76, 29);
            this.btnHuy.TabIndex = 58;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = false;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.PapayaWhip;
            this.btnAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(278, 14);
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
            this.label1.Location = new System.Drawing.Point(4, 8);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mã sách";
            // 
            // txtAmount
            // 
            this.txtAmount.Location = new System.Drawing.Point(146, 47);
            this.txtAmount.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(123, 24);
            this.txtAmount.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI Black", 11F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(4, 44);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Số lượng";
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.Color.PapayaWhip;
            this.btnSua.Enabled = false;
            this.btnSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.Location = new System.Drawing.Point(540, 19);
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
            this.btnXoa.Enabled = false;
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.Location = new System.Drawing.Point(545, 58);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(74, 29);
            this.btnXoa.TabIndex = 59;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe UI Black", 11F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(4, 117);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 25);
            this.label4.TabIndex = 52;
            this.label4.Text = "Mã NV";
            // 
            // txtBillID
            // 
            this.txtBillID.Location = new System.Drawing.Point(146, 81);
            this.txtBillID.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtBillID.Name = "txtBillID";
            this.txtBillID.Size = new System.Drawing.Size(123, 24);
            this.txtBillID.TabIndex = 49;
            // 
            // cbEmployeeID
            // 
            this.cbEmployeeID.FormattingEnabled = true;
            this.cbEmployeeID.Location = new System.Drawing.Point(146, 118);
            this.cbEmployeeID.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cbEmployeeID.Name = "cbEmployeeID";
            this.cbEmployeeID.Size = new System.Drawing.Size(123, 26);
            this.cbEmployeeID.TabIndex = 51;
            this.cbEmployeeID.SelectedIndexChanged += new System.EventHandler(this.cbEmployeeNAME_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Segoe UI Black", 11F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(8, 154);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 25);
            this.label5.TabIndex = 54;
            this.label5.Text = "Mã KH";
            // 
            // btnCus
            // 
            this.btnCus.BackColor = System.Drawing.Color.PapayaWhip;
            this.btnCus.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCus.Location = new System.Drawing.Point(155, 188);
            this.btnCus.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnCus.Name = "btnCus";
            this.btnCus.Size = new System.Drawing.Size(115, 29);
            this.btnCus.TabIndex = 63;
            this.btnCus.Text = "Khách mới";
            this.btnCus.UseVisualStyleBackColor = false;
            this.btnCus.Click += new System.EventHandler(this.btnCus_Click);
            // 
            // cbCustomerID
            // 
            this.cbCustomerID.FormattingEnabled = true;
            this.cbCustomerID.Location = new System.Drawing.Point(148, 154);
            this.cbCustomerID.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cbCustomerID.Name = "cbCustomerID";
            this.cbCustomerID.Size = new System.Drawing.Size(122, 26);
            this.cbCustomerID.TabIndex = 55;
            this.cbCustomerID.SelectedIndexChanged += new System.EventHandler(this.cbCustomerID_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI Black", 11F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(4, 81);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 25);
            this.label3.TabIndex = 50;
            this.label3.Text = "Mã HĐ";
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewTextBoxColumn1.FillWeight = 173.135F;
            this.dataGridViewTextBoxColumn1.HeaderText = "STT";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewTextBoxColumn1.Width = 50;
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.FillWeight = 115.0713F;
            this.dataGridViewImageColumn1.HeaderText = "Bìa sách";
            this.dataGridViewImageColumn1.MinimumWidth = 6;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.ReadOnly = true;
            this.dataGridViewImageColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewImageColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewImageColumn1.Width = 277;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.FillWeight = 45.5081F;
            this.dataGridViewTextBoxColumn2.HeaderText = "Mã sách";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 109;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.FillWeight = 48.46496F;
            this.dataGridViewTextBoxColumn3.HeaderText = "Mã HĐ";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 117;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.FillWeight = 55.47709F;
            this.dataGridViewTextBoxColumn7.HeaderText = "Giá";
            this.dataGridViewTextBoxColumn7.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            this.dataGridViewTextBoxColumn7.Width = 133;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.FillWeight = 94.79729F;
            this.dataGridViewTextBoxColumn8.HeaderText = "Số lượng mua";
            this.dataGridViewTextBoxColumn8.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            this.dataGridViewTextBoxColumn8.Width = 228;
            // 
            // TongTien
            // 
            this.TongTien.FillWeight = 115.0713F;
            this.TongTien.HeaderText = "Tổng Tiền";
            this.TongTien.MinimumWidth = 6;
            this.TongTien.Name = "TongTien";
            this.TongTien.ReadOnly = true;
            this.TongTien.Width = 277;
            // 
            // frmSell
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Khaki;
            this.ClientSize = new System.Drawing.Size(1555, 1022);
            this.Controls.Add(this.btnUnFilter);
            this.Controls.Add(this.dgvBill);
            this.Controls.Add(this.btnfilter);
            this.Controls.Add(this.cbPublisherNAME);
            this.Controls.Add(this.cbAuthorNAME);
            this.Controls.Add(this.cbCategoryNAME);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgvBillDetail);
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
            ((System.ComponentModel.ISupportInitialize)(this.dgvBillDetail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBill)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBookID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.DataGridView dgvAllBook;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBillID;
        private System.Windows.Forms.ComboBox cbEmployeeID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dgvBillDetail;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbCustomerID;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnCreateBill;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Label labelTongTien;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnCus;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblEmployeeNAME;
        private System.Windows.Forms.Label lblCustomerNAME;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cbCategoryNAME;
        private System.Windows.Forms.ComboBox cbAuthorNAME;
        private System.Windows.Forms.ComboBox cbPublisherNAME;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button btnfilter;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.DataGridViewTextBoxColumn stt;
        private System.Windows.Forms.DataGridViewImageColumn BookIMAGE;
        private System.Windows.Forms.DataGridViewTextBoxColumn BookID;
        private System.Windows.Forms.DataGridViewTextBoxColumn BookName;
        private System.Windows.Forms.DataGridViewTextBoxColumn CategoryName;
        private System.Windows.Forms.DataGridViewTextBoxColumn AuthorName;
        private System.Windows.Forms.DataGridViewTextBoxColumn PublisherNAME;
        private System.Windows.Forms.DataGridViewTextBoxColumn BookPRICE;
        private System.Windows.Forms.DataGridViewTextBoxColumn BookAMOUNT;
        private System.Windows.Forms.DataGridView dgvBill;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn BillID;
        private System.Windows.Forms.DataGridViewTextBoxColumn SumBill1;
        private System.Windows.Forms.DataGridViewTextBoxColumn BuyDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustomerID;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmpID;
        private System.Windows.Forms.Button btnUnFilter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn TongTien;
    }
}