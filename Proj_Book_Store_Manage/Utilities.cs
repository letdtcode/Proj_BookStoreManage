using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Data;

namespace Proj_Book_Store_Manage
{
    public class Utilities
    {
        private List<Control> controls;
        private DataGridView dgv = null;
        private static bool checkIDValid = false;
        private string rowIDCurrentIndex;
        private int rowCurrentIndex;
        private DataTable dt = null;

        public Utilities(List<Control> controls,DataGridView dgv)
        {
            Controls = new List<Control>(controls);
            this.dgv = dgv;
            rowIDCurrentIndex = null;
            rowCurrentIndex = -1;
        }
        public Utilities(DataGridView dgv)
        {
            this.dgv = dgv;
            rowIDCurrentIndex = null;
            rowCurrentIndex = -1;
        }
        public Utilities(DataTable dataTable)
        {
            this.dt = dataTable;
        }
        public bool CheckIDValid
        {
            get => checkIDValid;
            set => checkIDValid = value;
        }
        public List<Control> Controls { get => controls; set => controls = value; }
        public string IDCurrent
        {
            get => rowIDCurrentIndex;
        }
        public int rowCurrent
        {
            get => rowCurrentIndex;
            set => rowCurrentIndex = value;
        }
        public string createID(string codeMark)
        {
            int numIDNext = 0;
            int numRows = dgv.Rows.Count;
            if (numRows <= 1)
            {
                numIDNext = 1;
            }
            else
            {
                numIDNext = getMax(idsInDgv(dgv))+1;
            }
            return codeMark + numIDNext.ToString();
        }
        public string createIDBill(string codeMark)
        {
            int numIDNext = 0;
            int numRows = dt.Rows.Count;
            if (numRows < 0)
            {
                numIDNext = 1;
            }
            else
            {
                //numIDNext = numRows + 1;
                numIDNext = getMax(idsInDataTable(dt));
            }
            return codeMark + numIDNext.ToString();
        }
        public int getMax(List<string> ID)
        {
            int max = int.Parse(Regex.Match(ID[0], @"\d+").Value);
            int temp = -1;
            foreach (string id in ID)
            {
                temp = int.Parse(Regex.Match(id, @"\d+").Value);
                if (temp > max)
                {
                    max = temp;
                }
            }
            return max;
        }
        public List<string> idsInDgv (DataGridView dgv)
        {
            List<string> list = new List<string>();
            foreach(DataGridViewRow item in dgv.Rows)
            {
                if (item.Cells[0].Value == null)
                    break;
                list.Add(item.Cells[0].Value.ToString());
            }
            return list;
        }
        public List<string> idsInDataTable(DataTable dt)
        {
            List<string> list = new List<string>();
            foreach (DataRow item in dt.Rows)
            {
                list.Add(item[0].ToString());
            }
            return list;
        }
        
        public void setEnableControl(bool b)
        {
            foreach (Control control in controls)
            {
                control.Enabled = b;
            }
        }
        public void SetNullForAllControl()
        {
            foreach(Control control in controls)
            {
                if(control is TextBox)
                {
                    control.Text = "";
                }
                if(control is RadioButton)
                {
                    control.Enabled = false;
                }
            }
        }
        public void SetEnableButton(List<Button> btns, bool enabled)
        {
            btns.ForEach(b => {
                b.Enabled = enabled;
                b.BackColor = enabled ? Color.White : Color.Gray;
            });
        }

        public void CellClick(Button Cancel, Button Delete)
        {
            //int r = dgv.CurrentCell.RowIndex;
            rowCurrentIndex = dgv.SelectedCells[0].RowIndex;

            if (rowCurrentIndex > dgv.RowCount - 2)
            {
                checkIDValid = false;
                SetEnableButton(new List<Button>() { Cancel, Delete }, false);
                rowIDCurrentIndex = null;
            }
            else
            {
                checkIDValid = true;
                SetEnableButton(new List<Button>() { Cancel, Delete }, true);
                rowIDCurrentIndex = dgv.Rows[rowCurrentIndex].Cells[0].Value.ToString();
            }
            /*rowCurrentIndex = dgv.SelectedCells[0].RowIndex;
            SetEnableButton(new List<Button>() { Cancel, Delete }, true);
            rowIDCurrentIndex = (int)dgv.Rows[rowCurrentIndex].Cells[0].Value;*/
        }
        public void CellClick(Button DetailReceipt)
        {
            rowCurrentIndex = dgv.SelectedCells[0].RowIndex;

            if (rowCurrentIndex > dgv.RowCount - 2)
            {
                checkIDValid = false;
                SetEnableButton(new List<Button>() { DetailReceipt }, false);
                rowIDCurrentIndex = null;
            }
            else
            {
                checkIDValid = true;
                SetEnableButton(new List<Button>() { DetailReceipt }, true);
                rowIDCurrentIndex = dgv.Rows[rowCurrentIndex].Cells[0].Value.ToString();
            }
        }
        public bool checkAllControlIsFill()
        {
            foreach(Control control in controls)
            {
                if ((string)control.Text.ToString() is null || (string)control.Text.ToString()=="")
                    return false;
            }
            return true;
        }
    }
}
