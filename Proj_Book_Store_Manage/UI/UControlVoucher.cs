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
    public partial class UControlVoucher : UserControl
    {
        private List<Control> controls = null;
        private DataTable dtVoucher = null;
        private Utilities utl = null;

        private string err = "";
        private DialogResult result;

        //false là chế độ sửa, true là chế độ thêm
        private bool isAdd = false;
        private bool isEdit = false;
        VoucherBL voucher = new VoucherBL();
        private bool roleTemp;
        public UControlVoucher()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
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
                        if (voucher.deleteVoucher(utl.IDCurrent, ref err) == true)
                        {
                            MessageBox.Show("Xóa thành công !");
                        }
                        else
                            MessageBox.Show("Xoá thất bại !");

                    }
                }
            }
            catch
            {
                MessageBox.Show("Không thể xóa !");
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
                    voucher = new VoucherBL();
                    try
                    {
                        voucher.addNewVoucher(int.Parse(this.txtValueVoucher.Text), this.txtEvent.Text, this.dtpDateStart.Value.ToString(), this.dtpDateEnd.Value.ToString(), int.Parse(this.txtAmount.Text), ref err);
                        if (err == "")
                        {
                            MessageBox.Show("Thêm voucher thành công !");
                        }
                        else
                        {
                            MessageBox.Show(err, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    catch
                    {
                        MessageBox.Show("Thông tin không hợp lệ");
                    }
                }
                else if (isEdit)
                {
                    //account = new AccountBL()
                    voucher.modifyVoucher(utl.IDCurrent, int.Parse(this.txtValueVoucher.Text), this.txtEvent.Text, this.dtpDateStart.Value.ToString(), this.dtpDateEnd.Value.ToString(), int.Parse(this.txtAmount.Text), ref err);
                    //LoadData();
                    if (err == "")
                    {
                        MessageBox.Show("Sửa thông tin voucher thành công !");
                    }
                    else
                    {
                        MessageBox.Show(err, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch
            {
                MessageBox.Show("Đã có lỗi xảy ra !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
        private void LoadData()
        {
            lblID.Text = "None";
            controls = new List<Control> { txtValueVoucher, txtEvent, dtpDateStart, dtpDateEnd, txtAmount };
            dtVoucher = voucher.getDataVoucher();
            dgvVoucher.DataSource = dtVoucher;
            utl = new Utilities(controls, dgvVoucher);
            dgvVoucher.AutoResizeColumns();
            utl.SetEnableButton(new List<Button>() { btnSave, btnCancel }, false);
            utl.SetEnableButton(new List<Button>() { btnAdd, btnEdit, btnDelete, btnReload }, true);
            utl.setEnableControl(false);
        }

        private void dgvVoucher_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            utl.CellClick(btnCancel, btnDelete);
            lblID.Text = dgvVoucher.Rows[utl.rowCurrent].Cells[0].Value.ToString();
            txtValueVoucher.Text = dgvVoucher.Rows[utl.rowCurrent].Cells[1].Value.ToString();
            txtEvent.Text = dgvVoucher.Rows[utl.rowCurrent].Cells[2].Value.ToString();
            dtpDateStart.Text = dgvVoucher.Rows[utl.rowCurrent].Cells[3].Value.ToString();
            dtpDateEnd.Text = dgvVoucher.Rows[utl.rowCurrent].Cells[4].Value.ToString();
            txtAmount.Text = dgvVoucher.Rows[utl.rowCurrent].Cells[5].Value.ToString();
        }

        private void UControlVoucher_Load(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}
