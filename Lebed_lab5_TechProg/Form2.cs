using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lebed_lab5_TechProg
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void gitHub_Click(object sender, EventArgs e)
        {
            Process.Start(new ProcessStartInfo("https://github.com/n1kys") { UseShellExecute = true });
        }

        private void telegram_Click(object sender, EventArgs e)
        {
            Process.Start(new ProcessStartInfo("https://t.me/n1kys21") { UseShellExecute = true });
        }

        private void gmail_Click(object sender, EventArgs e)
        {
            Process.Start(new ProcessStartInfo("mailto:n.n.lebidj@student.csn.khai.edu") { UseShellExecute = true });
        }
    }
}
