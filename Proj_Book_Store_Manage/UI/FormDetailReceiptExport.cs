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
    public partial class FormDetailReceiptExport : Form
    {
        private DataTable dtListBook = null;
        private DataTable dtListIemOfBill = null;

        private string err = "";

        DetailReceiptExport detailReceiptExport = null;

        public FormDetailReceiptExport(string idBill)
        {
            InitializeComponent();
            detailReceiptExport = new DetailReceiptExport(idBill);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                addItemIntoBill(this.lblIDBook.Text, this.lblNameBook.Text, int.Parse(this.txtAmountBook.Text));
            }
            catch
            {
                MessageBox.Show("Vui lòng nhập số lượng sách muốn thêm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            /*List<string> idOld = new List<string>();
            List<string> idNew = new List<string>();
            bool isExist = false;
            foreach (DataRow rowOfDtListItemOfBill in dtListIemOfBill.Rows)
            {
                idOld.Add(rowOfDtListItemOfBill.Field<string>("ID"));
            }
            foreach (DataGridViewRow dgvCartRow in dgvCart.Rows)
            {
                idNew.Add(dgvCartRow.Cells[0].Value.ToString());
            }
            foreach(String idTempNew in idNew)
            {
                foreach(String idTempOld in idOld)
                {
                    if (idTempNew == idTempOld)
                    {
                        idTempOld
                        detailReceiptExport.modifyDetailReceiptExport(this.lblIDReceipt.Text, idTempOld, idTempNew, int.Parse(dgvCartRow.Cells[2].Value.ToString()), ref err);
                    }
                }
            }*/
            bool isExist = false;
            foreach (DataGridViewRow dgvCartRow in dgvCart.Rows)
            {
                foreach (DataRow rowOfDtListItemOfBill in dtListIemOfBill.Rows)
                {
                    if (dgvCartRow.Cells[0].Value.ToString() == rowOfDtListItemOfBill.Field<string>("ID"))
                    {
                        isExist = true;
                        detailReceiptExport.modifyDetailReceiptExport(this.lblIDReceipt.Text, rowOfDtListItemOfBill.Field<string>("ID"), dgvCartRow.Cells[0].Value.ToString(), int.Parse(dgvCartRow.Cells[2].Value.ToString()), ref err);
                        break;
                    }
                }
                if (isExist == false)
                {
                    try
                    {
                        detailReceiptExport.addNewDetailReceiptExport(this.lblIDReceipt.Text, dgvCartRow.Cells[0].Value.ToString(), int.Parse(dgvCartRow.Cells[2].Value.ToString()), ref err);
                    }
                    catch
                    {
                        MessageBox.Show(err);
                    }
                    
                }
                isExist = false;
            }
            //
            foreach (DataRow rowOfDtListItemOfBill in dtListIemOfBill.Rows)
            {
                foreach (DataGridViewRow dgvCartRow in dgvCart.Rows)
                {
                    if (rowOfDtListItemOfBill.Field<string>("ID") == dgvCartRow.Cells[0].Value.ToString())
                    {
                        isExist = true;
                        break;
                    }
                }
                if (isExist == false)
                {
                    detailReceiptExport.deleteDetailReceiptExport(this.lblIDReceipt.Text, rowOfDtListItemOfBill.Field<string>("ID"), ref err);
                }
                isExist = false;
            }
        }

        private void LoadDataBook()
        {
            this.lblIDReceipt.Text = detailReceiptExport.IdBill;
            dtListBook = detailReceiptExport.getDataBook();
            dgvListBook.DataSource = dtListBook;
            //utl = new Utilities(controls, dgvAuthor);
            dgvListBook.AutoResizeColumns();
            /*utl.SetEnableButton(new List<Button>() { btnSave, btnCancel }, false);
            utl.SetEnableButton(new List<Button>() { btnAdd, btnEdit, btnDelete, btnReload }, true);
            utl.setEnableControl(false);*/
        }

        private void FormDetailReceiptExport_Load(object sender, EventArgs e)
        {
            LoadDataBook();
            LoadItemOfBill(detailReceiptExport.IdBill, ref err);
            this.lblNameCustomer.Text = detailReceiptExport.getNameOfCustomer(ref err);
            this.lblNameEmployee.Text = detailReceiptExport.getNameOfEmployee(ref err);
        }

        private void dgvListBook_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowCurrentIndex = dgvListBook.CurrentCell.RowIndex;
            this.lblIDBook.Text = dgvListBook.Rows[rowCurrentIndex].Cells[0].Value.ToString();
            this.lblNameBook.Text=dgvListBook.Rows[rowCurrentIndex].Cells[1].Value.ToString();
        }

        private void LoadItemOfBill(string idBill, ref string err)
        {
            dgvCart.Rows.Clear();
            dtListIemOfBill = detailReceiptExport.getDataItemOfBill(ref err);
            foreach(DataRow rowsOfTable in dtListIemOfBill.Rows)
            {
                DataGridViewRow rowOfDgv = new DataGridViewRow();
                dgvCart.Rows.Add(rowOfDgv);
                rowOfDgv.Cells[0].Value = rowsOfTable.Field<string>("ID");
                
                rowOfDgv.Cells[1].Value = rowsOfTable.Field<string>("Tên Sách");
                rowOfDgv.Cells[2].Value = rowsOfTable.Field<int>("Số lượng");
                
            }
            dgvCart.AutoResizeColumns();
        }
        private void addItemIntoBill(string idBook, string nameBook, int amount)
        {
            bool checkExist = false;
            int rowIndex = 0;
            for(rowIndex = 0; rowIndex < dgvCart.Rows.Count; rowIndex++)
            {
                if (dgvCart.Rows[rowIndex].Cells[0].Value == null)
                    break;
                if (dgvCart.Rows[rowIndex].Cells[0].Value.ToString() == idBook)
                {
                    checkExist = true;
                    break;
                }
            }
            if (checkExist == true)
            {
                dgvCart.Rows[rowIndex].Cells[2].Value = int.Parse(dgvCart.Rows[rowIndex].Cells[2].Value.ToString()) + amount;
            }
            else
            {
                dgvCart.Rows.Add(idBook, nameBook, amount.ToString());
            }
        }

        private void dgvCart_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;
            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.ColumnIndex == 3)
            {
                FormEditDetailReceiptExport frmEditDetailReceiptExport = new FormEditDetailReceiptExport(dgvCart,e.RowIndex);
                frmEditDetailReceiptExport.Show();
            }
            if(senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.ColumnIndex == 4)
            {
                DialogResult result = MessageBox.Show("Xác nhận xóa khỏi đơn hàng", "Xác nhận", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (result == DialogResult.OK) 
                    dgvCart.Rows.RemoveAt(e.RowIndex);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
