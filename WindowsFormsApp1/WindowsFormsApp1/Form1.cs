using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLine_Click(object sender, EventArgs e)
        {
            Graphics g = this.CreateGraphics();
            Pen pen = new Pen(Color.Black,5);
            g.Clear(Color.White);
            for(int i = 40; i <= 400; i += 40)
            {
                g.DrawLine(pen, 0, i, 300, i);
            }
            for (int i = 40; i <= 400; i += 40)
            {
                g.DrawLine(pen, i, 0, i, 500);
            }
        }

        private void btnRect_Click(object sender, EventArgs e)
        {
            Graphics g = this.CreateGraphics();
            Pen p = new Pen(Color.Black, 5);
            g.Clear(Color.White);
            g.DrawRectangle(p, new Rectangle(105, 105, 70, 100));
            g.DrawRectangle(p, new Rectangle(75, 105, 30, 70));
            g.DrawRectangle(p, new Rectangle(175, 105, 30, 70));
            g.DrawRectangle(p, new Rectangle(105, 205, 30, 80));
            g.DrawRectangle(p, new Rectangle(145, 205, 30, 80));

            for(int i = 0; i <360; i+=20)
            {
                g.DrawRectangle(p, new Rectangle(200, 200, 30, 30));
                g.Transform.Rotate(i);
            }

            
        }

    }
}
