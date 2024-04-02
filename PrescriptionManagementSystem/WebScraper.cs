using Microsoft.AspNetCore.Cryptography.KeyDerivation;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrescriptionManagementSystem
{
    public partial class WebScraper : Form
    {
        public WebScraper()
        {
            InitializeComponent();
        }

        private void btnFetch_Click(object sender, EventArgs e)
        {
            //WorkerClass workerClass = new WorkerClass();
            string sourceCode = WorkerClass.getSourceCode(txtURL.Text);
            if (sourceCode != null)
            {
                lblSourceDump.Text = sourceCode.Substring(0, 100);
                StreamWriter streamWriter = new StreamWriter("sourceCode.txt");
                streamWriter.WriteLine(sourceCode);
                streamWriter.Close();
            }
        }

        private void btnParse_Click(object sender, EventArgs e)
        {
            WorkerClass.parseSource("sourceCode.txt");
        }

        
    }
}
