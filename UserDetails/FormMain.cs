﻿using System;
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
        public FormMain()
        {
            InitializeComponent();
        }

        private void enterDetails(object sender, EventArgs e)
        {
            FormAddressDetails form = new FormAddressDetails();
            form.Activate();
            form.ShowDialog();
        }

        private void reviewDetails(object sender, EventArgs e)
        {
            FormSummary form = new FormSummary();
            form.Activate();
            form.ShowDialog();
        }
    }
}
