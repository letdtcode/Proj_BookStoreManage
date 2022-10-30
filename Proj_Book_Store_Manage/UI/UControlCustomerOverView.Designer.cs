
namespace Proj_Book_Store_Manage.UI
{
    partial class UControlCustomerOverview
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
            this.panelMainCustomer = new System.Windows.Forms.Panel();
            this.panelSide = new System.Windows.Forms.Panel();
            this.btnTypeCus = new System.Windows.Forms.Button();
            this.btnInfoCus = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // panelMainCustomer
            // 
            this.panelMainCustomer.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelMainCustomer.Location = new System.Drawing.Point(0, 79);
            this.panelMainCustomer.Name = "panelMainCustomer";
            this.panelMainCustomer.Size = new System.Drawing.Size(1072, 568);
            this.panelMainCustomer.TabIndex = 6;
            // 
            // panelSide
            // 
            this.panelSide.BackColor = System.Drawing.Color.Lime;
            this.panelSide.Location = new System.Drawing.Point(0, 58);
            this.panelSide.Name = "panelSide";
            this.panelSide.Size = new System.Drawing.Size(509, 15);
            this.panelSide.TabIndex = 5;
            // 
            // btnTypeCus
            // 
            this.btnTypeCus.BackColor = System.Drawing.Color.Black;
            this.btnTypeCus.FlatAppearance.BorderSize = 0;
            this.btnTypeCus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTypeCus.Font = new System.Drawing.Font("Century Gothic", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTypeCus.ForeColor = System.Drawing.Color.White;
            this.btnTypeCus.Location = new System.Drawing.Point(536, 0);
            this.btnTypeCus.Name = "btnTypeCus";
            this.btnTypeCus.Size = new System.Drawing.Size(536, 58);
            this.btnTypeCus.TabIndex = 3;
            this.btnTypeCus.Text = "Loại Khách Hàng";
            this.btnTypeCus.UseVisualStyleBackColor = false;
            this.btnTypeCus.Click += new System.EventHandler(this.btnTypeCus_Click);
            this.btnTypeCus.MouseEnter += new System.EventHandler(this.ChangeColorEnter);
            this.btnTypeCus.MouseLeave += new System.EventHandler(this.ChangeColorLeave);
            // 
            // btnInfoCus
            // 
            this.btnInfoCus.BackColor = System.Drawing.Color.Black;
            this.btnInfoCus.FlatAppearance.BorderSize = 0;
            this.btnInfoCus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInfoCus.Font = new System.Drawing.Font("Century Gothic", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInfoCus.ForeColor = System.Drawing.Color.White;
            this.btnInfoCus.Location = new System.Drawing.Point(0, 0);
            this.btnInfoCus.Name = "btnInfoCus";
            this.btnInfoCus.Size = new System.Drawing.Size(536, 58);
            this.btnInfoCus.TabIndex = 4;
            this.btnInfoCus.Text = "Thông Tin Khách Hàng";
            this.btnInfoCus.UseVisualStyleBackColor = false;
            this.btnInfoCus.Click += new System.EventHandler(this.btnInfoCus_Click);
            this.btnInfoCus.MouseEnter += new System.EventHandler(this.ChangeColorEnter);
            this.btnInfoCus.MouseLeave += new System.EventHandler(this.ChangeColorLeave);
            // 
            // UControlCustomerOverview
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.panelMainCustomer);
            this.Controls.Add(this.panelSide);
            this.Controls.Add(this.btnTypeCus);
            this.Controls.Add(this.btnInfoCus);
            this.Name = "UControlCustomerOverview";
            this.Size = new System.Drawing.Size(1072, 647);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMainCustomer;
        private System.Windows.Forms.Panel panelSide;
        private System.Windows.Forms.Button btnTypeCus;
        private System.Windows.Forms.Button btnInfoCus;
    }
}
