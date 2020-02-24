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
    public partial class FormAddressDetails : Form
    {
        internal UserDetails ud { get; set; }

        public FormAddressDetails()
        {
            InitializeComponent();
        }

        private void FormAddressDetails_Load(object sender, EventArgs e)
        {

        }

        private void submitDetails(object sender, EventArgs e)
        {
            ud = new UserDetails();
            ud.FirstName = firstNameTextBox.Text;
            ud.LastName = lastNameTextBox.Text;
            ud.AddressLine1 = addressLine1TextBox.Text;
            ud.AddressLine2 = addressLine2TextBox.Text;
            ud.City = cityTextBox.Text;
            ud.PostCode = postCodeTextBox.Text;
            this.Hide();
        }
    }
}
