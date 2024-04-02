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
    public partial class DashboardForm : Form
    {
        //Fields
        private Dashboard model;
        private Button currentButton;
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
        private void btnToday_Click(object sender, EventArgs e)
        {
            dtpStartDate.Value = DateTime.Today;
            dtpEndDate.Value = DateTime.Now;
            LoadData();
            SetDateMenuButtonUI(sender);
        }

        private void btnLast7Days_Click(object sender, EventArgs e)
        {
            dtpStartDate.Value = DateTime.Today.AddDays(-7);
            dtpEndDate.Value = DateTime.Now;
            LoadData();
            SetDateMenuButtonUI(sender);
        }

        private void btnLast30Days_Click(object sender, EventArgs e)
        {
            dtpStartDate.Value = DateTime.Today.AddDays(-30);
            dtpEndDate.Value = DateTime.Now;
            LoadData();
            SetDateMenuButtonUI(sender);
        }

        private void btnThisMonth_Click(object sender, EventArgs e)
        {
            dtpStartDate.Value = new DateTime(DateTime.Today.Year, DateTime.Today.Month, 1);
            dtpEndDate.Value = DateTime.Now;
            LoadData();
            SetDateMenuButtonUI(sender);
        }

        private void btnCustomDate_Click(object sender, EventArgs e)
        {
            SetDateMenuButtonUI(sender);
        }

        private void btnOkCustomDate_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void lblStartDate_Click(object sender, EventArgs e)
        {
            if (currentButton == btnCustomDate)
            {
                dtpStartDate.Select();
                SendKeys.Send("%{DOWN}");
            }
        }

        private void lblEndDate_Click(object sender, EventArgs e)
        {
            if (currentButton == btnCustomDate)
            {
                dtpEndDate.Select();
                SendKeys.Send("%{DOWN}");
            }
        }

        private void dtpStartDate_ValueChanged(object sender, EventArgs e)
        {
            lblStartDate.Text = dtpStartDate.Text;
        }

        private void dtpEndDate_ValueChanged(object sender, EventArgs e)
        {
            lblEndDate.Text = dtpEndDate.Text;
        }

        private void DashboardForm_Load(object sender, EventArgs e)
        {
            lblStartDate.Text = dtpStartDate.Text;
            lblEndDate.Text = dtpEndDate.Text;
        }
    }
}
