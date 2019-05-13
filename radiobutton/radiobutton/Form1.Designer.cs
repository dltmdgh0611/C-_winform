namespace radiobutton
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
            this.main_lb = new System.Windows.Forms.Label();
            this.black_rb = new System.Windows.Forms.RadioButton();
            this.blue_rb = new System.Windows.Forms.RadioButton();
            this.red_rb = new System.Windows.Forms.RadioButton();
            this.bold_cb = new System.Windows.Forms.CheckBox();
            this.italic_cb = new System.Windows.Forms.CheckBox();
            this.cancelLine_cb = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // main_lb
            // 
            this.main_lb.AutoSize = true;
            this.main_lb.Location = new System.Drawing.Point(31, 34);
            this.main_lb.Name = "main_lb";
            this.main_lb.Size = new System.Drawing.Size(87, 12);
            this.main_lb.TabIndex = 0;
            this.main_lb.Text = "뭐가 나올까요?";
            // 
            // black_rb
            // 
            this.black_rb.AutoSize = true;
            this.black_rb.Location = new System.Drawing.Point(33, 69);
            this.black_rb.Name = "black_rb";
            this.black_rb.Size = new System.Drawing.Size(59, 16);
            this.black_rb.TabIndex = 1;
            this.black_rb.TabStop = true;
            this.black_rb.Text = "검정색";
            this.black_rb.UseVisualStyleBackColor = true;
            this.black_rb.CheckedChanged += new System.EventHandler(this.black_rb_CheckedChanged);
            // 
            // blue_rb
            // 
            this.blue_rb.AutoSize = true;
            this.blue_rb.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.blue_rb.Location = new System.Drawing.Point(33, 135);
            this.blue_rb.Name = "blue_rb";
            this.blue_rb.Size = new System.Drawing.Size(59, 16);
            this.blue_rb.TabIndex = 2;
            this.blue_rb.TabStop = true;
            this.blue_rb.Text = "파란색";
            this.blue_rb.UseVisualStyleBackColor = true;
            this.blue_rb.CheckedChanged += new System.EventHandler(this.blue_rb_CheckedChanged);
            // 
            // red_rb
            // 
            this.red_rb.AutoSize = true;
            this.red_rb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.red_rb.Location = new System.Drawing.Point(33, 102);
            this.red_rb.Name = "red_rb";
            this.red_rb.Size = new System.Drawing.Size(59, 16);
            this.red_rb.TabIndex = 3;
            this.red_rb.TabStop = true;
            this.red_rb.Text = "빨간색";
            this.red_rb.UseVisualStyleBackColor = true;
            this.red_rb.CheckedChanged += new System.EventHandler(this.red_rb_CheckedChanged);
            // 
            // bold_cb
            // 
            this.bold_cb.AutoSize = true;
            this.bold_cb.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.bold_cb.Location = new System.Drawing.Point(127, 69);
            this.bold_cb.Name = "bold_cb";
            this.bold_cb.Size = new System.Drawing.Size(63, 16);
            this.bold_cb.TabIndex = 4;
            this.bold_cb.Text = "볼드체";
            this.bold_cb.UseVisualStyleBackColor = true;
            this.bold_cb.CheckedChanged += new System.EventHandler(this.bold_cb_CheckedChanged);
            // 
            // italic_cb
            // 
            this.italic_cb.AutoSize = true;
            this.italic_cb.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.italic_cb.Location = new System.Drawing.Point(127, 102);
            this.italic_cb.Name = "italic_cb";
            this.italic_cb.Size = new System.Drawing.Size(72, 16);
            this.italic_cb.TabIndex = 5;
            this.italic_cb.Text = "이탈릭체";
            this.italic_cb.UseVisualStyleBackColor = true;
            this.italic_cb.CheckedChanged += new System.EventHandler(this.italic_cb_CheckedChanged);
            // 
            // cancelLine_cb
            // 
            this.cancelLine_cb.AutoSize = true;
            this.cancelLine_cb.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Strikeout, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.cancelLine_cb.Location = new System.Drawing.Point(127, 135);
            this.cancelLine_cb.Name = "cancelLine_cb";
            this.cancelLine_cb.Size = new System.Drawing.Size(60, 16);
            this.cancelLine_cb.TabIndex = 6;
            this.cancelLine_cb.Text = "취소선";
            this.cancelLine_cb.UseVisualStyleBackColor = true;
            this.cancelLine_cb.CheckedChanged += new System.EventHandler(this.cancelLine_cb_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(332, 188);
            this.Controls.Add(this.cancelLine_cb);
            this.Controls.Add(this.italic_cb);
            this.Controls.Add(this.bold_cb);
            this.Controls.Add(this.red_rb);
            this.Controls.Add(this.blue_rb);
            this.Controls.Add(this.black_rb);
            this.Controls.Add(this.main_lb);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label main_lb;
        private System.Windows.Forms.RadioButton black_rb;
        private System.Windows.Forms.RadioButton blue_rb;
        private System.Windows.Forms.RadioButton red_rb;
        private System.Windows.Forms.CheckBox bold_cb;
        private System.Windows.Forms.CheckBox italic_cb;
        private System.Windows.Forms.CheckBox cancelLine_cb;
    }
}

