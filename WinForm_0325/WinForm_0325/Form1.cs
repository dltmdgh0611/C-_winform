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

namespace WinForm_0325
{
   
    public partial class Form1 : Form
    {
        public static Pen p = new Pen(Color.White);
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            clsLineRectangle im = new clsLineRectangle();
            this.plPaint.MouseDown += new MouseEventHandler(im.clsLineRectangle_OnMouseDown);
            this.plPaint.MouseMove += new MouseEventHandler(im.clsLineRectangle_OnMouseMove);
            this.plPaint.MouseUp += new MouseEventHandler(im.clsLineRectangle_OnMouseUp);
        }

        private void rbLine_CheckedChanged(object sender, EventArgs e)
        {
            
                clsLineRectangle.checkflags = 1;
            
        }
        
        private void rbRect_CheckedChanged(object sender, EventArgs e)
        {
            
                clsLineRectangle.checkflags = 2;
            
        }

        private void oneclicksq_rb_CheckedChanged(object sender, EventArgs e)
        {
           
                clsLineRectangle.checkflags = 3;
            
        }

        private void oneclickcir_rb_CheckedChanged(object sender, EventArgs e)
        {
            
                clsLineRectangle.checkflags = 4;
            
        }

        private void oneclickline_rb_CheckedChanged(object sender, EventArgs e)
        {
            
                clsLineRectangle.checkflags = 5;
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(colorDialog1.ShowDialog() != System.Windows.Forms.DialogResult.Cancel)
            {

                p.Color = colorDialog1.Color;
            }
        }
    }

    public class clsLineRectangle
    {
        public static int checkflags = 1;
        Rectangle SelectRect = new Rectangle();
        Point ps = new Point();
        Point pe = new Point();

        public void clsLineRectangle_OnMouseDown(object sender, MouseEventArgs e)
        {

            
            SelectRect.Width = 0;
            SelectRect.Height = 0;
            SelectRect.X = e.X;
            SelectRect.Y = e.Y;
            ps.X = e.X;
            ps.Y = e.Y;
            pe = ps;

            Panel Paintform = (Panel)sender;
            Graphics g = Paintform.CreateGraphics();
            
            Rectangle rect;

            if(checkflags == 3)
            {
                rect = new Rectangle(e.X, e.Y, 150, 150);
                g.DrawRectangle(Form1.p, rect);
                
            }
            else if(checkflags == 4)
            {
                rect = new Rectangle(e.X, e.Y, 150, 150);
                g.DrawArc(Form1.p, rect, 0, 365);
            }
            else if(checkflags == 5)
            {
                g.DrawLine(Form1.p, e.X, e.Y, e.X+200, e.Y);
            }
        }

      

        public void clsLineRectangle_OnMouseMove(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left)
            {
                Panel Paintform = (Panel)sender;
                if (checkflags == 1)
                {
                    ControlPaint.DrawReversibleLine(Paintform.PointToScreen(ps), Paintform.PointToScreen(pe), Color.Black);
                    pe = new Point(e.X, e.Y);
                    ControlPaint.DrawReversibleLine(Paintform.PointToScreen(ps), Paintform.PointToScreen(pe), Color.Black);
                }
                else if(checkflags == 2)
                {
                    ControlPaint.DrawReversibleFrame(Paintform.RectangleToScreen(SelectRect), Color.Black, FrameStyle.Dashed);
                    SelectRect.Width = e.X - SelectRect.X;
                    SelectRect.Height = e.Y - SelectRect.Y;
                    ControlPaint.DrawReversibleFrame(Paintform.RectangleToScreen(SelectRect), Color.Black, FrameStyle.Dashed);
                }
            }
        }
        public void clsLineRectangle_OnMouseUp(object sender, MouseEventArgs e)
        {
            Panel Paintform = (Panel)sender;
            Graphics g = Paintform.CreateGraphics();
            if (checkflags == 1)
            {
                ControlPaint.DrawReversibleLine(Paintform.PointToScreen(ps), Paintform.PointToScreen(pe), Form1.p.Color);
                g.DrawLine(Form1.p, ps, pe);
            }
            else if (checkflags == 2)
            {
                ControlPaint.DrawReversibleFrame(Paintform.RectangleToScreen(SelectRect), Form1.p.Color, FrameStyle.Dashed);
                g.DrawRectangle(Form1.p, SelectRect);
            }
            g.Dispose();
        }
    }

}
