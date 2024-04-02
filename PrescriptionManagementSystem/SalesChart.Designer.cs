namespace PrescriptionManagementSystem
{
    partial class SalesChart
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title2 = new System.Windows.Forms.DataVisualization.Charting.Title();
            panelHeader = new Panel();
            lbltitle = new Label();
            btnClose = new Button();
            panelContent = new Panel();
            button1 = new Button();
            dgvLowStockItems = new DataGridView();
            panel5 = new Panel();
            label13 = new Label();
            lblNumberOfProducts = new Label();
            label9 = new Label();
            lblNumberOfSuppliers = new Label();
            label8 = new Label();
            label7 = new Label();
            lblNumberOfCustomers = new Label();
            label6 = new Label();
            panel4 = new Panel();
            chartTop5Products = new System.Windows.Forms.DataVisualization.Charting.Chart();
            chartGrossRevenue = new System.Windows.Forms.DataVisualization.Charting.Chart();
            lblTotalProfit = new Label();
            label5 = new Label();
            panel3 = new Panel();
            lblTotalRevenue = new Label();
            label4 = new Label();
            panel2 = new Panel();
            lblNumerOfSale = new Label();
            label2 = new Label();
            panel1 = new Panel();
            btnOkCustomDate = new Button();
            btnCustomDate = new Button();
            btnToday = new Button();
            btnLast7Days = new Button();
            btnLast30Days = new Button();
            btnThisMonth = new Button();
            dtpEndDate = new DateTimePicker();
            dtpStartDate = new DateTimePicker();
            label1 = new Label();
            panelHeader.SuspendLayout();
            panelContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvLowStockItems).BeginInit();
            panel5.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chartTop5Products).BeginInit();
            ((System.ComponentModel.ISupportInitialize)chartGrossRevenue).BeginInit();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panelHeader
            // 
            panelHeader.BackColor = Color.WhiteSmoke;
            panelHeader.Controls.Add(lbltitle);
            panelHeader.Controls.Add(btnClose);
            panelHeader.Dock = DockStyle.Top;
            panelHeader.Location = new Point(0, 0);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(1358, 55);
            panelHeader.TabIndex = 0;
            // 
            // lbltitle
            // 
            lbltitle.AutoSize = true;
            lbltitle.Font = new Font("Segoe UI", 14F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lbltitle.ForeColor = Color.SteelBlue;
            lbltitle.Location = new Point(245, 7);
            lbltitle.Name = "lbltitle";
            lbltitle.Size = new Size(639, 38);
            lbltitle.TabIndex = 148;
            lbltitle.Text = "Prescription Management System - Sales Chart";
            lbltitle.TextAlign = ContentAlignment.TopCenter;
            // 
            // btnClose
            // 
            btnClose.Dock = DockStyle.Right;
            btnClose.FlatAppearance.BorderSize = 0;
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnClose.Location = new Point(1311, 0);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(47, 55);
            btnClose.TabIndex = 147;
            btnClose.Text = "X";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // panelContent
            // 
            panelContent.Controls.Add(button1);
            panelContent.Controls.Add(panel5);
            panelContent.Controls.Add(panel4);
            panelContent.Controls.Add(chartTop5Products);
            panelContent.Controls.Add(chartGrossRevenue);
            panelContent.Controls.Add(panel3);
            panelContent.Controls.Add(panel2);
            panelContent.Controls.Add(panel1);
            panelContent.Controls.Add(btnOkCustomDate);
            panelContent.Controls.Add(btnCustomDate);
            panelContent.Controls.Add(btnToday);
            panelContent.Controls.Add(btnLast7Days);
            panelContent.Controls.Add(btnLast30Days);
            panelContent.Controls.Add(btnThisMonth);
            panelContent.Controls.Add(dtpEndDate);
            panelContent.Controls.Add(dtpStartDate);
            panelContent.Controls.Add(label1);
            panelContent.Dock = DockStyle.Fill;
            panelContent.Location = new Point(0, 55);
            panelContent.Name = "panelContent";
            panelContent.Size = new Size(1358, 763);
            panelContent.TabIndex = 1;
            // 
            // button1
            // 
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(1245, 9);
            button1.Name = "button1";
            button1.Size = new Size(40, 40);
            button1.TabIndex = 163;
            button1.Text = "X";
            button1.UseVisualStyleBackColor = true;
            // 
            // dgvLowStockItems
            // 
            dgvLowStockItems.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvLowStockItems.Location = new Point(14, 33);
            dgvLowStockItems.Name = "dgvLowStockItems";
            dgvLowStockItems.RowHeadersWidth = 62;
            dgvLowStockItems.RowTemplate.Height = 33;
            dgvLowStockItems.Size = new Size(570, 190);
            dgvLowStockItems.TabIndex = 3;
            // 
            // panel5
            // 
            panel5.BackColor = Color.FromArgb(42, 45, 86);
            panel5.Controls.Add(dgvLowStockItems);
            panel5.Controls.Add(label13);
            panel5.Location = new Point(250, 495);
            panel5.Name = "panel5";
            panel5.Size = new Size(587, 235);
            panel5.TabIndex = 160;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label13.ForeColor = Color.Black;
            label13.Location = new Point(0, 0);
            label13.Name = "label13";
            label13.Size = new Size(213, 30);
            label13.TabIndex = 2;
            label13.Text = "Products Understock";
            // 
            // lblNumberOfProducts
            // 
            lblNumberOfProducts.AutoSize = true;
            lblNumberOfProducts.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            lblNumberOfProducts.ForeColor = Color.Black;
            lblNumberOfProducts.Location = new Point(19, 193);
            lblNumberOfProducts.Name = "lblNumberOfProducts";
            lblNumberOfProducts.Size = new Size(85, 30);
            lblNumberOfProducts.TabIndex = 6;
            lblNumberOfProducts.Text = "100000";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
            label9.ForeColor = Color.Black;
            label9.Location = new Point(19, 168);
            label9.Name = "label9";
            label9.Size = new Size(151, 21);
            label9.TabIndex = 5;
            label9.Text = "Number of Products";
            // 
            // lblNumberOfSuppliers
            // 
            lblNumberOfSuppliers.AutoSize = true;
            lblNumberOfSuppliers.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            lblNumberOfSuppliers.ForeColor = Color.Black;
            lblNumberOfSuppliers.Location = new Point(19, 127);
            lblNumberOfSuppliers.Name = "lblNumberOfSuppliers";
            lblNumberOfSuppliers.Size = new Size(85, 30);
            lblNumberOfSuppliers.TabIndex = 4;
            lblNumberOfSuppliers.Text = "100000";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
            label8.ForeColor = Color.Black;
            label8.Location = new Point(19, 102);
            label8.Name = "label8";
            label8.Size = new Size(155, 21);
            label8.TabIndex = 3;
            label8.Text = "Number of Suppliers";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label7.ForeColor = Color.Black;
            label7.Location = new Point(0, 0);
            label7.Name = "label7";
            label7.Size = new Size(143, 30);
            label7.TabIndex = 2;
            label7.Text = "Total Counter";
            // 
            // lblNumberOfCustomers
            // 
            lblNumberOfCustomers.AutoSize = true;
            lblNumberOfCustomers.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            lblNumberOfCustomers.ForeColor = Color.Black;
            lblNumberOfCustomers.Location = new Point(19, 63);
            lblNumberOfCustomers.Name = "lblNumberOfCustomers";
            lblNumberOfCustomers.Size = new Size(85, 30);
            lblNumberOfCustomers.TabIndex = 1;
            lblNumberOfCustomers.Text = "100000";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = Color.Black;
            label6.Location = new Point(19, 38);
            label6.Name = "label6";
            label6.Size = new Size(165, 21);
            label6.TabIndex = 0;
            label6.Text = "Number of Customers";
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(42, 45, 86);
            panel4.Controls.Add(lblNumberOfProducts);
            panel4.Controls.Add(label9);
            panel4.Controls.Add(lblNumberOfSuppliers);
            panel4.Controls.Add(label8);
            panel4.Controls.Add(label7);
            panel4.Controls.Add(lblNumberOfCustomers);
            panel4.Controls.Add(label6);
            panel4.Location = new Point(12, 495);
            panel4.Name = "panel4";
            panel4.Size = new Size(221, 235);
            panel4.TabIndex = 158;
            // 
            // chartTop5Products
            // 
            chartTop5Products.BackColor = Color.FromArgb(42, 45, 86);
            chartArea1.Name = "ChartArea1";
            chartTop5Products.ChartAreas.Add(chartArea1);
            legend1.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom;
            legend1.Name = "Legend1";
            chartTop5Products.Legends.Add(legend1);
            chartTop5Products.Location = new Point(843, 144);
            chartTop5Products.Name = "chartTop5Products";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
            series1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            series1.IsValueShownAsLabel = true;
            series1.LabelForeColor = Color.White;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            chartTop5Products.Series.Add(series1);
            chartTop5Products.Size = new Size(427, 580);
            chartTop5Products.TabIndex = 162;
            chartTop5Products.Text = "chart2";
            title1.Alignment = ContentAlignment.TopLeft;
            title1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            title1.Name = "Title1";
            title1.Text = "Top 5 Products";
            chartTop5Products.Titles.Add(title1);
            // 
            // chartGrossRevenue
            // 
            chartGrossRevenue.BackColor = Color.FromArgb(42, 45, 86);
            chartArea2.Name = "ChartArea1";
            chartGrossRevenue.ChartAreas.Add(chartArea2);
            legend2.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Top;
            legend2.Name = "Legend1";
            chartGrossRevenue.Legends.Add(legend2);
            chartGrossRevenue.Location = new Point(12, 144);
            chartGrossRevenue.Name = "chartGrossRevenue";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            chartGrossRevenue.Series.Add(series2);
            chartGrossRevenue.Size = new Size(825, 339);
            chartGrossRevenue.TabIndex = 161;
            chartGrossRevenue.Text = "chart1";
            title2.Alignment = ContentAlignment.TopLeft;
            title2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            title2.Name = "Title1";
            title2.Text = "Gross Revenue";
            chartGrossRevenue.Titles.Add(title2);
            // 
            // lblTotalProfit
            // 
            lblTotalProfit.AutoSize = true;
            lblTotalProfit.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblTotalProfit.ForeColor = Color.Black;
            lblTotalProfit.Location = new Point(14, 25);
            lblTotalProfit.Name = "lblTotalProfit";
            lblTotalProfit.Size = new Size(92, 32);
            lblTotalProfit.TabIndex = 1;
            lblTotalProfit.Text = "100000";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = Color.Black;
            label5.Location = new Point(14, 0);
            label5.Name = "label5";
            label5.Size = new Size(97, 25);
            label5.TabIndex = 0;
            label5.Text = "Total Profit";
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(42, 45, 86);
            panel3.Controls.Add(lblTotalProfit);
            panel3.Controls.Add(label5);
            panel3.Location = new Point(706, 72);
            panel3.Name = "panel3";
            panel3.Size = new Size(567, 66);
            panel3.TabIndex = 159;
            // 
            // lblTotalRevenue
            // 
            lblTotalRevenue.AutoSize = true;
            lblTotalRevenue.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblTotalRevenue.ForeColor = Color.Black;
            lblTotalRevenue.Location = new Point(14, 25);
            lblTotalRevenue.Name = "lblTotalRevenue";
            lblTotalRevenue.Size = new Size(92, 32);
            lblTotalRevenue.TabIndex = 1;
            lblTotalRevenue.Text = "100000";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.Black;
            label4.Location = new Point(14, 0);
            label4.Name = "label4";
            label4.Size = new Size(120, 25);
            label4.TabIndex = 0;
            label4.Text = "Total Revenue";
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(42, 45, 86);
            panel2.Controls.Add(lblTotalRevenue);
            panel2.Controls.Add(label4);
            panel2.Location = new Point(250, 72);
            panel2.Name = "panel2";
            panel2.Size = new Size(450, 66);
            panel2.TabIndex = 157;
            // 
            // lblNumerOfSale
            // 
            lblNumerOfSale.AutoSize = true;
            lblNumerOfSale.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblNumerOfSale.ForeColor = Color.Black;
            lblNumerOfSale.Location = new Point(14, 25);
            lblNumerOfSale.Name = "lblNumerOfSale";
            lblNumerOfSale.Size = new Size(92, 32);
            lblNumerOfSale.TabIndex = 1;
            lblNumerOfSale.Text = "100000";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.Black;
            label2.Location = new Point(14, 0);
            label2.Name = "label2";
            label2.Size = new Size(144, 25);
            label2.TabIndex = 0;
            label2.Text = "Number of Sales";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(42, 45, 86);
            panel1.Controls.Add(lblNumerOfSale);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(12, 72);
            panel1.Name = "panel1";
            panel1.Size = new Size(221, 66);
            panel1.TabIndex = 156;
            // 
            // btnOkCustomDate
            // 
            btnOkCustomDate.BackColor = Color.FromArgb(241, 88, 127);
            btnOkCustomDate.FlatAppearance.BorderSize = 0;
            btnOkCustomDate.FlatStyle = FlatStyle.Flat;
            btnOkCustomDate.Font = new Font("Segoe UI", 6F, FontStyle.Regular, GraphicsUnit.Point);
            btnOkCustomDate.Location = new Point(577, 19);
            btnOkCustomDate.Name = "btnOkCustomDate";
            btnOkCustomDate.Size = new Size(30, 30);
            btnOkCustomDate.TabIndex = 155;
            btnOkCustomDate.Text = "Ok";
            btnOkCustomDate.UseVisualStyleBackColor = false;
            btnOkCustomDate.Visible = false;
            // 
            // btnCustomDate
            // 
            btnCustomDate.FlatAppearance.BorderColor = Color.FromArgb(107, 83, 255);
            btnCustomDate.FlatStyle = FlatStyle.Flat;
            btnCustomDate.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnCustomDate.ForeColor = Color.FromArgb(124, 141, 181);
            btnCustomDate.Location = new Point(635, 19);
            btnCustomDate.Name = "btnCustomDate";
            btnCustomDate.Size = new Size(112, 34);
            btnCustomDate.TabIndex = 154;
            btnCustomDate.Text = "Custom";
            btnCustomDate.UseVisualStyleBackColor = true;
            // 
            // btnToday
            // 
            btnToday.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnToday.FlatAppearance.BorderColor = Color.FromArgb(107, 83, 255);
            btnToday.FlatStyle = FlatStyle.Flat;
            btnToday.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnToday.ForeColor = Color.FromArgb(124, 141, 181);
            btnToday.Location = new Point(747, 19);
            btnToday.Name = "btnToday";
            btnToday.Size = new Size(112, 34);
            btnToday.TabIndex = 153;
            btnToday.Text = "Today";
            btnToday.UseVisualStyleBackColor = true;
            // 
            // btnLast7Days
            // 
            btnLast7Days.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnLast7Days.FlatAppearance.BorderColor = Color.FromArgb(107, 83, 255);
            btnLast7Days.FlatStyle = FlatStyle.Flat;
            btnLast7Days.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnLast7Days.ForeColor = Color.FromArgb(124, 141, 181);
            btnLast7Days.Location = new Point(859, 19);
            btnLast7Days.Name = "btnLast7Days";
            btnLast7Days.Size = new Size(112, 34);
            btnLast7Days.TabIndex = 152;
            btnLast7Days.Text = "Last 7 Days";
            btnLast7Days.UseVisualStyleBackColor = true;
            // 
            // btnLast30Days
            // 
            btnLast30Days.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnLast30Days.FlatAppearance.BorderColor = Color.FromArgb(107, 83, 255);
            btnLast30Days.FlatStyle = FlatStyle.Flat;
            btnLast30Days.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnLast30Days.ForeColor = Color.FromArgb(124, 141, 181);
            btnLast30Days.Location = new Point(971, 19);
            btnLast30Days.Name = "btnLast30Days";
            btnLast30Days.Size = new Size(156, 34);
            btnLast30Days.TabIndex = 151;
            btnLast30Days.Text = "Last 30 Days";
            btnLast30Days.UseVisualStyleBackColor = true;
            // 
            // btnThisMonth
            // 
            btnThisMonth.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnThisMonth.FlatAppearance.BorderColor = Color.FromArgb(107, 83, 255);
            btnThisMonth.FlatStyle = FlatStyle.Flat;
            btnThisMonth.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnThisMonth.ForeColor = Color.FromArgb(124, 141, 181);
            btnThisMonth.Location = new Point(1127, 19);
            btnThisMonth.Name = "btnThisMonth";
            btnThisMonth.Size = new Size(112, 34);
            btnThisMonth.TabIndex = 150;
            btnThisMonth.Text = "This Month";
            btnThisMonth.UseVisualStyleBackColor = true;
            // 
            // dtpEndDate
            // 
            dtpEndDate.CustomFormat = "dd MMM, yyyy";
            dtpEndDate.Enabled = false;
            dtpEndDate.Format = DateTimePickerFormat.Custom;
            dtpEndDate.Location = new Point(401, 19);
            dtpEndDate.Name = "dtpEndDate";
            dtpEndDate.Size = new Size(163, 31);
            dtpEndDate.TabIndex = 149;
            // 
            // dtpStartDate
            // 
            dtpStartDate.CustomFormat = "dd MMM, yyyy";
            dtpStartDate.Enabled = false;
            dtpStartDate.Format = DateTimePickerFormat.Custom;
            dtpStartDate.Location = new Point(230, 18);
            dtpStartDate.Name = "dtpStartDate";
            dtpStartDate.Size = new Size(165, 31);
            dtpStartDate.TabIndex = 148;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(0, 7);
            label1.Name = "label1";
            label1.Size = new Size(184, 45);
            label1.TabIndex = 147;
            label1.Text = "Dashboard";
            // 
            // SalesChart
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1358, 818);
            Controls.Add(panelContent);
            Controls.Add(panelHeader);
            FormBorderStyle = FormBorderStyle.None;
            Name = "SalesChart";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SalesChart";
            Load += SalesChart_Load;
            panelHeader.ResumeLayout(false);
            panelHeader.PerformLayout();
            panelContent.ResumeLayout(false);
            panelContent.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvLowStockItems).EndInit();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)chartTop5Products).EndInit();
            ((System.ComponentModel.ISupportInitialize)chartGrossRevenue).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelHeader;
        private Label lbltitle;
        private Button btnClose;
        private Panel panelContent;
        private Button button1;
        private Panel panel5;
        private DataGridView dgvLowStockItems;
        private Label label13;
        private Panel panel4;
        private Label lblNumberOfProducts;
        private Label label9;
        private Label lblNumberOfSuppliers;
        private Label label8;
        private Label label7;
        private Label lblNumberOfCustomers;
        private Label label6;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartTop5Products;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartGrossRevenue;
        private Panel panel3;
        private Label lblTotalProfit;
        private Label label5;
        private Panel panel2;
        private Label lblTotalRevenue;
        private Label label4;
        private Panel panel1;
        private Label lblNumerOfSale;
        private Label label2;
        private Button btnOkCustomDate;
        private Button btnCustomDate;
        private Button btnToday;
        private Button btnLast7Days;
        private Button btnLast30Days;
        private Button btnThisMonth;
        private DateTimePicker dtpEndDate;
        private DateTimePicker dtpStartDate;
        private Label label1;
    }
}