namespace Proj_Book_Store_Manage.UI
{
    partial class FormAddBook
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
            this.dgvBook = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvAthor = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dgvCategory = new System.Windows.Forms.DataGridView();
            this.ptbBookImg = new System.Windows.Forms.PictureBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txtPriceIm = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtIdPub = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPriceEx = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBookName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnPushPath = new System.Windows.Forms.Button();
            this.btnAddAuthor = new System.Windows.Forms.Button();
            this.btnDelAuthor = new System.Windows.Forms.Button();
            this.btnAddCate = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnReload = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnAddBook = new System.Windows.Forms.Button();
            this.lbIdBook = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBook)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAthor)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbBookImg)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvBook
            // 
            this.dgvBook.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBook.Location = new System.Drawing.Point(6, 19);
            this.dgvBook.Name = "dgvBook";
            this.dgvBook.Size = new System.Drawing.Size(704, 236);
            this.dgvBook.TabIndex = 0;
            this.dgvBook.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBook_CellClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvBook);
            this.groupBox1.Location = new System.Drawing.Point(12, 290);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(716, 261);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Bảng Sách";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvAthor);
            this.groupBox2.Location = new System.Drawing.Point(942, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(290, 197);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Bảng Tác Giả";
            // 
            // dgvAthor
            // 
            this.dgvAthor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAthor.Location = new System.Drawing.Point(6, 19);
            this.dgvAthor.Name = "dgvAthor";
            this.dgvAthor.Size = new System.Drawing.Size(278, 172);
            this.dgvAthor.TabIndex = 0;
            this.dgvAthor.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAthor_CellClick);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dgvCategory);
            this.groupBox3.Location = new System.Drawing.Point(942, 296);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(290, 255);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Bảng Thể Loại";
            // 
            // dgvCategory
            // 
            this.dgvCategory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCategory.Location = new System.Drawing.Point(6, 19);
            this.dgvCategory.Name = "dgvCategory";
            this.dgvCategory.Size = new System.Drawing.Size(278, 230);
            this.dgvCategory.TabIndex = 0;
            this.dgvCategory.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCategory_CellClick);
            // 
            // ptbBookImg
            // 
            this.ptbBookImg.Location = new System.Drawing.Point(33, 31);
            this.ptbBookImg.Name = "ptbBookImg";
            this.ptbBookImg.Size = new System.Drawing.Size(100, 116);
            this.ptbBookImg.TabIndex = 4;
            this.ptbBookImg.TabStop = false;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.txtPriceIm);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.txtIdPub);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.txtPriceEx);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Controls.Add(this.txtBookName);
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Location = new System.Drawing.Point(178, 12);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(550, 197);
            this.groupBox4.TabIndex = 5;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Thông Tin";
            // 
            // txtPriceIm
            // 
            this.txtPriceIm.Location = new System.Drawing.Point(393, 63);
            this.txtPriceIm.Name = "txtPriceIm";
            this.txtPriceIm.Size = new System.Drawing.Size(100, 20);
            this.txtPriceIm.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(287, 66);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Giá Nhập Kho";
            // 
            // txtIdPub
            // 
            this.txtIdPub.Location = new System.Drawing.Point(124, 104);
            this.txtIdPub.Name = "txtIdPub";
            this.txtIdPub.Size = new System.Drawing.Size(100, 20);
            this.txtIdPub.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Mã Nhà Xuất Bản";
            // 
            // txtPriceEx
            // 
            this.txtPriceEx.Location = new System.Drawing.Point(393, 108);
            this.txtPriceEx.Name = "txtPriceEx";
            this.txtPriceEx.Size = new System.Drawing.Size(100, 20);
            this.txtPriceEx.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(287, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Giá Xuất Kho";
            // 
            // txtBookName
            // 
            this.txtBookName.Location = new System.Drawing.Point(124, 63);
            this.txtBookName.Name = "txtBookName";
            this.txtBookName.Size = new System.Drawing.Size(100, 20);
            this.txtBookName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên Sách";
            // 
            // btnPushPath
            // 
            this.btnPushPath.Location = new System.Drawing.Point(37, 153);
            this.btnPushPath.Name = "btnPushPath";
            this.btnPushPath.Size = new System.Drawing.Size(87, 47);
            this.btnPushPath.TabIndex = 1;
            this.btnPushPath.Text = "Lấy Ảnh";
            this.btnPushPath.UseVisualStyleBackColor = true;
            // 
            // btnAddAuthor
            // 
            this.btnAddAuthor.Location = new System.Drawing.Point(849, 30);
            this.btnAddAuthor.Name = "btnAddAuthor";
            this.btnAddAuthor.Size = new System.Drawing.Size(87, 36);
            this.btnAddAuthor.TabIndex = 9;
            this.btnAddAuthor.Text = "Thêm Tác Giả";
            this.btnAddAuthor.UseVisualStyleBackColor = true;
            // 
            // btnDelAuthor
            // 
            this.btnDelAuthor.Location = new System.Drawing.Point(849, 80);
            this.btnDelAuthor.Name = "btnDelAuthor";
            this.btnDelAuthor.Size = new System.Drawing.Size(87, 36);
            this.btnDelAuthor.TabIndex = 10;
            this.btnDelAuthor.Text = "Xóa Tác Giả";
            this.btnDelAuthor.UseVisualStyleBackColor = true;
            // 
            // btnAddCate
            // 
            this.btnAddCate.Location = new System.Drawing.Point(849, 373);
            this.btnAddCate.Name = "btnAddCate";
            this.btnAddCate.Size = new System.Drawing.Size(87, 36);
            this.btnAddCate.TabIndex = 11;
            this.btnAddCate.Text = "Thêm Thể Loại";
            this.btnAddCate.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(849, 424);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(87, 36);
            this.button7.TabIndex = 12;
            this.button7.Text = "Xóa Thể Loại";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnReload);
            this.panel1.Controls.Add(this.btnCancel);
            this.panel1.Controls.Add(this.btnSave);
            this.panel1.Controls.Add(this.btnSearch);
            this.panel1.Controls.Add(this.btnEdit);
            this.panel1.Controls.Add(this.btnAddBook);
            this.panel1.Location = new System.Drawing.Point(18, 215);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(710, 55);
            this.panel1.TabIndex = 13;
            // 
            // btnReload
            // 
            this.btnReload.Location = new System.Drawing.Point(612, 11);
            this.btnReload.Name = "btnReload";
            this.btnReload.Size = new System.Drawing.Size(87, 36);
            this.btnReload.TabIndex = 22;
            this.btnReload.Text = "Làm Mới";
            this.btnReload.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(519, 11);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(87, 36);
            this.btnCancel.TabIndex = 21;
            this.btnCancel.Text = "Hủy";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(426, 11);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(87, 36);
            this.btnSave.TabIndex = 20;
            this.btnSave.Text = "Lưu";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(200, 11);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(87, 36);
            this.btnSearch.TabIndex = 18;
            this.btnSearch.Text = "Tìm";
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(105, 11);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(87, 36);
            this.btnEdit.TabIndex = 17;
            this.btnEdit.Text = "Sửa";
            this.btnEdit.UseVisualStyleBackColor = true;
            // 
            // btnAddBook
            // 
            this.btnAddBook.Location = new System.Drawing.Point(12, 11);
            this.btnAddBook.Name = "btnAddBook";
            this.btnAddBook.Size = new System.Drawing.Size(87, 36);
            this.btnAddBook.TabIndex = 16;
            this.btnAddBook.Text = "Thêm";
            this.btnAddBook.UseVisualStyleBackColor = true;
            this.btnAddBook.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lbIdBook
            // 
            this.lbIdBook.AutoSize = true;
            this.lbIdBook.Location = new System.Drawing.Point(743, 170);
            this.lbIdBook.Name = "lbIdBook";
            this.lbIdBook.Size = new System.Drawing.Size(0, 13);
            this.lbIdBook.TabIndex = 8;
            // 
            // FormAddBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1244, 563);
            this.Controls.Add(this.lbIdBook);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.btnAddCate);
            this.Controls.Add(this.btnDelAuthor);
            this.Controls.Add(this.btnAddAuthor);
            this.Controls.Add(this.btnPushPath);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.ptbBookImg);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormAddBook";
            this.Text = "FormAddBook";
            ((System.ComponentModel.ISupportInitialize)(this.dgvBook)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAthor)).EndInit();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbBookImg)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvBook;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvAthor;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dgvCategory;
        private System.Windows.Forms.PictureBox ptbBookImg;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox txtPriceIm;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtIdPub;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPriceEx;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBookName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnPushPath;
        private System.Windows.Forms.Button btnAddAuthor;
        private System.Windows.Forms.Button btnDelAuthor;
        private System.Windows.Forms.Button btnAddCate;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnReload;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnAddBook;
        private System.Windows.Forms.Label lbIdBook;
    }
}