using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Text.RegularExpressions;

namespace Proj_Book_Store_Manage
{
    public class Utilities
    {
        private List<Control> controls;
        private DataGridView dgv = null;
        private static bool checkIDValid = false;
        private string rowIDCurrentIndex;
        private int rowCurrentIndex;

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
        public bool CheckIDValid
        {
            get => checkIDValid;
            set => checkIDValid = value;
        }
        public List<Control> Controls { get => controls; set => controls = value; }
        public string IDCurrent
        {
            get => rowIDCurrentIndex;
            //set => rowIDCurrentIndex = value;
        }
        public int rowCurrent
        {
            get => rowCurrentIndex;
            set => rowCurrentIndex = value;
        }
        public string createID(string codeMark)
        {
            int numIDNext = 0;
            int indexLastRow = dgv.Rows.GetLastRow(DataGridViewElementStates.None);
            if (indexLastRow == 0)
            {
                numIDNext = 1;
            }
            else
            {
                string resultString = Regex.Match(dgv.Rows[indexLastRow - 1].Cells[0].Value.ToString(), @"\d+").Value;
                numIDNext = int.Parse(resultString) + 1;
            }
            return codeMark+numIDNext.ToString();
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
