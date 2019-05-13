using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MSG_190311
{
    public partial class Planner : Form
    {
        
        
        public Planner()
        {
            InitializeComponent();
        }

        private void next_bt_Click(object sender, EventArgs e)
        {
            //enter
            Form1.hour[Form1.count] = Convert.ToInt32(hour_tb.Text);
            Form1.min[Form1.count] = Convert.ToInt32(minuet_tb.Text);
            if (high_cb.Checked)
            {
                Form1.major[Form1.count] = 0;
            }
            else if(middle_cb.Checked)
            {
                Form1.major[Form1.count] = 1;
            }
            else if (low_cb.Checked)
            {
                Form1.major[Form1.count] = 2;
            }
            Form1.memo[Form1.count] = Convert.ToString(memo_tb.Text);

            //init
            hour_tb.Text = Convert.ToString('\0');
            minuet_tb.Text = Convert.ToString('\0');
            memo_tb.Text = Convert.ToString('\0');
            high_cb.Checked = false;
            middle_cb.Checked = false;
            low_cb.Checked = false;

            Form1.count++;
        }

        private void hour_tb_KeyPress(object sender, KeyPressEventArgs e)
        {
            Check_Stirng(e);
        }

        private void minuet_tb_KeyPress(object sender, KeyPressEventArgs e)
        {
            Check_Stirng(e);
        }

        public void Check_Stirng(KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || e.KeyChar == Convert.ToChar(Keys.Back) || e.KeyChar == '-'))
            {
                e.Handled = true;
            }
        }

        private void exit_bt_Click(object sender, EventArgs e)
        {
            Form1.count = 0;
            this.Close();
        }

       
    }
}
