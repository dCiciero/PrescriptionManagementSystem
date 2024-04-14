using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrescriptionManagementSystem
{
    public partial class mainForm : Form
    {
        public mainForm()
        {
            InitializeComponent();
        }

        private void customerManaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //customersForm.TopLevel = false;
            //customersForm.FormBorderStyle = FormBorderStyle.None;
            ////customersForm.Dock = DockStyle.None;

            //if (contentPanel.Controls.Count > 0 )
            //{
            //    contentPanel.Controls.Clear();
            //}
            //contentPanel.Controls.Add( customersForm );
            //customersForm.Show();

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void mainAdminMenu_Click(object sender, EventArgs e)
        {
            //Admin adminForm = new Admin();
            //adminForm.ShowDialog();
        }

        private void mainForm_Load(object sender, EventArgs e)
        {
            //LoginForm frmLogin = new LoginForm();
            //frmLogin.ShowDialog();
            lblUserDetails.Text = $"Welcome {AppConfig.loggedInUserName}"; // You are logged in to {AppConfig.loggedInUserStore}
            lblStoreName.Text = $"You are logged into {AppConfig.loggedInUserStore} branch";
            if (!AppConfig.loggedInUserIsAdmin)
            {
                mainAdminMenu.Visible = false;
                createModifyToolStripMenuItem.Visible = false;
                //invemtoryToolStripMenuItem.Visible = false ;
                //invemtoryToolStripMenuItem.Enabled = false ;
            }
        }

        private void createModifyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCustomers customersForm = new frmCustomers();
            customersForm.ShowDialog();
        }

        private void manageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CustomerSearchForm customersForm = new CustomerSearchForm();
            customersForm.ShowDialog();
        }

        private void invemtoryToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }


        private void createUsersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CreateUserForm createUserForm = new CreateUserForm();
            createUserForm.ShowDialog();
        }


        private void changePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //ChangePasswordForm changePasswordForm = new ChangePasswordForm();
            DashboardForm dashboardForm = new();
            dashboardForm.ShowDialog();
        }

        private void signOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            LoginForm signInForm = new LoginForm();
            signInForm.ShowDialog();
        }

       


        private void inventoryManagementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StockManagementForm stockManagementForm = new();
            stockManagementForm.ShowDialog();
        }

        private void searchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DrugStoreForm drugStoreForm = new DrugStoreForm();
            drugStoreForm.ShowDialog();
        }

        private void sellToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SalesForm sales = new();
            sales.ShowDialog();
        }
    }
}
