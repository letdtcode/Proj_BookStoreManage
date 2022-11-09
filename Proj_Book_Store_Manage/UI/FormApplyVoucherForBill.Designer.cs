
namespace Proj_Book_Store_Manage.UI
{
    partial class FormApplyVoucherForBill
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
            this.lblInfo = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lblBill = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.lbIdVoucher = new System.Windows.Forms.Label();
            this.lbIdBill = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvVoucher = new System.Windows.Forms.DataGridView();
            this.btnUse = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVoucher)).BeginInit();
            this.SuspendLayout();
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.lblInfo.Location = new System.Drawing.Point(133, 35);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(192, 23);
            this.lblInfo.TabIndex = 0;
            this.lblInfo.Text = "VOUCHER ÁP DỤNG";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Teal;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1235, 10);
            this.panel1.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Teal;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 570);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1235, 10);
            this.panel2.TabIndex = 3;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Teal;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 10);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(10, 560);
            this.panel3.TabIndex = 4;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Teal;
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(1225, 10);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(10, 560);
            this.panel4.TabIndex = 5;
            // 
            // lblBill
            // 
            this.lblBill.AutoSize = true;
            this.lblBill.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBill.Location = new System.Drawing.Point(58, 88);
            this.lblBill.Name = "lblBill";
            this.lblBill.Size = new System.Drawing.Size(108, 22);
            this.lblBill.TabIndex = 7;
            this.lblBill.Text = "Mã Hóa Đơn: ";
            // 
            // btnExit
            // 
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Century Gothic", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.Teal;
            this.btnExit.Location = new System.Drawing.Point(1144, 19);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(66, 48);
            this.btnExit.TabIndex = 16;
            this.btnExit.Text = "X";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lbIdVoucher
            // 
            this.lbIdVoucher.AutoSize = true;
            this.lbIdVoucher.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbIdVoucher.Location = new System.Drawing.Point(222, 148);
            this.lbIdVoucher.Name = "lbIdVoucher";
            this.lbIdVoucher.Size = new System.Drawing.Size(0, 22);
            this.lbIdVoucher.TabIndex = 32;
            // 
            // lbIdBill
            // 
            this.lbIdBill.AutoSize = true;
            this.lbIdBill.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbIdBill.Location = new System.Drawing.Point(222, 88);
            this.lbIdBill.Name = "lbIdBill";
            this.lbIdBill.Size = new System.Drawing.Size(0, 22);
            this.lbIdBill.TabIndex = 31;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(58, 148);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 22);
            this.label1.TabIndex = 30;
            this.label1.Text = "Mã Voucher:";
            // 
            // dgvVoucher
            // 
            this.dgvVoucher.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVoucher.Location = new System.Drawing.Point(593, 148);
            this.dgvVoucher.Name = "dgvVoucher";
            this.dgvVoucher.Size = new System.Drawing.Size(597, 372);
            this.dgvVoucher.TabIndex = 29;
            this.dgvVoucher.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvVoucher_CellClick);
            // 
            // btnUse
            // 
            this.btnUse.BackColor = System.Drawing.Color.Yellow;
            this.btnUse.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUse.ForeColor = System.Drawing.Color.Black;
            this.btnUse.Location = new System.Drawing.Point(62, 446);
            this.btnUse.Name = "btnUse";
            this.btnUse.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnUse.Size = new System.Drawing.Size(116, 46);
            this.btnUse.TabIndex = 27;
            this.btnUse.Text = "Sử Dụng";
            this.btnUse.UseVisualStyleBackColor = false;
            this.btnUse.Click += new System.EventHandler(this.btnUse_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Yellow;
            this.btnCancel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.Black;
            this.btnCancel.Location = new System.Drawing.Point(238, 446);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(116, 46);
            this.btnCancel.TabIndex = 33;
            this.btnCancel.Text = "Bỏ Voucher";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // FormApplyVoucherForBill
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1235, 580);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.lbIdVoucher);
            this.Controls.Add(this.lbIdBill);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvVoucher);
            this.Controls.Add(this.btnUse);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.lblBill);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblInfo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormApplyVoucherForBill";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FormApplyVoucherForBill";
            ((System.ComponentModel.ISupportInitialize)(this.dgvVoucher)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lblBill;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lbIdVoucher;
        private System.Windows.Forms.Label lbIdBill;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvVoucher;
        private System.Windows.Forms.Button btnUse;
        private System.Windows.Forms.Button btnCancel;
    }
}