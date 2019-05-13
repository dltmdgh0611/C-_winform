namespace winform0408
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.lb_Fruits = new System.Windows.Forms.Label();
            this.cbx_Fruits = new System.Windows.Forms.ComboBox();
            this.pbx_Fruits = new System.Windows.Forms.PictureBox();
            this.ad_pbx = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_Fruits)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ad_pbx)).BeginInit();
            this.SuspendLayout();
            // 
            // lb_Fruits
            // 
            this.lb_Fruits.AutoSize = true;
            this.lb_Fruits.Location = new System.Drawing.Point(30, 33);
            this.lb_Fruits.Name = "lb_Fruits";
            this.lb_Fruits.Size = new System.Drawing.Size(117, 12);
            this.lb_Fruits.TabIndex = 0;
            this.lb_Fruits.Text = "좋아하는 트로피카나";
            // 
            // cbx_Fruits
            // 
            this.cbx_Fruits.AutoCompleteCustomSource.AddRange(new string[] {
            "사과 톡톡톡 트로피카나",
            "청포도 톡톡톡 트로피카나",
            "포도 톡톡톡 트로피카나",
            "망고 톡톡톡 트로피카나",
            "오렌지 톡톡톡 트로피카나",
            "파인애플 톡톡톡 트로피카나",
            "복숭아 톡톡톡 트로피카나"});
            this.cbx_Fruits.FormattingEnabled = true;
            this.cbx_Fruits.Items.AddRange(new object[] {
            "복숭아 톡톡톡 트로피카나",
            "청포도 톡톡톡 트로피카나",
            "포도 톡톡톡 트로피카나",
            "망고 톡톡톡 트로피카나",
            "오렌지 톡톡톡 트로피카나",
            "사과 톡톡톡 트로피카나",
            "파인애플 톡톡톡 트로피카나"});
            this.cbx_Fruits.Location = new System.Drawing.Point(32, 82);
            this.cbx_Fruits.Name = "cbx_Fruits";
            this.cbx_Fruits.Size = new System.Drawing.Size(121, 20);
            this.cbx_Fruits.TabIndex = 1;
            this.cbx_Fruits.SelectedIndexChanged += new System.EventHandler(this.cbx_Fruits_SelectedIndexChanged);
            // 
            // pbx_Fruits
            // 
            this.pbx_Fruits.Location = new System.Drawing.Point(32, 136);
            this.pbx_Fruits.Name = "pbx_Fruits";
            this.pbx_Fruits.Size = new System.Drawing.Size(277, 330);
            this.pbx_Fruits.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbx_Fruits.TabIndex = 2;
            this.pbx_Fruits.TabStop = false;
            // 
            // ad_pbx
            // 
            this.ad_pbx.Location = new System.Drawing.Point(333, 136);
            this.ad_pbx.Name = "ad_pbx";
            this.ad_pbx.Size = new System.Drawing.Size(266, 330);
            this.ad_pbx.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ad_pbx.TabIndex = 3;
            this.ad_pbx.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(638, 503);
            this.Controls.Add(this.ad_pbx);
            this.Controls.Add(this.pbx_Fruits);
            this.Controls.Add(this.cbx_Fruits);
            this.Controls.Add(this.lb_Fruits);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbx_Fruits)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ad_pbx)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_Fruits;
        private System.Windows.Forms.ComboBox cbx_Fruits;
        private System.Windows.Forms.PictureBox pbx_Fruits;
        private System.Windows.Forms.PictureBox ad_pbx;
    }
}

