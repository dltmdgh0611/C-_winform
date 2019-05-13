using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace windowform0415_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnFile_Click(object sender, EventArgs e)
        {
            if(this.ofdFile.ShowDialog() == DialogResult.OK)
            {
                txtPath.Text = this.ofdFile.FileName;
            }
        }

        private bool txtCheck()
        {
            if(txtPath.Text == null)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private void btnAllRead_Click(object sender, EventArgs e)
        {
            if (txtCheck() == false) return;

            if(File.Exists(this.txtPath.Text))
            {
                using (StreamReader sr = new StreamReader(this.txtPath.Text))
                {
                    this.txtView.Text = sr.ReadToEnd();
                }
            }
            else
            {
                MessageBox.Show("파일을 넣지않고 텍스트 읽기 버튼을 눌러 프로그램의 일부분이 심각한 손상을 입었습니다.", "심각한 오류", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
            }
        }

        private void btnLineRead_Click(object sender, EventArgs e)
        {
            if (txtCheck() == false) return;
            this.txtView.Clear();
            if (File.Exists(this.txtPath.Text))
            {
                using (StreamReader sr = new StreamReader(this.txtPath.Text))
                {
                    string line = null;
                    while ((line = sr.ReadLine()) != null)
                    {
                        this.txtView.AppendText(line + "\r\n");
                    }
                }
            }
            else
            {
                MessageBox.Show("파일을 넣지않고 텍스트 읽기 버튼을 눌러 프로그램의 일부분이 심각한 손상을 입었습니다.", "심각한 오류", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
            }
        }
    }
}
