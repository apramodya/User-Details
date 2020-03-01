using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
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
            string filePath = String.Format("{0}\\{1}", Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "userDetails.txt");
            FileStream myFile = new FileStream(filePath, FileMode.Open, FileAccess.Read);
            IFormatter formatter = new BinaryFormatter();
            this.ud = (UserDetails)formatter.Deserialize(myFile);
            myFile.Close();

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
