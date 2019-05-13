using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForms0422_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void mExit(object sender, EventArgs e)
        {
            this.Close();
        }

        private void mRun(object sender, EventArgs e)
        {

        }

        private void minfo(object sender, EventArgs e)
        {
            info pu = new info();
            pu.Show();
        }
    }
}
