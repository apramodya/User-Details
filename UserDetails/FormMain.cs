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
    public partial class FormMain : Form
    {
        UserDetails ud = new UserDetails();

        public FormMain()
        {
            InitializeComponent();
        }

        private void enterDetails(object sender, EventArgs e)
        {
            FormAddressDetails form = new FormAddressDetails();
            form.ud = this.ud;
            form.ShowDialog();
            this.ud = form.ud;
            form.Dispose();
        }

        private void reviewDetails(object sender, EventArgs e)
        {
            FormSummary form = new FormSummary();
            form.ud = this.ud;
            form.ShowDialog();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {

        }
    }
}
