using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using System.Threading.Tasks;


namespace winform0408_2
{
    public partial class Form1 : Form
    {
        public void eve()
        {
            while (true)
            {
                res = sum * 60 / cnt;
                prb_Level.Value = cnt;
                lb_OUTPUT_1.Text = str1[i];
                lb_OUTPUT_2.Text = res + "타";
                Thread.Sleep(50);
            }
        }


        int cnt=1, i, sum, res;
        string[] str1 = new string[] {"내 목숨을 아이어에","나 여기 어둠속에 있다","첫번째 자손은 굴하지 않으리라","압도적인 힘으로","내 분노를 이끌어다오","정의는 질서로부터","출격 준비 완료"};
        public Form1()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
            Thread thr = new Thread(eve);
            thr.Start();
        }

        private void btn_Start_Click(object sender, EventArgs e)
        {
            timer1_Tick.Enabled = true;
        }

        private void timer1_Tick_Tick(object sender, EventArgs e)
        {
            cnt++;
            
        }

        private void tbx_INPUT_KeyPress(object sender, KeyPressEventArgs e)
        {
            sum++;
        }

        private void tbx_INPUT_KeyUp(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                if(str1[i] == tbx_INPUT.Text)
                {
                    result.Text = "적절한 대답";
                    result.ForeColor = Color.Blue;
                    i++;
                    tbx_INPUT.Text = "";
                    sum = 1;
                    cnt = 1;
                }
                else
                {
                    result.Text = "심각한 오류";
                    result.ForeColor = Color.Red;
                    tbx_INPUT.Text = "";
                    sum = 1;
                    cnt = 1;
                }
            }
        }
    }
}
