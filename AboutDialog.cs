using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _3DPatternMaker
{
    public partial class AboutDialog : Form
    {
        public AboutDialog()
        {
            InitializeComponent();
            AppNameLabel.Text = Application.ProductName;
            VersionLabel.Text = Application.ProductVersion;
            VendorLabel.Text = Application.CompanyName;
        }
    }
}
