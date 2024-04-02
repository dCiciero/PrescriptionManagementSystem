namespace PrescriptionManagementSystem
{
    partial class WebScraper
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
            lblURL = new Label();
            txtURL = new TextBox();
            btnFetch = new Button();
            lblSourceDump = new Label();
            btnParse = new Button();
            SuspendLayout();
            // 
            // lblURL
            // 
            lblURL.AutoSize = true;
            lblURL.Location = new Point(52, 15);
            lblURL.Name = "lblURL";
            lblURL.Size = new Size(43, 25);
            lblURL.TabIndex = 0;
            lblURL.Text = "URL";
            // 
            // txtURL
            // 
            txtURL.Location = new Point(101, 12);
            txtURL.Name = "txtURL";
            txtURL.Size = new Size(567, 31);
            txtURL.TabIndex = 1;
            // 
            // btnFetch
            // 
            btnFetch.Location = new Point(101, 64);
            btnFetch.Name = "btnFetch";
            btnFetch.Size = new Size(567, 34);
            btnFetch.TabIndex = 2;
            btnFetch.Text = "Fetch URL Source Code";
            btnFetch.UseVisualStyleBackColor = true;
            btnFetch.Click += btnFetch_Click;
            // 
            // lblSourceDump
            // 
            lblSourceDump.AutoSize = true;
            lblSourceDump.Location = new Point(52, 151);
            lblSourceDump.Name = "lblSourceDump";
            lblSourceDump.Size = new Size(66, 25);
            lblSourceDump.TabIndex = 3;
            lblSourceDump.Text = "Source";
            // 
            // btnParse
            // 
            btnParse.Location = new Point(101, 114);
            btnParse.Name = "btnParse";
            btnParse.Size = new Size(567, 34);
            btnParse.TabIndex = 4;
            btnParse.Text = "Parse Source Code";
            btnParse.UseVisualStyleBackColor = true;
            btnParse.Click += btnParse_Click;
            // 
            // WebScraper
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnParse);
            Controls.Add(lblSourceDump);
            Controls.Add(btnFetch);
            Controls.Add(txtURL);
            Controls.Add(lblURL);
            Name = "WebScraper";
            Text = "WebScrappe";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblURL;
        private TextBox txtURL;
        private Button btnFetch;
        private Label lblSourceDump;
        private Button btnParse;
    }
}