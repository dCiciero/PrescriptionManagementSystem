// ***********************************************************************
// Assembly         : PrescriptionManagementSystem
// Author           : ogaga.ivhurie
// Created          : 02-22-2024
//
// Last Modified By : ogaga.ivhurie
// Last Modified On : 05-11-2024
// ***********************************************************************
// <copyright file="mainForm.cs" company="PrescriptionManagementSystem">
//     Copyright (c) . All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
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
    /// <summary>
    /// Class mainForm.
    /// Implements the <see cref="Form" />
    /// </summary>
    /// <seealso cref="Form" />
    public partial class mainForm : Form
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="mainForm"/> class.
        /// </summary>
        public mainForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Handles the Click event of the customerManaToolStripMenuItem control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
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

        /// <summary>
        /// Handles the Click event of the exitToolStripMenuItem control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /// <summary>
        /// Handles the Click event of the mainAdminMenu control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void mainAdminMenu_Click(object sender, EventArgs e)
        {
            //Admin adminForm = new Admin();
            //adminForm.ShowDialog();
        }

        /// <summary>
        /// Handles the Load event of the mainForm control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void mainForm_Load(object sender, EventArgs e)
        {
            //LoginForm frmLogin = new LoginForm();
            //frmLogin.ShowDialog();
             // You are logged in to {AppConfig.loggedInUserStore}
            lblStoreName.Text = $"You are logged into {AppConfig.loggedInUserStore} branch";
            if (!AppConfig.loggedInUserIsAdmin)
            {
                mainAdminMenu.Visible = false;
                createModifyToolStripMenuItem.Visible = false;
                lblUserDetails.Text = $"Welcome {AppConfig.loggedInUserName} - (System User)";
                //invemtoryToolStripMenuItem.Visible = false ;
                //invemtoryToolStripMenuItem.Enabled = false ;
            }
            else
            {
                lblUserDetails.Text = $"Welcome {AppConfig.loggedInUserName} - (Admin User)";
            }
        }

        /// <summary>
        /// Handles the Click event of the createModifyToolStripMenuItem control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void createModifyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCustomers customersForm = new frmCustomers();
            customersForm.ShowDialog();
        }

        /// <summary>
        /// Handles the Click event of the manageToolStripMenuItem control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void manageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CustomerSearchForm customersForm = new CustomerSearchForm();
            customersForm.ShowDialog();
        }

        /// <summary>
        /// Handles the Click event of the invemtoryToolStripMenuItem control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void invemtoryToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }


        /// <summary>
        /// Handles the Click event of the createUsersToolStripMenuItem control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void createUsersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CreateUserForm createUserForm = new CreateUserForm();
            createUserForm.ShowDialog();
        }


        /// <summary>
        /// Handles the Click event of the changePasswordToolStripMenuItem control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void changePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //ChangePasswordForm changePasswordForm = new ChangePasswordForm();
            DashboardForm dashboardForm = new();
            dashboardForm.ShowDialog();
        }

        /// <summary>
        /// Handles the Click event of the signOutToolStripMenuItem control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void signOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            LoginForm signInForm = new LoginForm();
            signInForm.ShowDialog();
        }




        /// <summary>
        /// Handles the Click event of the inventoryManagementToolStripMenuItem control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void inventoryManagementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StockManagementForm stockManagementForm = new();
            stockManagementForm.ShowDialog();
        }

        /// <summary>
        /// Handles the Click event of the searchToolStripMenuItem control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void searchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DrugStoreForm drugStoreForm = new DrugStoreForm();
            drugStoreForm.ShowDialog();
        }

        /// <summary>
        /// Handles the Click event of the sellToolStripMenuItem control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void sellToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SalesForm sales = new();
            sales.ShowDialog();
        }

        /// <summary>
        /// Handles the Click event of the salesToolStripMenuItem control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void salesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SystemSetupFrom systemSetupFrom = new SystemSetupFrom();
            systemSetupFrom.ShowDialog();
        }
    }
}
