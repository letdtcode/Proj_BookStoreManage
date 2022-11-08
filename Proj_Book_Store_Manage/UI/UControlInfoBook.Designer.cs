
namespace Proj_Book_Store_Manage.UI
{
    partial class UControlInfoBook
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
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.lblSearchBy = new System.Windows.Forms.Label();
            this.gpSearch = new System.Windows.Forms.GroupBox();
            this.cbAttributeSearch = new System.Windows.Forms.ComboBox();
            this.btnReload = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtNameBook = new System.Windows.Forms.TextBox();
            this.lblAmount = new System.Windows.Forms.Label();
            this.lblNameBook = new System.Windows.Forms.Label();
            this.gbInfoBook = new System.Windows.Forms.GroupBox();
            this.cbIDPublisher = new System.Windows.Forms.ComboBox();
            this.txtPriceExport = new System.Windows.Forms.TextBox();
            this.txtPriceImport = new System.Windows.Forms.TextBox();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.lblPriceExport = new System.Windows.Forms.Label();
            this.lblPublisher = new System.Windows.Forms.Label();
            this.lblPriceImport = new System.Windows.Forms.Label();
            this.lblIDBook = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnUploadImg = new System.Windows.Forms.Button();
            this.ptbBook = new System.Windows.Forms.PictureBox();
            this.dgvBook = new System.Windows.Forms.DataGridView();
            this.panelCategory = new System.Windows.Forms.Panel();
            this.gbAuthor = new System.Windows.Forms.GroupBox();
            this.cbaddAuthor = new System.Windows.Forms.ComboBox();
            this.dgvAuthor = new System.Windows.Forms.DataGridView();
            this.btnEditAuthor = new System.Windows.Forms.Button();
            this.btnSaveAuthor = new System.Windows.Forms.Button();
            this.btnDeleteAuthor = new System.Windows.Forms.Button();
            this.btnAddAuthor = new System.Windows.Forms.Button();
            this.lblNameAuthor = new System.Windows.Forms.Label();
            this.gbCategoryBook = new System.Windows.Forms.GroupBox();
            this.cbaddCategory = new System.Windows.Forms.ComboBox();
            this.dgvCategory = new System.Windows.Forms.DataGridView();
            this.btnSaveCate = new System.Windows.Forms.Button();
            this.btnEditCate = new System.Windows.Forms.Button();
            this.btnDeleteCate = new System.Windows.Forms.Button();
            this.btnAddCate = new System.Windows.Forms.Button();
            this.lblNameCategory = new System.Windows.Forms.Label();
            this.gpSearch.SuspendLayout();
            this.gbInfoBook.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbBook)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBook)).BeginInit();
            this.panelCategory.SuspendLayout();
            this.gbAuthor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAuthor)).BeginInit();
            this.gbCategoryBook.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategory)).BeginInit();
            this.SuspendLayout();
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(63, 110);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(224, 22);
            this.txtSearch.TabIndex = 2;
            // 
            // lblSearchBy
            // 
            this.lblSearchBy.AutoSize = true;
            this.lblSearchBy.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearchBy.Location = new System.Drawing.Point(23, 49);
            this.lblSearchBy.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSearchBy.Name = "lblSearchBy";
            this.lblSearchBy.Size = new System.Drawing.Size(93, 21);
            this.lblSearchBy.TabIndex = 0;
            this.lblSearchBy.Text = "Thuộc tính";
            // 
            // gpSearch
            // 
            this.gpSearch.Controls.Add(this.txtSearch);
            this.gpSearch.Controls.Add(this.cbAttributeSearch);
            this.gpSearch.Controls.Add(this.lblSearchBy);
            this.gpSearch.Location = new System.Drawing.Point(486, 6);
            this.gpSearch.Name = "gpSearch";
            this.gpSearch.Size = new System.Drawing.Size(293, 153);
            this.gpSearch.TabIndex = 1;
            this.gpSearch.TabStop = false;
            this.gpSearch.Text = "Tìm kiếm";
            // 
            // cbAttributeSearch
            // 
            this.cbAttributeSearch.FormattingEnabled = true;
            this.cbAttributeSearch.Location = new System.Drawing.Point(132, 46);
            this.cbAttributeSearch.Name = "cbAttributeSearch";
            this.cbAttributeSearch.Size = new System.Drawing.Size(121, 24);
            this.cbAttributeSearch.TabIndex = 1;
            // 
            // btnReload
            // 
            this.btnReload.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReload.Location = new System.Drawing.Point(519, 187);
            this.btnReload.Name = "btnReload";
            this.btnReload.Size = new System.Drawing.Size(87, 53);
            this.btnReload.TabIndex = 1;
            this.btnReload.Text = "Tải lại";
            this.btnReload.UseVisualStyleBackColor = true;
            this.btnReload.Click += new System.EventHandler(this.btnReload_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(14, 187);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(87, 53);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.Location = new System.Drawing.Point(115, 187);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(87, 53);
            this.btnEdit.TabIndex = 1;
            this.btnEdit.Text = "Sửa";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(418, 187);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(87, 53);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "Hủy";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(216, 187);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(87, 53);
            this.btnDelete.TabIndex = 1;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(317, 187);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(87, 53);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "Lưu";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtNameBook
            // 
            this.txtNameBook.Location = new System.Drawing.Point(106, 84);
            this.txtNameBook.Name = "txtNameBook";
            this.txtNameBook.Size = new System.Drawing.Size(147, 22);
            this.txtNameBook.TabIndex = 2;
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAmount.Location = new System.Drawing.Point(10, 129);
            this.lblAmount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(74, 21);
            this.lblAmount.TabIndex = 1;
            this.lblAmount.Text = "Số lượng";
            // 
            // lblNameBook
            // 
            this.lblNameBook.AutoSize = true;
            this.lblNameBook.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNameBook.Location = new System.Drawing.Point(10, 85);
            this.lblNameBook.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNameBook.Name = "lblNameBook";
            this.lblNameBook.Size = new System.Drawing.Size(85, 21);
            this.lblNameBook.TabIndex = 0;
            this.lblNameBook.Text = "Tên Sách";
            // 
            // gbInfoBook
            // 
            this.gbInfoBook.Controls.Add(this.cbIDPublisher);
            this.gbInfoBook.Controls.Add(this.txtPriceExport);
            this.gbInfoBook.Controls.Add(this.txtPriceImport);
            this.gbInfoBook.Controls.Add(this.txtAmount);
            this.gbInfoBook.Controls.Add(this.txtNameBook);
            this.gbInfoBook.Controls.Add(this.lblPriceExport);
            this.gbInfoBook.Controls.Add(this.lblPublisher);
            this.gbInfoBook.Controls.Add(this.lblPriceImport);
            this.gbInfoBook.Controls.Add(this.lblAmount);
            this.gbInfoBook.Controls.Add(this.lblIDBook);
            this.gbInfoBook.Controls.Add(this.label1);
            this.gbInfoBook.Controls.Add(this.lblNameBook);
            this.gbInfoBook.Location = new System.Drawing.Point(4, 6);
            this.gbInfoBook.Margin = new System.Windows.Forms.Padding(4);
            this.gbInfoBook.Name = "gbInfoBook";
            this.gbInfoBook.Padding = new System.Windows.Forms.Padding(4);
            this.gbInfoBook.Size = new System.Drawing.Size(458, 170);
            this.gbInfoBook.TabIndex = 0;
            this.gbInfoBook.TabStop = false;
            this.gbInfoBook.Text = "Thông tin Sách";
            // 
            // cbIDPublisher
            // 
            this.cbIDPublisher.FormattingEnabled = true;
            this.cbIDPublisher.Items.AddRange(new object[] {
            "3"});
            this.cbIDPublisher.Location = new System.Drawing.Point(359, 39);
            this.cbIDPublisher.Name = "cbIDPublisher";
            this.cbIDPublisher.Size = new System.Drawing.Size(99, 24);
            this.cbIDPublisher.TabIndex = 3;
            // 
            // txtPriceExport
            // 
            this.txtPriceExport.Location = new System.Drawing.Point(364, 131);
            this.txtPriceExport.Name = "txtPriceExport";
            this.txtPriceExport.Size = new System.Drawing.Size(87, 22);
            this.txtPriceExport.TabIndex = 2;
            // 
            // txtPriceImport
            // 
            this.txtPriceImport.Location = new System.Drawing.Point(364, 86);
            this.txtPriceImport.Name = "txtPriceImport";
            this.txtPriceImport.Size = new System.Drawing.Size(87, 22);
            this.txtPriceImport.TabIndex = 2;
            // 
            // txtAmount
            // 
            this.txtAmount.Location = new System.Drawing.Point(105, 130);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(147, 22);
            this.txtAmount.TabIndex = 2;
            // 
            // lblPriceExport
            // 
            this.lblPriceExport.AutoSize = true;
            this.lblPriceExport.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPriceExport.Location = new System.Drawing.Point(268, 131);
            this.lblPriceExport.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPriceExport.Name = "lblPriceExport";
            this.lblPriceExport.Size = new System.Drawing.Size(77, 21);
            this.lblPriceExport.TabIndex = 1;
            this.lblPriceExport.Text = "Giá Bán";
            // 
            // lblPublisher
            // 
            this.lblPublisher.AutoSize = true;
            this.lblPublisher.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPublisher.Location = new System.Drawing.Point(268, 39);
            this.lblPublisher.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPublisher.Name = "lblPublisher";
            this.lblPublisher.Size = new System.Drawing.Size(43, 21);
            this.lblPublisher.TabIndex = 1;
            this.lblPublisher.Text = "NXB";
            // 
            // lblPriceImport
            // 
            this.lblPriceImport.AutoSize = true;
            this.lblPriceImport.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPriceImport.Location = new System.Drawing.Point(268, 88);
            this.lblPriceImport.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPriceImport.Name = "lblPriceImport";
            this.lblPriceImport.Size = new System.Drawing.Size(89, 21);
            this.lblPriceImport.TabIndex = 1;
            this.lblPriceImport.Text = "Giá Nhập";
            // 
            // lblIDBook
            // 
            this.lblIDBook.AutoSize = true;
            this.lblIDBook.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIDBook.Location = new System.Drawing.Point(101, 39);
            this.lblIDBook.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIDBook.Name = "lblIDBook";
            this.lblIDBook.Size = new System.Drawing.Size(55, 21);
            this.lblIDBook.TabIndex = 0;
            this.lblIDBook.Text = "None";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 42);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID Sách";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnUploadImg);
            this.panel1.Controls.Add(this.ptbBook);
            this.panel1.Controls.Add(this.gpSearch);
            this.panel1.Controls.Add(this.gbInfoBook);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1072, 180);
            this.panel1.TabIndex = 3;
            // 
            // btnUploadImg
            // 
            this.btnUploadImg.Location = new System.Drawing.Point(974, 68);
            this.btnUploadImg.Name = "btnUploadImg";
            this.btnUploadImg.Size = new System.Drawing.Size(73, 44);
            this.btnUploadImg.TabIndex = 3;
            this.btnUploadImg.Text = "Up Ảnh";
            this.btnUploadImg.UseVisualStyleBackColor = true;
            this.btnUploadImg.Click += new System.EventHandler(this.btnUploadImg_Click);
            // 
            // ptbBook
            // 
            this.ptbBook.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ptbBook.Location = new System.Drawing.Point(811, 6);
            this.ptbBook.Name = "ptbBook";
            this.ptbBook.Size = new System.Drawing.Size(155, 153);
            this.ptbBook.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbBook.TabIndex = 2;
            this.ptbBook.TabStop = false;
            // 
            // dgvBook
            // 
            this.dgvBook.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgvBook.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBook.Location = new System.Drawing.Point(18, 275);
            this.dgvBook.Name = "dgvBook";
            this.dgvBook.ReadOnly = true;
            this.dgvBook.RowHeadersWidth = 51;
            this.dgvBook.RowTemplate.Height = 24;
            this.dgvBook.Size = new System.Drawing.Size(602, 294);
            this.dgvBook.TabIndex = 5;
            this.dgvBook.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBook_CellClick);
            // 
            // panelCategory
            // 
            this.panelCategory.Controls.Add(this.gbAuthor);
            this.panelCategory.Controls.Add(this.gbCategoryBook);
            this.panelCategory.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelCategory.Location = new System.Drawing.Point(640, 180);
            this.panelCategory.Name = "panelCategory";
            this.panelCategory.Size = new System.Drawing.Size(432, 401);
            this.panelCategory.TabIndex = 7;
            // 
            // gbAuthor
            // 
            this.gbAuthor.Controls.Add(this.cbaddAuthor);
            this.gbAuthor.Controls.Add(this.dgvAuthor);
            this.gbAuthor.Controls.Add(this.btnEditAuthor);
            this.gbAuthor.Controls.Add(this.btnSaveAuthor);
            this.gbAuthor.Controls.Add(this.btnDeleteAuthor);
            this.gbAuthor.Controls.Add(this.btnAddAuthor);
            this.gbAuthor.Controls.Add(this.lblNameAuthor);
            this.gbAuthor.Location = new System.Drawing.Point(12, 199);
            this.gbAuthor.Name = "gbAuthor";
            this.gbAuthor.Size = new System.Drawing.Size(417, 190);
            this.gbAuthor.TabIndex = 0;
            this.gbAuthor.TabStop = false;
            this.gbAuthor.Text = "Tác giả";
            // 
            // cbaddAuthor
            // 
            this.cbaddAuthor.FormattingEnabled = true;
            this.cbaddAuthor.Location = new System.Drawing.Point(210, 33);
            this.cbaddAuthor.Name = "cbaddAuthor";
            this.cbaddAuthor.Size = new System.Drawing.Size(121, 24);
            this.cbaddAuthor.TabIndex = 2;
            // 
            // dgvAuthor
            // 
            this.dgvAuthor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAuthor.Location = new System.Drawing.Point(15, 82);
            this.dgvAuthor.Name = "dgvAuthor";
            this.dgvAuthor.ReadOnly = true;
            this.dgvAuthor.RowHeadersWidth = 51;
            this.dgvAuthor.RowTemplate.Height = 24;
            this.dgvAuthor.Size = new System.Drawing.Size(211, 95);
            this.dgvAuthor.TabIndex = 0;
            this.dgvAuthor.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAuthor_CellClick);
            // 
            // btnEditAuthor
            // 
            this.btnEditAuthor.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditAuthor.Location = new System.Drawing.Point(320, 82);
            this.btnEditAuthor.Name = "btnEditAuthor";
            this.btnEditAuthor.Size = new System.Drawing.Size(68, 43);
            this.btnEditAuthor.TabIndex = 1;
            this.btnEditAuthor.Text = "Sửa";
            this.btnEditAuthor.UseVisualStyleBackColor = true;
            this.btnEditAuthor.Click += new System.EventHandler(this.btnEditAuthor_Click);
            // 
            // btnSaveAuthor
            // 
            this.btnSaveAuthor.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveAuthor.Location = new System.Drawing.Point(320, 131);
            this.btnSaveAuthor.Name = "btnSaveAuthor";
            this.btnSaveAuthor.Size = new System.Drawing.Size(68, 43);
            this.btnSaveAuthor.TabIndex = 1;
            this.btnSaveAuthor.Text = "Lưu";
            this.btnSaveAuthor.UseVisualStyleBackColor = true;
            this.btnSaveAuthor.Click += new System.EventHandler(this.btnSaveAuthor_Click);
            // 
            // btnDeleteAuthor
            // 
            this.btnDeleteAuthor.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteAuthor.Location = new System.Drawing.Point(246, 131);
            this.btnDeleteAuthor.Name = "btnDeleteAuthor";
            this.btnDeleteAuthor.Size = new System.Drawing.Size(68, 43);
            this.btnDeleteAuthor.TabIndex = 1;
            this.btnDeleteAuthor.Text = "Xóa";
            this.btnDeleteAuthor.UseVisualStyleBackColor = true;
            this.btnDeleteAuthor.Click += new System.EventHandler(this.btnDeleteAuthor_Click);
            // 
            // btnAddAuthor
            // 
            this.btnAddAuthor.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddAuthor.Location = new System.Drawing.Point(246, 82);
            this.btnAddAuthor.Name = "btnAddAuthor";
            this.btnAddAuthor.Size = new System.Drawing.Size(68, 43);
            this.btnAddAuthor.TabIndex = 1;
            this.btnAddAuthor.Text = "Thêm";
            this.btnAddAuthor.UseVisualStyleBackColor = true;
            this.btnAddAuthor.Click += new System.EventHandler(this.btnAddAuthor_Click);
            // 
            // lblNameAuthor
            // 
            this.lblNameAuthor.AutoSize = true;
            this.lblNameAuthor.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNameAuthor.Location = new System.Drawing.Point(101, 33);
            this.lblNameAuthor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNameAuthor.Name = "lblNameAuthor";
            this.lblNameAuthor.Size = new System.Drawing.Size(87, 19);
            this.lblNameAuthor.TabIndex = 0;
            this.lblNameAuthor.Text = "Tên Tác Giả";
            // 
            // gbCategoryBook
            // 
            this.gbCategoryBook.Controls.Add(this.cbaddCategory);
            this.gbCategoryBook.Controls.Add(this.dgvCategory);
            this.gbCategoryBook.Controls.Add(this.btnSaveCate);
            this.gbCategoryBook.Controls.Add(this.btnEditCate);
            this.gbCategoryBook.Controls.Add(this.btnDeleteCate);
            this.gbCategoryBook.Controls.Add(this.btnAddCate);
            this.gbCategoryBook.Controls.Add(this.lblNameCategory);
            this.gbCategoryBook.Location = new System.Drawing.Point(12, 15);
            this.gbCategoryBook.Name = "gbCategoryBook";
            this.gbCategoryBook.Size = new System.Drawing.Size(417, 178);
            this.gbCategoryBook.TabIndex = 0;
            this.gbCategoryBook.TabStop = false;
            this.gbCategoryBook.Text = "Thể loại sách";
            // 
            // cbaddCategory
            // 
            this.cbaddCategory.FormattingEnabled = true;
            this.cbaddCategory.Location = new System.Drawing.Point(210, 28);
            this.cbaddCategory.Name = "cbaddCategory";
            this.cbaddCategory.Size = new System.Drawing.Size(121, 24);
            this.cbaddCategory.TabIndex = 2;
            // 
            // dgvCategory
            // 
            this.dgvCategory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCategory.Location = new System.Drawing.Point(15, 80);
            this.dgvCategory.Name = "dgvCategory";
            this.dgvCategory.ReadOnly = true;
            this.dgvCategory.RowHeadersWidth = 51;
            this.dgvCategory.RowTemplate.Height = 24;
            this.dgvCategory.Size = new System.Drawing.Size(211, 92);
            this.dgvCategory.TabIndex = 0;
            this.dgvCategory.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCategory_CellClick);
            // 
            // btnSaveCate
            // 
            this.btnSaveCate.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveCate.Location = new System.Drawing.Point(320, 133);
            this.btnSaveCate.Name = "btnSaveCate";
            this.btnSaveCate.Size = new System.Drawing.Size(68, 43);
            this.btnSaveCate.TabIndex = 1;
            this.btnSaveCate.Text = "Lưu";
            this.btnSaveCate.UseVisualStyleBackColor = true;
            this.btnSaveCate.Click += new System.EventHandler(this.btnSaveCate_Click);
            // 
            // btnEditCate
            // 
            this.btnEditCate.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditCate.Location = new System.Drawing.Point(320, 80);
            this.btnEditCate.Name = "btnEditCate";
            this.btnEditCate.Size = new System.Drawing.Size(68, 43);
            this.btnEditCate.TabIndex = 1;
            this.btnEditCate.Text = "Sửa";
            this.btnEditCate.UseVisualStyleBackColor = true;
            this.btnEditCate.Click += new System.EventHandler(this.btnEditCate_Click);
            // 
            // btnDeleteCate
            // 
            this.btnDeleteCate.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteCate.Location = new System.Drawing.Point(246, 133);
            this.btnDeleteCate.Name = "btnDeleteCate";
            this.btnDeleteCate.Size = new System.Drawing.Size(68, 43);
            this.btnDeleteCate.TabIndex = 1;
            this.btnDeleteCate.Text = "Xóa";
            this.btnDeleteCate.UseVisualStyleBackColor = true;
            this.btnDeleteCate.Click += new System.EventHandler(this.btnDeleteCate_Click);
            // 
            // btnAddCate
            // 
            this.btnAddCate.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddCate.Location = new System.Drawing.Point(246, 80);
            this.btnAddCate.Name = "btnAddCate";
            this.btnAddCate.Size = new System.Drawing.Size(68, 43);
            this.btnAddCate.TabIndex = 1;
            this.btnAddCate.Text = "Thêm";
            this.btnAddCate.UseVisualStyleBackColor = true;
            this.btnAddCate.Click += new System.EventHandler(this.btnAddCate_Click);
            // 
            // lblNameCategory
            // 
            this.lblNameCategory.AutoSize = true;
            this.lblNameCategory.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNameCategory.Location = new System.Drawing.Point(101, 33);
            this.lblNameCategory.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNameCategory.Name = "lblNameCategory";
            this.lblNameCategory.Size = new System.Drawing.Size(85, 19);
            this.lblNameCategory.TabIndex = 0;
            this.lblNameCategory.Text = "Tên Thể loại";
            // 
            // UControlInfoBook
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.panelCategory);
            this.Controls.Add(this.btnReload);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.dgvBook);
            this.Name = "UControlInfoBook";
            this.Size = new System.Drawing.Size(1072, 581);
            this.Load += new System.EventHandler(this.UControlInfoBook_Load);
            this.gpSearch.ResumeLayout(false);
            this.gpSearch.PerformLayout();
            this.gbInfoBook.ResumeLayout(false);
            this.gbInfoBook.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ptbBook)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBook)).EndInit();
            this.panelCategory.ResumeLayout(false);
            this.gbAuthor.ResumeLayout(false);
            this.gbAuthor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAuthor)).EndInit();
            this.gbCategoryBook.ResumeLayout(false);
            this.gbCategoryBook.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategory)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label lblSearchBy;
        private System.Windows.Forms.GroupBox gpSearch;
        private System.Windows.Forms.ComboBox cbAttributeSearch;
        private System.Windows.Forms.Button btnReload;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtNameBook;
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.Label lblNameBook;
        private System.Windows.Forms.GroupBox gbInfoBook;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvBook;
        private System.Windows.Forms.Label lblPriceExport;
        private System.Windows.Forms.Label lblPublisher;
        private System.Windows.Forms.Label lblPriceImport;
        private System.Windows.Forms.TextBox txtPriceExport;
        private System.Windows.Forms.TextBox txtPriceImport;
        private System.Windows.Forms.Panel panelCategory;
        private System.Windows.Forms.GroupBox gbAuthor;
        private System.Windows.Forms.DataGridView dgvAuthor;
        private System.Windows.Forms.GroupBox gbCategoryBook;
        private System.Windows.Forms.DataGridView dgvCategory;
        private System.Windows.Forms.PictureBox ptbBook;
        private System.Windows.Forms.Button btnSaveAuthor;
        private System.Windows.Forms.Button btnDeleteAuthor;
        private System.Windows.Forms.Button btnAddAuthor;
        private System.Windows.Forms.Label lblNameAuthor;
        private System.Windows.Forms.Button btnSaveCate;
        private System.Windows.Forms.Button btnDeleteCate;
        private System.Windows.Forms.Button btnAddCate;
        private System.Windows.Forms.Label lblNameCategory;
        private System.Windows.Forms.Button btnUploadImg;
        private System.Windows.Forms.ComboBox cbIDPublisher;
        private System.Windows.Forms.ComboBox cbaddAuthor;
        private System.Windows.Forms.ComboBox cbaddCategory;
        private System.Windows.Forms.Button btnEditAuthor;
        private System.Windows.Forms.Button btnEditCate;
        private System.Windows.Forms.Label lblIDBook;
        private System.Windows.Forms.Label label1;
    }
}
