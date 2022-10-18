namespace Project_QuanLyCuaHangSach
{
    partial class frmBook
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBook));
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
            this.panel = new System.Windows.Forms.Panel();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnLoadBia = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnSuaPublisher = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.pictureBoxImageB = new System.Windows.Forms.PictureBox();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.cbAuthorNAME = new System.Windows.Forms.ComboBox();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSuaCategory = new System.Windows.Forms.Button();
            this.btnSuaAuthor = new System.Windows.Forms.Button();
            this.cbPublisherNAME = new System.Windows.Forms.ComboBox();
            this.cbCategoryNAME = new System.Windows.Forms.ComboBox();
            this.txtBookID = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtBookAMOUNT = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBookPRICE = new System.Windows.Forms.TextBox();
            this.txtBookNAME = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllBook)).BeginInit();
            this.panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImageB)).BeginInit();
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
            this.dgvAllBook.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAllBook.BackgroundColor = System.Drawing.Color.NavajoWhite;
            this.dgvAllBook.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
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
            this.dgvAllBook.Location = new System.Drawing.Point(29, 322);
            this.dgvAllBook.Margin = new System.Windows.Forms.Padding(4);
            this.dgvAllBook.MultiSelect = false;
            this.dgvAllBook.Name = "dgvAllBook";
            this.dgvAllBook.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Times New Roman", 10F);
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
            this.dgvAllBook.Size = new System.Drawing.Size(1380, 251);
            this.dgvAllBook.TabIndex = 47;
            // 
            // stt
            // 
            this.stt.FillWeight = 38.51598F;
            this.stt.HeaderText = "STT";
            this.stt.MinimumWidth = 6;
            this.stt.Name = "stt";
            this.stt.ReadOnly = true;
            this.stt.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // BookIMAGE
            // 
            this.BookIMAGE.HeaderText = "Bìa sách";
            this.BookIMAGE.MinimumWidth = 6;
            this.BookIMAGE.Name = "BookIMAGE";
            this.BookIMAGE.ReadOnly = true;
            this.BookIMAGE.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.BookIMAGE.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // BookID
            // 
            this.BookID.FillWeight = 71.58199F;
            this.BookID.HeaderText = "Mã sách";
            this.BookID.MinimumWidth = 6;
            this.BookID.Name = "BookID";
            this.BookID.ReadOnly = true;
            // 
            // BookName
            // 
            this.BookName.FillWeight = 164.5794F;
            this.BookName.HeaderText = "Tên sách";
            this.BookName.MinimumWidth = 6;
            this.BookName.Name = "BookName";
            this.BookName.ReadOnly = true;
            // 
            // CategoryName
            // 
            this.CategoryName.FillWeight = 175.4011F;
            this.CategoryName.HeaderText = "Thể loại";
            this.CategoryName.MinimumWidth = 30;
            this.CategoryName.Name = "CategoryName";
            this.CategoryName.ReadOnly = true;
            // 
            // AuthorName
            // 
            this.AuthorName.FillWeight = 95.56902F;
            this.AuthorName.HeaderText = "Tác giả";
            this.AuthorName.MinimumWidth = 6;
            this.AuthorName.Name = "AuthorName";
            this.AuthorName.ReadOnly = true;
            // 
            // PublisherNAME
            // 
            this.PublisherNAME.FillWeight = 101.5049F;
            this.PublisherNAME.HeaderText = "NXB";
            this.PublisherNAME.MinimumWidth = 6;
            this.PublisherNAME.Name = "PublisherNAME";
            this.PublisherNAME.ReadOnly = true;
            // 
            // BookPRICE
            // 
            this.BookPRICE.FillWeight = 90.46624F;
            this.BookPRICE.HeaderText = "Giá";
            this.BookPRICE.MinimumWidth = 6;
            this.BookPRICE.Name = "BookPRICE";
            this.BookPRICE.ReadOnly = true;
            // 
            // BookAMOUNT
            // 
            this.BookAMOUNT.FillWeight = 82.3814F;
            this.BookAMOUNT.HeaderText = "Số lượng";
            this.BookAMOUNT.MinimumWidth = 6;
            this.BookAMOUNT.Name = "BookAMOUNT";
            this.BookAMOUNT.ReadOnly = true;
            // 
            // panel
            // 
            this.panel.BackColor = System.Drawing.Color.Transparent;
            this.panel.BackgroundImage = global::Project_QuanLyCuaHangSach.Properties.Resources.tron_bo_hinh_nen_may_tinh_hinh_quyen_sach_dep_nhat_2017_5;
            this.panel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel.Controls.Add(this.btnSearch);
            this.panel.Controls.Add(this.btnLoadBia);
            this.panel.Controls.Add(this.btnHuy);
            this.panel.Controls.Add(this.btnSuaPublisher);
            this.panel.Controls.Add(this.btnThoat);
            this.panel.Controls.Add(this.btnLuu);
            this.panel.Controls.Add(this.pictureBoxImageB);
            this.panel.Controls.Add(this.btnSua);
            this.panel.Controls.Add(this.btnXoa);
            this.panel.Controls.Add(this.cbAuthorNAME);
            this.panel.Controls.Add(this.btnThem);
            this.panel.Controls.Add(this.btnSuaCategory);
            this.panel.Controls.Add(this.btnSuaAuthor);
            this.panel.Controls.Add(this.cbPublisherNAME);
            this.panel.Controls.Add(this.cbCategoryNAME);
            this.panel.Controls.Add(this.txtBookID);
            this.panel.Controls.Add(this.label8);
            this.panel.Controls.Add(this.txtBookAMOUNT);
            this.panel.Controls.Add(this.label2);
            this.panel.Controls.Add(this.txtBookPRICE);
            this.panel.Controls.Add(this.txtBookNAME);
            this.panel.Controls.Add(this.label6);
            this.panel.Controls.Add(this.label3);
            this.panel.Controls.Add(this.label7);
            this.panel.Controls.Add(this.label5);
            this.panel.Controls.Add(this.label4);
            this.panel.Controls.Add(this.label1);
            this.panel.Location = new System.Drawing.Point(29, 12);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(1380, 288);
            this.panel.TabIndex = 48;
            // 
            // btnSearch
            // 
            this.btnSearch.BackgroundImage = global::Project_QuanLyCuaHangSach.Properties.Resources.tk;
            this.btnSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSearch.Location = new System.Drawing.Point(409, 21);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(37, 29);
            this.btnSearch.TabIndex = 54;
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnLoadBia
            // 
            this.btnLoadBia.BackColor = System.Drawing.Color.Orange;
            this.btnLoadBia.Font = new System.Drawing.Font("Verdana", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btnLoadBia.Location = new System.Drawing.Point(861, 53);
            this.btnLoadBia.Name = "btnLoadBia";
            this.btnLoadBia.Size = new System.Drawing.Size(124, 37);
            this.btnLoadBia.TabIndex = 53;
            this.btnLoadBia.Text = "Tải Bìa";
            this.btnLoadBia.UseVisualStyleBackColor = false;
            this.btnLoadBia.Click += new System.EventHandler(this.btnLoadBia_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.BackColor = System.Drawing.Color.Orange;
            this.btnHuy.Enabled = false;
            this.btnHuy.Font = new System.Drawing.Font("Verdana", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btnHuy.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnHuy.Location = new System.Drawing.Point(672, 231);
            this.btnHuy.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(90, 37);
            this.btnHuy.TabIndex = 31;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = false;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnSuaPublisher
            // 
            this.btnSuaPublisher.BackColor = System.Drawing.Color.Transparent;
            this.btnSuaPublisher.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSuaPublisher.BackgroundImage")));
            this.btnSuaPublisher.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSuaPublisher.Location = new System.Drawing.Point(449, 247);
            this.btnSuaPublisher.Name = "btnSuaPublisher";
            this.btnSuaPublisher.Size = new System.Drawing.Size(41, 24);
            this.btnSuaPublisher.TabIndex = 52;
            this.btnSuaPublisher.UseVisualStyleBackColor = false;
            this.btnSuaPublisher.Click += new System.EventHandler(this.btnSuaPublisher_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.Color.Orange;
            this.btnThoat.Font = new System.Drawing.Font("Verdana", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btnThoat.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnThoat.Location = new System.Drawing.Point(777, 231);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(90, 37);
            this.btnThoat.TabIndex = 27;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.BackColor = System.Drawing.Color.Orange;
            this.btnLuu.Enabled = false;
            this.btnLuu.Font = new System.Drawing.Font("Verdana", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btnLuu.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnLuu.Location = new System.Drawing.Point(570, 231);
            this.btnLuu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(85, 37);
            this.btnLuu.TabIndex = 29;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = false;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // pictureBoxImageB
            // 
            this.pictureBoxImageB.BackColor = System.Drawing.Color.Beige;
            this.pictureBoxImageB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxImageB.Location = new System.Drawing.Point(991, 3);
            this.pictureBoxImageB.Name = "pictureBoxImageB";
            this.pictureBoxImageB.Size = new System.Drawing.Size(224, 268);
            this.pictureBoxImageB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxImageB.TabIndex = 45;
            this.pictureBoxImageB.TabStop = false;
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.Color.Orange;
            this.btnSua.Font = new System.Drawing.Font("Verdana", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btnSua.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnSua.Location = new System.Drawing.Point(672, 167);
            this.btnSua.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(90, 37);
            this.btnSua.TabIndex = 30;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.Orange;
            this.btnXoa.Font = new System.Drawing.Font("Verdana", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btnXoa.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnXoa.Location = new System.Drawing.Point(777, 167);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(90, 37);
            this.btnXoa.TabIndex = 26;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // cbAuthorNAME
            // 
            this.cbAuthorNAME.Enabled = false;
            this.cbAuthorNAME.FormattingEnabled = true;
            this.cbAuthorNAME.Location = new System.Drawing.Point(202, 200);
            this.cbAuthorNAME.Name = "cbAuthorNAME";
            this.cbAuthorNAME.Size = new System.Drawing.Size(241, 24);
            this.cbAuthorNAME.TabIndex = 48;
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.Orange;
            this.btnThem.Font = new System.Drawing.Font("Verdana", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnThem.Location = new System.Drawing.Point(570, 167);
            this.btnThem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(85, 37);
            this.btnThem.TabIndex = 28;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnSuaCategory
            // 
            this.btnSuaCategory.BackColor = System.Drawing.Color.Transparent;
            this.btnSuaCategory.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSuaCategory.BackgroundImage")));
            this.btnSuaCategory.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSuaCategory.Location = new System.Drawing.Point(449, 146);
            this.btnSuaCategory.Name = "btnSuaCategory";
            this.btnSuaCategory.Size = new System.Drawing.Size(41, 28);
            this.btnSuaCategory.TabIndex = 50;
            this.btnSuaCategory.UseVisualStyleBackColor = false;
            this.btnSuaCategory.Click += new System.EventHandler(this.btnSuaCategory_Click);
            // 
            // btnSuaAuthor
            // 
            this.btnSuaAuthor.BackColor = System.Drawing.Color.Transparent;
            this.btnSuaAuthor.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSuaAuthor.BackgroundImage")));
            this.btnSuaAuthor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSuaAuthor.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnSuaAuthor.Location = new System.Drawing.Point(449, 199);
            this.btnSuaAuthor.Name = "btnSuaAuthor";
            this.btnSuaAuthor.Size = new System.Drawing.Size(41, 24);
            this.btnSuaAuthor.TabIndex = 51;
            this.btnSuaAuthor.UseVisualStyleBackColor = false;
            this.btnSuaAuthor.Click += new System.EventHandler(this.btnSuaAuthor_Click);
            // 
            // cbPublisherNAME
            // 
            this.cbPublisherNAME.Enabled = false;
            this.cbPublisherNAME.FormattingEnabled = true;
            this.cbPublisherNAME.Location = new System.Drawing.Point(202, 247);
            this.cbPublisherNAME.Name = "cbPublisherNAME";
            this.cbPublisherNAME.Size = new System.Drawing.Size(241, 24);
            this.cbPublisherNAME.TabIndex = 49;
            // 
            // cbCategoryNAME
            // 
            this.cbCategoryNAME.Enabled = false;
            this.cbCategoryNAME.FormattingEnabled = true;
            this.cbCategoryNAME.Location = new System.Drawing.Point(202, 148);
            this.cbCategoryNAME.Name = "cbCategoryNAME";
            this.cbCategoryNAME.Size = new System.Drawing.Size(241, 24);
            this.cbCategoryNAME.TabIndex = 47;
            // 
            // txtBookID
            // 
            this.txtBookID.Location = new System.Drawing.Point(200, 21);
            this.txtBookID.Name = "txtBookID";
            this.txtBookID.Size = new System.Drawing.Size(203, 22);
            this.txtBookID.TabIndex = 46;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold);
            this.label8.ForeColor = System.Drawing.Color.PeachPuff;
            this.label8.Location = new System.Drawing.Point(85, 21);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(98, 28);
            this.label8.TabIndex = 45;
            this.label8.Text = "Mã sách:";
            // 
            // txtBookAMOUNT
            // 
            this.txtBookAMOUNT.Enabled = false;
            this.txtBookAMOUNT.Location = new System.Drawing.Point(610, 86);
            this.txtBookAMOUNT.Name = "txtBookAMOUNT";
            this.txtBookAMOUNT.Size = new System.Drawing.Size(196, 22);
            this.txtBookAMOUNT.TabIndex = 42;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.PeachPuff;
            this.label2.Location = new System.Drawing.Point(880, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 28);
            this.label2.TabIndex = 35;
            this.label2.Text = "Bìa Sách: ";
            // 
            // txtBookPRICE
            // 
            this.txtBookPRICE.Enabled = false;
            this.txtBookPRICE.Location = new System.Drawing.Point(610, 28);
            this.txtBookPRICE.Name = "txtBookPRICE";
            this.txtBookPRICE.Size = new System.Drawing.Size(196, 22);
            this.txtBookPRICE.TabIndex = 43;
            // 
            // txtBookNAME
            // 
            this.txtBookNAME.Enabled = false;
            this.txtBookNAME.Location = new System.Drawing.Point(202, 80);
            this.txtBookNAME.Name = "txtBookNAME";
            this.txtBookNAME.Size = new System.Drawing.Size(241, 22);
            this.txtBookNAME.TabIndex = 44;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.PeachPuff;
            this.label6.Location = new System.Drawing.Point(82, 141);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(101, 28);
            this.label6.TabIndex = 32;
            this.label6.Text = "Thể Loại:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.PeachPuff;
            this.label3.Location = new System.Drawing.Point(82, 193);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 28);
            this.label3.TabIndex = 33;
            this.label3.Text = "Tác Giả: ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.Color.PeachPuff;
            this.label7.Location = new System.Drawing.Point(19, 240);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(159, 28);
            this.label7.TabIndex = 34;
            this.label7.Text = "Nhà Xuất Bản: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.PeachPuff;
            this.label5.Location = new System.Drawing.Point(483, 80);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 28);
            this.label5.TabIndex = 36;
            this.label5.Text = "Số Lượng:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.PeachPuff;
            this.label4.Location = new System.Drawing.Point(483, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 28);
            this.label4.TabIndex = 37;
            this.label4.Text = "Giá Tiền:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.PeachPuff;
            this.label1.Location = new System.Drawing.Point(82, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 28);
            this.label1.TabIndex = 38;
            this.label1.Text = "Tên Sách:";
            // 
            // frmBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Goldenrod;
            this.ClientSize = new System.Drawing.Size(1439, 596);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.dgvAllBook);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmBook";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kho Sách";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmBook_FormClosed);
            //this.Load += new System.EventHandler(this.frmBook_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllBook)).EndInit();
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImageB)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.Button btnLoadBia;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnSuaPublisher;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.PictureBox pictureBoxImageB;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.ComboBox cbAuthorNAME;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSuaCategory;
        private System.Windows.Forms.Button btnSuaAuthor;
        private System.Windows.Forms.ComboBox cbPublisherNAME;
        private System.Windows.Forms.ComboBox cbCategoryNAME;
        private System.Windows.Forms.TextBox txtBookID;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtBookAMOUNT;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBookPRICE;
        private System.Windows.Forms.TextBox txtBookNAME;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvAllBook;
        private System.Windows.Forms.DataGridViewTextBoxColumn stt;
        private System.Windows.Forms.DataGridViewImageColumn BookIMAGE;
        private System.Windows.Forms.DataGridViewTextBoxColumn BookID;
        private System.Windows.Forms.DataGridViewTextBoxColumn BookName;
        private System.Windows.Forms.DataGridViewTextBoxColumn CategoryName;
        private System.Windows.Forms.DataGridViewTextBoxColumn AuthorName;
        private System.Windows.Forms.DataGridViewTextBoxColumn PublisherNAME;
        private System.Windows.Forms.DataGridViewTextBoxColumn BookPRICE;
        private System.Windows.Forms.DataGridViewTextBoxColumn BookAMOUNT;
        private System.Windows.Forms.Button btnSearch;
    }
}