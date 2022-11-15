
namespace Proj_Book_Store_Manage.UI
{
    partial class FormSelectUsing
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
            this.btnImport = new System.Windows.Forms.Button();
            this.btnManage = new System.Windows.Forms.Button();
            this.btnSale = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(175, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Vui lòng chọn chức năng";
            // 
            // btnImport
            // 
            this.btnImport.Location = new System.Drawing.Point(197, 146);
            this.btnImport.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnImport.Name = "btnImport";
            this.btnImport.Size = new System.Drawing.Size(117, 50);
            this.btnImport.TabIndex = 1;
            this.btnImport.Text = "Nhập đơn hàng";
            this.btnImport.UseVisualStyleBackColor = true;
            this.btnImport.Click += new System.EventHandler(this.btnImport_Click);
            // 
            // btnManage
            // 
            this.btnManage.Location = new System.Drawing.Point(197, 299);
            this.btnManage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnManage.Name = "btnManage";
            this.btnManage.Size = new System.Drawing.Size(117, 50);
            this.btnManage.TabIndex = 2;
            this.btnManage.Text = "Quản lý dữ liệu";
            this.btnManage.UseVisualStyleBackColor = true;
            this.btnManage.Click += new System.EventHandler(this.btnManage_Click);
            // 
            // btnSale
            // 
            this.btnSale.Location = new System.Drawing.Point(197, 222);
            this.btnSale.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSale.Name = "btnSale";
            this.btnSale.Size = new System.Drawing.Size(117, 50);
            this.btnSale.TabIndex = 3;
            this.btnSale.Text = "Bán sách";
            this.btnSale.UseVisualStyleBackColor = true;
            this.btnSale.Click += new System.EventHandler(this.btnSale_Click);
            // 
            // btnExit
            // 
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.Black;
            this.btnExit.Location = new System.Drawing.Point(441, 14);
            this.btnExit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(67, 48);
            this.btnExit.TabIndex = 16;
            this.btnExit.Text = "X";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // FormSelectUsing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(523, 401);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnSale);
            this.Controls.Add(this.btnManage);
            this.Controls.Add(this.btnImport);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormSelectUsing";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormSelectUsing";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnImport;
        private System.Windows.Forms.Button btnManage;
        private System.Windows.Forms.Button btnSale;
        private System.Windows.Forms.Button btnExit;
    }
}