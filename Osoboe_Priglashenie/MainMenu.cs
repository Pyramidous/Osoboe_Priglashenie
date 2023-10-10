using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Osoboe_Priglashenie
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void SiteBtn_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.os-pr.ru/"); //переход на сайт
        }

        private void StaffBtn_Click(object sender, EventArgs e)
        {
            Autorisation autorisation = new Autorisation();
            autorisation.Show();
            this.Hide();
        }

        private void RefBtn_Click(object sender, EventArgs e)
        {
            string commandText = System.IO.Directory.GetCurrentDirectory() + "\\..\\..\\..\\help.chm";
            var proc = new System.Diagnostics.Process();
            proc.StartInfo.FileName = commandText;
            proc.StartInfo.UseShellExecute = true;
            proc.Start();
        }

        private void AboutBtn_Click(object sender, EventArgs e)
        {
            About about = new About();
            about.Show();
        }

        private void OrderBtn_Click(object sender, EventArgs e)
        {
            Order order = new Order();
            order.Show();
            this.Hide();
        }
    }
}
