using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proj_Book_Store_Manage.UI
{
    public partial class UControlBookOverview : UserControl
    {
        public UControlBookOverview()
        {
            InitializeComponent();
        }

        private void btnAuthor_Click(object sender, EventArgs e)
        {
            moveSidePanel(btnAuthor);
            UControlAuthor uc_Author = new UControlAuthor();
            addUserControl(uc_Author);
        }
        private void moveSidePanel(Button btn)
        {
            panelSide.Top = btn.Bottom;
            panelSide.Left = btn.Left;
        }

        private void btnPublisher_Click(object sender, EventArgs e)
        {
            moveSidePanel(btnPublisher);
            UControlPublisher uc_Publisher = new UControlPublisher();
            addUserControl(uc_Publisher);
        }

        private void btnInfoBook_Click(object sender, EventArgs e)
        {
            moveSidePanel(btnInfoBook);
            UControlInfoBook uc_InfoBook = new UControlInfoBook();
            addUserControl(uc_InfoBook);
        }

        private void btnCategory_Click(object sender, EventArgs e)
        {
            moveSidePanel(btnCategory);
            UControlCategory uc_Category = new UControlCategory();
            addUserControl(uc_Category);
        }

        private void ChangeColorEnter(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            btn.BackColor = Color.Silver;
        }

        private void ChangeColorLeave(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            btn.BackColor = Color.Black;
        }
        private void addUserControl(Control c)
        {
            panelMain.Controls.Clear();
            panelMain.Controls.Add(c);
        }

        private void UControlBookOverview_Load(object sender, EventArgs e)
        {
            UControlAuthor uc_author = new UControlAuthor();
            panelMain.Controls.Clear();
            panelMain.Controls.Add(uc_author);
        }
    }
}
