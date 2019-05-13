namespace MSG_190311
{
    partial class Planner
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.time_setbox = new System.Windows.Forms.GroupBox();
            this.minuet_tb = new System.Windows.Forms.TextBox();
            this.minuet_t = new System.Windows.Forms.Label();
            this.hour_tb = new System.Windows.Forms.TextBox();
            this.hour_T = new System.Windows.Forms.Label();
            this.major_box = new System.Windows.Forms.GroupBox();
            this.low_cb = new System.Windows.Forms.CheckBox();
            this.middle_cb = new System.Windows.Forms.CheckBox();
            this.high_cb = new System.Windows.Forms.CheckBox();
            this.low_t = new System.Windows.Forms.Label();
            this.middle_t = new System.Windows.Forms.Label();
            this.high_t = new System.Windows.Forms.Label();
            this.next_bt = new System.Windows.Forms.Button();
            this.exit_bt = new System.Windows.Forms.Button();
            this.memo_box = new System.Windows.Forms.GroupBox();
            this.memo_tb = new System.Windows.Forms.TextBox();
            this.time_setbox.SuspendLayout();
            this.major_box.SuspendLayout();
            this.memo_box.SuspendLayout();
            this.SuspendLayout();
            // 
            // time_setbox
            // 
            this.time_setbox.Controls.Add(this.minuet_tb);
            this.time_setbox.Controls.Add(this.minuet_t);
            this.time_setbox.Controls.Add(this.hour_tb);
            this.time_setbox.Controls.Add(this.hour_T);
            this.time_setbox.Location = new System.Drawing.Point(12, 12);
            this.time_setbox.Name = "time_setbox";
            this.time_setbox.Size = new System.Drawing.Size(167, 66);
            this.time_setbox.TabIndex = 0;
            this.time_setbox.TabStop = false;
            this.time_setbox.Text = "시간 설정";
            // 
            // minuet_tb
            // 
            this.minuet_tb.Location = new System.Drawing.Point(87, 27);
            this.minuet_tb.Name = "minuet_tb";
            this.minuet_tb.Size = new System.Drawing.Size(44, 21);
            this.minuet_tb.TabIndex = 3;
            this.minuet_tb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.minuet_tb_KeyPress);
            // 
            // minuet_t
            // 
            this.minuet_t.AutoSize = true;
            this.minuet_t.Font = new System.Drawing.Font("굴림", 12F);
            this.minuet_t.Location = new System.Drawing.Point(133, 30);
            this.minuet_t.Name = "minuet_t";
            this.minuet_t.Size = new System.Drawing.Size(24, 16);
            this.minuet_t.TabIndex = 2;
            this.minuet_t.Text = "분";
            // 
            // hour_tb
            // 
            this.hour_tb.Location = new System.Drawing.Point(16, 27);
            this.hour_tb.Name = "hour_tb";
            this.hour_tb.Size = new System.Drawing.Size(44, 21);
            this.hour_tb.TabIndex = 1;
            this.hour_tb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.hour_tb_KeyPress);
            // 
            // hour_T
            // 
            this.hour_T.AutoSize = true;
            this.hour_T.Font = new System.Drawing.Font("굴림", 12F);
            this.hour_T.Location = new System.Drawing.Point(62, 30);
            this.hour_T.Name = "hour_T";
            this.hour_T.Size = new System.Drawing.Size(24, 16);
            this.hour_T.TabIndex = 0;
            this.hour_T.Text = "시";
            // 
            // major_box
            // 
            this.major_box.Controls.Add(this.low_cb);
            this.major_box.Controls.Add(this.middle_cb);
            this.major_box.Controls.Add(this.high_cb);
            this.major_box.Controls.Add(this.low_t);
            this.major_box.Controls.Add(this.middle_t);
            this.major_box.Controls.Add(this.high_t);
            this.major_box.Location = new System.Drawing.Point(185, 12);
            this.major_box.Name = "major_box";
            this.major_box.Size = new System.Drawing.Size(171, 66);
            this.major_box.TabIndex = 1;
            this.major_box.TabStop = false;
            this.major_box.Text = "중요도";
            // 
            // low_cb
            // 
            this.low_cb.AutoSize = true;
            this.low_cb.Location = new System.Drawing.Point(131, 40);
            this.low_cb.Name = "low_cb";
            this.low_cb.Size = new System.Drawing.Size(15, 14);
            this.low_cb.TabIndex = 5;
            this.low_cb.UseVisualStyleBackColor = true;
            // 
            // middle_cb
            // 
            this.middle_cb.AutoSize = true;
            this.middle_cb.Location = new System.Drawing.Point(78, 40);
            this.middle_cb.Name = "middle_cb";
            this.middle_cb.Size = new System.Drawing.Size(15, 14);
            this.middle_cb.TabIndex = 4;
            this.middle_cb.UseVisualStyleBackColor = true;
            // 
            // high_cb
            // 
            this.high_cb.AutoSize = true;
            this.high_cb.Location = new System.Drawing.Point(26, 40);
            this.high_cb.Name = "high_cb";
            this.high_cb.Size = new System.Drawing.Size(15, 14);
            this.high_cb.TabIndex = 3;
            this.high_cb.UseVisualStyleBackColor = true;
            // 
            // low_t
            // 
            this.low_t.AutoSize = true;
            this.low_t.Location = new System.Drawing.Point(124, 21);
            this.low_t.Name = "low_t";
            this.low_t.Size = new System.Drawing.Size(29, 12);
            this.low_t.TabIndex = 2;
            this.low_t.Text = "낮음";
            // 
            // middle_t
            // 
            this.middle_t.AutoSize = true;
            this.middle_t.Location = new System.Drawing.Point(71, 21);
            this.middle_t.Name = "middle_t";
            this.middle_t.Size = new System.Drawing.Size(29, 12);
            this.middle_t.TabIndex = 1;
            this.middle_t.Text = "보통";
            // 
            // high_t
            // 
            this.high_t.AutoSize = true;
            this.high_t.Location = new System.Drawing.Point(19, 21);
            this.high_t.Name = "high_t";
            this.high_t.Size = new System.Drawing.Size(29, 12);
            this.high_t.TabIndex = 0;
            this.high_t.Text = "높음";
            // 
            // next_bt
            // 
            this.next_bt.Location = new System.Drawing.Point(216, 90);
            this.next_bt.Name = "next_bt";
            this.next_bt.Size = new System.Drawing.Size(67, 48);
            this.next_bt.TabIndex = 2;
            this.next_bt.Text = "Next";
            this.next_bt.UseVisualStyleBackColor = true;
            this.next_bt.Click += new System.EventHandler(this.next_bt_Click);
            // 
            // exit_bt
            // 
            this.exit_bt.Location = new System.Drawing.Point(289, 90);
            this.exit_bt.Name = "exit_bt";
            this.exit_bt.Size = new System.Drawing.Size(67, 48);
            this.exit_bt.TabIndex = 3;
            this.exit_bt.Text = "Exit";
            this.exit_bt.UseVisualStyleBackColor = true;
            this.exit_bt.Click += new System.EventHandler(this.exit_bt_Click);
            // 
            // memo_box
            // 
            this.memo_box.Controls.Add(this.memo_tb);
            this.memo_box.Location = new System.Drawing.Point(13, 83);
            this.memo_box.Name = "memo_box";
            this.memo_box.Size = new System.Drawing.Size(200, 55);
            this.memo_box.TabIndex = 4;
            this.memo_box.TabStop = false;
            this.memo_box.Text = "메모";
            // 
            // memo_tb
            // 
            this.memo_tb.Location = new System.Drawing.Point(15, 22);
            this.memo_tb.Name = "memo_tb";
            this.memo_tb.Size = new System.Drawing.Size(169, 21);
            this.memo_tb.TabIndex = 0;
            // 
            // Planner
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(368, 143);
            this.Controls.Add(this.memo_box);
            this.Controls.Add(this.exit_bt);
            this.Controls.Add(this.next_bt);
            this.Controls.Add(this.major_box);
            this.Controls.Add(this.time_setbox);
            this.Name = "Planner";
            this.Text = "Planner";
            this.time_setbox.ResumeLayout(false);
            this.time_setbox.PerformLayout();
            this.major_box.ResumeLayout(false);
            this.major_box.PerformLayout();
            this.memo_box.ResumeLayout(false);
            this.memo_box.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox time_setbox;
        private System.Windows.Forms.TextBox hour_tb;
        private System.Windows.Forms.Label hour_T;
        private System.Windows.Forms.TextBox minuet_tb;
        private System.Windows.Forms.Label minuet_t;
        private System.Windows.Forms.GroupBox major_box;
        private System.Windows.Forms.CheckBox low_cb;
        private System.Windows.Forms.CheckBox middle_cb;
        private System.Windows.Forms.CheckBox high_cb;
        private System.Windows.Forms.Label low_t;
        private System.Windows.Forms.Label middle_t;
        private System.Windows.Forms.Label high_t;
        private System.Windows.Forms.Button next_bt;
        private System.Windows.Forms.Button exit_bt;
        private System.Windows.Forms.GroupBox memo_box;
        private System.Windows.Forms.TextBox memo_tb;
    }
}