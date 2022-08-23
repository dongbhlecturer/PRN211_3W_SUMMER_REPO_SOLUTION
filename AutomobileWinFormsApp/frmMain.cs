using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutomobileWinFormsApp
{
    public partial class frmMain : Form
    {

        public frmMain()
        {
            InitializeComponent();
        }

        private void productToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void managementProductToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmManagementCar frmManagement = new frmManagementCar();
            frmManagement.MdiParent = this;
            frmManagement.Show();
        }

        private void mnuExit_Click(object sender, EventArgs e)
        {
            //Hien thi message confirm before closing application
            Application.Exit();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            /*Muốn khi form main được load thì mnuAddnew "nghe được" sự kiện click để
             show form thêm mới Car lên*/
            mnuAddNew.Click += new EventHandler(new frmManagementCar().btnSave_Click);
            //add event cho nut exit khi form được load
            mnuExit.ShortcutKeys = (Keys)(Keys.Alt | Keys.X);
            mnuExit.Click += new EventHandler(mnuExit_Click);
        }

        private void addNewToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
