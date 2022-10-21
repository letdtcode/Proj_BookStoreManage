namespace Project_QuanLyCuaHangSach
{
    partial class frmUpdatePublisher
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
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.txtPHONENUM = new System.Windows.Forms.TextBox();
            this.txtPublisherADDRESS = new System.Windows.Forms.TextBox();
            this.txtPublisherNAME = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPublisherID = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvPublisher = new System.Windows.Forms.DataGridView();
            this.btnFinish = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPublisher)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.DarkCyan;
            this.label1.Location = new System.Drawing.Point(491, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(265, 44);
            this.label1.TabIndex = 9;
            this.label1.Text = "Nhà Xuất Bản";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BackgroundImage = global::Project_QuanLyCuaHangSach.Properties.Resources.hinh_anh_sach_hoa_dep_nghe_thuat___14_;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.btnSearch);
            this.panel1.Controls.Add(this.btnSua);
            this.panel1.Controls.Add(this.btnXoa);
            this.panel1.Controls.Add(this.btnThem);
            this.panel1.Controls.Add(this.txtPHONENUM);
            this.panel1.Controls.Add(this.txtPublisherADDRESS);
            this.panel1.Controls.Add(this.txtPublisherNAME);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txtPublisherID);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.panel1.Location = new System.Drawing.Point(3, 76);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(482, 343);
            this.panel1.TabIndex = 10;
            // 
            // btnSearch
            // 
            this.btnSearch.BackgroundImage = global::Project_QuanLyCuaHangSach.Properties.Resources.tk;
            this.btnSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSearch.Location = new System.Drawing.Point(327, 37);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(35, 29);
            this.btnSearch.TabIndex = 32;
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.Color.PeachPuff;
            this.btnSua.Font = new System.Drawing.Font("Verdana", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btnSua.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnSua.Location = new System.Drawing.Point(192, 285);
            this.btnSua.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(74, 33);
            this.btnSua.TabIndex = 31;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.PeachPuff;
            this.btnXoa.Font = new System.Drawing.Font("Verdana", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btnXoa.Location = new System.Drawing.Point(304, 285);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(67, 33);
            this.btnXoa.TabIndex = 7;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.PeachPuff;
            this.btnThem.Font = new System.Drawing.Font("Verdana", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btnThem.Location = new System.Drawing.Point(74, 285);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(67, 33);
            this.btnThem.TabIndex = 6;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // txtPHONENUM
            // 
            this.txtPHONENUM.Location = new System.Drawing.Point(208, 150);
            this.txtPHONENUM.Name = "txtPHONENUM";
            this.txtPHONENUM.Size = new System.Drawing.Size(177, 26);
            this.txtPHONENUM.TabIndex = 5;
            // 
            // txtPublisherADDRESS
            // 
            this.txtPublisherADDRESS.Location = new System.Drawing.Point(208, 112);
            this.txtPublisherADDRESS.Name = "txtPublisherADDRESS";
            this.txtPublisherADDRESS.Size = new System.Drawing.Size(178, 26);
            this.txtPublisherADDRESS.TabIndex = 5;
            // 
            // txtPublisherNAME
            // 
            this.txtPublisherNAME.Location = new System.Drawing.Point(208, 72);
            this.txtPublisherNAME.Name = "txtPublisherNAME";
            this.txtPublisherNAME.Size = new System.Drawing.Size(178, 26);
            this.txtPublisherNAME.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(55, 151);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(122, 21);
            this.label5.TabIndex = 2;
            this.label5.Text = "Số Điện Thoại:";
            // 
            // txtPublisherID
            // 
            this.txtPublisherID.Location = new System.Drawing.Point(208, 41);
            this.txtPublisherID.Name = "txtPublisherID";
            this.txtPublisherID.Size = new System.Drawing.Size(114, 26);
            this.txtPublisherID.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(59, 114);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 21);
            this.label4.TabIndex = 2;
            this.label4.Text = "Địa chỉ:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(55, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(155, 21);
            this.label3.TabIndex = 1;
            this.label3.Text = "Tên Nhà Xuất Bản:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(55, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(151, 21);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã Nhà Xuất Bản:";
            // 
            // dgvPublisher
            // 
            this.dgvPublisher.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPublisher.Location = new System.Drawing.Point(640, 76);
            this.dgvPublisher.Name = "dgvPublisher";
            this.dgvPublisher.Size = new System.Drawing.Size(548, 343);
            this.dgvPublisher.TabIndex = 11;
            // 
            // btnFinish
            // 
            this.btnFinish.BackColor = System.Drawing.Color.PeachPuff;
            this.btnFinish.Font = new System.Drawing.Font("Verdana", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btnFinish.Location = new System.Drawing.Point(520, 361);
            this.btnFinish.Name = "btnFinish";
            this.btnFinish.Size = new System.Drawing.Size(104, 33);
            this.btnFinish.TabIndex = 33;
            this.btnFinish.Text = "Xác nhận";
            this.btnFinish.UseVisualStyleBackColor = false;
            // 
            // frmUpdatePublisher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AntiqueWhite;
            this.ClientSize = new System.Drawing.Size(1229, 503);
            this.Controls.Add(this.btnFinish);
            this.Controls.Add(this.dgvPublisher);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmUpdatePublisher";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nhà Xuất Bản";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmUpdatePublisher_FormClosed);
            this.Load += new System.EventHandler(this.frmUpdatePublisher_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPublisher)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.TextBox txtPHONENUM;
        private System.Windows.Forms.TextBox txtPublisherADDRESS;
        private System.Windows.Forms.TextBox txtPublisherNAME;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtPublisherID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvPublisher;
        private System.Windows.Forms.Button btnFinish;
    }
}