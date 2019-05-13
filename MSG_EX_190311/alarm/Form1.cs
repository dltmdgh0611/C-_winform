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
    public partial class Form1 : Form
    {
        public static int[] hour = new int[100];
        public static int[] min = new int[100];
        public static byte[] major = new byte[100];
        public static string[] memo = new string[100];
        public static int count = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            alarm newForm = new alarm();
            newForm.Show();
            count++;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            notice newForm = new notice();
            newForm.Show();
            count++;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            error newForm = new error();
            newForm.Show();
            count++;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            
            Time_Text.Text = DateTime.Now.ToLongTimeString();
            if ((DateTime.Now.Hour == hour[count]) && (DateTime.Now.Minute == min[count]) && (DateTime.Now.Second == 0)) 
            {
                
                if(major[count] == 0)
                {
                    error newForm = new error();
                    newForm.Show();
                    count++;
                }
                else if (major[count] == 1)
                {
                    notice newForm = new notice();
                    newForm.Show();
                    count++;
                }
                else if (major[count] == 2)
                {
                    alarm newForm = new alarm();
                    newForm.Show();
                    count++;
                }
            }
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            timer1.Start();
            timer1.Interval = 1000;
        }

        private void planner_Click(object sender, EventArgs e)
        {
            Planner newForm = new Planner();
            newForm.Show();
        }
    }
}
