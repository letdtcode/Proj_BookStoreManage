using Proj_Book_Store_Manage.BSLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proj_Book_Store_Manage.UI
{
    public partial class FormRevenue : Form
    {
        Revenue revenue;
        private string err;
        private DataTable dtCategory = null;
        

        public FormRevenue()
        {
            InitializeComponent();
            LoadData(DateTime.Now.AddDays(-7), DateTime.Now);
        }

        private void FormRevenue_Load(object sender, EventArgs e)
        {

            LoadData(DateTime.Now.AddDays(-7), DateTime.Now);
        }

        private void chartGrossRevenue_Click(object sender, EventArgs e)
        {

        }


        private void LoadData(DateTime begin, DateTime end)
        {
            chartGrossRevenue.DataBind();
            chartTopProducts.DataBind();


            revenue = new Revenue();
            dtCategory = revenue.getRevenue(begin, end, ref err);
            chartGrossRevenue.DataSource = dtCategory;
            chartGrossRevenue.Series["Series1"].XValueMember = "dateOfBill";
            chartGrossRevenue.Series["Series1"].YValueMembers = "total";

            revenue = new Revenue();
            dtCategory = revenue.getTop5Book(begin, end, ref err);
            chartTopProducts.DataSource = dtCategory;
            chartTopProducts.Series["Series1"].XValueMember = "nameBook";
            chartTopProducts.Series["Series1"].YValueMembers = "amountOutput";


            revenue = new Revenue();
            dtCategory = revenue.getTop5MinStock();
            chartMinStock.DataSource = dtCategory;
            chartMinStock.Series["Series1"].XValueMember = "nameBook";
            chartMinStock.Series["Series1"].YValueMembers = "amount";


            revenue = new Revenue();
            dtCategory = revenue.getOverView_Revenue(begin, end, ref err);
            lblTotalRevenue.Text = dtCategory.Rows[0][0].ToString() + " đ";

            revenue = new Revenue();
            dtCategory = revenue.get_Overview_AmountBillOutput(begin, end, ref err);
            lblAmountBill.Text = dtCategory.Rows[0][0].ToString();

            revenue = new Revenue();
            dtCategory = revenue.get_Overview_AmountBookBillOutput(begin, end, ref err);
            lblAmountBook.Text = dtCategory.Rows[0][0].ToString();
        }
        private void btnToday_Click(object sender, EventArgs e)
        {
            this.dtpStartDate.Value = DateTime.Today;
            this.dtpEndDate.Value = DateTime.Now;
            try
            {
                LoadData(dtpStartDate.Value, dtpEndDate.Value);
            }
            catch
            {
                MessageBox.Show("Không có dữ liệu trong ngày hôm nay");
            }
        }

        private void btnLast7Days_Click(object sender, EventArgs e)
        {
            this.dtpStartDate.Value = DateTime.Now.AddDays(-7);
            this.dtpEndDate.Value = DateTime.Now;
            try
            {
                LoadData(dtpStartDate.Value, dtpEndDate.Value);
            }
            catch
            {
                MessageBox.Show("Không có dữ liệu trong tuần vừa qua");
            }
        }

        private void btnThisMonth_Click(object sender, EventArgs e)
        {
            this.dtpStartDate.Value = new DateTime(DateTime.Today.Year, DateTime.Today.Month, 1);
            this.dtpEndDate.Value = DateTime.Now;

            try
            {
                LoadData(dtpStartDate.Value, dtpEndDate.Value);
            }
            catch
            {
                MessageBox.Show("Không có dữ liệu trong tháng này");
            }
        }

        private void btnCustomDate_Click(object sender, EventArgs e)
        {
            btnCustomDate.Enabled=false;
            btnToday.Enabled = false;
            btnLast7Days.Enabled = false;
            btnThisMonth.Enabled = false;
            btnOK.Visible = true;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            try
            {
                LoadData(this.dtpStartDate.Value, this.dtpEndDate.Value);
                btnOK.Visible = false;
                btnCustomDate.Enabled = true;
                btnToday.Enabled = true;
                btnLast7Days.Enabled = true;
                btnThisMonth.Enabled = true;
            }   
            catch (Exception ex)
            {
                MessageBox.Show("Không có dữ liệu trong khoảng thời gian này");
            }
        }
    }
}
