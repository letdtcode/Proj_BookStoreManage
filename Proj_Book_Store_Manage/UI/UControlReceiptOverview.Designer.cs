
namespace Proj_Book_Store_Manage.UI
{
    partial class UControlReceiptOverview
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
            this.btnImport = new System.Windows.Forms.Button();
            this.btnExport = new System.Windows.Forms.Button();
            this.panelSide = new System.Windows.Forms.Panel();
            this.panelMainReceipt = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // btnImport
            // 
            this.btnImport.BackColor = System.Drawing.Color.Black;
            this.btnImport.FlatAppearance.BorderSize = 0;
            this.btnImport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImport.Font = new System.Drawing.Font("Century Gothic", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImport.ForeColor = System.Drawing.Color.White;
            this.btnImport.Location = new System.Drawing.Point(0, 0);
            this.btnImport.Name = "btnImport";
            this.btnImport.Size = new System.Drawing.Size(536, 58);
            this.btnImport.TabIndex = 0;
            this.btnImport.Text = "Nhập Sách";
            this.btnImport.UseVisualStyleBackColor = false;
            this.btnImport.Click += new System.EventHandler(this.btnImport_Click);
            this.btnImport.MouseEnter += new System.EventHandler(this.ChangeColorEnter);
            this.btnImport.MouseLeave += new System.EventHandler(this.ChangeColorLeave);
            // 
            // btnExport
            // 
            this.btnExport.BackColor = System.Drawing.Color.Black;
            this.btnExport.FlatAppearance.BorderSize = 0;
            this.btnExport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExport.Font = new System.Drawing.Font("Century Gothic", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExport.ForeColor = System.Drawing.Color.White;
            this.btnExport.Location = new System.Drawing.Point(536, 0);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(536, 58);
            this.btnExport.TabIndex = 0;
            this.btnExport.Text = "Bán Sách";
            this.btnExport.UseVisualStyleBackColor = false;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            this.btnExport.MouseEnter += new System.EventHandler(this.ChangeColorEnter);
            this.btnExport.MouseLeave += new System.EventHandler(this.ChangeColorLeave);
            // 
            // panelSide
            // 
            this.panelSide.BackColor = System.Drawing.Color.Lime;
            this.panelSide.Location = new System.Drawing.Point(0, 58);
            this.panelSide.Name = "panelSide";
            this.panelSide.Size = new System.Drawing.Size(536, 15);
            this.panelSide.TabIndex = 1;
            // 
            // panelMainReceipt
            // 
            this.panelMainReceipt.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelMainReceipt.Location = new System.Drawing.Point(0, 79);
            this.panelMainReceipt.Name = "panelMainReceipt";
            this.panelMainReceipt.Size = new System.Drawing.Size(1072, 568);
            this.panelMainReceipt.TabIndex = 2;
            // 
            // UControlReceiptOverview
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.panelMainReceipt);
            this.Controls.Add(this.panelSide);
            this.Controls.Add(this.btnExport);
            this.Controls.Add(this.btnImport);
            this.Name = "UControlReceiptOverview";
            this.Size = new System.Drawing.Size(1072, 647);
            this.Load += new System.EventHandler(this.UControlReceiptOverview_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnImport;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.Panel panelSide;
        private System.Windows.Forms.Panel panelMainReceipt;
    }
}
