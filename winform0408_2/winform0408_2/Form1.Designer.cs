namespace winform0408_2
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
            this.components = new System.ComponentModel.Container();
            this.lb_OUTPUT_1 = new System.Windows.Forms.Label();
            this.prb_Level = new System.Windows.Forms.ProgressBar();
            this.lb_OUTPUT_2 = new System.Windows.Forms.Label();
            this.tbx_INPUT = new System.Windows.Forms.TextBox();
            this.btn_Start = new System.Windows.Forms.Button();
            this.timer1_Tick = new System.Windows.Forms.Timer(this.components);
            this.result = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lb_OUTPUT_1
            // 
            this.lb_OUTPUT_1.AutoSize = true;
            this.lb_OUTPUT_1.Location = new System.Drawing.Point(54, 57);
            this.lb_OUTPUT_1.Name = "lb_OUTPUT_1";
            this.lb_OUTPUT_1.Size = new System.Drawing.Size(38, 12);
            this.lb_OUTPUT_1.TabIndex = 0;
            this.lb_OUTPUT_1.Text = "label1";
            // 
            // prb_Level
            // 
            this.prb_Level.Location = new System.Drawing.Point(56, 95);
            this.prb_Level.Name = "prb_Level";
            this.prb_Level.Size = new System.Drawing.Size(665, 23);
            this.prb_Level.TabIndex = 1;
            // 
            // lb_OUTPUT_2
            // 
            this.lb_OUTPUT_2.AutoSize = true;
            this.lb_OUTPUT_2.Location = new System.Drawing.Point(54, 238);
            this.lb_OUTPUT_2.Name = "lb_OUTPUT_2";
            this.lb_OUTPUT_2.Size = new System.Drawing.Size(38, 12);
            this.lb_OUTPUT_2.TabIndex = 2;
            this.lb_OUTPUT_2.Text = "label2";
            // 
            // tbx_INPUT
            // 
            this.tbx_INPUT.Location = new System.Drawing.Point(56, 284);
            this.tbx_INPUT.Name = "tbx_INPUT";
            this.tbx_INPUT.Size = new System.Drawing.Size(665, 21);
            this.tbx_INPUT.TabIndex = 3;
            this.tbx_INPUT.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbx_INPUT_KeyPress);
            this.tbx_INPUT.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tbx_INPUT_KeyUp);
            // 
            // btn_Start
            // 
            this.btn_Start.Location = new System.Drawing.Point(56, 351);
            this.btn_Start.Name = "btn_Start";
            this.btn_Start.Size = new System.Drawing.Size(150, 56);
            this.btn_Start.TabIndex = 4;
            this.btn_Start.Text = "시작";
            this.btn_Start.UseVisualStyleBackColor = true;
            this.btn_Start.Click += new System.EventHandler(this.btn_Start_Click);
            // 
            // timer1_Tick
            // 
            this.timer1_Tick.Interval = 1000;
            this.timer1_Tick.Tick += new System.EventHandler(this.timer1_Tick_Tick);
            // 
            // result
            // 
            this.result.AutoSize = true;
            this.result.Location = new System.Drawing.Point(520, 351);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(38, 12);
            this.result.TabIndex = 5;
            this.result.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.result);
            this.Controls.Add(this.btn_Start);
            this.Controls.Add(this.tbx_INPUT);
            this.Controls.Add(this.lb_OUTPUT_2);
            this.Controls.Add(this.prb_Level);
            this.Controls.Add(this.lb_OUTPUT_1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_OUTPUT_1;
        private System.Windows.Forms.ProgressBar prb_Level;
        private System.Windows.Forms.Label lb_OUTPUT_2;
        private System.Windows.Forms.TextBox tbx_INPUT;
        private System.Windows.Forms.Button btn_Start;
        private System.Windows.Forms.Timer timer1_Tick;
        private System.Windows.Forms.Label result;
    }
}

