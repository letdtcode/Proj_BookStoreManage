using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Project_QuanLyCuaHangSach.Business_Layer;

namespace Project_QuanLyCuaHangSach
{
    public partial class frmUpdatePublisher : Form
    {
        bool insert, update, delete, search;
        string err;

        DataTable dt;
        Publisher publisher = new Publisher();


        public frmUpdatePublisher()
        {
            InitializeComponent();
            loadData();
            
        }
      
        void loadData()
        {
            try
            {
                dt = new DataTable();
                DataSet ds = publisher.getPublishers();

                dt = ds.Tables[0];

                dgvPublisher.DataSource = dt;

                this.txtPublisherID.Text = dgvPublisher.Rows[0].Cells[0].Value.ToString().Trim();
                this.txtPublisherNAME.Text = dgvPublisher.Rows[0].Cells[1].Value.ToString().Trim();
                this.txtPublisherADDRESS.Text = dgvPublisher.Rows[0].Cells[2].Value.ToString().Trim();
                this.txtPHONENUM.Text = dgvPublisher.Rows[0].Cells[3].Value.ToString().Trim();
            }
            catch(Exception)
            {
                MessageBox.Show("Lỗi rồi!!");
            }
        }

        private void Reset()
        {
            txtPublisherID.ResetText();
            txtPublisherNAME.ResetText();
            txtPublisherADDRESS.ResetText();
            txtPHONENUM.ResetText();

            this.insert = false;
            this.update = false;
            this.delete = false;
            this.search = false;

            this.btnFinish.Enabled = true;
            this.btnThem.Enabled = true;
            this.btnXoa.Enabled = true;
            this.btnSua.Enabled = true;
            this.btnSearch.Enabled = true;

        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            this.txtPHONENUM.Enabled = false;
            this.txtPublisherADDRESS.Enabled = false;

            this.search = true;
            this.btnFinish.Enabled = true;
            this.btnThem.Enabled = false;
            this.btnXoa.Enabled = false;
            this.btnSua.Enabled = false;
            this.btnSearch.Enabled = false;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            this.insert = true;

            this.btnFinish.Enabled = true;
            this.btnXoa.Enabled = false;
            this.btnSua.Enabled = false;
            this.btnSearch.Enabled = false;
            this.btnThem.Enabled = false;

        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            this.update=true;

            this.btnFinish.Enabled = true;
            this.btnXoa.Enabled = false;
            this.btnSua.Enabled = false;
            this.btnSearch.Enabled = false;
            this.btnThem.Enabled = false;

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            this.delete = true;

            this.btnFinish.Enabled = true;
            this.btnXoa.Enabled = false;
            this.btnSua.Enabled = false;
            this.btnSearch.Enabled = false;
            this.btnThem.Enabled = false;
        }

        private void btnFinish_Click(object sender, EventArgs e)
        {
            if (insert)
            {
                try
                {
                    publisher.insertPublisher(txtPublisherNAME.Text.ToString().Trim(),
                        txtPublisherADDRESS.Text.ToString().Trim(),
                        txtPHONENUM.Text.Trim().ToString(), 
                        ref err);
                    if (err != null)
                        MessageBox.Show(err);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString());
                }
            }
            else if (search)
            {
                try
                {
                    publisher.searchPublisher(Convert.ToInt32(txtPublisherID.Text), 
                        txtPublisherNAME.Text.ToString().Trim(), 
                        ref err);
                    if (err != null)
                        MessageBox.Show(err);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString());
                }
            }   
            
            else if (delete)
            {
                try
                {
                    publisher.deletePublisher(Convert.ToInt32(txtPublisherID.Text.ToString()),
                        ref err);
                    if (err != null)
                        MessageBox.Show(err);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString());
                }
            }   
            
            else if (update)
            {
                try
                {
                    publisher.updatePublisher(Convert.ToInt32(txtPublisherID.Text.ToString()),
                        txtPublisherNAME.Text.ToString().Trim(),
                        txtPublisherADDRESS.Text.ToString().Trim(),
                        txtPHONENUM.Text.Trim().ToString(),
                        ref err);
                    if (err != null)
                        MessageBox.Show(err);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString());
                }
            }
            else
            {
                MessageBox.Show("Lỗi rồi");
            }
            Reset();
            loadData();
        }

        private void dgvPublisher_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = e.RowIndex;

            this.txtPublisherID.Text = dgvPublisher.Rows[r].Cells[0].Value.ToString().Trim();
            this.txtPublisherNAME.Text = dgvPublisher.Rows[r].Cells[1].Value.ToString().Trim();
            this.txtPublisherADDRESS.Text = dgvPublisher.Rows[r].Cells[2].Value.ToString().Trim();
            this.txtPHONENUM.Text = dgvPublisher.Rows[r].Cells[3].Value.ToString().Trim();
        }

       

        private void frmUpdatePublisher_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmBook frm = new frmBook();
            frm.Show();
            this.Hide();
        }

        private void frmUpdatePublisher_Load(object sender, EventArgs e)
        {

        }
    }
}
