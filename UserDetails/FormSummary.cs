using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UserDetails
{
    public partial class FormSummary : Form
    {
        internal UserDetails ud { get; set; }
        public FormSummary()
        {
            InitializeComponent();
        }

        private void FormSummary_Load(object sender, EventArgs e)
        {
            firstNameTextBox.Text = ud.FirstName;
            lastNameTextBox.Text = ud.LastName;
            addressLine1TextBox.Text = ud.AddressLine1;
            addressLine2TextBox.Text = ud.AddressLine2;
            cityTextBox.Text = ud.City;
            postCodeTextBox.Text = ud.PostCode;
        }

        private void close(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
