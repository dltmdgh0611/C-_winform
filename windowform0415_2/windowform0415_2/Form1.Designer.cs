namespace windowform0415_2
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
            this.txtPath = new System.Windows.Forms.TextBox();
            this.btnFile = new System.Windows.Forms.Button();
            this.btnAllRead = new System.Windows.Forms.Button();
            this.btnLineRead = new System.Windows.Forms.Button();
            this.txtView = new System.Windows.Forms.TextBox();
            this.ofdFile = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // txtPath
            // 
            this.txtPath.Location = new System.Drawing.Point(12, 12);
            this.txtPath.Name = "txtPath";
            this.txtPath.Size = new System.Drawing.Size(635, 21);
            this.txtPath.TabIndex = 0;
            // 
            // btnFile
            // 
            this.btnFile.Location = new System.Drawing.Point(663, 12);
            this.btnFile.Name = "btnFile";
            this.btnFile.Size = new System.Drawing.Size(112, 23);
            this.btnFile.TabIndex = 1;
            this.btnFile.Text = "파일";
            this.btnFile.UseVisualStyleBackColor = true;
            this.btnFile.Click += new System.EventHandler(this.btnFile_Click);
            // 
            // btnAllRead
            // 
            this.btnAllRead.Location = new System.Drawing.Point(535, 39);
            this.btnAllRead.Name = "btnAllRead";
            this.btnAllRead.Size = new System.Drawing.Size(112, 23);
            this.btnAllRead.TabIndex = 2;
            this.btnAllRead.Text = "전체읽기";
            this.btnAllRead.UseVisualStyleBackColor = true;
            this.btnAllRead.Click += new System.EventHandler(this.btnAllRead_Click);
            // 
            // btnLineRead
            // 
            this.btnLineRead.Location = new System.Drawing.Point(663, 41);
            this.btnLineRead.Name = "btnLineRead";
            this.btnLineRead.Size = new System.Drawing.Size(112, 23);
            this.btnLineRead.TabIndex = 3;
            this.btnLineRead.Text = "라인읽기";
            this.btnLineRead.UseVisualStyleBackColor = true;
            this.btnLineRead.Click += new System.EventHandler(this.btnLineRead_Click);
            // 
            // txtView
            // 
            this.txtView.Location = new System.Drawing.Point(12, 79);
            this.txtView.Multiline = true;
            this.txtView.Name = "txtView";
            this.txtView.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtView.Size = new System.Drawing.Size(763, 359);
            this.txtView.TabIndex = 4;
            // 
            // ofdFile
            // 
            this.ofdFile.FileName = "openFileDialog1";
            this.ofdFile.Filter = "텍스트 파일 (*.txt)|*.txt";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtView);
            this.Controls.Add(this.btnLineRead);
            this.Controls.Add(this.btnAllRead);
            this.Controls.Add(this.btnFile);
            this.Controls.Add(this.txtPath);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "파일읽기";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPath;
        private System.Windows.Forms.Button btnFile;
        private System.Windows.Forms.Button btnAllRead;
        private System.Windows.Forms.Button btnLineRead;
        private System.Windows.Forms.TextBox txtView;
        private System.Windows.Forms.OpenFileDialog ofdFile;
    }
}

