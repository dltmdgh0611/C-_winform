﻿namespace windowform0422
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
            this.btnSave = new System.Windows.Forms.Button();
            this.txtSave = new System.Windows.Forms.TextBox();
            this.stdFile = new System.Windows.Forms.SaveFileDialog();
            this.SuspendLayout();
            // 
            // txtPath
            // 
            this.txtPath.Location = new System.Drawing.Point(13, 13);
            this.txtPath.Name = "txtPath";
            this.txtPath.ReadOnly = true;
            this.txtPath.Size = new System.Drawing.Size(450, 21);
            this.txtPath.TabIndex = 0;
            // 
            // btnFile
            // 
            this.btnFile.Location = new System.Drawing.Point(470, 13);
            this.btnFile.Name = "btnFile";
            this.btnFile.Size = new System.Drawing.Size(92, 23);
            this.btnFile.TabIndex = 1;
            this.btnFile.Text = "파일";
            this.btnFile.UseVisualStyleBackColor = true;
            this.btnFile.Click += new System.EventHandler(this.btnFile_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(470, 42);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(92, 23);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "전체저장";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtSave
            // 
            this.txtSave.Location = new System.Drawing.Point(13, 71);
            this.txtSave.Multiline = true;
            this.txtSave.Name = "txtSave";
            this.txtSave.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtSave.Size = new System.Drawing.Size(549, 212);
            this.txtSave.TabIndex = 3;
            // 
            // stdFile
            // 
            this.stdFile.Filter = "텍스트파일(*.txt)|*.txt";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(574, 295);
            this.Controls.Add(this.txtSave);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnFile);
            this.Controls.Add(this.txtPath);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "파일쓰기";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPath;
        private System.Windows.Forms.Button btnFile;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtSave;
        private System.Windows.Forms.SaveFileDialog stdFile;
    }
}

