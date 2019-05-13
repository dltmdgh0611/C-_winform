namespace MSG_190311
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
            this.alarmtest = new System.Windows.Forms.Button();
            this.noticetest = new System.Windows.Forms.Button();
            this.errortest = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.Time_Text = new System.Windows.Forms.Label();
            this.planner = new System.Windows.Forms.Button();
            this.testbox = new System.Windows.Forms.GroupBox();
            this.testbox.SuspendLayout();
            this.SuspendLayout();
            // 
            // alarmtest
            // 
            this.alarmtest.BackColor = System.Drawing.Color.GreenYellow;
            this.alarmtest.Location = new System.Drawing.Point(9, 20);
            this.alarmtest.Name = "alarmtest";
            this.alarmtest.Size = new System.Drawing.Size(50, 50);
            this.alarmtest.TabIndex = 0;
            this.alarmtest.Text = "alarm";
            this.alarmtest.UseVisualStyleBackColor = false;
            this.alarmtest.Click += new System.EventHandler(this.button1_Click);
            // 
            // noticetest
            // 
            this.noticetest.BackColor = System.Drawing.Color.Gold;
            this.noticetest.Location = new System.Drawing.Point(75, 20);
            this.noticetest.Name = "noticetest";
            this.noticetest.Size = new System.Drawing.Size(50, 50);
            this.noticetest.TabIndex = 1;
            this.noticetest.Text = "notice";
            this.noticetest.UseVisualStyleBackColor = false;
            this.noticetest.Click += new System.EventHandler(this.button2_Click);
            // 
            // errortest
            // 
            this.errortest.BackColor = System.Drawing.Color.Red;
            this.errortest.Location = new System.Drawing.Point(144, 20);
            this.errortest.Name = "errortest";
            this.errortest.Size = new System.Drawing.Size(50, 50);
            this.errortest.TabIndex = 2;
            this.errortest.Text = "error";
            this.errortest.UseVisualStyleBackColor = false;
            this.errortest.Click += new System.EventHandler(this.button3_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Time_Text
            // 
            this.Time_Text.AutoSize = true;
            this.Time_Text.Font = new System.Drawing.Font("나눔스퀘어라운드 Regular", 17.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Time_Text.Location = new System.Drawing.Point(71, 108);
            this.Time_Text.Name = "Time_Text";
            this.Time_Text.Size = new System.Drawing.Size(0, 26);
            this.Time_Text.TabIndex = 4;
            // 
            // planner
            // 
            this.planner.Location = new System.Drawing.Point(218, 32);
            this.planner.Name = "planner";
            this.planner.Size = new System.Drawing.Size(99, 50);
            this.planner.TabIndex = 5;
            this.planner.Text = "Start Planning";
            this.planner.UseVisualStyleBackColor = true;
            this.planner.Click += new System.EventHandler(this.planner_Click);
            // 
            // testbox
            // 
            this.testbox.Controls.Add(this.alarmtest);
            this.testbox.Controls.Add(this.noticetest);
            this.testbox.Controls.Add(this.errortest);
            this.testbox.Location = new System.Drawing.Point(12, 12);
            this.testbox.Name = "testbox";
            this.testbox.Size = new System.Drawing.Size(200, 78);
            this.testbox.TabIndex = 6;
            this.testbox.TabStop = false;
            this.testbox.Text = "Test_Buttons";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(320, 131);
            this.Controls.Add(this.testbox);
            this.Controls.Add(this.planner);
            this.Controls.Add(this.Time_Text);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Shown += new System.EventHandler(this.Form1_Shown);
            this.testbox.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button alarmtest;
        private System.Windows.Forms.Button noticetest;
        private System.Windows.Forms.Button errortest;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label Time_Text;
        private System.Windows.Forms.Button planner;
        private System.Windows.Forms.GroupBox testbox;
    }
}

