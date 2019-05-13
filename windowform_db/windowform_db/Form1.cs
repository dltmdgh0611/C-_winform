using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace windowform_db
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string Consql = "";

        private void Form1_Load(object sender, EventArgs e)
        {
            this.cbGender.Text = "Male";

            string DbPath = Application.StartupPath;
            Consql = "Provider=Microsoft.ACE.OLEDB.16.0;Data Source=" + DbPath + @"\Human1.accdb;Mode=ReadWrite";
            lvViewListUp();
        }

        private void lvViewListUp()
        {
            int ItemsCount = 1;
            this.lvView.Items.Clear();
            var Conn = new OleDbConnection(Consql);
            Conn.Open();

            var Comm = new OleDbCommand("Select * from HumanTable", Conn);
            var myRead = Comm.ExecuteReader();
            while (myRead.Read())
            {
                string[] ReadArray = new string[] { ItemsCount.ToString(), myRead[0].ToString(), myRead[1].ToString(), myRead[2].ToString() };
                this.lvView.Items.Add(new ListViewItem(ReadArray));
                ItemsCount++;
            }
            myRead.Close();
            Conn.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (this.tbID.Text != "")
            {
                this.tbID.Text = "";
                this.tbName.Text = "";
                this.cbGender.Text = "Male";
                return;
            }
            if(TxtCheck())
            {
                var Conn = new OleDbConnection(Consql);
                Conn.Open();

                string Sql = "Insert into HumanTable(H_Name, H_Gender)";
                Sql += "values('" + this.tbName.Text + "', '" + this.cbGender.Text + "')";
                var Comm = new OleDbCommand(Sql, Conn);
                int i = Comm.ExecuteNonQuery();
                if (i == 1)
                {
                    MessageBox.Show("정상적으로 정보가 추가되었습니다", "알림", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    lvViewListUp();
                }
                else MessageBox.Show("정보를 추가하는 도중 심각한 오류가 발생했습니다(0x0688990)", "알림", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool TxtCheck()
        {
            string ConName = "";
            if (this.tbName.Text == "") ConName = "이름";
            if (ConName == "") return true;
            else
            { 
            MessageBox.Show("정보가 입력되지 않았습니다. 정보를 입력해주세요", "알림", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return false;
            }
        }

        private void lvView_Click(object sender, EventArgs e)
        {
            if (this.lvView.SelectedItems.Count > 0)
            {
                int n = this.lvView.SelectedItems[0].Index;
                this.tbID.Text = this.lvView.Items[n].SubItems[1].Text;
                this.tbName.Text = this.lvView.Items[n].SubItems[2].Text;
                this.cbGender.Text = this.lvView.Items[n].SubItems[3].Text;
            }
        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            if (this.lvView.SelectedItems.Count == 0)
            {
                MessageBox.Show("정보가 선택되지 않았습니다. 정보를 선택해주세요", "알림", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                var dlg = MessageBox.Show("수정하시겠습니까?", "알림", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if(dlg==DialogResult.Yes)
                {
                    if(TxtCheck())
                    {
                        var Conn = new OleDbConnection(Consql);
                        Conn.Open();
                        string Sql = "Update HumanTable Set H_Name = '" + this.tbName.Text + "', H_Gender = '" + this.cbGender.Text + "' ";
                        Sql += "where H_ID = " + Convert.ToInt32(tbID.Text) + "";
                        var Comm = new OleDbCommand(Sql, Conn);
                        int i = Comm.ExecuteNonQuery();
                        if (i == 1)
                        {
                            MessageBox.Show("정상적으로 정보가 수정되었습니다", "알림", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                            lvViewListUp();
                        }
                        else MessageBox.Show("정보를 수정하는 도중 심각한 오류가 발생했습니다(0x0688440)", "알림", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (this.lvView.SelectedItems.Count == 0)
            {
                MessageBox.Show("정보가 선택되지 않았습니다. 정보를 선택해주세요", "알림", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                var dlg = MessageBox.Show("삭제하시겠습니까?", "알림", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (dlg == DialogResult.Yes)
                {
                    if (TxtCheck())
                    {
                        var Conn = new OleDbConnection(Consql);
                        Conn.Open();

                        string Sql = "Delete from HumanTable where H_ID = " + Convert.ToInt32(tbID.Text) + "";
                        var Comm = new OleDbCommand(Sql, Conn);
                        int i = Comm.ExecuteNonQuery();
                        if (i == 1)
                        {
                            MessageBox.Show("정상적으로 정보가 삭제되었습니다", "알림", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                            lvViewListUp();
                        }
                        else MessageBox.Show("정보를 삭제하는 도중 심각한 오류가 발생했습니다(0x0677990)", "알림", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
    }
}

