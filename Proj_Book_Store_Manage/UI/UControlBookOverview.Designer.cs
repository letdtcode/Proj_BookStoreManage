
namespace Proj_Book_Store_Manage.UI
{
    partial class UControlBookOverview
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
            this.btnAuthor = new System.Windows.Forms.Button();
            this.btnPublisher = new System.Windows.Forms.Button();
            this.btnInfoBook = new System.Windows.Forms.Button();
            this.btnCategory = new System.Windows.Forms.Button();
            this.panelSide = new System.Windows.Forms.Panel();
            this.panelMain = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // btnAuthor
            // 
            this.btnAuthor.BackColor = System.Drawing.Color.Black;
            this.btnAuthor.FlatAppearance.BorderSize = 0;
            this.btnAuthor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAuthor.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAuthor.ForeColor = System.Drawing.Color.White;
            this.btnAuthor.Location = new System.Drawing.Point(0, 0);
            this.btnAuthor.Name = "btnAuthor";
            this.btnAuthor.Size = new System.Drawing.Size(268, 50);
            this.btnAuthor.TabIndex = 0;
            this.btnAuthor.Text = "TÁC GIẢ";
            this.btnAuthor.UseVisualStyleBackColor = false;
            this.btnAuthor.Click += new System.EventHandler(this.btnAuthor_Click);
            this.btnAuthor.MouseEnter += new System.EventHandler(this.ChangeColorEnter);
            this.btnAuthor.MouseLeave += new System.EventHandler(this.ChangeColorLeave);
            // 
            // btnPublisher
            // 
            this.btnPublisher.BackColor = System.Drawing.Color.Black;
            this.btnPublisher.FlatAppearance.BorderSize = 0;
            this.btnPublisher.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPublisher.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPublisher.ForeColor = System.Drawing.Color.White;
            this.btnPublisher.Location = new System.Drawing.Point(268, 0);
            this.btnPublisher.Name = "btnPublisher";
            this.btnPublisher.Size = new System.Drawing.Size(268, 50);
            this.btnPublisher.TabIndex = 0;
            this.btnPublisher.Text = "NHÀ XUẤT BẢN";
            this.btnPublisher.UseVisualStyleBackColor = false;
            this.btnPublisher.Click += new System.EventHandler(this.btnPublisher_Click);
            this.btnPublisher.MouseEnter += new System.EventHandler(this.ChangeColorEnter);
            this.btnPublisher.MouseLeave += new System.EventHandler(this.ChangeColorLeave);
            // 
            // btnInfoBook
            // 
            this.btnInfoBook.BackColor = System.Drawing.Color.Black;
            this.btnInfoBook.FlatAppearance.BorderSize = 0;
            this.btnInfoBook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInfoBook.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInfoBook.ForeColor = System.Drawing.Color.White;
            this.btnInfoBook.Location = new System.Drawing.Point(536, 0);
            this.btnInfoBook.Name = "btnInfoBook";
            this.btnInfoBook.Size = new System.Drawing.Size(268, 50);
            this.btnInfoBook.TabIndex = 0;
            this.btnInfoBook.Text = "THÔNG TIN SÁCH";
            this.btnInfoBook.UseVisualStyleBackColor = false;
            this.btnInfoBook.Click += new System.EventHandler(this.btnInfoBook_Click);
            this.btnInfoBook.MouseEnter += new System.EventHandler(this.ChangeColorEnter);
            this.btnInfoBook.MouseLeave += new System.EventHandler(this.ChangeColorLeave);
            // 
            // btnCategory
            // 
            this.btnCategory.BackColor = System.Drawing.Color.Black;
            this.btnCategory.FlatAppearance.BorderSize = 0;
            this.btnCategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCategory.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCategory.ForeColor = System.Drawing.Color.White;
            this.btnCategory.Location = new System.Drawing.Point(804, 0);
            this.btnCategory.Name = "btnCategory";
            this.btnCategory.Size = new System.Drawing.Size(268, 50);
            this.btnCategory.TabIndex = 0;
            this.btnCategory.Text = "THỂ LOẠI";
            this.btnCategory.UseVisualStyleBackColor = false;
            this.btnCategory.Click += new System.EventHandler(this.btnCategory_Click);
            this.btnCategory.MouseEnter += new System.EventHandler(this.ChangeColorEnter);
            this.btnCategory.MouseLeave += new System.EventHandler(this.ChangeColorLeave);
            // 
            // panelSide
            // 
            this.panelSide.BackColor = System.Drawing.Color.Lime;
            this.panelSide.Location = new System.Drawing.Point(0, 50);
            this.panelSide.Name = "panelSide";
            this.panelSide.Size = new System.Drawing.Size(268, 10);
            this.panelSide.TabIndex = 1;
            // 
            // panelMain
            // 
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelMain.Location = new System.Drawing.Point(0, 66);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(1055, 563);
            this.panelMain.TabIndex = 2;
            // 
            // UControlBookOverview
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.panelSide);
            this.Controls.Add(this.btnCategory);
            this.Controls.Add(this.btnInfoBook);
            this.Controls.Add(this.btnPublisher);
            this.Controls.Add(this.btnAuthor);
            this.MaximumSize = new System.Drawing.Size(1055, 629);
            this.MinimumSize = new System.Drawing.Size(1055, 629);
            this.Name = "UControlBookOverview";
            this.Size = new System.Drawing.Size(1055, 629);
            this.Load += new System.EventHandler(this.UControlBookOverview_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAuthor;
        private System.Windows.Forms.Button btnPublisher;
        private System.Windows.Forms.Button btnInfoBook;
        private System.Windows.Forms.Button btnCategory;
        private System.Windows.Forms.Panel panelSide;
        private System.Windows.Forms.Panel panelMain;
    }
}
