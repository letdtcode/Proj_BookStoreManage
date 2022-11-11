using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Proj_Book_Store_Manage.BSLayer;

namespace Proj_Book_Store_Manage.UI
{
    public partial class UControlPublisher : UserControl
    {
        private List<Control> controls = null;
        private DataTable dtPublisher = null;
        private Utilities utl = null;
        //private int IDAccount;
        private string err = "";
        private DialogResult result;

        //false là chế độ sửa, true là chế độ thêm
        private bool isAdd = false;
        private bool isEdit = false;
        PublisherBL publisher = new PublisherBL();
        public UControlPublisher()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //int indexLastRow = dgvPublisher.Rows.GetLastRow(DataGridViewElementStates.None);
            //lblIDPublisher.Text = ((int)dgvPublisher.Rows[indexLastRow-1].Cells[0].Value + 1).ToString();
            lblIDPublisher.Text = utl.createID("NXB");
            isAdd = true;
            utl.SetNullForAllControl();
            utl.setEnableControl(true);
            utl.SetEnableButton(new List<Button> { btnEdit, btnDelete }, false);
            utl.SetEnableButton(new List<Button> { btnSave, btnReload }, true);
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            isEdit = true;
            //utl.SetNullForAllControl();
            utl.setEnableControl(true);
            utl.SetEnableButton(new List<Button> { btnAdd, btnDelete }, false);
            utl.SetEnableButton(new List<Button> { btnSave, btnReload }, true);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (utl.CheckIDValid is true)
                {
                    result = MessageBox.Show("Bạn có chắc chắn muốn xóa không ?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        publisher.deletePublisher(utl.IDCurrent, ref err);
                        if (err == "")
                        {
                            MessageBox.Show("Xóa thành công !");
                        }
                        else
                            MessageBox.Show(err);

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                LoadData();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (utl.checkAllControlIsFill() == false)
                {
                    result = MessageBox.Show("Vui lòng nhập đầy đủ thông tin !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    isAdd = false;
                    isEdit = false;
                    return;
                }
                if (isAdd)
                {
                    publisher = new PublisherBL();
                    try
                    {
                        publisher.addNewPublisher(this.lblIDPublisher.Text, this.txtNamePublisher.Text, this.txtAddress.Text, this.txtPhoneNumber.Text, ref err);
                        if (err == "")
                        {
                            MessageBox.Show("Thêm tài khoản thành công !");
                        }
                        else
                        {
                            MessageBox.Show(err, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(err);
                    }
                }
                else if (isEdit)
                {
                    //account = new AccountBL()
                    publisher.modifyPublisher(utl.IDCurrent, this.txtNamePublisher.Text, this.txtAddress.Text, this.txtPhoneNumber.Text, ref err);
                    //LoadData();
                    if (err == "")
                    {
                        MessageBox.Show("Sửa tài khoản thành công !");
                    }
                    else
                    {
                        MessageBox.Show(err, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                isAdd = false;
                isEdit = false;
                utl.SetNullForAllControl();
                LoadData();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {

        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void UControlPublisher_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void dgvPublisher_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            utl.CellClick(btnCancel, btnDelete);
            lblIDPublisher.Text = utl.IDCurrent;
            txtNamePublisher.Text = dgvPublisher.Rows[utl.rowCurrent].Cells[1].Value.ToString();
            txtAddress.Text = dgvPublisher.Rows[utl.rowCurrent].Cells[2].Value.ToString();
            txtPhoneNumber.Text = dgvPublisher.Rows[utl.rowCurrent].Cells[3].Value.ToString();
        }
        private void LoadData()
        {
            lblIDPublisher.Text = "None";
            controls = new List<Control> { txtNamePublisher, txtAddress, txtPhoneNumber };
            dtPublisher = publisher.getDataPublisher();
            dgvPublisher.DataSource = dtPublisher;
            utl = new Utilities(controls, dgvPublisher);
            dgvPublisher.AutoResizeColumns();
            utl.SetEnableButton(new List<Button>() { btnSave, btnCancel }, false);
            utl.SetEnableButton(new List<Button>() { btnAdd, btnEdit, btnDelete, btnReload }, true);
            utl.setEnableControl(false);
        }
    }
}
