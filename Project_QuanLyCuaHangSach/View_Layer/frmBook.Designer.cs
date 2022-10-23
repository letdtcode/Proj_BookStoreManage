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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBook));
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
            this.dgvAllBook = new System.Windows.Forms.DataGridView();
            this.panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImageB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllBook)).BeginInit();
            this.SuspendLayout();
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
            this.panel.Location = new System.Drawing.Point(22, 10);
            this.panel.Margin = new System.Windows.Forms.Padding(2);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(1036, 235);
            this.panel.TabIndex = 48;
            // 
            // btnSearch
            // 
            this.btnSearch.BackgroundImage = global::Project_QuanLyCuaHangSach.Properties.Resources.tk;
            this.btnSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSearch.Location = new System.Drawing.Point(307, 17);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(2);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(28, 24);
            this.btnSearch.TabIndex = 54;
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnLoadBia
            // 
            this.btnLoadBia.BackColor = System.Drawing.Color.Orange;
            this.btnLoadBia.Font = new System.Drawing.Font("Verdana", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btnLoadBia.Location = new System.Drawing.Point(646, 43);
            this.btnLoadBia.Margin = new System.Windows.Forms.Padding(2);
            this.btnLoadBia.Name = "btnLoadBia";
            this.btnLoadBia.Size = new System.Drawing.Size(93, 30);
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
            this.btnHuy.Location = new System.Drawing.Point(504, 188);
            this.btnHuy.Margin = new System.Windows.Forms.Padding(2);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(68, 30);
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
            this.btnSuaPublisher.Location = new System.Drawing.Point(337, 201);
            this.btnSuaPublisher.Margin = new System.Windows.Forms.Padding(2);
            this.btnSuaPublisher.Name = "btnSuaPublisher";
            this.btnSuaPublisher.Size = new System.Drawing.Size(31, 20);
            this.btnSuaPublisher.TabIndex = 52;
            this.btnSuaPublisher.UseVisualStyleBackColor = false;
            this.btnSuaPublisher.Click += new System.EventHandler(this.btnSuaPublisher_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.Color.Orange;
            this.btnThoat.Font = new System.Drawing.Font("Verdana", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btnThoat.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnThoat.Location = new System.Drawing.Point(611, 188);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(2);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(68, 30);
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
            this.btnLuu.Location = new System.Drawing.Point(428, 188);
            this.btnLuu.Margin = new System.Windows.Forms.Padding(2);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(64, 30);
            this.btnLuu.TabIndex = 29;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = false;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // pictureBoxImageB
            // 
            this.pictureBoxImageB.BackColor = System.Drawing.Color.Beige;
            this.pictureBoxImageB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxImageB.Location = new System.Drawing.Point(743, 2);
            this.pictureBoxImageB.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBoxImageB.Name = "pictureBoxImageB";
            this.pictureBoxImageB.Size = new System.Drawing.Size(168, 218);
            this.pictureBoxImageB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxImageB.TabIndex = 45;
            this.pictureBoxImageB.TabStop = false;
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.Color.Orange;
            this.btnSua.Font = new System.Drawing.Font("Verdana", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btnSua.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnSua.Location = new System.Drawing.Point(424, 136);
            this.btnSua.Margin = new System.Windows.Forms.Padding(2);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(68, 30);
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
            this.btnXoa.Location = new System.Drawing.Point(504, 136);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(2);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(68, 30);
            this.btnXoa.TabIndex = 26;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // cbAuthorNAME
            // 
            this.cbAuthorNAME.Enabled = false;
            this.cbAuthorNAME.FormattingEnabled = true;
            this.cbAuthorNAME.Location = new System.Drawing.Point(152, 162);
            this.cbAuthorNAME.Margin = new System.Windows.Forms.Padding(2);
            this.cbAuthorNAME.Name = "cbAuthorNAME";
            this.cbAuthorNAME.Size = new System.Drawing.Size(182, 21);
            this.cbAuthorNAME.TabIndex = 48;
            // 
            // btnSuaCategory
            // 
            this.btnSuaCategory.BackColor = System.Drawing.Color.Transparent;
            this.btnSuaCategory.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSuaCategory.BackgroundImage")));
            this.btnSuaCategory.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSuaCategory.Location = new System.Drawing.Point(337, 119);
            this.btnSuaCategory.Margin = new System.Windows.Forms.Padding(2);
            this.btnSuaCategory.Name = "btnSuaCategory";
            this.btnSuaCategory.Size = new System.Drawing.Size(31, 23);
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
            this.btnSuaAuthor.Location = new System.Drawing.Point(337, 162);
            this.btnSuaAuthor.Margin = new System.Windows.Forms.Padding(2);
            this.btnSuaAuthor.Name = "btnSuaAuthor";
            this.btnSuaAuthor.Size = new System.Drawing.Size(31, 20);
            this.btnSuaAuthor.TabIndex = 51;
            this.btnSuaAuthor.UseVisualStyleBackColor = false;
            this.btnSuaAuthor.Click += new System.EventHandler(this.btnSuaAuthor_Click);
            // 
            // cbPublisherNAME
            // 
            this.cbPublisherNAME.Enabled = false;
            this.cbPublisherNAME.FormattingEnabled = true;
            this.cbPublisherNAME.Location = new System.Drawing.Point(152, 201);
            this.cbPublisherNAME.Margin = new System.Windows.Forms.Padding(2);
            this.cbPublisherNAME.Name = "cbPublisherNAME";
            this.cbPublisherNAME.Size = new System.Drawing.Size(182, 21);
            this.cbPublisherNAME.TabIndex = 49;
            // 
            // cbCategoryNAME
            // 
            this.cbCategoryNAME.Enabled = false;
            this.cbCategoryNAME.FormattingEnabled = true;
            this.cbCategoryNAME.Location = new System.Drawing.Point(152, 120);
            this.cbCategoryNAME.Margin = new System.Windows.Forms.Padding(2);
            this.cbCategoryNAME.Name = "cbCategoryNAME";
            this.cbCategoryNAME.Size = new System.Drawing.Size(182, 21);
            this.cbCategoryNAME.TabIndex = 47;
            // 
            // txtBookID
            // 
            this.txtBookID.Location = new System.Drawing.Point(150, 17);
            this.txtBookID.Margin = new System.Windows.Forms.Padding(2);
            this.txtBookID.Name = "txtBookID";
            this.txtBookID.Size = new System.Drawing.Size(153, 20);
            this.txtBookID.TabIndex = 46;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold);
            this.label8.ForeColor = System.Drawing.Color.PeachPuff;
            this.label8.Location = new System.Drawing.Point(64, 17);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(79, 21);
            this.label8.TabIndex = 45;
            this.label8.Text = "Mã sách:";
            // 
            // txtBookAMOUNT
            // 
            this.txtBookAMOUNT.Enabled = false;
            this.txtBookAMOUNT.Location = new System.Drawing.Point(458, 70);
            this.txtBookAMOUNT.Margin = new System.Windows.Forms.Padding(2);
            this.txtBookAMOUNT.Name = "txtBookAMOUNT";
            this.txtBookAMOUNT.Size = new System.Drawing.Size(148, 20);
            this.txtBookAMOUNT.TabIndex = 42;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.PeachPuff;
            this.label2.Location = new System.Drawing.Point(660, 2);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 21);
            this.label2.TabIndex = 35;
            this.label2.Text = "Bìa Sách: ";
            // 
            // txtBookPRICE
            // 
            this.txtBookPRICE.Enabled = false;
            this.txtBookPRICE.Location = new System.Drawing.Point(458, 23);
            this.txtBookPRICE.Margin = new System.Windows.Forms.Padding(2);
            this.txtBookPRICE.Name = "txtBookPRICE";
            this.txtBookPRICE.Size = new System.Drawing.Size(148, 20);
            this.txtBookPRICE.TabIndex = 43;
            // 
            // txtBookNAME
            // 
            this.txtBookNAME.Enabled = false;
            this.txtBookNAME.Location = new System.Drawing.Point(152, 65);
            this.txtBookNAME.Margin = new System.Windows.Forms.Padding(2);
            this.txtBookNAME.Name = "txtBookNAME";
            this.txtBookNAME.Size = new System.Drawing.Size(182, 20);
            this.txtBookNAME.TabIndex = 44;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.PeachPuff;
            this.label6.Location = new System.Drawing.Point(62, 115);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 21);
            this.label6.TabIndex = 32;
            this.label6.Text = "Thể Loại:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.PeachPuff;
            this.label3.Location = new System.Drawing.Point(62, 157);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 21);
            this.label3.TabIndex = 33;
            this.label3.Text = "Tác Giả: ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.Color.PeachPuff;
            this.label7.Location = new System.Drawing.Point(14, 195);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(126, 21);
            this.label7.TabIndex = 34;
            this.label7.Text = "Nhà Xuất Bản: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.PeachPuff;
            this.label5.Location = new System.Drawing.Point(362, 65);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 21);
            this.label5.TabIndex = 36;
            this.label5.Text = "Số Lượng:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.PeachPuff;
            this.label4.Location = new System.Drawing.Point(362, 17);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 21);
            this.label4.TabIndex = 37;
            this.label4.Text = "Giá Tiền:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.PeachPuff;
            this.label1.Location = new System.Drawing.Point(62, 59);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 21);
            this.label1.TabIndex = 38;
            this.label1.Text = "Tên Sách:";
            // 
            // dgvAllBook
            // 
            this.dgvAllBook.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAllBook.Location = new System.Drawing.Point(22, 277);
            this.dgvAllBook.Name = "dgvAllBook";
            this.dgvAllBook.Size = new System.Drawing.Size(994, 150);
            this.dgvAllBook.TabIndex = 55;
            this.dgvAllBook.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAllBook_CellClick);
            // 
            // frmBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Goldenrod;
            this.ClientSize = new System.Drawing.Size(1028, 484);
            this.Controls.Add(this.dgvAllBook);
            this.Controls.Add(this.panel);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmBook";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kho Sách";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmBook_FormClosed);
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImageB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllBook)).EndInit();
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
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DataGridView dgvAllBook;
    }
}