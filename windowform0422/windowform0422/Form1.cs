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

namespace windowform0422
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnFile_Click(object sender, EventArgs e)
        {
            if(this.stdFile.ShowDialog() == DialogResult.OK)
            {
                this.txtPath.Text = this.stdFile.FileName;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                using (StreamWriter sw = new StreamWriter(this.txtPath.Text))
                {
                    sw.WriteLine(this.txtSave.Text);
                }
            }
            catch { return; }
            MessageBox.Show("저장이 완료 되었습니다.", "TMI", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
