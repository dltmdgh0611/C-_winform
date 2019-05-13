using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Diagnostics;

namespace windowform0415
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private PerformanceCounter oCPU = new PerformanceCounter("Processor", "% Processor Time", "_Total");
        private bool bExit = false;
        private int iCPU = 0;
        private Font F = new Font("굴림", 9);

        private Thread checkThread;

        private delegate void ProcessEventHandler(int Current);
        private ProcessEventHandler ResultView = null;
        public bool toggle = false;
        private void Form1_Load(object sender, EventArgs e)
        {
            ResultView += new ProcessEventHandler(Current);
            checkThread = new Thread(getCPU_Info);
            checkThread.Start();
        }

        private void getCPU_Info()
        {
            while (!bExit)
            {
                iCPU = (int)oCPU.NextValue();
                Invoke(ResultView, iCPU);
                Thread.Sleep(1000);
            }
        }

        private void Current(int Current)
        {
            this.Text = "CPU 사용량 : " + Current.ToString() + " %";
            iCPU = Current * 3;
            plBar.Invalidate();
        }

        private void plBar_Paint(object sender, PaintEventArgs e)
        {
            Graphics G = e.Graphics;

            if (iCPU <= 60) G.FillRectangle(Brushes.BlanchedAlmond, 0, 0, iCPU, plBar.Height);
            else if (iCPU <= 120) G.FillRectangle(Brushes.Orange, 0, 0, iCPU, plBar.Height);
            else if (iCPU <= 180) G.FillRectangle(Brushes.OrangeRed, 0, 0, iCPU, plBar.Height);
            else if (iCPU <= 240) G.FillRectangle(Brushes.Red, 0, 0, iCPU, plBar.Height);

            iCPU = iCPU / 3;

            G.DrawString(iCPU.ToString() + " %", F, Brushes.DarkRed, plBar.Width / 2 - 16, plBar.Height / 4);
        }

        private void onoff_bt_Click(object sender, EventArgs e)
        {
            if (toggle)
            {
                ResultView += new ProcessEventHandler(Current);
                checkThread = new Thread(getCPU_Info);
                checkThread.Start();
                toggle = false; 
            }
            else
            {
                checkThread.Abort();
                toggle = true;
            }
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            checkThread.Abort();
        }
    }
}
