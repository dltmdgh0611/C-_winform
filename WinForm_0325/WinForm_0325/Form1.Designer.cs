namespace WinForm_0325
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
            this.gbOption = new System.Windows.Forms.GroupBox();
            this.oneclickline_rb = new System.Windows.Forms.RadioButton();
            this.oneclickcir_rb = new System.Windows.Forms.RadioButton();
            this.oneclicksq_rb = new System.Windows.Forms.RadioButton();
            this.rbRect = new System.Windows.Forms.RadioButton();
            this.rbLine = new System.Windows.Forms.RadioButton();
            this.plPaint = new System.Windows.Forms.Panel();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.button1 = new System.Windows.Forms.Button();
            this.gbOption.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbOption
            // 
            this.gbOption.Controls.Add(this.button1);
            this.gbOption.Controls.Add(this.oneclickline_rb);
            this.gbOption.Controls.Add(this.oneclickcir_rb);
            this.gbOption.Controls.Add(this.oneclicksq_rb);
            this.gbOption.Controls.Add(this.rbRect);
            this.gbOption.Controls.Add(this.rbLine);
            this.gbOption.Location = new System.Drawing.Point(12, 12);
            this.gbOption.Name = "gbOption";
            this.gbOption.Size = new System.Drawing.Size(332, 131);
            this.gbOption.TabIndex = 0;
            this.gbOption.TabStop = false;
            this.gbOption.Text = "Option";
            // 
            // oneclickline_rb
            // 
            this.oneclickline_rb.AutoSize = true;
            this.oneclickline_rb.Location = new System.Drawing.Point(226, 63);
            this.oneclickline_rb.Name = "oneclickline_rb";
            this.oneclickline_rb.Size = new System.Drawing.Size(83, 16);
            this.oneclickline_rb.TabIndex = 4;
            this.oneclickline_rb.Text = "원클릭라인";
            this.oneclickline_rb.UseVisualStyleBackColor = true;
            this.oneclickline_rb.CheckedChanged += new System.EventHandler(this.oneclickline_rb_CheckedChanged);
            // 
            // oneclickcir_rb
            // 
            this.oneclickcir_rb.AutoSize = true;
            this.oneclickcir_rb.Location = new System.Drawing.Point(119, 63);
            this.oneclickcir_rb.Name = "oneclickcir_rb";
            this.oneclickcir_rb.Size = new System.Drawing.Size(83, 16);
            this.oneclickcir_rb.TabIndex = 3;
            this.oneclickcir_rb.Text = "원클릭서클";
            this.oneclickcir_rb.UseVisualStyleBackColor = true;
            this.oneclickcir_rb.CheckedChanged += new System.EventHandler(this.oneclickcir_rb_CheckedChanged);
            // 
            // oneclicksq_rb
            // 
            this.oneclicksq_rb.AutoSize = true;
            this.oneclicksq_rb.Location = new System.Drawing.Point(15, 63);
            this.oneclicksq_rb.Name = "oneclicksq_rb";
            this.oneclicksq_rb.Size = new System.Drawing.Size(83, 16);
            this.oneclicksq_rb.TabIndex = 2;
            this.oneclicksq_rb.Text = "원클릭네모";
            this.oneclicksq_rb.UseVisualStyleBackColor = true;
            this.oneclicksq_rb.CheckedChanged += new System.EventHandler(this.oneclicksq_rb_CheckedChanged);
            // 
            // rbRect
            // 
            this.rbRect.AutoSize = true;
            this.rbRect.Location = new System.Drawing.Point(119, 24);
            this.rbRect.Name = "rbRect";
            this.rbRect.Size = new System.Drawing.Size(95, 16);
            this.rbRect.TabIndex = 1;
            this.rbRect.Text = "사각형그리기";
            this.rbRect.UseVisualStyleBackColor = true;
            this.rbRect.CheckedChanged += new System.EventHandler(this.rbRect_CheckedChanged);
            // 
            // rbLine
            // 
            this.rbLine.AutoSize = true;
            this.rbLine.Checked = true;
            this.rbLine.Location = new System.Drawing.Point(15, 24);
            this.rbLine.Name = "rbLine";
            this.rbLine.Size = new System.Drawing.Size(83, 16);
            this.rbLine.TabIndex = 0;
            this.rbLine.TabStop = true;
            this.rbLine.Text = "라인그리기";
            this.rbLine.UseVisualStyleBackColor = true;
            this.rbLine.CheckedChanged += new System.EventHandler(this.rbLine_CheckedChanged);
            // 
            // plPaint
            // 
            this.plPaint.BackColor = System.Drawing.Color.White;
            this.plPaint.Location = new System.Drawing.Point(12, 149);
            this.plPaint.Name = "plPaint";
            this.plPaint.Size = new System.Drawing.Size(590, 340);
            this.plPaint.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(68, 100);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(134, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "choose color";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(614, 501);
            this.Controls.Add(this.plPaint);
            this.Controls.Add(this.gbOption);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "라인 사각형 그리기";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbOption.ResumeLayout(false);
            this.gbOption.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbOption;
        private System.Windows.Forms.RadioButton rbRect;
        private System.Windows.Forms.RadioButton rbLine;
        private System.Windows.Forms.Panel plPaint;
        private System.Windows.Forms.RadioButton oneclickline_rb;
        private System.Windows.Forms.RadioButton oneclickcir_rb;
        private System.Windows.Forms.RadioButton oneclicksq_rb;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ColorDialog colorDialog1;
    }
}

