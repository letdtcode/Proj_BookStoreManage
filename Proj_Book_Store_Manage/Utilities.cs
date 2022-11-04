using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace Proj_Book_Store_Manage
{
    public class Utilities
    {
        private List<Control> controls;
        private DataGridView dgv = null;
        private static bool checkIDValid = false;
        private int rowIDCurrentIndex;
        private int rowCurrentIndex;

        public Utilities(List<Control> controls,DataGridView dgv)
        {
            Controls = new List<Control>(controls);
            this.dgv = dgv;
            rowIDCurrentIndex = -1;
            rowCurrentIndex = -1;
        }
        public bool CheckIDValid
        {
            get => checkIDValid;
            set => checkIDValid = value;
        }
        public List<Control> Controls { get => controls; set => controls = value; }
        public int IDCurrent
        {
            get => rowIDCurrentIndex;
            //set => rowIDCurrentIndex = value;
        }
        public int rowCurrent
        {
            get => rowCurrentIndex;
            set => rowCurrentIndex = value;
        }
        public string createID(string nameTable, int numberIDBefore)
        {
            string ID = nameTable + numberIDBefore.ToString();
            return ID;
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
                rowIDCurrentIndex = -1;
            }
            else
            {
                checkIDValid = true;
                SetEnableButton(new List<Button>() { Cancel, Delete }, true);
                rowIDCurrentIndex = (int)dgv.Rows[rowCurrentIndex].Cells[0].Value;
            }
            /*rowCurrentIndex = dgv.SelectedCells[0].RowIndex;
            SetEnableButton(new List<Button>() { Cancel, Delete }, true);
            rowIDCurrentIndex = (int)dgv.Rows[rowCurrentIndex].Cells[0].Value;*/
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
