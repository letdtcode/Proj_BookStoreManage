namespace Proj_Book_Store_Manage.UI
{
    partial class FormRevenue
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea25 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend25 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series25 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title25 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea26 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend26 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series26 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title26 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea27 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend27 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series27 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title27 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.chartGrossRevenue = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartTopProducts = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartMinStock = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblTotalRevenue = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblAmountBook = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lblAmountBill = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnThisMonth = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCustomDate = new System.Windows.Forms.Button();
            this.btnToday = new System.Windows.Forms.Button();
            this.btnLast7Days = new System.Windows.Forms.Button();
            this.dtpEndDate = new System.Windows.Forms.DateTimePicker();
            this.dtpStartDate = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.chartGrossRevenue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartTopProducts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartMinStock)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // chartGrossRevenue
            // 
            this.chartGrossRevenue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(45)))), ((int)(((byte)(86)))));
            this.chartGrossRevenue.BorderlineWidth = 0;
            chartArea25.AxisX.LabelStyle.ForeColor = System.Drawing.Color.Silver;
            chartArea25.AxisX.LineColor = System.Drawing.Color.White;
            chartArea25.AxisX.LineWidth = 0;
            chartArea25.AxisX.MajorGrid.LineColor = System.Drawing.Color.White;
            chartArea25.AxisX.MajorGrid.LineWidth = 0;
            chartArea25.AxisX.MajorTickMark.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(75)))), ((int)(((byte)(111)))));
            chartArea25.AxisX.MajorTickMark.Size = 3F;
            chartArea25.AxisY.LabelStyle.ForeColor = System.Drawing.Color.Silver;
            chartArea25.AxisY.LabelStyle.Format = "{0} đ";
            chartArea25.AxisY.LineWidth = 0;
            chartArea25.AxisY.MajorGrid.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(75)))), ((int)(((byte)(111)))));
            chartArea25.AxisY.MajorTickMark.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(75)))), ((int)(((byte)(111)))));
            chartArea25.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(45)))), ((int)(((byte)(86)))));
            chartArea25.Name = "ChartArea1";
            this.chartGrossRevenue.ChartAreas.Add(chartArea25);
            legend25.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(45)))), ((int)(((byte)(86)))));
            legend25.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Top;
            legend25.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            legend25.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            legend25.IsTextAutoFit = false;
            legend25.Name = "Legend1";
            this.chartGrossRevenue.Legends.Add(legend25);
            this.chartGrossRevenue.Location = new System.Drawing.Point(37, 50);
            this.chartGrossRevenue.Margin = new System.Windows.Forms.Padding(5);
            this.chartGrossRevenue.Name = "chartGrossRevenue";
            series25.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.LeftRight;
            series25.BackSecondaryColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(28)))), ((int)(((byte)(65)))));
            series25.ChartArea = "ChartArea1";
            series25.Color = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(83)))), ((int)(((byte)(255)))));
            series25.Legend = "Legend1";
            series25.Name = "Series1";
            series25.YValuesPerPoint = 2;
            this.chartGrossRevenue.Series.Add(series25);
            this.chartGrossRevenue.Size = new System.Drawing.Size(842, 255);
            this.chartGrossRevenue.TabIndex = 39;
            this.chartGrossRevenue.Text = "chart1";
            title25.Alignment = System.Drawing.ContentAlignment.TopLeft;
            title25.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            title25.ForeColor = System.Drawing.Color.WhiteSmoke;
            title25.Name = "Title1";
            title25.Text = "Doanh thu";
            this.chartGrossRevenue.Titles.Add(title25);
            // 
            // chartTopProducts
            // 
            this.chartTopProducts.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(45)))), ((int)(((byte)(86)))));
            chartArea26.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(45)))), ((int)(((byte)(86)))));
            chartArea26.Name = "ChartArea1";
            this.chartTopProducts.ChartAreas.Add(chartArea26);
            legend26.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(45)))), ((int)(((byte)(86)))));
            legend26.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom;
            legend26.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            legend26.ForeColor = System.Drawing.Color.WhiteSmoke;
            legend26.IsTextAutoFit = false;
            legend26.Name = "Legend1";
            this.chartTopProducts.Legends.Add(legend26);
            this.chartTopProducts.Location = new System.Drawing.Point(889, 50);
            this.chartTopProducts.Margin = new System.Windows.Forms.Padding(5);
            this.chartTopProducts.Name = "chartTopProducts";
            series26.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.TopBottom;
            series26.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(45)))), ((int)(((byte)(86)))));
            series26.BorderWidth = 9;
            series26.ChartArea = "ChartArea1";
            series26.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
            series26.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            series26.IsValueShownAsLabel = true;
            series26.LabelForeColor = System.Drawing.Color.White;
            series26.Legend = "Legend1";
            series26.Name = "Series1";
            this.chartTopProducts.Series.Add(series26);
            this.chartTopProducts.Size = new System.Drawing.Size(320, 507);
            this.chartTopProducts.TabIndex = 42;
            this.chartTopProducts.Text = "chartTopProducts";
            title26.Alignment = System.Drawing.ContentAlignment.TopLeft;
            title26.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            title26.ForeColor = System.Drawing.Color.WhiteSmoke;
            title26.Name = "Title1";
            title26.Text = "5 Sản phẩm bán chạy nhất";
            this.chartTopProducts.Titles.Add(title26);
            // 
            // chartMinStock
            // 
            this.chartMinStock.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(45)))), ((int)(((byte)(86)))));
            chartArea27.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(45)))), ((int)(((byte)(86)))));
            chartArea27.Name = "ChartArea1";
            this.chartMinStock.ChartAreas.Add(chartArea27);
            legend27.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(45)))), ((int)(((byte)(86)))));
            legend27.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            legend27.ForeColor = System.Drawing.Color.WhiteSmoke;
            legend27.IsTextAutoFit = false;
            legend27.Name = "Legend1";
            this.chartMinStock.Legends.Add(legend27);
            this.chartMinStock.Location = new System.Drawing.Point(277, 327);
            this.chartMinStock.Margin = new System.Windows.Forms.Padding(5);
            this.chartMinStock.Name = "chartMinStock";
            series27.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.TopBottom;
            series27.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(45)))), ((int)(((byte)(86)))));
            series27.BorderWidth = 9;
            series27.ChartArea = "ChartArea1";
            series27.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
            series27.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            series27.IsValueShownAsLabel = true;
            series27.LabelForeColor = System.Drawing.Color.White;
            series27.Legend = "Legend1";
            series27.Name = "Series1";
            this.chartMinStock.Series.Add(series27);
            this.chartMinStock.Size = new System.Drawing.Size(602, 230);
            this.chartMinStock.TabIndex = 43;
            this.chartMinStock.Text = "chart1";
            title27.Alignment = System.Drawing.ContentAlignment.TopLeft;
            title27.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            title27.ForeColor = System.Drawing.Color.WhiteSmoke;
            title27.Name = "Title1";
            title27.Text = "5 sản phẩm có số lượng ít nhất trong kho";
            this.chartMinStock.Titles.Add(title27);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(45)))), ((int)(((byte)(86)))));
            this.panel1.Controls.Add(this.lblTotalRevenue);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.lblAmountBook);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.lblAmountBill);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Location = new System.Drawing.Point(37, 327);
            this.panel1.Margin = new System.Windows.Forms.Padding(5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(230, 230);
            this.panel1.TabIndex = 44;
            // 
            // lblTotalRevenue
            // 
            this.lblTotalRevenue.AutoSize = true;
            this.lblTotalRevenue.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalRevenue.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblTotalRevenue.Location = new System.Drawing.Point(59, 185);
            this.lblTotalRevenue.Name = "lblTotalRevenue";
            this.lblTotalRevenue.Size = new System.Drawing.Size(78, 25);
            this.lblTotalRevenue.TabIndex = 6;
            this.lblTotalRevenue.Text = "100000";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(141)))), ((int)(((byte)(181)))));
            this.label3.Location = new System.Drawing.Point(60, 165);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Tổng doanh thu";
            // 
            // lblAmountBook
            // 
            this.lblAmountBook.AutoSize = true;
            this.lblAmountBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAmountBook.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblAmountBook.Location = new System.Drawing.Point(59, 125);
            this.lblAmountBook.Name = "lblAmountBook";
            this.lblAmountBook.Size = new System.Drawing.Size(78, 25);
            this.lblAmountBook.TabIndex = 4;
            this.lblAmountBook.Text = "100000";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(141)))), ((int)(((byte)(181)))));
            this.label1.Location = new System.Drawing.Point(60, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Tổng sách đã bán";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label10.Location = new System.Drawing.Point(10, 10);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(107, 25);
            this.label10.TabIndex = 2;
            this.label10.Text = "Tổng quan";
            // 
            // lblAmountBill
            // 
            this.lblAmountBill.AutoSize = true;
            this.lblAmountBill.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAmountBill.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblAmountBill.Location = new System.Drawing.Point(59, 65);
            this.lblAmountBill.Name = "lblAmountBill";
            this.lblAmountBill.Size = new System.Drawing.Size(78, 25);
            this.lblAmountBill.TabIndex = 1;
            this.lblAmountBill.Text = "100000";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(141)))), ((int)(((byte)(181)))));
            this.label12.Location = new System.Drawing.Point(60, 45);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(100, 20);
            this.label12.TabIndex = 0;
            this.label12.Text = "Số đơn hàng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(28)))), ((int)(((byte)(63)))));
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label2.Location = new System.Drawing.Point(305, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(13, 18);
            this.label2.TabIndex = 59;
            this.label2.Text = "-";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(28)))), ((int)(((byte)(63)))));
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label4.Location = new System.Drawing.Point(146, 11);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(25, 18);
            this.label4.TabIndex = 58;
            this.label4.Text = "Từ";
            // 
            // btnThisMonth
            // 
            this.btnThisMonth.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(83)))), ((int)(((byte)(255)))));
            this.btnThisMonth.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThisMonth.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThisMonth.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(141)))), ((int)(((byte)(181)))));
            this.btnThisMonth.Location = new System.Drawing.Point(886, 5);
            this.btnThisMonth.Margin = new System.Windows.Forms.Padding(5);
            this.btnThisMonth.Name = "btnThisMonth";
            this.btnThisMonth.Size = new System.Drawing.Size(130, 35);
            this.btnThisMonth.TabIndex = 57;
            this.btnThisMonth.Text = "Tháng này ";
            this.btnThisMonth.UseVisualStyleBackColor = true;
            this.btnThisMonth.Click += new System.EventHandler(this.btnThisMonth_Click);
            // 
            // btnOK
            // 
            this.btnOK.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(83)))), ((int)(((byte)(255)))));
            this.btnOK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOK.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOK.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(141)))), ((int)(((byte)(181)))));
            this.btnOK.Location = new System.Drawing.Point(453, 5);
            this.btnOK.Margin = new System.Windows.Forms.Padding(5);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(45, 35);
            this.btnOK.TabIndex = 56;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Visible = false;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCustomDate
            // 
            this.btnCustomDate.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(83)))), ((int)(((byte)(255)))));
            this.btnCustomDate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCustomDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCustomDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(141)))), ((int)(((byte)(181)))));
            this.btnCustomDate.Location = new System.Drawing.Point(498, 5);
            this.btnCustomDate.Margin = new System.Windows.Forms.Padding(5);
            this.btnCustomDate.Name = "btnCustomDate";
            this.btnCustomDate.Size = new System.Drawing.Size(130, 35);
            this.btnCustomDate.TabIndex = 55;
            this.btnCustomDate.Text = "Tùy chỉnh";
            this.btnCustomDate.UseVisualStyleBackColor = true;
            this.btnCustomDate.Click += new System.EventHandler(this.btnCustomDate_Click);
            // 
            // btnToday
            // 
            this.btnToday.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(83)))), ((int)(((byte)(255)))));
            this.btnToday.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnToday.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnToday.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(141)))), ((int)(((byte)(181)))));
            this.btnToday.Location = new System.Drawing.Point(628, 5);
            this.btnToday.Margin = new System.Windows.Forms.Padding(5);
            this.btnToday.Name = "btnToday";
            this.btnToday.Size = new System.Drawing.Size(130, 35);
            this.btnToday.TabIndex = 51;
            this.btnToday.Text = "Hôm nay";
            this.btnToday.UseVisualStyleBackColor = true;
            this.btnToday.Click += new System.EventHandler(this.btnToday_Click);
            // 
            // btnLast7Days
            // 
            this.btnLast7Days.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(83)))), ((int)(((byte)(255)))));
            this.btnLast7Days.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLast7Days.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLast7Days.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(141)))), ((int)(((byte)(181)))));
            this.btnLast7Days.Location = new System.Drawing.Point(758, 5);
            this.btnLast7Days.Margin = new System.Windows.Forms.Padding(5);
            this.btnLast7Days.Name = "btnLast7Days";
            this.btnLast7Days.Size = new System.Drawing.Size(130, 35);
            this.btnLast7Days.TabIndex = 52;
            this.btnLast7Days.Text = "7 ngày trước";
            this.btnLast7Days.UseVisualStyleBackColor = true;
            this.btnLast7Days.Click += new System.EventHandler(this.btnLast7Days_Click);
            // 
            // dtpEndDate
            // 
            this.dtpEndDate.CustomFormat = "MMM dd, yyyy";
            this.dtpEndDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpEndDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpEndDate.Location = new System.Drawing.Point(323, 11);
            this.dtpEndDate.Name = "dtpEndDate";
            this.dtpEndDate.Size = new System.Drawing.Size(122, 20);
            this.dtpEndDate.TabIndex = 54;
            this.dtpEndDate.Value = new System.DateTime(2022, 6, 17, 2, 24, 0, 0);
            // 
            // dtpStartDate
            // 
            this.dtpStartDate.CustomFormat = "MMM dd, yyyy";
            this.dtpStartDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpStartDate.Location = new System.Drawing.Point(177, 11);
            this.dtpStartDate.Name = "dtpStartDate";
            this.dtpStartDate.Size = new System.Drawing.Size(122, 20);
            this.dtpStartDate.TabIndex = 53;
            this.dtpStartDate.Value = new System.DateTime(2022, 6, 1, 2, 24, 0, 0);
            // 
            // FormRevenue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(28)))), ((int)(((byte)(63)))));
            this.ClientSize = new System.Drawing.Size(1219, 591);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnThisMonth);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.btnCustomDate);
            this.Controls.Add(this.btnToday);
            this.Controls.Add(this.btnLast7Days);
            this.Controls.Add(this.dtpEndDate);
            this.Controls.Add(this.dtpStartDate);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.chartMinStock);
            this.Controls.Add(this.chartTopProducts);
            this.Controls.Add(this.chartGrossRevenue);
            this.Name = "FormRevenue";
            this.Text = "FormRevenue";
            this.Load += new System.EventHandler(this.FormRevenue_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chartGrossRevenue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartTopProducts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartMinStock)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chartGrossRevenue;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartTopProducts;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartMinStock;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblTotalRevenue;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblAmountBook;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblAmountBill;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnThisMonth;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCustomDate;
        private System.Windows.Forms.Button btnToday;
        private System.Windows.Forms.Button btnLast7Days;
        private System.Windows.Forms.DateTimePicker dtpEndDate;
        private System.Windows.Forms.DateTimePicker dtpStartDate;
    }
}