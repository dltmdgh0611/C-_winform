using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace winform0408
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void cbx_Fruits_SelectedIndexChanged(object sender, EventArgs e)
        {
            if((string)cbx_Fruits.SelectedItem == "사과 톡톡톡 트로피카나")
            {
                lb_Fruits.Text = (string)cbx_Fruits.SelectedItem;
                pbx_Fruits.ImageLocation = @"D:\tropicana\apple.jpg";
                ad_pbx.ImageLocation = @"D:\tropicana\applead.png";
            }
            if ((string)cbx_Fruits.SelectedItem == "청포도 톡톡톡 트로피카나")
            {
                lb_Fruits.Text = (string)cbx_Fruits.SelectedItem;
                pbx_Fruits.ImageLocation = @"D:\tropicana\whitegrape.jpg";
                ad_pbx.ImageLocation = @"D:\tropicana\whitegrapead.png";
            }
            if ((string)cbx_Fruits.SelectedItem == "포도 톡톡톡 트로피카나")
            {
                lb_Fruits.Text = (string)cbx_Fruits.SelectedItem;
                pbx_Fruits.ImageLocation = @"D:\tropicana\grape.jpg";
                ad_pbx.ImageLocation = @"D:\tropicana\grapead.png";
            }
            if ((string)cbx_Fruits.SelectedItem == "망고 톡톡톡 트로피카나")
            {
                lb_Fruits.Text = (string)cbx_Fruits.SelectedItem;
                pbx_Fruits.ImageLocation = @"D:\tropicana\mango.jpg";
                ad_pbx.ImageLocation = @"D:\tropicana\mangoad.png";
            }
            if ((string)cbx_Fruits.SelectedItem == "오렌지 톡톡톡 트로피카나")
            {
                lb_Fruits.Text = (string)cbx_Fruits.SelectedItem;
                pbx_Fruits.ImageLocation = @"D:\tropicana\orange.jpg";
                ad_pbx.ImageLocation = @"D:\tropicana\orangead.png";
            }
            if ((string)cbx_Fruits.SelectedItem == "복숭아 톡톡톡 트로피카나")
            {
                lb_Fruits.Text = (string)cbx_Fruits.SelectedItem;
                pbx_Fruits.ImageLocation = @"D:\tropicana\peach.jpg";
                ad_pbx.ImageLocation = @"D:\tropicana\peachad.png";
            }
            if ((string)cbx_Fruits.SelectedItem == "파인애플 톡톡톡 트로피카나")
            {
                lb_Fruits.Text = (string)cbx_Fruits.SelectedItem;
                pbx_Fruits.ImageLocation = @"D:\tropicana\pineapple.gif";
                ad_pbx.ImageLocation = @"D:\tropicana\pineapplead.png";
            }
        }
    }
}
