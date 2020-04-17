using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MediaDataConfig
{
    public partial class AboutForm : Form
    {
        public AboutForm()
        {
            InitializeComponent();
            System.Reflection.Assembly executingAssembly = System.Reflection.Assembly.GetExecutingAssembly();
            var fieVersionInfo = FileVersionInfo.GetVersionInfo(executingAssembly.Location);
            lblVersion.Text = fieVersionInfo.FileVersion;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
