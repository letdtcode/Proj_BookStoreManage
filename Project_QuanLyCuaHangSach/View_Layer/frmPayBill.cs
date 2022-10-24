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
    public partial class frmPayBill : Form
    {
        public int idBill { get; set; }

        public frmPayBill()
        {
            InitializeComponent();
        }
    }
}
