// ***********************************************************************
// Assembly         : PrescriptionManagementSystem
// Author           : ogaga.ivhurie
// Created          : 04-01-2024
//
// Last Modified By : ogaga.ivhurie
// Last Modified On : 05-02-2024
// ***********************************************************************
// <copyright file="DashboardForm.cs" company="PrescriptionManagementSystem">
//     Copyright (c) . All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using PrescriptionManagementSystem.Data.Models;
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
    /// Class DashboardForm.
    /// Implements the <see cref="Form" />
    /// </summary>
    /// <seealso cref="Form" />
    public partial class DashboardForm : Form
    {
        //Fields
        /// <summary>
        /// The model
        /// </summary>
        private Dashboard model;
        /// <summary>
        /// The current button
        /// </summary>
        private Button currentButton;
        /// <summary>
        /// Initializes a new instance of the <see cref="DashboardForm"/> class.
        /// </summary>
        public DashboardForm()
        {
            InitializeComponent();

            //Default - last 7 days
            dtpStartDate.Value = DateTime.Today.AddDays(-7);
            dtpEndDate.Value = DateTime.Now;
            btnLast7Days.Select();
            SetDateMenuButtonUI(btnLast7Days);

            model = new();
            LoadData();
        }

        /// <summary>
        /// Loads the data.
        /// </summary>
        private void LoadData()
        {
            var refreshData = model.LoadData(dtpStartDate.Value, dtpEndDate.Value);
            if (refreshData)
            {
                lblNumerOfSale.Text = model.NumberOfSales.ToString();
                lblTotalRevenue.Text = "£" + model.TotalRevenue.ToString();
                lblTotalProfit.Text = "£" + model.TotalProfit.ToString();

                lblNumberOfCustomers.Text = model.NumberOfCustomers.ToString();
                lblNumberOfSuppliers.Text = model.NumberOfSuppliers.ToString();
                lblNumberOfProducts.Text = model.NumberOfProducts.ToString();


                chartGrossRevenue.DataSource = model.GrossRevenueList;
                chartGrossRevenue.Series[0].XValueMember = "Date";
                chartGrossRevenue.Series[0].YValueMembers = "TotalAmount";
                chartGrossRevenue.DataBind();

                


                chartTop5Products.DataSource = model.TopProductList;
                chartTop5Products.Series[0].XValueMember = "Key";
                chartTop5Products.Series[0].YValueMembers = "Value";
                chartTop5Products.DataBind();


                dgvLowStockItems.DataSource = model.UnderstockList;
                dgvLowStockItems.Columns[0].HeaderText = "Items";
                dgvLowStockItems.Columns[1].HeaderText = "Quantity";

                Console.WriteLine("Loaded view :}");
            }
            else
                Console.WriteLine("View not loaded");
        }

        /// <summary>
        /// Sets the date menu button UI.
        /// </summary>
        /// <param name="button">The button.</param>
        private void SetDateMenuButtonUI(object button)
        {
            var btn = (Button)button;
            //Highlight button
            btn.BackColor = btnLast30Days.FlatAppearance.BorderColor;
            btn.ForeColor = Color.White;

            //Unhighlight button
            if (currentButton != null && currentButton != btn)
            {
                currentButton.BackColor = this.BackColor;
                currentButton.ForeColor = Color.FromArgb(124, 141, 181);
            }
            currentButton = btn; //set current button

            //Enable custom dates
            if (btn == btnCustomDate)
            {
                dtpStartDate.Enabled = true;
                dtpEndDate.Enabled = true;
                btnOkCustomDate.Visible = true;
                lblStartDate.Cursor = Cursors.Hand;
                lblEndDate.Cursor = Cursors.Hand;
            }
            else
            {
                dtpStartDate.Enabled = false;
                dtpEndDate.Enabled = false;
                btnOkCustomDate.Visible = false;
                lblStartDate.Cursor = Cursors.Default;
                lblEndDate.Cursor = Cursors.Default;
            }

        }
        /// <summary>
        /// Handles the Click event of the btnToday control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void btnToday_Click(object sender, EventArgs e)
        {
            dtpStartDate.Value = DateTime.Today;
            dtpEndDate.Value = DateTime.Now;
            LoadData();
            SetDateMenuButtonUI(sender);
        }

        /// <summary>
        /// Handles the Click event of the btnLast7Days control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void btnLast7Days_Click(object sender, EventArgs e)
        {
            dtpStartDate.Value = DateTime.Today.AddDays(-7);
            dtpEndDate.Value = DateTime.Now;
            LoadData();
            SetDateMenuButtonUI(sender);
        }

        /// <summary>
        /// Handles the Click event of the btnLast30Days control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void btnLast30Days_Click(object sender, EventArgs e)
        {
            dtpStartDate.Value = DateTime.Today.AddDays(-30);
            dtpEndDate.Value = DateTime.Now;
            LoadData();
            SetDateMenuButtonUI(sender);
        }

        /// <summary>
        /// Handles the Click event of the btnThisMonth control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void btnThisMonth_Click(object sender, EventArgs e)
        {
            dtpStartDate.Value = new DateTime(DateTime.Today.Year, DateTime.Today.Month, 1);
            dtpEndDate.Value = DateTime.Now;
            LoadData();
            SetDateMenuButtonUI(sender);
        }

        /// <summary>
        /// Handles the Click event of the btnCustomDate control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void btnCustomDate_Click(object sender, EventArgs e)
        {
            SetDateMenuButtonUI(sender);
        }

        /// <summary>
        /// Handles the Click event of the btnOkCustomDate control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void btnOkCustomDate_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        /// <summary>
        /// Handles the Click event of the lblStartDate control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void lblStartDate_Click(object sender, EventArgs e)
        {
            if (currentButton == btnCustomDate)
            {
                dtpStartDate.Select();
                SendKeys.Send("%{DOWN}");
            }
        }

        /// <summary>
        /// Handles the Click event of the lblEndDate control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void lblEndDate_Click(object sender, EventArgs e)
        {
            if (currentButton == btnCustomDate)
            {
                dtpEndDate.Select();
                SendKeys.Send("%{DOWN}");
            }
        }

        /// <summary>
        /// Handles the ValueChanged event of the dtpStartDate control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void dtpStartDate_ValueChanged(object sender, EventArgs e)
        {
            lblStartDate.Text = dtpStartDate.Text;
        }

        /// <summary>
        /// Handles the ValueChanged event of the dtpEndDate control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void dtpEndDate_ValueChanged(object sender, EventArgs e)
        {
            lblEndDate.Text = dtpEndDate.Text;
        }

        /// <summary>
        /// Handles the Load event of the DashboardForm control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void DashboardForm_Load(object sender, EventArgs e)
        {
            lblStartDate.Text = dtpStartDate.Text;
            lblEndDate.Text = dtpEndDate.Text;
        }

        /// <summary>
        /// Handles the Click event of the btnClose control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
