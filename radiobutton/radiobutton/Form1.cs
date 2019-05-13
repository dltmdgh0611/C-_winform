using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace radiobutton
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void black_rb_CheckedChanged(object sender, EventArgs e)
        {
            if(black_rb.Checked == true)
            {
                main_lb.ForeColor = Color.Black;
                red_rb.Checked = false;
                blue_rb.Checked = false;
            }
        }

        private void red_rb_CheckedChanged(object sender, EventArgs e)
        {
            if (red_rb.Checked == true)
            {
                main_lb.ForeColor = Color.Red;
                black_rb.Checked = false;
                blue_rb.Checked = false;
            }
        }

        private void blue_rb_CheckedChanged(object sender, EventArgs e)
        {
            if (blue_rb.Checked == true)
            {
                main_lb.ForeColor = Color.Blue;
                red_rb.Checked = false;
                black_rb.Checked = false;
            }
        }

        private void bold_cb_CheckedChanged(object sender, EventArgs e)
        {
            if(bold_cb.Checked == true)
            {
                main_lb.Font = new Font("Arial", 9, FontStyle.Bold);
            }
            else
            {
                main_lb.Font = new Font("Arial", 9, FontStyle.Regular);
            }
        }

        private void italic_cb_CheckedChanged(object sender, EventArgs e)
        {
            if (italic_cb.Checked == true)
            {
                main_lb.Font = new Font("Arial", 9, FontStyle.Italic);
            }
            else
            {
                main_lb.Font = new Font("Arial", 9, FontStyle.Regular);
            }
        }

        private void cancelLine_cb_CheckedChanged(object sender, EventArgs e)
        {
            if (cancelLine_cb.Checked == true)
            {
                main_lb.Font = new Font("Arial", 9, FontStyle.Strikeout);
            }
            else
            {
                main_lb.Font = new Font("Arial", 9, FontStyle.Regular);
            }
        }
    }
}
