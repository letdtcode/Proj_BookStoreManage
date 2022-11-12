﻿using System;
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
    public partial class UControlReceiptImport : UserControl
    {
        private DataTable dtReceiptImport = null;
        private Utilities utl = null;
        private string err = "";
        private DialogResult result;
        ReceiptImportBL receiptImport = null;
        ImportBooksBL importBook = null;

        public UControlReceiptImport()
        {
            InitializeComponent();
            dtpReceiptImport.Format = DateTimePickerFormat.Custom;
            dtpReceiptImport.CustomFormat = "dd-MM-yyyy";
            this.lbIdEmployee.Text = frmLogin.idEmp;
            receiptImport = new ReceiptImportBL();
            utl = new Utilities(dgvReceiptImport);
        }

        private void btnDetailImportReceipt_Click(object sender, EventArgs e)
        {
            FormDetailReceiptImport frm_DetailReceiptImport = new FormDetailReceiptImport();
            frm_DetailReceiptImport.ShowDialog();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string idBill = utl.createID("HDN");
            receiptImport.addNewReceiptImport(idBill, ref err);
            importBook = new ImportBooksBL(idBill);      
            
            FormImportBook frmImportBook = new FormImportBook(idBill);
            frmImportBook.FormClosed += Edit_FormImportBookClosed;
            frmImportBook.Show();
        }
        private void Edit_FormImportBookClosed(object sender, FormClosedEventArgs e)
        {
            LoadData();
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
                        receiptImport.deleteReceiptImport(this.lblIDBill.Text, ref err);
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
        private void btnCancel_Click(object sender, EventArgs e)
        {

        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void dgvReceiptImport_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                utl.CellClick(btnDetailImportReceipt);
                this.lblIDBill.Text = dgvReceiptImport.Rows[utl.rowCurrent].Cells[0].Value.ToString();

                string dt = DateTime.Parse(dgvReceiptImport.Rows[utl.rowCurrent].Cells[1].Value.ToString()).ToString("dd/MM/yyyy");
                this.lblDateImport.Text = dt;
                this.lblTotal.Text = dgvReceiptImport.Rows[utl.rowCurrent].Cells[2].Value.ToString();      
                this.lblEmployee.Text = dgvReceiptImport.Rows[utl.rowCurrent].Cells[3].Value.ToString();
            }
            catch
            {
                result = MessageBox.Show("Hóa đơn này không có giá trị ! Vui lòng chọn hóa đơn khác", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void UControlReceiptImport_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        private void LoadData()
        {
            dtReceiptImport = receiptImport.getDataReceiptImport();
            dgvReceiptImport.DataSource = dtReceiptImport;
            utl = new Utilities(dgvReceiptImport);
            dgvReceiptImport.AutoResizeColumns();
            utl.SetEnableButton(new List<Button>() { btnDetailImportReceipt }, false);
        }
    }
}
