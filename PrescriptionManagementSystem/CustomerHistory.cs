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
    public partial class CustomerHistory : Form
    {
        string _customerNamename = "";
        public CustomerHistory(string customerNamename)
        {
            InitializeComponent();
            _customerNamename = customerNamename;
            lblCustomerName.Text = _customerNamename;
        }

        private void CustomerHistory_Load(object sender, EventArgs e)
        {

        }

        private void ImgClose_Click(object sender, EventArgs e)
        {
            this.Close();
            CustomerSearchForm frm = new CustomerSearchForm();
            frm.ShowDialog();
        }
    }
}
