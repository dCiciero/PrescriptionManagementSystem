namespace PrescriptionManagementSystem
{
    partial class DashboardForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DashboardForm));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title3 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title4 = new System.Windows.Forms.DataVisualization.Charting.Title();
            label1 = new Label();
            dtpStartDate = new DateTimePicker();
            dtpEndDate = new DateTimePicker();
            btnThisMonth = new Button();
            btnLast30Days = new Button();
            btnLast7Days = new Button();
            btnToday = new Button();
            btnCustomDate = new Button();
            btnOkCustomDate = new Button();
            panel1 = new Panel();
            lblNumerOfSale = new Label();
            label2 = new Label();
            panel2 = new Panel();
            lblTotalRevenue = new Label();
            label4 = new Label();
            panel3 = new Panel();
            lblTotalProfit = new Label();
            label5 = new Label();
            chartGrossRevenue = new System.Windows.Forms.DataVisualization.Charting.Chart();
            chartTop5Products = new System.Windows.Forms.DataVisualization.Charting.Chart();
            panel4 = new Panel();
            lblNumberOfProducts = new Label();
            label9 = new Label();
            lblNumberOfSuppliers = new Label();
            label8 = new Label();
            label7 = new Label();
            lblNumberOfCustomers = new Label();
            label6 = new Label();
            panel5 = new Panel();
            dgvLowStockItems = new DataGridView();
            label13 = new Label();
            btnClose = new Button();
            lblStartDate = new Label();
            lblEndDate = new Label();
            label3 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chartGrossRevenue).BeginInit();
            ((System.ComponentModel.ISupportInitialize)chartTop5Products).BeginInit();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvLowStockItems).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.WhiteSmoke;
            label1.Location = new Point(0, 15);
            label1.Name = "label1";
            label1.Size = new Size(184, 45);
            label1.TabIndex = 0;
            label1.Text = "Dashboard";
            // 
            // dtpStartDate
            // 
            dtpStartDate.CustomFormat = "dd MMM, yyyy";
            dtpStartDate.Enabled = false;
            dtpStartDate.Format = DateTimePickerFormat.Custom;
            dtpStartDate.Location = new Point(307, 26);
            dtpStartDate.Name = "dtpStartDate";
            dtpStartDate.Size = new Size(128, 31);
            dtpStartDate.TabIndex = 1;
            dtpStartDate.ValueChanged += dtpStartDate_ValueChanged;
            // 
            // dtpEndDate
            // 
            dtpEndDate.CustomFormat = "dd MMM, yyyy";
            dtpEndDate.Enabled = false;
            dtpEndDate.Format = DateTimePickerFormat.Custom;
            dtpEndDate.Location = new Point(464, 27);
            dtpEndDate.Name = "dtpEndDate";
            dtpEndDate.Size = new Size(128, 31);
            dtpEndDate.TabIndex = 2;
            dtpEndDate.ValueChanged += dtpEndDate_ValueChanged;
            // 
            // btnThisMonth
            // 
            btnThisMonth.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnThisMonth.FlatAppearance.BorderColor = Color.FromArgb(107, 83, 255);
            btnThisMonth.FlatStyle = FlatStyle.Flat;
            btnThisMonth.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnThisMonth.ForeColor = Color.FromArgb(124, 141, 181);
            btnThisMonth.Location = new Point(1127, 27);
            btnThisMonth.Name = "btnThisMonth";
            btnThisMonth.Size = new Size(112, 34);
            btnThisMonth.TabIndex = 3;
            btnThisMonth.Text = "This Month";
            btnThisMonth.UseVisualStyleBackColor = true;
            btnThisMonth.Click += btnThisMonth_Click;
            // 
            // btnLast30Days
            // 
            btnLast30Days.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnLast30Days.FlatAppearance.BorderColor = Color.FromArgb(107, 83, 255);
            btnLast30Days.FlatStyle = FlatStyle.Flat;
            btnLast30Days.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnLast30Days.ForeColor = Color.FromArgb(124, 141, 181);
            btnLast30Days.Location = new Point(971, 27);
            btnLast30Days.Name = "btnLast30Days";
            btnLast30Days.Size = new Size(156, 34);
            btnLast30Days.TabIndex = 4;
            btnLast30Days.Text = "Last 30 Days";
            btnLast30Days.UseVisualStyleBackColor = true;
            btnLast30Days.Click += btnLast30Days_Click;
            // 
            // btnLast7Days
            // 
            btnLast7Days.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnLast7Days.FlatAppearance.BorderColor = Color.FromArgb(107, 83, 255);
            btnLast7Days.FlatStyle = FlatStyle.Flat;
            btnLast7Days.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnLast7Days.ForeColor = Color.FromArgb(124, 141, 181);
            btnLast7Days.Location = new Point(859, 26);
            btnLast7Days.Name = "btnLast7Days";
            btnLast7Days.Size = new Size(112, 34);
            btnLast7Days.TabIndex = 5;
            btnLast7Days.Text = "Last 7 Days";
            btnLast7Days.UseVisualStyleBackColor = true;
            btnLast7Days.Click += btnLast7Days_Click;
            // 
            // btnToday
            // 
            btnToday.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnToday.FlatAppearance.BorderColor = Color.FromArgb(107, 83, 255);
            btnToday.FlatStyle = FlatStyle.Flat;
            btnToday.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnToday.ForeColor = Color.FromArgb(124, 141, 181);
            btnToday.Location = new Point(747, 27);
            btnToday.Name = "btnToday";
            btnToday.Size = new Size(112, 34);
            btnToday.TabIndex = 6;
            btnToday.Text = "Today";
            btnToday.UseVisualStyleBackColor = true;
            btnToday.Click += btnToday_Click;
            // 
            // btnCustomDate
            // 
            btnCustomDate.FlatAppearance.BorderColor = Color.FromArgb(107, 83, 255);
            btnCustomDate.FlatStyle = FlatStyle.Flat;
            btnCustomDate.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnCustomDate.ForeColor = Color.FromArgb(124, 141, 181);
            btnCustomDate.Location = new Point(635, 26);
            btnCustomDate.Name = "btnCustomDate";
            btnCustomDate.Size = new Size(112, 34);
            btnCustomDate.TabIndex = 7;
            btnCustomDate.Text = "Custom";
            btnCustomDate.UseVisualStyleBackColor = true;
            btnCustomDate.Click += btnCustomDate_Click;
            // 
            // btnOkCustomDate
            // 
            btnOkCustomDate.BackColor = Color.FromArgb(241, 88, 127);
            btnOkCustomDate.FlatAppearance.BorderSize = 0;
            btnOkCustomDate.FlatStyle = FlatStyle.Flat;
            btnOkCustomDate.Font = new Font("Segoe UI", 6F, FontStyle.Regular, GraphicsUnit.Point);
            btnOkCustomDate.Image = (Image)resources.GetObject("btnOkCustomDate.Image");
            btnOkCustomDate.Location = new Point(600, 27);
            btnOkCustomDate.Name = "btnOkCustomDate";
            btnOkCustomDate.Size = new Size(34, 30);
            btnOkCustomDate.TabIndex = 8;
            btnOkCustomDate.UseVisualStyleBackColor = false;
            btnOkCustomDate.Visible = false;
            btnOkCustomDate.Click += btnOkCustomDate_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(42, 45, 86);
            panel1.Controls.Add(lblNumerOfSale);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(12, 80);
            panel1.Name = "panel1";
            panel1.Size = new Size(221, 66);
            panel1.TabIndex = 9;
            // 
            // lblNumerOfSale
            // 
            lblNumerOfSale.AutoSize = true;
            lblNumerOfSale.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblNumerOfSale.ForeColor = Color.WhiteSmoke;
            lblNumerOfSale.Location = new Point(14, 25);
            lblNumerOfSale.Name = "lblNumerOfSale";
            lblNumerOfSale.Size = new Size(92, 32);
            lblNumerOfSale.TabIndex = 1;
            lblNumerOfSale.Text = "100000";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.WhiteSmoke;
            label2.Location = new Point(14, 0);
            label2.Name = "label2";
            label2.Size = new Size(144, 25);
            label2.TabIndex = 0;
            label2.Text = "Number of Sales";
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(42, 45, 86);
            panel2.Controls.Add(lblTotalRevenue);
            panel2.Controls.Add(label4);
            panel2.Location = new Point(250, 80);
            panel2.Name = "panel2";
            panel2.Size = new Size(450, 66);
            panel2.TabIndex = 10;
            // 
            // lblTotalRevenue
            // 
            lblTotalRevenue.AutoSize = true;
            lblTotalRevenue.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblTotalRevenue.ForeColor = Color.WhiteSmoke;
            lblTotalRevenue.Location = new Point(14, 25);
            lblTotalRevenue.Name = "lblTotalRevenue";
            lblTotalRevenue.Size = new Size(92, 32);
            lblTotalRevenue.TabIndex = 1;
            lblTotalRevenue.Text = "100000";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.WhiteSmoke;
            label4.Location = new Point(14, 0);
            label4.Name = "label4";
            label4.Size = new Size(120, 25);
            label4.TabIndex = 0;
            label4.Text = "Total Revenue";
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(42, 45, 86);
            panel3.Controls.Add(lblTotalProfit);
            panel3.Controls.Add(label5);
            panel3.Location = new Point(706, 80);
            panel3.Name = "panel3";
            panel3.Size = new Size(567, 66);
            panel3.TabIndex = 11;
            // 
            // lblTotalProfit
            // 
            lblTotalProfit.AutoSize = true;
            lblTotalProfit.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblTotalProfit.ForeColor = Color.WhiteSmoke;
            lblTotalProfit.Location = new Point(14, 25);
            lblTotalProfit.Name = "lblTotalProfit";
            lblTotalProfit.Size = new Size(92, 32);
            lblTotalProfit.TabIndex = 1;
            lblTotalProfit.Text = "100000";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = Color.WhiteSmoke;
            label5.Location = new Point(14, 0);
            label5.Name = "label5";
            label5.Size = new Size(97, 25);
            label5.TabIndex = 0;
            label5.Text = "Total Profit";
            // 
            // chartGrossRevenue
            // 
            chartGrossRevenue.BackColor = Color.FromArgb(42, 45, 86);
            chartArea3.AxisX.LabelStyle.ForeColor = Color.Gainsboro;
            chartArea3.AxisX.LineColor = Color.White;
            chartArea3.AxisX.LineWidth = 0;
            chartArea3.AxisX.MajorGrid.LineColor = Color.White;
            chartArea3.AxisX.MajorGrid.LineWidth = 0;
            chartArea3.AxisX.MajorTickMark.LineColor = Color.FromArgb(73, 75, 111);
            chartArea3.AxisX.MajorTickMark.Size = 3F;
            chartArea3.AxisY.LabelStyle.ForeColor = Color.Gainsboro;
            chartArea3.AxisY.LabelStyle.Format = "£(0)";
            chartArea3.AxisY.LineColor = Color.White;
            chartArea3.AxisY.LineWidth = 0;
            chartArea3.AxisY.MajorGrid.LineColor = Color.FromArgb(73, 75, 111);
            chartArea3.AxisY.MajorTickMark.LineColor = Color.FromArgb(73, 75, 111);
            chartArea3.BackColor = Color.FromArgb(42, 45, 86);
            chartArea3.Name = "ChartArea1";
            chartGrossRevenue.ChartAreas.Add(chartArea3);
            legend3.BackColor = Color.FromArgb(42, 45, 86);
            legend3.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Top;
            legend3.ForeColor = Color.FromArgb(192, 162, 255);
            legend3.Name = "Legend1";
            chartGrossRevenue.Legends.Add(legend3);
            chartGrossRevenue.Location = new Point(12, 152);
            chartGrossRevenue.Name = "chartGrossRevenue";
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            chartGrossRevenue.Series.Add(series3);
            chartGrossRevenue.Size = new Size(825, 339);
            chartGrossRevenue.TabIndex = 12;
            chartGrossRevenue.Text = "chart1";
            title3.Alignment = ContentAlignment.TopLeft;
            title3.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            title3.ForeColor = Color.WhiteSmoke;
            title3.Name = "Title1";
            title3.Text = "Gross Revenue";
            chartGrossRevenue.Titles.Add(title3);
            // 
            // chartTop5Products
            // 
            chartTop5Products.BackColor = Color.FromArgb(42, 45, 86);
            chartArea4.Name = "ChartArea1";
            chartTop5Products.ChartAreas.Add(chartArea4);
            legend4.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom;
            legend4.Name = "Legend1";
            chartTop5Products.Legends.Add(legend4);
            chartTop5Products.Location = new Point(843, 152);
            chartTop5Products.Name = "chartTop5Products";
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
            series4.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            series4.IsValueShownAsLabel = true;
            series4.LabelForeColor = Color.White;
            series4.Legend = "Legend1";
            series4.Name = "Series1";
            chartTop5Products.Series.Add(series4);
            chartTop5Products.Size = new Size(427, 580);
            chartTop5Products.TabIndex = 13;
            chartTop5Products.Text = "chart2";
            title4.Alignment = ContentAlignment.TopLeft;
            title4.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            title4.ForeColor = Color.WhiteSmoke;
            title4.Name = "Title1";
            title4.Text = "Top 5 Products";
            chartTop5Products.Titles.Add(title4);
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
            panel4.Location = new Point(12, 503);
            panel4.Name = "panel4";
            panel4.Size = new Size(221, 235);
            panel4.TabIndex = 10;
            // 
            // lblNumberOfProducts
            // 
            lblNumberOfProducts.AutoSize = true;
            lblNumberOfProducts.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            lblNumberOfProducts.ForeColor = Color.WhiteSmoke;
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
            label9.ForeColor = Color.WhiteSmoke;
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
            lblNumberOfSuppliers.ForeColor = Color.WhiteSmoke;
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
            label8.ForeColor = Color.WhiteSmoke;
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
            label7.ForeColor = Color.WhiteSmoke;
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
            lblNumberOfCustomers.ForeColor = Color.WhiteSmoke;
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
            label6.ForeColor = Color.WhiteSmoke;
            label6.Location = new Point(19, 38);
            label6.Name = "label6";
            label6.Size = new Size(165, 21);
            label6.TabIndex = 0;
            label6.Text = "Number of Customers";
            // 
            // panel5
            // 
            panel5.BackColor = Color.FromArgb(42, 45, 86);
            panel5.Controls.Add(dgvLowStockItems);
            panel5.Controls.Add(label13);
            panel5.Location = new Point(250, 503);
            panel5.Name = "panel5";
            panel5.Size = new Size(587, 235);
            panel5.TabIndex = 11;
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
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label13.ForeColor = Color.WhiteSmoke;
            label13.Location = new Point(0, 0);
            label13.Name = "label13";
            label13.Size = new Size(213, 30);
            label13.TabIndex = 2;
            label13.Text = "Products Understock";
            // 
            // btnClose
            // 
            btnClose.FlatAppearance.BorderSize = 0;
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnClose.ForeColor = Color.WhiteSmoke;
            btnClose.Location = new Point(1245, 17);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(40, 40);
            btnClose.TabIndex = 146;
            btnClose.Text = "X";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // lblStartDate
            // 
            lblStartDate.ForeColor = Color.WhiteSmoke;
            lblStartDate.Location = new Point(307, 22);
            lblStartDate.MinimumSize = new Size(130, 0);
            lblStartDate.Name = "lblStartDate";
            lblStartDate.Size = new Size(130, 33);
            lblStartDate.TabIndex = 2;
            lblStartDate.Text = "April 01, 2024";
            lblStartDate.TextAlign = ContentAlignment.MiddleRight;
            lblStartDate.Click += lblStartDate_Click;
            // 
            // lblEndDate
            // 
            lblEndDate.ForeColor = Color.WhiteSmoke;
            lblEndDate.Location = new Point(464, 23);
            lblEndDate.MinimumSize = new Size(130, 0);
            lblEndDate.Name = "lblEndDate";
            lblEndDate.Size = new Size(130, 33);
            lblEndDate.TabIndex = 147;
            lblEndDate.Text = "April 01, 2024";
            lblEndDate.TextAlign = ContentAlignment.MiddleLeft;
            lblEndDate.Click += lblEndDate_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.WhiteSmoke;
            label3.Location = new Point(443, 33);
            label3.Name = "label3";
            label3.Size = new Size(16, 25);
            label3.TabIndex = 149;
            label3.Text = ".";
            label3.TextAlign = ContentAlignment.MiddleRight;
            // 
            // DashboardForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(24, 28, 63);
            ClientSize = new Size(1285, 774);
            Controls.Add(label3);
            Controls.Add(lblEndDate);
            Controls.Add(lblStartDate);
            Controls.Add(btnClose);
            Controls.Add(panel5);
            Controls.Add(panel4);
            Controls.Add(chartTop5Products);
            Controls.Add(chartGrossRevenue);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(btnOkCustomDate);
            Controls.Add(btnCustomDate);
            Controls.Add(btnToday);
            Controls.Add(btnLast7Days);
            Controls.Add(btnLast30Days);
            Controls.Add(btnThisMonth);
            Controls.Add(dtpEndDate);
            Controls.Add(dtpStartDate);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "DashboardForm";
            Text = "DashboardForm";
            Load += DashboardForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)chartGrossRevenue).EndInit();
            ((System.ComponentModel.ISupportInitialize)chartTop5Products).EndInit();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvLowStockItems).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DateTimePicker dtpStartDate;
        private DateTimePicker dtpEndDate;
        private Button btnThisMonth;
        private Button btnLast30Days;
        private Button btnLast7Days;
        private Button btnToday;
        private Button btnCustomDate;
        private Button btnOkCustomDate;
        private Panel panel1;
        private Label lblNumerOfSale;
        private Label label2;
        private Panel panel2;
        private Label lblTotalRevenue;
        private Label label4;
        private Panel panel3;
        private Label lblTotalProfit;
        private Label label5;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartGrossRevenue;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartTop5Products;
        private Panel panel4;
        private Label lblNumberOfCustomers;
        private Label label6;
        private Label label7;
        private Label lblNumberOfProducts;
        private Label label9;
        private Label lblNumberOfSuppliers;
        private Label label8;
        private Panel panel5;
        private DataGridView dgvLowStockItems;
        private Label label13;
        private Button btnClose;
        private Label lblStartDate;
        private Label lblEndDate;
        private Label label3;
    }
}