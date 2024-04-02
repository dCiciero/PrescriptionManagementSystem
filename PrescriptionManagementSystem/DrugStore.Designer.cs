namespace PrescriptionManagementSystem
{
    partial class DrugStoreForm
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            lblFirstname = new Label();
            txtSearchDrugStore = new TextBox();
            panel2 = new Panel();
            panel1 = new Panel();
            lbltitle = new Label();
            InLongton = new DataGridViewTextBoxColumn();
            InHanley = new DataGridViewTextBoxColumn();
            InFenton = new DataGridViewTextBoxColumn();
            InTunstall = new DataGridViewTextBoxColumn();
            InStoke = new DataGridViewTextBoxColumn();
            IdCheck = new DataGridViewTextBoxColumn();
            Condition = new DataGridViewTextBoxColumn();
            DrugName = new DataGridViewTextBoxColumn();
            dataGridDrugSet = new DataGridView();
            panel3 = new Panel();
            btnClose = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridDrugSet).BeginInit();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // lblFirstname
            // 
            lblFirstname.AutoSize = true;
            lblFirstname.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblFirstname.Location = new Point(16, 83);
            lblFirstname.Name = "lblFirstname";
            lblFirstname.Size = new Size(104, 25);
            lblFirstname.TabIndex = 28;
            lblFirstname.Text = "Enter Name";
            // 
            // txtSearchDrugStore
            // 
            txtSearchDrugStore.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtSearchDrugStore.Location = new Point(13, 106);
            txtSearchDrugStore.Name = "txtSearchDrugStore";
            txtSearchDrugStore.Size = new Size(1284, 39);
            txtSearchDrugStore.TabIndex = 24;
            txtSearchDrugStore.TextChanged += txtSearchDrugStore_TextChanged;
            // 
            // panel2
            // 
            panel2.BackColor = Color.SteelBlue;
            panel2.Location = new Point(0, 361);
            panel2.Name = "panel2";
            panel2.Size = new Size(1362, 5);
            panel2.TabIndex = 23;
            // 
            // panel1
            // 
            panel1.BackColor = Color.SteelBlue;
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(16, 167);
            panel1.Name = "panel1";
            panel1.Size = new Size(1288, 8);
            panel1.TabIndex = 26;
            // 
            // lbltitle
            // 
            lbltitle.AutoSize = true;
            lbltitle.Font = new Font("Segoe UI", 14F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lbltitle.ForeColor = Color.SteelBlue;
            lbltitle.Location = new Point(352, 9);
            lbltitle.Name = "lbltitle";
            lbltitle.Size = new Size(663, 38);
            lbltitle.TabIndex = 27;
            lbltitle.Text = "Prescription Management System - Search Drugs";
            lbltitle.TextAlign = ContentAlignment.TopCenter;
            // 
            // InLongton
            // 
            InLongton.DataPropertyName = "InLongton";
            InLongton.HeaderText = "Longton";
            InLongton.MinimumWidth = 8;
            InLongton.Name = "InLongton";
            InLongton.ReadOnly = true;
            // 
            // InHanley
            // 
            InHanley.DataPropertyName = "InHanley";
            InHanley.HeaderText = "Hanley";
            InHanley.MinimumWidth = 8;
            InHanley.Name = "InHanley";
            InHanley.ReadOnly = true;
            // 
            // InFenton
            // 
            InFenton.DataPropertyName = "InFenton";
            InFenton.HeaderText = "Fenton";
            InFenton.MinimumWidth = 8;
            InFenton.Name = "InFenton";
            InFenton.ReadOnly = true;
            // 
            // InTunstall
            // 
            InTunstall.DataPropertyName = "InTunstall";
            InTunstall.HeaderText = "Tunstall";
            InTunstall.MinimumWidth = 8;
            InTunstall.Name = "InTunstall";
            InTunstall.ReadOnly = true;
            // 
            // InStoke
            // 
            InStoke.DataPropertyName = "InStoke";
            InStoke.HeaderText = "Stoke";
            InStoke.MinimumWidth = 8;
            InStoke.Name = "InStoke";
            InStoke.ReadOnly = true;
            // 
            // IdCheck
            // 
            IdCheck.DataPropertyName = "IdCheck";
            IdCheck.HeaderText = "ID Check";
            IdCheck.MinimumWidth = 8;
            IdCheck.Name = "IdCheck";
            IdCheck.ReadOnly = true;
            // 
            // Condition
            // 
            Condition.DataPropertyName = "Condition";
            Condition.HeaderText = "Condition";
            Condition.MinimumWidth = 8;
            Condition.Name = "Condition";
            Condition.ReadOnly = true;
            // 
            // DrugName
            // 
            DrugName.DataPropertyName = "Name";
            DrugName.HeaderText = "Name of Drug";
            DrugName.MinimumWidth = 8;
            DrugName.Name = "DrugName";
            DrugName.ReadOnly = true;
            // 
            // dataGridDrugSet
            // 
            dataGridDrugSet.AllowUserToAddRows = false;
            dataGridDrugSet.AllowUserToDeleteRows = false;
            dataGridDrugSet.AllowUserToResizeColumns = false;
            dataGridDrugSet.AllowUserToResizeRows = false;
            dataGridDrugSet.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridDrugSet.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridDrugSet.CellBorderStyle = DataGridViewCellBorderStyle.RaisedVertical;
            dataGridDrugSet.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.SteelBlue;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.WhiteSmoke;
            dataGridViewCellStyle1.SelectionBackColor = Color.SteelBlue;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridDrugSet.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridDrugSet.ColumnHeadersHeight = 40;
            dataGridDrugSet.Columns.AddRange(new DataGridViewColumn[] { DrugName, Condition, IdCheck, InStoke, InTunstall, InFenton, InHanley, InLongton });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = Color.White;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.SteelBlue;
            dataGridViewCellStyle2.SelectionBackColor = Color.RoyalBlue;
            dataGridViewCellStyle2.SelectionForeColor = Color.White;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGridDrugSet.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridDrugSet.EnableHeadersVisualStyles = false;
            dataGridDrugSet.Location = new Point(12, 183);
            dataGridDrugSet.MultiSelect = false;
            dataGridDrugSet.Name = "dataGridDrugSet";
            dataGridDrugSet.ReadOnly = true;
            dataGridDrugSet.RowHeadersVisible = false;
            dataGridDrugSet.RowHeadersWidth = 30;
            dataGridDrugSet.RowTemplate.DividerHeight = 2;
            dataGridDrugSet.RowTemplate.Height = 34;
            dataGridDrugSet.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridDrugSet.Size = new Size(1300, 441);
            dataGridDrugSet.TabIndex = 25;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Gainsboro;
            panel3.Controls.Add(btnClose);
            panel3.Controls.Add(lbltitle);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(1350, 55);
            panel3.TabIndex = 35;
            // 
            // btnClose
            // 
            btnClose.Dock = DockStyle.Right;
            btnClose.FlatAppearance.BorderSize = 0;
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnClose.Location = new Point(1303, 0);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(47, 55);
            btnClose.TabIndex = 145;
            btnClose.Text = "X";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // DrugStoreForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1350, 650);
            Controls.Add(panel3);
            Controls.Add(lblFirstname);
            Controls.Add(panel1);
            Controls.Add(dataGridDrugSet);
            Controls.Add(txtSearchDrugStore);
            FormBorderStyle = FormBorderStyle.None;
            Name = "DrugStoreForm";
            Text = "DrugStore";
            Load += DrugStoreForm_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridDrugSet).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbltitle;
        private Panel panel1;
        private Panel panel2;
        private DataGridView dataGridDrugSet;
        private TextBox txtSearchDrugStore;
        private Label lblFirstname;
        private PictureBox ImgClose;
        private DataGridViewTextBoxColumn DrugName;
        private DataGridViewTextBoxColumn Condition;
        private DataGridViewTextBoxColumn IdCheck;
        private DataGridViewTextBoxColumn InStoke;
        private DataGridViewTextBoxColumn InTunstall;
        private DataGridViewTextBoxColumn InFenton;
        private DataGridViewTextBoxColumn InHanley;
        private DataGridViewTextBoxColumn InLongton;
        private Panel panel3;
        private Button btnClose;
    }
}