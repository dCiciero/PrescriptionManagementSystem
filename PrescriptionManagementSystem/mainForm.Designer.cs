namespace PrescriptionManagementSystem
{
    partial class mainForm
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
            menuStrip1 = new MenuStrip();
            homeToolStripMenuItem = new ToolStripMenuItem();
            customerManaToolStripMenuItem = new ToolStripMenuItem();
            createModifyToolStripMenuItem = new ToolStripMenuItem();
            manageToolStripMenuItem = new ToolStripMenuItem();
            inventoryManagementToolStripMenuItem = new ToolStripMenuItem();
            drugSearchToolStripMenuItem = new ToolStripMenuItem();
            searchToolStripMenuItem = new ToolStripMenuItem();
            sellToolStripMenuItem = new ToolStripMenuItem();
            signOutToolStripMenuItem = new ToolStripMenuItem();
            exitToolStripMenuItem = new ToolStripMenuItem();
            mainAdminMenu = new ToolStripMenuItem();
            createUsersToolStripMenuItem = new ToolStripMenuItem();
            changePasswordToolStripMenuItem = new ToolStripMenuItem();
            salesToolStripMenuItem = new ToolStripMenuItem();
            contentPanel = new Panel();
            lblStoreName = new Label();
            lblUserDetails = new Label();
            menuStrip1.SuspendLayout();
            contentPanel.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(24, 24);
            menuStrip1.Items.AddRange(new ToolStripItem[] { homeToolStripMenuItem, mainAdminMenu });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1323, 33);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // homeToolStripMenuItem
            // 
            homeToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { customerManaToolStripMenuItem, inventoryManagementToolStripMenuItem, drugSearchToolStripMenuItem, signOutToolStripMenuItem, exitToolStripMenuItem });
            homeToolStripMenuItem.Name = "homeToolStripMenuItem";
            homeToolStripMenuItem.Size = new Size(77, 29);
            homeToolStripMenuItem.Text = "Home";
            // 
            // customerManaToolStripMenuItem
            // 
            customerManaToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { createModifyToolStripMenuItem, manageToolStripMenuItem });
            customerManaToolStripMenuItem.Name = "customerManaToolStripMenuItem";
            customerManaToolStripMenuItem.Size = new Size(299, 34);
            customerManaToolStripMenuItem.Text = "Customers";
            customerManaToolStripMenuItem.Click += customerManaToolStripMenuItem_Click;
            // 
            // createModifyToolStripMenuItem
            // 
            createModifyToolStripMenuItem.Name = "createModifyToolStripMenuItem";
            createModifyToolStripMenuItem.Size = new Size(228, 34);
            createModifyToolStripMenuItem.Text = "Create/Modify";
            createModifyToolStripMenuItem.Click += createModifyToolStripMenuItem_Click;
            // 
            // manageToolStripMenuItem
            // 
            manageToolStripMenuItem.Name = "manageToolStripMenuItem";
            manageToolStripMenuItem.Size = new Size(228, 34);
            manageToolStripMenuItem.Text = "Manage";
            manageToolStripMenuItem.Click += manageToolStripMenuItem_Click;
            // 
            // inventoryManagementToolStripMenuItem
            // 
            inventoryManagementToolStripMenuItem.Name = "inventoryManagementToolStripMenuItem";
            inventoryManagementToolStripMenuItem.Size = new Size(299, 34);
            inventoryManagementToolStripMenuItem.Text = "Inventory Management";
            inventoryManagementToolStripMenuItem.Click += inventoryManagementToolStripMenuItem_Click;
            // 
            // drugSearchToolStripMenuItem
            // 
            drugSearchToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { searchToolStripMenuItem, sellToolStripMenuItem });
            drugSearchToolStripMenuItem.Name = "drugSearchToolStripMenuItem";
            drugSearchToolStripMenuItem.Size = new Size(299, 34);
            drugSearchToolStripMenuItem.Text = "Drug Management";
            // 
            // searchToolStripMenuItem
            // 
            searchToolStripMenuItem.Name = "searchToolStripMenuItem";
            searchToolStripMenuItem.Size = new Size(166, 34);
            searchToolStripMenuItem.Text = "Search";
            searchToolStripMenuItem.Click += searchToolStripMenuItem_Click;
            // 
            // sellToolStripMenuItem
            // 
            sellToolStripMenuItem.Name = "sellToolStripMenuItem";
            sellToolStripMenuItem.Size = new Size(166, 34);
            sellToolStripMenuItem.Text = "Sell";
            sellToolStripMenuItem.Click += sellToolStripMenuItem_Click;
            // 
            // signOutToolStripMenuItem
            // 
            signOutToolStripMenuItem.Name = "signOutToolStripMenuItem";
            signOutToolStripMenuItem.Size = new Size(299, 34);
            signOutToolStripMenuItem.Text = "Sign Out";
            signOutToolStripMenuItem.Click += signOutToolStripMenuItem_Click;
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(299, 34);
            exitToolStripMenuItem.Text = "Exit";
            exitToolStripMenuItem.Click += exitToolStripMenuItem_Click;
            // 
            // mainAdminMenu
            // 
            mainAdminMenu.DropDownItems.AddRange(new ToolStripItem[] { createUsersToolStripMenuItem, changePasswordToolStripMenuItem, salesToolStripMenuItem });
            mainAdminMenu.Name = "mainAdminMenu";
            mainAdminMenu.Size = new Size(81, 29);
            mainAdminMenu.Text = "Admin";
            mainAdminMenu.Click += mainAdminMenu_Click;
            // 
            // createUsersToolStripMenuItem
            // 
            createUsersToolStripMenuItem.Name = "createUsersToolStripMenuItem";
            createUsersToolStripMenuItem.Size = new Size(274, 34);
            createUsersToolStripMenuItem.Text = "Create System Users";
            createUsersToolStripMenuItem.Click += createUsersToolStripMenuItem_Click;
            // 
            // changePasswordToolStripMenuItem
            // 
            changePasswordToolStripMenuItem.Name = "changePasswordToolStripMenuItem";
            changePasswordToolStripMenuItem.Size = new Size(274, 34);
            changePasswordToolStripMenuItem.Text = "Dashboard";
            changePasswordToolStripMenuItem.Click += changePasswordToolStripMenuItem_Click;
            // 
            // salesToolStripMenuItem
            // 
            salesToolStripMenuItem.Name = "salesToolStripMenuItem";
            salesToolStripMenuItem.Size = new Size(274, 34);
            // 
            // contentPanel
            // 
            contentPanel.BackColor = Color.SteelBlue;
            contentPanel.Controls.Add(lblStoreName);
            contentPanel.Controls.Add(lblUserDetails);
            contentPanel.Dock = DockStyle.Fill;
            contentPanel.Location = new Point(0, 33);
            contentPanel.Name = "contentPanel";
            contentPanel.Size = new Size(1323, 568);
            contentPanel.TabIndex = 0;
            // 
            // lblStoreName
            // 
            lblStoreName.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblStoreName.AutoSize = true;
            lblStoreName.Font = new Font("Comic Sans MS", 14F, FontStyle.Bold, GraphicsUnit.Point);
            lblStoreName.ForeColor = Color.White;
            lblStoreName.Location = new Point(1202, 25);
            lblStoreName.Name = "lblStoreName";
            lblStoreName.Size = new Size(99, 39);
            lblStoreName.TabIndex = 2;
            lblStoreName.Text = "label2";
            // 
            // lblUserDetails
            // 
            lblUserDetails.AutoSize = true;
            lblUserDetails.Font = new Font("Comic Sans MS", 14F, FontStyle.Bold, GraphicsUnit.Point);
            lblUserDetails.ForeColor = Color.White;
            lblUserDetails.Location = new Point(44, 15);
            lblUserDetails.Name = "lblUserDetails";
            lblUserDetails.Size = new Size(99, 39);
            lblUserDetails.TabIndex = 1;
            lblUserDetails.Text = "label1";
            // 
            // mainForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1323, 601);
            Controls.Add(contentPanel);
            Controls.Add(menuStrip1);
            FormBorderStyle = FormBorderStyle.None;
            MainMenuStrip = menuStrip1;
            Name = "mainForm";
            Text = "mainForm";
            Load += mainForm_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            contentPanel.ResumeLayout(false);
            contentPanel.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem homeToolStripMenuItem;
        private ToolStripMenuItem customerManaToolStripMenuItem;
        private ToolStripMenuItem mainAdminMenu;
        private ToolStripMenuItem createUsersToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private Panel contentPanel;
        private ToolStripMenuItem createModifyToolStripMenuItem;
        private ToolStripMenuItem manageToolStripMenuItem;
        private ToolStripMenuItem salesToolStripMenuItem;
        private ToolStripMenuItem changePasswordToolStripMenuItem;
        private ToolStripMenuItem signOutToolStripMenuItem;
        private ToolStripMenuItem inventoryManagementToolStripMenuItem;
        private ToolStripMenuItem drugSearchToolStripMenuItem;
        private ToolStripMenuItem searchToolStripMenuItem;
        private ToolStripMenuItem sellToolStripMenuItem;
        private Label lblUserDetails;
        private Label lblStoreName;
    }
}