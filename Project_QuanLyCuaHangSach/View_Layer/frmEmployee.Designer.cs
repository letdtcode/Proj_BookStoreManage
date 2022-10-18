namespace Project_QuanLyCuaHangSach
{
    partial class frmEmployee
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEmployee));
            this.dgvEmployee = new System.Windows.Forms.DataGridView();
            this.stt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmpID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmpNAME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mpADDRESS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmpPHONENUM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.panel = new System.Windows.Forms.Panel();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtEmployeePHONENUM = new System.Windows.Forms.TextBox();
            this.txtEmployeeADDRESS = new System.Windows.Forms.TextBox();
            this.txtEmployeeNAME = new System.Windows.Forms.TextBox();
            this.txtEmployeeID = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployee)).BeginInit();
            this.panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvEmployee
            // 
            this.dgvEmployee.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvEmployee.BackgroundColor = System.Drawing.Color.AliceBlue;
            this.dgvEmployee.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvEmployee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmployee.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.stt,
            this.EmpID,
            this.EmpNAME,
            this.mpADDRESS,
            this.EmpPHONENUM});
            resources.ApplyResources(this.dgvEmployee, "dgvEmployee");
            this.dgvEmployee.Name = "dgvEmployee";
            this.dgvEmployee.RowTemplate.Height = 24;
            // 
            // stt
            // 
            this.stt.FillWeight = 59.6427F;
            resources.ApplyResources(this.stt, "stt");
            this.stt.Name = "stt";
            // 
            // EmpID
            // 
            this.EmpID.FillWeight = 66.84492F;
            resources.ApplyResources(this.EmpID, "EmpID");
            this.EmpID.Name = "EmpID";
            // 
            // EmpNAME
            // 
            this.EmpNAME.FillWeight = 124.5041F;
            resources.ApplyResources(this.EmpNAME, "EmpNAME");
            this.EmpNAME.Name = "EmpNAME";
            // 
            // mpADDRESS
            // 
            this.mpADDRESS.FillWeight = 124.5041F;
            resources.ApplyResources(this.mpADDRESS, "mpADDRESS");
            this.mpADDRESS.Name = "mpADDRESS";
            // 
            // EmpPHONENUM
            // 
            this.EmpPHONENUM.FillWeight = 124.5041F;
            resources.ApplyResources(this.EmpPHONENUM, "EmpPHONENUM");
            this.EmpPHONENUM.Name = "EmpPHONENUM";
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.SkyBlue;
            this.btnXoa.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            resources.ApplyResources(this.btnXoa, "btnXoa");
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.SkyBlue;
            resources.ApplyResources(this.btnThem, "btnThem");
            this.btnThem.Name = "btnThem";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.Color.SkyBlue;
            resources.ApplyResources(this.btnThoat, "btnThoat");
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.BackColor = System.Drawing.Color.SkyBlue;
            resources.ApplyResources(this.btnLuu, "btnLuu");
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.UseVisualStyleBackColor = false;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.BackColor = System.Drawing.Color.SkyBlue;
            resources.ApplyResources(this.btnHuy, "btnHuy");
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.UseVisualStyleBackColor = false;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.Color.SkyBlue;
            resources.ApplyResources(this.btnSua, "btnSua");
            this.btnSua.Name = "btnSua";
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // panel
            // 
            this.panel.BackgroundImage = global::Project_QuanLyCuaHangSach.Properties.Resources.phat_trien_kha_nang_lanh_dao_0;
            resources.ApplyResources(this.panel, "panel");
            this.panel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel.Controls.Add(this.btnSearch);
            this.panel.Controls.Add(this.btnXoa);
            this.panel.Controls.Add(this.txtEmployeePHONENUM);
            this.panel.Controls.Add(this.txtEmployeeADDRESS);
            this.panel.Controls.Add(this.btnThem);
            this.panel.Controls.Add(this.btnThoat);
            this.panel.Controls.Add(this.txtEmployeeNAME);
            this.panel.Controls.Add(this.btnHuy);
            this.panel.Controls.Add(this.txtEmployeeID);
            this.panel.Controls.Add(this.btnLuu);
            this.panel.Controls.Add(this.label5);
            this.panel.Controls.Add(this.btnSua);
            this.panel.Controls.Add(this.label3);
            this.panel.Controls.Add(this.label1);
            this.panel.Controls.Add(this.label2);
            this.panel.Name = "panel";
            // 
            // btnSearch
            // 
            this.btnSearch.BackgroundImage = global::Project_QuanLyCuaHangSach.Properties.Resources.tk;
            resources.ApplyResources(this.btnSearch, "btnSearch");
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtEmployeePHONENUM
            // 
            resources.ApplyResources(this.txtEmployeePHONENUM, "txtEmployeePHONENUM");
            this.txtEmployeePHONENUM.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtEmployeePHONENUM.Name = "txtEmployeePHONENUM";
            // 
            // txtEmployeeADDRESS
            // 
            resources.ApplyResources(this.txtEmployeeADDRESS, "txtEmployeeADDRESS");
            this.txtEmployeeADDRESS.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtEmployeeADDRESS.Name = "txtEmployeeADDRESS";
            // 
            // txtEmployeeNAME
            // 
            resources.ApplyResources(this.txtEmployeeNAME, "txtEmployeeNAME");
            this.txtEmployeeNAME.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtEmployeeNAME.Name = "txtEmployeeNAME";
            // 
            // txtEmployeeID
            // 
            resources.ApplyResources(this.txtEmployeeID, "txtEmployeeID");
            this.txtEmployeeID.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtEmployeeID.Name = "txtEmployeeID";
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label5.Name = "label5";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label3.Name = "label3";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Name = "label1";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label2.Name = "label2";
            // 
            // frmEmployee
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.CausesValidation = false;
            this.Controls.Add(this.dgvEmployee);
            this.Controls.Add(this.panel);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmEmployee";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmEmployee_FormClosed);
            //this.Load += new System.EventHandler(this.frmEmployee_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployee)).EndInit();
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvEmployee;
        private System.Windows.Forms.DataGridViewTextBoxColumn stt;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmpID;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmpNAME;
        private System.Windows.Forms.DataGridViewTextBoxColumn mpADDRESS;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmpPHONENUM;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtEmployeePHONENUM;
        private System.Windows.Forms.TextBox txtEmployeeADDRESS;
        private System.Windows.Forms.TextBox txtEmployeeNAME;
        private System.Windows.Forms.TextBox txtEmployeeID;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnSua;
    }
}