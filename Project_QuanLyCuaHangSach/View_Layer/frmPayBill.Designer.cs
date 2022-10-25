namespace Project_QuanLyCuaHangSach
{
    partial class frmPayBill
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
            this.dgvDetailItem = new System.Windows.Forms.DataGridView();
            this.dgvVoucher = new System.Windows.Forms.DataGridView();
            this.btnAddVoucher = new System.Windows.Forms.Button();
            this.btnDeleVoucher = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lbNamCus = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lbIdBill = new System.Windows.Forms.Label();
            this.lbNotVoucher = new System.Windows.Forms.Label();
            this.lbPayMust = new System.Windows.Forms.Label();
            this.btnFinish = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lbIdVoucher = new System.Windows.Forms.Label();
            this.dgvBill = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetailItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVoucher)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBill)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvDetailItem
            // 
            this.dgvDetailItem.AllowUserToDeleteRows = false;
            this.dgvDetailItem.AllowUserToResizeColumns = false;
            this.dgvDetailItem.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.MistyRose;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.ForestGreen;
            this.dgvDetailItem.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDetailItem.BackgroundColor = System.Drawing.Color.LemonChiffon;
            this.dgvDetailItem.ColumnHeadersHeight = 30;
            this.dgvDetailItem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvDetailItem.Location = new System.Drawing.Point(678, 13);
            this.dgvDetailItem.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.dgvDetailItem.MultiSelect = false;
            this.dgvDetailItem.Name = "dgvDetailItem";
            this.dgvDetailItem.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.MenuText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.MistyRose;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.MistyRose;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDetailItem.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvDetailItem.RowHeadersVisible = false;
            this.dgvDetailItem.RowHeadersWidth = 50;
            this.dgvDetailItem.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvDetailItem.RowTemplate.Height = 20;
            this.dgvDetailItem.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDetailItem.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDetailItem.Size = new System.Drawing.Size(558, 183);
            this.dgvDetailItem.TabIndex = 84;
            // 
            // dgvVoucher
            // 
            this.dgvVoucher.AllowUserToDeleteRows = false;
            this.dgvVoucher.AllowUserToResizeColumns = false;
            this.dgvVoucher.AllowUserToResizeRows = false;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.MistyRose;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.ForestGreen;
            this.dgvVoucher.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvVoucher.BackgroundColor = System.Drawing.Color.LemonChiffon;
            this.dgvVoucher.ColumnHeadersHeight = 30;
            this.dgvVoucher.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvVoucher.Location = new System.Drawing.Point(14, 13);
            this.dgvVoucher.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.dgvVoucher.MultiSelect = false;
            this.dgvVoucher.Name = "dgvVoucher";
            this.dgvVoucher.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.MenuText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.MistyRose;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.MistyRose;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvVoucher.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvVoucher.RowHeadersVisible = false;
            this.dgvVoucher.RowHeadersWidth = 50;
            this.dgvVoucher.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvVoucher.RowTemplate.Height = 20;
            this.dgvVoucher.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvVoucher.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvVoucher.Size = new System.Drawing.Size(558, 183);
            this.dgvVoucher.TabIndex = 85;
            this.dgvVoucher.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvVoucher_CellClick);
            // 
            // btnAddVoucher
            // 
            this.btnAddVoucher.Location = new System.Drawing.Point(580, 42);
            this.btnAddVoucher.Name = "btnAddVoucher";
            this.btnAddVoucher.Size = new System.Drawing.Size(90, 34);
            this.btnAddVoucher.TabIndex = 87;
            this.btnAddVoucher.Text = "Áp dụng voucher";
            this.btnAddVoucher.UseVisualStyleBackColor = true;
            this.btnAddVoucher.Click += new System.EventHandler(this.btnAddVoucher_Click);
            // 
            // btnDeleVoucher
            // 
            this.btnDeleVoucher.Location = new System.Drawing.Point(580, 98);
            this.btnDeleVoucher.Name = "btnDeleVoucher";
            this.btnDeleVoucher.Size = new System.Drawing.Size(90, 23);
            this.btnDeleVoucher.TabIndex = 89;
            this.btnDeleVoucher.Text = "Xóa voucher";
            this.btnDeleVoucher.UseVisualStyleBackColor = true;
            this.btnDeleVoucher.Click += new System.EventHandler(this.btnDeleVoucher_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(66, 250);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 22);
            this.label1.TabIndex = 86;
            this.label1.Text = "Tên khách hàng";
            // 
            // lbNamCus
            // 
            this.lbNamCus.AutoSize = true;
            this.lbNamCus.Font = new System.Drawing.Font("Lucida Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNamCus.Location = new System.Drawing.Point(415, 250);
            this.lbNamCus.Name = "lbNamCus";
            this.lbNamCus.Size = new System.Drawing.Size(0, 22);
            this.lbNamCus.TabIndex = 90;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lucida Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(66, 284);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 22);
            this.label3.TabIndex = 91;
            this.label3.Text = "Mã hóa đơn";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Lucida Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(66, 327);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(277, 22);
            this.label4.TabIndex = 92;
            this.label4.Text = "Số tiền chưa áp dụng voucher";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Lucida Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(66, 428);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(146, 22);
            this.label5.TabIndex = 93;
            this.label5.Text = "Số tiền phải trả";
            // 
            // lbIdBill
            // 
            this.lbIdBill.AutoSize = true;
            this.lbIdBill.Font = new System.Drawing.Font("Lucida Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbIdBill.Location = new System.Drawing.Point(415, 284);
            this.lbIdBill.Name = "lbIdBill";
            this.lbIdBill.Size = new System.Drawing.Size(0, 22);
            this.lbIdBill.TabIndex = 94;
            // 
            // lbNotVoucher
            // 
            this.lbNotVoucher.AutoSize = true;
            this.lbNotVoucher.Font = new System.Drawing.Font("Lucida Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNotVoucher.Location = new System.Drawing.Point(415, 327);
            this.lbNotVoucher.Name = "lbNotVoucher";
            this.lbNotVoucher.Size = new System.Drawing.Size(0, 22);
            this.lbNotVoucher.TabIndex = 95;
            // 
            // lbPayMust
            // 
            this.lbPayMust.AutoSize = true;
            this.lbPayMust.Font = new System.Drawing.Font("Lucida Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPayMust.Location = new System.Drawing.Point(415, 428);
            this.lbPayMust.Name = "lbPayMust";
            this.lbPayMust.Size = new System.Drawing.Size(0, 22);
            this.lbPayMust.TabIndex = 96;
            // 
            // btnFinish
            // 
            this.btnFinish.Location = new System.Drawing.Point(621, 416);
            this.btnFinish.Name = "btnFinish";
            this.btnFinish.Size = new System.Drawing.Size(90, 34);
            this.btnFinish.TabIndex = 97;
            this.btnFinish.Text = "Thanh toán";
            this.btnFinish.UseVisualStyleBackColor = true;
            this.btnFinish.Click += new System.EventHandler(this.btnFinish_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(415, 374);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 22);
            this.label2.TabIndex = 98;
            // 
            // lbIdVoucher
            // 
            this.lbIdVoucher.AutoSize = true;
            this.lbIdVoucher.Font = new System.Drawing.Font("Lucida Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbIdVoucher.Location = new System.Drawing.Point(66, 374);
            this.lbIdVoucher.Name = "lbIdVoucher";
            this.lbIdVoucher.Size = new System.Drawing.Size(122, 22);
            this.lbIdVoucher.TabIndex = 99;
            this.lbIdVoucher.Text = "Mã giảm giá";
            // 
            // dgvBill
            // 
            this.dgvBill.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBill.Location = new System.Drawing.Point(678, 223);
            this.dgvBill.Name = "dgvBill";
            this.dgvBill.Size = new System.Drawing.Size(558, 100);
            this.dgvBill.TabIndex = 100;
            // 
            // frmPayBill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1250, 486);
            this.Controls.Add(this.dgvBill);
            this.Controls.Add(this.lbIdVoucher);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnFinish);
            this.Controls.Add(this.lbPayMust);
            this.Controls.Add(this.lbNotVoucher);
            this.Controls.Add(this.lbIdBill);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbNamCus);
            this.Controls.Add(this.btnDeleVoucher);
            this.Controls.Add(this.btnAddVoucher);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvVoucher);
            this.Controls.Add(this.dgvDetailItem);
            this.Name = "frmPayBill";
            this.Text = "frmPayBill";
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetailItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVoucher)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBill)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvDetailItem;
        private System.Windows.Forms.DataGridView dgvVoucher;
        private System.Windows.Forms.Button btnAddVoucher;
        private System.Windows.Forms.Button btnDeleVoucher;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbNamCus;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbIdBill;
        private System.Windows.Forms.Label lbNotVoucher;
        private System.Windows.Forms.Label lbPayMust;
        private System.Windows.Forms.Button btnFinish;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbIdVoucher;
        private System.Windows.Forms.DataGridView dgvBill;
    }
}