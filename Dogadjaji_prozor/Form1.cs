using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dogadjaji_prozor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            vucicBtn.Click += DanGlas;
            brenaBtn.Click += DanGlas;
            brenaBtn.MouseEnter += BrenaBtn_MouseEnter;
        }

        private void BrenaBtn_MouseEnter(object sender, EventArgs e)
        {
            Point poz = brenaBtn.Location;
            poz.Y += 40;
            if (poz.Y > 450) poz.Y = 300;
            brenaBtn.Location = poz;
        }

        private void DanGlas(object sender, EventArgs e)
        {
            MessageBox.Show("Hvala što ste dali glas za " + (sender as Button).Text);
        }

        private void gumbVeliki_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hvala na kliku");
        }
    }
}
